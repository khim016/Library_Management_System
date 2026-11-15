using System;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class frmReturn : Form
    {
        private Library lib = DataStore.Lib;

        public frmReturn()
        {
            InitializeComponent();
        }

        void FrmReturnLoad(object sender, EventArgs e)
        {
            RefreshGrid();
            UpdatePreview();
        }

        private void RefreshGrid()
        {
            dgvActive.DataSource = null;
            dgvActive.DataSource = lib.GetActiveTransactions();
        }

        private BorrowTransaction GetSelected()
        {
            if (dgvActive.CurrentRow == null) return null;
            return dgvActive.CurrentRow.DataBoundItem as BorrowTransaction;
        }

        private void UpdatePreview()
        {
            BorrowTransaction t = GetSelected();
            if (t == null)
            {
                lblLateValue.Text = "0";
                lblFineValue.Text = "0.00";
                return;
            }

            int late = (dtpReturnDate.Value.Date - t.DueDate).Days;
            lblLateValue.Text = (late > 0 ? late : 0).ToString();
            lblFineValue.Text = t.PreviewFine(dtpReturnDate.Value).ToString("N2");
        }

        void DgvActiveSelectionChanged(object sender, EventArgs e)  { UpdatePreview(); }
        void DtpReturnDateValueChanged(object sender, EventArgs e)  { UpdatePreview(); }

        void BtnReturnClick(object sender, EventArgs e)
        {
            BorrowTransaction t = GetSelected();
            if (t == null)
            {
                MessageBox.Show("Select a borrowed item first.");
                return;
            }

            try
            {
                decimal fine = lib.ReturnItem(t, dtpReturnDate.Value);
                string msg = "Item returned successfully.";
                if (fine > 0)
                    msg += "\nFine to pay: PHP " + fine.ToString("N2");
                MessageBox.Show(msg, "Return Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshGrid();
                UpdatePreview();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void BtnCloseClick(object sender, EventArgs e) { this.Close(); }
		void LblLateValueClick(object sender, EventArgs e)
		{
	
		}
    }
}
