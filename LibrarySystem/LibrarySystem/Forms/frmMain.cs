using System;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        void FrmMainLoad(object sender, EventArgs e)
        {
            UpdateStatus();
        }

        private void UpdateStatus()
        {
            lblStatus.Text = "Items: " + DataStore.Lib.Items.Count
                           + "  |  Borrowers: " + DataStore.Lib.Borrowers.Count
                           + "  |  Active loans: " + DataStore.Lib.GetActiveTransactions().Count;
        }

        private void OpenForm(Form f)
        {
            f.ShowDialog();
            UpdateStatus();      // refresh the status bar when the child form closes
        }

        void BtnItemsClick(object sender, EventArgs e)        { OpenForm(new frmItems()); }
        void BtnBorrowersClick(object sender, EventArgs e)    { OpenForm(new frmBorrowers()); }
        void BtnBorrowClick(object sender, EventArgs e)       { OpenForm(new frmBorrow()); }
        void BtnReturnClick(object sender, EventArgs e)       { OpenForm(new frmReturn()); }
        void BtnTransactionsClick(object sender, EventArgs e) { OpenForm(new frmTransactions()); }
        void BtnExitClick(object sender, EventArgs e)         { Application.Exit(); }
		void LblTitleClick(object sender, EventArgs e)
		{
	
		}
    }
}
