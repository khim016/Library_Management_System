namespace LibrarySystem
{
    partial class frmTransactions
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
        	this.lblHeader = new System.Windows.Forms.Label();
        	this.dgvTransactions = new System.Windows.Forms.DataGridView();
        	this.btnRefresh = new System.Windows.Forms.Button();
        	this.btnClose = new System.Windows.Forms.Button();
        	((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).BeginInit();
        	this.SuspendLayout();
        	// 
        	// lblHeader
        	// 
        	this.lblHeader.AutoSize = true;
        	this.lblHeader.BackColor = System.Drawing.Color.DodgerBlue;
        	this.lblHeader.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.lblHeader.ForeColor = System.Drawing.Color.White;
        	this.lblHeader.Location = new System.Drawing.Point(12, 15);
        	this.lblHeader.Name = "lblHeader";
        	this.lblHeader.Size = new System.Drawing.Size(282, 30);
        	this.lblHeader.TabIndex = 0;
        	this.lblHeader.Text = "TRANSACTION HISTORY";
        	// 
        	// dgvTransactions
        	// 
        	this.dgvTransactions.AllowUserToAddRows = false;
        	this.dgvTransactions.AllowUserToDeleteRows = false;
        	this.dgvTransactions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
        	this.dgvTransactions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        	this.dgvTransactions.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
        	this.dgvTransactions.Location = new System.Drawing.Point(12, 45);
        	this.dgvTransactions.MultiSelect = false;
        	this.dgvTransactions.Name = "dgvTransactions";
        	this.dgvTransactions.ReadOnly = true;
        	this.dgvTransactions.RowHeadersVisible = false;
        	this.dgvTransactions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        	this.dgvTransactions.Size = new System.Drawing.Size(876, 350);
        	this.dgvTransactions.TabIndex = 0;
        	// 
        	// btnRefresh
        	// 
        	this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
        	this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        	this.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
        	this.btnRefresh.Location = new System.Drawing.Point(12, 408);
        	this.btnRefresh.Name = "btnRefresh";
        	this.btnRefresh.Size = new System.Drawing.Size(90, 32);
        	this.btnRefresh.TabIndex = 1;
        	this.btnRefresh.Text = "Refresh";
        	this.btnRefresh.UseVisualStyleBackColor = true;
        	this.btnRefresh.Click += new System.EventHandler(this.BtnRefreshClick);
        	// 
        	// btnClose
        	// 
        	this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
        	this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        	this.btnClose.ForeColor = System.Drawing.Color.DodgerBlue;
        	this.btnClose.Location = new System.Drawing.Point(798, 408);
        	this.btnClose.Name = "btnClose";
        	this.btnClose.Size = new System.Drawing.Size(90, 32);
        	this.btnClose.TabIndex = 2;
        	this.btnClose.Text = "Close";
        	this.btnClose.UseVisualStyleBackColor = true;
        	this.btnClose.Click += new System.EventHandler(this.BtnCloseClick);
        	// 
        	// frmTransactions
        	// 
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
        	this.BackColor = System.Drawing.Color.White;
        	this.ClientSize = new System.Drawing.Size(900, 450);
        	this.Controls.Add(this.lblHeader);
        	this.Controls.Add(this.dgvTransactions);
        	this.Controls.Add(this.btnRefresh);
        	this.Controls.Add(this.btnClose);
        	this.Font = new System.Drawing.Font("Segoe UI", 10F);
        	this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        	this.MaximizeBox = false;
        	this.Name = "frmTransactions";
        	this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        	this.Text = "Transaction History";
        	this.Load += new System.EventHandler(this.FrmTransactionsLoad);
        	((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).EndInit();
        	this.ResumeLayout(false);
        	this.PerformLayout();

        }

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.DataGridView dgvTransactions;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnClose;
    }
}
