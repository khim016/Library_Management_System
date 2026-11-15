using System;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class frmBorrowers : Form
    {
        private Library lib = DataStore.Lib;

        public frmBorrowers()
        {
            InitializeComponent();
        }

        void FrmBorrowersLoad(object sender, EventArgs e)
        {
            cboType.SelectedIndex = 0;
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            dgvBorrowers.DataSource = null;
            dgvBorrowers.DataSource = lib.SearchBorrowers(txtSearch.Text);
        }

        private void ClearFields()
        {
            txtPersonId.Clear();
            txtName.Clear();
            txtContact.Clear();
            cboType.SelectedIndex = 0;
            txtPersonId.ReadOnly = false;
            cboType.Enabled = true;
            txtPersonId.Focus();
        }

        void BtnAddClick(object sender, EventArgs e)
        {
            try
            {
                string id = txtPersonId.Text.Trim();
                Person p;      // POLYMORPHISM

                if (cboType.Text == "Student")
                    p = new Student(id, txtName.Text, txtContact.Text);
                else
                    p = new Faculty(id, txtName.Text, txtContact.Text);

                lib.AddBorrower(p);
                MessageBox.Show("Borrower registered.", "Success",
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
            Person p = lib.FindBorrower(txtPersonId.Text.Trim());
            if (p == null)
            {
                MessageBox.Show("Select a borrower from the table first.");
                return;
            }
            try
            {
                p.Name = txtName.Text;
                p.Contact = txtContact.Text;
                MessageBox.Show("Borrower updated.");
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
            string id = txtPersonId.Text.Trim();
            if (lib.FindBorrower(id) == null)
            {
                MessageBox.Show("Select a borrower from the table first.");
                return;
            }
            if (MessageBox.Show("Delete this borrower?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            try
            {
                lib.RemoveBorrower(id);
                ClearFields();
                RefreshGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void BtnClearClick(object sender, EventArgs e) { ClearFields(); }

        void TxtSearchTextChanged(object sender, EventArgs e) { RefreshGrid(); }

        void DgvBorrowersCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            Person p = dgvBorrowers.Rows[e.RowIndex].DataBoundItem as Person;
            if (p == null) return;

            txtPersonId.Text = p.PersonId;
            txtName.Text = p.Name;
            txtContact.Text = p.Contact;
            cboType.Text = p.BorrowerType;
            txtPersonId.ReadOnly = true;
            cboType.Enabled = false;
        }

        void BtnCloseClick(object sender, EventArgs e) { this.Close(); }
		void GrpDetailsEnter(object sender, EventArgs e)
		{
	
		}
		void LblIdClick(object sender, EventArgs e)
		{
	
		}
		void LblSearchClick(object sender, EventArgs e)
		{
	
		}
		void Label1Click(object sender, EventArgs e)
		{
	
		}
    }
}
