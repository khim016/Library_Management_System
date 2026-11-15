using System;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class frmItems : Form
    {
        private Library lib = DataStore.Lib;

        public frmItems()
        {
            InitializeComponent();
        }

        void FrmItemsLoad(object sender, EventArgs e)
        {
            cboType.SelectedIndex = 0;
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            dgvItems.DataSource = null;
            dgvItems.DataSource = lib.SearchItems(txtSearch.Text);
        }

        private void ClearFields()
        {
            txtItemId.Clear();
            txtTitle.Clear();
            txtAuthor.Clear();
            cboType.SelectedIndex = 0;
            txtItemId.ReadOnly = false;
            cboType.Enabled = true;
            txtItemId.Focus();
        }

        void BtnAddClick(object sender, EventArgs e)
        {
            try
            {
                string id = txtItemId.Text.Trim();
                LibraryItem item;      // POLYMORPHISM: parent reference, child object

                switch (cboType.Text)
                {
                    case "Book":     item = new Book(id, txtTitle.Text, txtAuthor.Text); break;
                    case "Magazine": item = new Magazine(id, txtTitle.Text, txtAuthor.Text); break;
                    default:         item = new Thesis(id, txtTitle.Text, txtAuthor.Text); break;
                }

                lib.AddItem(item);
                MessageBox.Show("Item added successfully.", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
                RefreshGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void BtnUpdateClick(object sender, EventArgs e)
        {
            LibraryItem item = lib.FindItem(txtItemId.Text.Trim());
            if (item == null)
            {
                MessageBox.Show("Select an item from the table first.");
                return;
            }
            try
            {
                item.Title = txtTitle.Text;
                item.Author = txtAuthor.Text;
                MessageBox.Show("Item updated.");
                ClearFields();
                RefreshGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void BtnDeleteClick(object sender, EventArgs e)
        {
            string id = txtItemId.Text.Trim();
            if (lib.FindItem(id) == null)
            {
                MessageBox.Show("Select an item from the table first.");
                return;
            }
            if (MessageBox.Show("Delete this item?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            try
            {
                lib.RemoveItem(id);
                ClearFields();
                RefreshGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void BtnClearClick(object sender, EventArgs e)
        {
            ClearFields();
        }

        void TxtSearchTextChanged(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        void DgvItemsCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            LibraryItem item = dgvItems.Rows[e.RowIndex].DataBoundItem as LibraryItem;
            if (item == null) return;

            txtItemId.Text = item.ItemId;
            txtTitle.Text = item.Title;
            txtAuthor.Text = item.Author;
            cboType.Text = item.ItemType;
            txtItemId.ReadOnly = true;     // ID and type cannot be changed
            cboType.Enabled = false;
        }

        void BtnCloseClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
