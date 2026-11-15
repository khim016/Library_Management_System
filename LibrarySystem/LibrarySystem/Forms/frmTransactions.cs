using System;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class frmTransactions : Form
    {
        public frmTransactions()
        {
            InitializeComponent();
        }

        void FrmTransactionsLoad(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            dgvTransactions.DataSource = null;
            dgvTransactions.DataSource = DataStore.Lib.Transactions;
        }

        void BtnRefreshClick(object sender, EventArgs e) { RefreshGrid(); }
        void BtnCloseClick(object sender, EventArgs e)   { this.Close(); }
    }
}
