using System;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class frmBorrow : Form
    {
        private Library lib = DataStore.Lib;

        public frmBorrow()
        {
            InitializeComponent();
        }

        void FrmBorrowLoad(object sender, EventArgs e)
        {
            LoadCombos();
            RefreshGrid();
            UpdatePreview();
        }

        private void LoadCombos()
        {
            cboBorrower.DataSource = null;
            cboBorrower.DataSource = new System.Collections.Generic.List<Person>(lib.Borrowers);
            cboBorrower.DisplayMember = "Name";

            cboItem.DataSource = null;
            cboItem.DataSource = lib.GetAvailableItems();
            cboItem.DisplayMember = "Title";
        }

        private void RefreshGrid()
        {
            dgvActive.DataSource = null;
            dgvActive.DataSource = lib.GetActiveTransactions();
        }

        // Updates Item Type, Due Date, and Loans/Limit
        private void UpdatePreview()
        {
            LibraryItem item = cboItem.SelectedItem as LibraryItem;
            Person p = cboBorrower.SelectedItem as Person;

            if (item != null)
            {
                lblTypeValue.Text = item.ItemType;
                lblDueValue.Text = dtpBorrowDate.Value.Date.AddDays(item.LoanDays).ToShortDateString();
            }
            else
            {
                lblTypeValue.Text = "-";
                lblDueValue.Text = "-";
            }

            if (p != null)
                lblLimitValue.Text = lib.CountActiveLoans(p) + " / " + p.MaxItems;
            else
                lblLimitValue.Text = "-";
        }

        void CboBorrowerSelectedIndexChanged(object sender, EventArgs e) { UpdatePreview(); }
        void CboItemSelectedIndexChanged(object sender, EventArgs e)     { UpdatePreview(); }
        void DtpBorrowDateValueChanged(object sender, EventArgs e)       { UpdatePreview(); }

        void BtnBorrowClick(object sender, EventArgs e)
        {
            Person p = cboBorrower.SelectedItem as Person;
            LibraryItem item = cboItem.SelectedItem as LibraryItem;

            if (p == null || item == null)
            {
                MessageBox.Show("Please select a borrower and an item.");
                return;
            }

            try
            {
                BorrowTransaction t = lib.BorrowItem(p, item, dtpBorrowDate.Value);
                MessageBox.Show("Borrowed successfully!\nDue date: " + t.DueDate.ToShortDateString(),
                                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadCombos();
                RefreshGrid();
                UpdatePreview();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Cannot Borrow", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void BtnCloseClick(object sender, EventArgs e) { this.Close(); }
		void GrpBorrowEnter(object sender, EventArgs e)
		{
	
		}
		void LblDateClick(object sender, EventArgs e)
		{
	
		}
    }
}
