namespace LibrarySystem
{
    partial class frmBorrow
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
        	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBorrow));
        	this.lblHeader = new System.Windows.Forms.Label();
        	this.grpBorrow = new System.Windows.Forms.GroupBox();
        	this.lblBorrower = new System.Windows.Forms.Label();
        	this.cboBorrower = new System.Windows.Forms.ComboBox();
        	this.lblItem = new System.Windows.Forms.Label();
        	this.cboItem = new System.Windows.Forms.ComboBox();
        	this.lblType = new System.Windows.Forms.Label();
        	this.lblTypeValue = new System.Windows.Forms.Label();
        	this.dtpBorrowDate = new System.Windows.Forms.DateTimePicker();
        	this.lblDue = new System.Windows.Forms.Label();
        	this.lblDueValue = new System.Windows.Forms.Label();
        	this.lblLimit = new System.Windows.Forms.Label();
        	this.lblLimitValue = new System.Windows.Forms.Label();
        	this.btnBorrow = new System.Windows.Forms.Button();
        	this.btnClose = new System.Windows.Forms.Button();
        	this.lblDate = new System.Windows.Forms.Label();
        	this.lblActive = new System.Windows.Forms.Label();
        	this.dgvActive = new System.Windows.Forms.DataGridView();
        	this.pictureBox1 = new System.Windows.Forms.PictureBox();
        	this.grpBorrow.SuspendLayout();
        	((System.ComponentModel.ISupportInitialize)(this.dgvActive)).BeginInit();
        	((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
        	this.SuspendLayout();
        	// 
        	// lblHeader
        	// 
        	this.lblHeader.BackColor = System.Drawing.Color.DodgerBlue;
        	this.lblHeader.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.lblHeader.ForeColor = System.Drawing.Color.White;
        	this.lblHeader.Location = new System.Drawing.Point(271, 30);
        	this.lblHeader.Name = "lblHeader";
        	this.lblHeader.Size = new System.Drawing.Size(480, 32);
        	this.lblHeader.TabIndex = 0;
        	this.lblHeader.Text = "BORROW ITEM";
        	this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        	// 
        	// grpBorrow
        	// 
        	this.grpBorrow.Controls.Add(this.lblBorrower);
        	this.grpBorrow.Controls.Add(this.cboBorrower);
        	this.grpBorrow.Controls.Add(this.lblItem);
        	this.grpBorrow.Controls.Add(this.cboItem);
        	this.grpBorrow.Controls.Add(this.lblType);
        	this.grpBorrow.Controls.Add(this.lblTypeValue);
        	this.grpBorrow.Controls.Add(this.dtpBorrowDate);
        	this.grpBorrow.Controls.Add(this.lblDue);
        	this.grpBorrow.Controls.Add(this.lblDueValue);
        	this.grpBorrow.Controls.Add(this.lblLimit);
        	this.grpBorrow.Controls.Add(this.lblLimitValue);
        	this.grpBorrow.Controls.Add(this.btnBorrow);
        	this.grpBorrow.Controls.Add(this.btnClose);
        	this.grpBorrow.Controls.Add(this.lblDate);
        	this.grpBorrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        	this.grpBorrow.Location = new System.Drawing.Point(271, 53);
        	this.grpBorrow.Name = "grpBorrow";
        	this.grpBorrow.Size = new System.Drawing.Size(480, 290);
        	this.grpBorrow.TabIndex = 0;
        	this.grpBorrow.TabStop = false;
        	this.grpBorrow.Enter += new System.EventHandler(this.GrpBorrowEnter);
        	// 
        	// lblBorrower
        	// 
        	this.lblBorrower.AutoSize = true;
        	this.lblBorrower.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.lblBorrower.Location = new System.Drawing.Point(14, 35);
        	this.lblBorrower.Name = "lblBorrower";
        	this.lblBorrower.Size = new System.Drawing.Size(115, 19);
        	this.lblBorrower.TabIndex = 0;
        	this.lblBorrower.Text = "Borrower:";
        	// 
        	// cboBorrower
        	// 
        	this.cboBorrower.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        	this.cboBorrower.FormattingEnabled = true;
        	this.cboBorrower.Location = new System.Drawing.Point(135, 30);
        	this.cboBorrower.Name = "cboBorrower";
        	this.cboBorrower.Size = new System.Drawing.Size(320, 27);
        	this.cboBorrower.TabIndex = 0;
        	this.cboBorrower.SelectedIndexChanged += new System.EventHandler(this.CboBorrowerSelectedIndexChanged);
        	// 
        	// lblItem
        	// 
        	this.lblItem.AutoSize = true;
        	this.lblItem.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.lblItem.Location = new System.Drawing.Point(15, 69);
        	this.lblItem.Name = "lblItem";
        	this.lblItem.Size = new System.Drawing.Size(55, 19);
        	this.lblItem.TabIndex = 1;
        	this.lblItem.Text = "Item:";
        	// 
        	// cboItem
        	// 
        	this.cboItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        	this.cboItem.FormattingEnabled = true;
        	this.cboItem.Location = new System.Drawing.Point(135, 65);
        	this.cboItem.Name = "cboItem";
        	this.cboItem.Size = new System.Drawing.Size(320, 27);
        	this.cboItem.TabIndex = 1;
        	this.cboItem.SelectedIndexChanged += new System.EventHandler(this.CboItemSelectedIndexChanged);
        	// 
        	// lblType
        	// 
        	this.lblType.AutoSize = true;
        	this.lblType.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.lblType.Location = new System.Drawing.Point(15, 107);
        	this.lblType.Name = "lblType";
        	this.lblType.Size = new System.Drawing.Size(102, 19);
        	this.lblType.TabIndex = 2;
        	this.lblType.Text = "Item Type:";
        	// 
        	// lblTypeValue
        	// 
        	this.lblTypeValue.AutoSize = true;
        	this.lblTypeValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        	this.lblTypeValue.Location = new System.Drawing.Point(135, 103);
        	this.lblTypeValue.Name = "lblTypeValue";
        	this.lblTypeValue.Size = new System.Drawing.Size(17, 23);
        	this.lblTypeValue.TabIndex = 3;
        	this.lblTypeValue.Text = "-";
        	// 
        	// dtpBorrowDate
        	// 
        	this.dtpBorrowDate.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.dtpBorrowDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        	this.dtpBorrowDate.Location = new System.Drawing.Point(158, 136);
        	this.dtpBorrowDate.Name = "dtpBorrowDate";
        	this.dtpBorrowDate.Size = new System.Drawing.Size(168, 24);
        	this.dtpBorrowDate.TabIndex = 2;
        	this.dtpBorrowDate.ValueChanged += new System.EventHandler(this.DtpBorrowDateValueChanged);
        	// 
        	// lblDue
        	// 
        	this.lblDue.AutoSize = true;
        	this.lblDue.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.lblDue.Location = new System.Drawing.Point(15, 173);
        	this.lblDue.Name = "lblDue";
        	this.lblDue.Size = new System.Drawing.Size(102, 19);
        	this.lblDue.TabIndex = 5;
        	this.lblDue.Text = "Due Date:";
        	// 
        	// lblDueValue
        	// 
        	this.lblDueValue.AutoSize = true;
        	this.lblDueValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        	this.lblDueValue.Location = new System.Drawing.Point(135, 173);
        	this.lblDueValue.Name = "lblDueValue";
        	this.lblDueValue.Size = new System.Drawing.Size(17, 23);
        	this.lblDueValue.TabIndex = 6;
        	this.lblDueValue.Text = "-";
        	// 
        	// lblLimit
        	// 
        	this.lblLimit.AutoSize = true;
        	this.lblLimit.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.lblLimit.Location = new System.Drawing.Point(15, 208);
        	this.lblLimit.Name = "lblLimit";
        	this.lblLimit.Size = new System.Drawing.Size(140, 19);
        	this.lblLimit.TabIndex = 7;
        	this.lblLimit.Text = "Loans / Limit:";
        	// 
        	// lblLimitValue
        	// 
        	this.lblLimitValue.AutoSize = true;
        	this.lblLimitValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        	this.lblLimitValue.Location = new System.Drawing.Point(135, 208);
        	this.lblLimitValue.Name = "lblLimitValue";
        	this.lblLimitValue.Size = new System.Drawing.Size(17, 23);
        	this.lblLimitValue.TabIndex = 8;
        	this.lblLimitValue.Text = "-";
        	// 
        	// btnBorrow
        	// 
        	this.btnBorrow.BackColor = System.Drawing.Color.DodgerBlue;
        	this.btnBorrow.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
        	this.btnBorrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        	this.btnBorrow.ForeColor = System.Drawing.Color.White;
        	this.btnBorrow.Location = new System.Drawing.Point(135, 243);
        	this.btnBorrow.Name = "btnBorrow";
        	this.btnBorrow.Size = new System.Drawing.Size(110, 34);
        	this.btnBorrow.TabIndex = 3;
        	this.btnBorrow.Text = "Borrow";
        	this.btnBorrow.UseVisualStyleBackColor = false;
        	this.btnBorrow.Click += new System.EventHandler(this.BtnBorrowClick);
        	// 
        	// btnClose
        	// 
        	this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
        	this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        	this.btnClose.ForeColor = System.Drawing.Color.DodgerBlue;
        	this.btnClose.Location = new System.Drawing.Point(261, 243);
        	this.btnClose.Name = "btnClose";
        	this.btnClose.Size = new System.Drawing.Size(110, 34);
        	this.btnClose.TabIndex = 4;
        	this.btnClose.Text = "Close";
        	this.btnClose.UseVisualStyleBackColor = true;
        	this.btnClose.Click += new System.EventHandler(this.BtnCloseClick);
        	// 
        	// lblDate
        	// 
        	this.lblDate.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.lblDate.Location = new System.Drawing.Point(15, 138);
        	this.lblDate.Name = "lblDate";
        	this.lblDate.Size = new System.Drawing.Size(148, 19);
        	this.lblDate.TabIndex = 4;
        	this.lblDate.Text = "Borrow Date:";
        	this.lblDate.Click += new System.EventHandler(this.LblDateClick);
        	// 
        	// lblActive
        	// 
        	this.lblActive.AutoSize = true;
        	this.lblActive.Location = new System.Drawing.Point(12, 350);
        	this.lblActive.Name = "lblActive";
        	this.lblActive.Size = new System.Drawing.Size(140, 19);
        	this.lblActive.TabIndex = 1;
        	this.lblActive.Text = "Active Loans:";
        	// 
        	// dgvActive
        	// 
        	this.dgvActive.AllowUserToAddRows = false;
        	this.dgvActive.AllowUserToDeleteRows = false;
        	this.dgvActive.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
        	this.dgvActive.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        	this.dgvActive.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
        	this.dgvActive.Location = new System.Drawing.Point(12, 372);
        	this.dgvActive.MultiSelect = false;
        	this.dgvActive.Name = "dgvActive";
        	this.dgvActive.ReadOnly = true;
        	this.dgvActive.RowHeadersVisible = false;
        	this.dgvActive.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        	this.dgvActive.Size = new System.Drawing.Size(1020, 240);
        	this.dgvActive.TabIndex = 5;
        	// 
        	// pictureBox1
        	// 
        	this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
        	this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
        	this.pictureBox1.Location = new System.Drawing.Point(27, 30);
        	this.pictureBox1.Name = "pictureBox1";
        	this.pictureBox1.Size = new System.Drawing.Size(122, 120);
        	this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        	this.pictureBox1.TabIndex = 6;
        	this.pictureBox1.TabStop = false;
        	// 
        	// frmBorrow
        	// 
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
        	this.BackColor = System.Drawing.Color.White;
        	this.ClientSize = new System.Drawing.Size(1044, 625);
        	this.Controls.Add(this.pictureBox1);
        	this.Controls.Add(this.lblHeader);
        	this.Controls.Add(this.grpBorrow);
        	this.Controls.Add(this.lblActive);
        	this.Controls.Add(this.dgvActive);
        	this.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        	this.MaximizeBox = false;
        	this.Name = "frmBorrow";
        	this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        	this.Text = "Borrow Item";
        	this.Load += new System.EventHandler(this.FrmBorrowLoad);
        	this.grpBorrow.ResumeLayout(false);
        	this.grpBorrow.PerformLayout();
        	((System.ComponentModel.ISupportInitialize)(this.dgvActive)).EndInit();
        	((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
        	this.ResumeLayout(false);
        	this.PerformLayout();

        }

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.GroupBox grpBorrow;
        private System.Windows.Forms.Label lblBorrower;
        private System.Windows.Forms.ComboBox cboBorrower;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.ComboBox cboItem;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblTypeValue;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpBorrowDate;
        private System.Windows.Forms.Label lblDue;
        private System.Windows.Forms.Label lblDueValue;
        private System.Windows.Forms.Label lblLimit;
        private System.Windows.Forms.Label lblLimitValue;
        private System.Windows.Forms.Button btnBorrow;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblActive;
        private System.Windows.Forms.DataGridView dgvActive;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
