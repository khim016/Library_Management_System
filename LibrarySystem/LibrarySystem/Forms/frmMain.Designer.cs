namespace LibrarySystem
{
    partial class frmMain
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
        	this.pnlHeader = new System.Windows.Forms.Panel();
        	this.lblTitle = new System.Windows.Forms.Label();
        	this.btnItems = new System.Windows.Forms.Button();
        	this.btnBorrowers = new System.Windows.Forms.Button();
        	this.btnBorrow = new System.Windows.Forms.Button();
        	this.btnReturn = new System.Windows.Forms.Button();
        	this.btnTransactions = new System.Windows.Forms.Button();
        	this.btnExit = new System.Windows.Forms.Button();
        	this.statusStrip1 = new System.Windows.Forms.StatusStrip();
        	this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
        	this.pnlHeader.SuspendLayout();
        	this.statusStrip1.SuspendLayout();
        	this.SuspendLayout();
        	// 
        	// pnlHeader
        	// 
        	this.pnlHeader.BackColor = System.Drawing.Color.DodgerBlue;
        	this.pnlHeader.Controls.Add(this.lblTitle);
        	this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
        	this.pnlHeader.Location = new System.Drawing.Point(0, 0);
        	this.pnlHeader.Name = "pnlHeader";
        	this.pnlHeader.Size = new System.Drawing.Size(620, 70);
        	this.pnlHeader.TabIndex = 6;
        	// 
        	// lblTitle
        	// 
        	this.lblTitle.AutoSize = true;
        	this.lblTitle.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.lblTitle.ForeColor = System.Drawing.Color.White;
        	this.lblTitle.Location = new System.Drawing.Point(123, 23);
        	this.lblTitle.Name = "lblTitle";
        	this.lblTitle.Size = new System.Drawing.Size(461, 37);
        	this.lblTitle.TabIndex = 0;
        	this.lblTitle.Text = "LIBRARY BORROWING SYSTEM";
        	this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        	this.lblTitle.Click += new System.EventHandler(this.LblTitleClick);
        	// 
        	// btnItems
        	// 
        	this.btnItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        	this.btnItems.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.btnItems.ForeColor = System.Drawing.Color.Blue;
        	this.btnItems.Location = new System.Drawing.Point(60, 100);
        	this.btnItems.Name = "btnItems";
        	this.btnItems.Size = new System.Drawing.Size(220, 70);
        	this.btnItems.TabIndex = 0;
        	this.btnItems.Text = "Manage Books";
        	this.btnItems.UseVisualStyleBackColor = true;
        	this.btnItems.Click += new System.EventHandler(this.BtnItemsClick);
        	// 
        	// btnBorrowers
        	// 
        	this.btnBorrowers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        	this.btnBorrowers.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.btnBorrowers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
        	this.btnBorrowers.Location = new System.Drawing.Point(330, 100);
        	this.btnBorrowers.Name = "btnBorrowers";
        	this.btnBorrowers.Size = new System.Drawing.Size(220, 70);
        	this.btnBorrowers.TabIndex = 1;
        	this.btnBorrowers.Text = "Manage Borrowers";
        	this.btnBorrowers.UseVisualStyleBackColor = true;
        	this.btnBorrowers.Click += new System.EventHandler(this.BtnBorrowersClick);
        	// 
        	// btnBorrow
        	// 
        	this.btnBorrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        	this.btnBorrow.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.btnBorrow.ForeColor = System.Drawing.Color.Green;
        	this.btnBorrow.Location = new System.Drawing.Point(60, 190);
        	this.btnBorrow.Name = "btnBorrow";
        	this.btnBorrow.Size = new System.Drawing.Size(220, 70);
        	this.btnBorrow.TabIndex = 2;
        	this.btnBorrow.Text = "Borrow Item";
        	this.btnBorrow.UseVisualStyleBackColor = true;
        	this.btnBorrow.Click += new System.EventHandler(this.BtnBorrowClick);
        	// 
        	// btnReturn
        	// 
        	this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        	this.btnReturn.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.btnReturn.ForeColor = System.Drawing.Color.Gold;
        	this.btnReturn.Location = new System.Drawing.Point(330, 190);
        	this.btnReturn.Name = "btnReturn";
        	this.btnReturn.Size = new System.Drawing.Size(220, 70);
        	this.btnReturn.TabIndex = 3;
        	this.btnReturn.Text = "Return Item";
        	this.btnReturn.UseVisualStyleBackColor = true;
        	this.btnReturn.Click += new System.EventHandler(this.BtnReturnClick);
        	// 
        	// btnTransactions
        	// 
        	this.btnTransactions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        	this.btnTransactions.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.btnTransactions.ForeColor = System.Drawing.Color.LimeGreen;
        	this.btnTransactions.Location = new System.Drawing.Point(60, 280);
        	this.btnTransactions.Name = "btnTransactions";
        	this.btnTransactions.Size = new System.Drawing.Size(220, 70);
        	this.btnTransactions.TabIndex = 4;
        	this.btnTransactions.Text = "Transactions";
        	this.btnTransactions.UseVisualStyleBackColor = true;
        	this.btnTransactions.Click += new System.EventHandler(this.BtnTransactionsClick);
        	// 
        	// btnExit
        	// 
        	this.btnExit.BackColor = System.Drawing.Color.White;
        	this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        	this.btnExit.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.btnExit.ForeColor = System.Drawing.Color.Red;
        	this.btnExit.Location = new System.Drawing.Point(330, 280);
        	this.btnExit.Name = "btnExit";
        	this.btnExit.Size = new System.Drawing.Size(220, 70);
        	this.btnExit.TabIndex = 5;
        	this.btnExit.Text = "Exit";
        	this.btnExit.UseVisualStyleBackColor = false;
        	this.btnExit.Click += new System.EventHandler(this.BtnExitClick);
        	// 
        	// statusStrip1
        	// 
        	this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
        	this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.lblStatus});
        	this.statusStrip1.Location = new System.Drawing.Point(0, 395);
        	this.statusStrip1.Name = "statusStrip1";
        	this.statusStrip1.Size = new System.Drawing.Size(620, 25);
        	this.statusStrip1.TabIndex = 7;
        	// 
        	// lblStatus
        	// 
        	this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
        	this.lblStatus.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
        	this.lblStatus.Name = "lblStatus";
        	this.lblStatus.Size = new System.Drawing.Size(50, 20);
        	this.lblStatus.Text = "Ready";
        	// 
        	// frmMain
        	// 
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
        	this.BackColor = System.Drawing.Color.White;
        	this.ClientSize = new System.Drawing.Size(620, 420);
        	this.Controls.Add(this.pnlHeader);
        	this.Controls.Add(this.btnItems);
        	this.Controls.Add(this.btnBorrowers);
        	this.Controls.Add(this.btnBorrow);
        	this.Controls.Add(this.btnReturn);
        	this.Controls.Add(this.btnTransactions);
        	this.Controls.Add(this.btnExit);
        	this.Controls.Add(this.statusStrip1);
        	this.Font = new System.Drawing.Font("Segoe UI", 10F);
        	this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        	this.MaximizeBox = false;
        	this.Name = "frmMain";
        	this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        	this.Text = "Library Borrowing System";
        	this.Load += new System.EventHandler(this.FrmMainLoad);
        	this.pnlHeader.ResumeLayout(false);
        	this.pnlHeader.PerformLayout();
        	this.statusStrip1.ResumeLayout(false);
        	this.statusStrip1.PerformLayout();
        	this.ResumeLayout(false);
        	this.PerformLayout();

        }

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnItems;
        private System.Windows.Forms.Button btnBorrowers;
        private System.Windows.Forms.Button btnBorrow;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnTransactions;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
    }
}
