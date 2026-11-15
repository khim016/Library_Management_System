namespace LibrarySystem
{
    partial class frmReturn
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
        	this.lblSelect = new System.Windows.Forms.Label();
        	this.dgvActive = new System.Windows.Forms.DataGridView();
        	this.grpReturn = new System.Windows.Forms.GroupBox();
        	this.lblDate = new System.Windows.Forms.Label();
        	this.dtpReturnDate = new System.Windows.Forms.DateTimePicker();
        	this.lblLate = new System.Windows.Forms.Label();
        	this.lblLateValue = new System.Windows.Forms.Label();
        	this.lblFine = new System.Windows.Forms.Label();
        	this.lblFineValue = new System.Windows.Forms.Label();
        	this.btnReturn = new System.Windows.Forms.Button();
        	this.btnClose = new System.Windows.Forms.Button();
        	((System.ComponentModel.ISupportInitialize)(this.dgvActive)).BeginInit();
        	this.grpReturn.SuspendLayout();
        	this.SuspendLayout();
        	// 
        	// lblHeader
        	// 
        	this.lblHeader.AutoSize = true;
        	this.lblHeader.BackColor = System.Drawing.Color.DodgerBlue;
        	this.lblHeader.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.lblHeader.ForeColor = System.Drawing.Color.White;
        	this.lblHeader.Location = new System.Drawing.Point(12, 9);
        	this.lblHeader.Name = "lblHeader";
        	this.lblHeader.Size = new System.Drawing.Size(180, 30);
        	this.lblHeader.TabIndex = 0;
        	this.lblHeader.Text = "RETURN ITEM";
        	// 
        	// lblSelect
        	// 
        	this.lblSelect.AutoSize = true;
        	this.lblSelect.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.lblSelect.Location = new System.Drawing.Point(12, 46);
        	this.lblSelect.Name = "lblSelect";
        	this.lblSelect.Size = new System.Drawing.Size(243, 19);
        	this.lblSelect.TabIndex = 1;
        	this.lblSelect.Text = "Select a borrowed item:";
        	// 
        	// dgvActive
        	// 
        	this.dgvActive.AllowUserToAddRows = false;
        	this.dgvActive.AllowUserToDeleteRows = false;
        	this.dgvActive.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
        	this.dgvActive.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        	this.dgvActive.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
        	this.dgvActive.Location = new System.Drawing.Point(12, 72);
        	this.dgvActive.MultiSelect = false;
        	this.dgvActive.Name = "dgvActive";
        	this.dgvActive.ReadOnly = true;
        	this.dgvActive.RowHeadersVisible = false;
        	this.dgvActive.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        	this.dgvActive.Size = new System.Drawing.Size(736, 255);
        	this.dgvActive.TabIndex = 3;
        	this.dgvActive.SelectionChanged += new System.EventHandler(this.DgvActiveSelectionChanged);
        	// 
        	// grpReturn
        	// 
        	this.grpReturn.Controls.Add(this.lblDate);
        	this.grpReturn.Controls.Add(this.dtpReturnDate);
        	this.grpReturn.Controls.Add(this.lblLate);
        	this.grpReturn.Controls.Add(this.lblLateValue);
        	this.grpReturn.Controls.Add(this.lblFine);
        	this.grpReturn.Controls.Add(this.lblFineValue);
        	this.grpReturn.Controls.Add(this.btnReturn);
        	this.grpReturn.Controls.Add(this.btnClose);
        	this.grpReturn.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.grpReturn.Location = new System.Drawing.Point(12, 340);
        	this.grpReturn.Name = "grpReturn";
        	this.grpReturn.Size = new System.Drawing.Size(736, 185);
        	this.grpReturn.TabIndex = 0;
        	this.grpReturn.TabStop = false;
        	this.grpReturn.Text = "Return Details";
        	// 
        	// lblDate
        	// 
        	this.lblDate.AutoSize = true;
        	this.lblDate.Location = new System.Drawing.Point(15, 38);
        	this.lblDate.Name = "lblDate";
        	this.lblDate.Size = new System.Drawing.Size(137, 19);
        	this.lblDate.TabIndex = 0;
        	this.lblDate.Text = "Return Date:";
        	// 
        	// dtpReturnDate
        	// 
        	this.dtpReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        	this.dtpReturnDate.Location = new System.Drawing.Point(152, 35);
        	this.dtpReturnDate.Name = "dtpReturnDate";
        	this.dtpReturnDate.Size = new System.Drawing.Size(160, 26);
        	this.dtpReturnDate.TabIndex = 0;
        	this.dtpReturnDate.ValueChanged += new System.EventHandler(this.DtpReturnDateValueChanged);
        	// 
        	// lblLate
        	// 
        	this.lblLate.AutoSize = true;
        	this.lblLate.Location = new System.Drawing.Point(15, 78);
        	this.lblLate.Name = "lblLate";
        	this.lblLate.Size = new System.Drawing.Size(109, 19);
        	this.lblLate.TabIndex = 1;
        	this.lblLate.Text = "Days Late:";
        	// 
        	// lblLateValue
        	// 
        	this.lblLateValue.AutoSize = true;
        	this.lblLateValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        	this.lblLateValue.Location = new System.Drawing.Point(135, 78);
        	this.lblLateValue.Name = "lblLateValue";
        	this.lblLateValue.Size = new System.Drawing.Size(20, 23);
        	this.lblLateValue.TabIndex = 2;
        	this.lblLateValue.Text = "0";
        	this.lblLateValue.Click += new System.EventHandler(this.LblLateValueClick);
        	// 
        	// lblFine
        	// 
        	this.lblFine.AutoSize = true;
        	this.lblFine.Location = new System.Drawing.Point(15, 120);
        	this.lblFine.Name = "lblFine";
        	this.lblFine.Size = new System.Drawing.Size(112, 19);
        	this.lblFine.TabIndex = 3;
        	this.lblFine.Text = "Fine (PHP):";
        	// 
        	// lblFineValue
        	// 
        	this.lblFineValue.AutoSize = true;
        	this.lblFineValue.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
        	this.lblFineValue.ForeColor = System.Drawing.Color.Firebrick;
        	this.lblFineValue.Location = new System.Drawing.Point(135, 116);
        	this.lblFineValue.Name = "lblFineValue";
        	this.lblFineValue.Size = new System.Drawing.Size(64, 32);
        	this.lblFineValue.TabIndex = 4;
        	this.lblFineValue.Text = "0.00";
        	// 
        	// btnReturn
        	// 
        	this.btnReturn.BackColor = System.Drawing.Color.DodgerBlue;
        	this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        	this.btnReturn.ForeColor = System.Drawing.Color.White;
        	this.btnReturn.Location = new System.Drawing.Point(510, 130);
        	this.btnReturn.Name = "btnReturn";
        	this.btnReturn.Size = new System.Drawing.Size(100, 36);
        	this.btnReturn.TabIndex = 1;
        	this.btnReturn.Text = "Return";
        	this.btnReturn.UseVisualStyleBackColor = false;
        	this.btnReturn.Click += new System.EventHandler(this.BtnReturnClick);
        	// 
        	// btnClose
        	// 
        	this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        	this.btnClose.ForeColor = System.Drawing.Color.DodgerBlue;
        	this.btnClose.Location = new System.Drawing.Point(620, 130);
        	this.btnClose.Name = "btnClose";
        	this.btnClose.Size = new System.Drawing.Size(100, 36);
        	this.btnClose.TabIndex = 2;
        	this.btnClose.Text = "Close";
        	this.btnClose.UseVisualStyleBackColor = true;
        	this.btnClose.Click += new System.EventHandler(this.BtnCloseClick);
        	// 
        	// frmReturn
        	// 
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
        	this.BackColor = System.Drawing.Color.White;
        	this.ClientSize = new System.Drawing.Size(760, 540);
        	this.Controls.Add(this.lblHeader);
        	this.Controls.Add(this.lblSelect);
        	this.Controls.Add(this.dgvActive);
        	this.Controls.Add(this.grpReturn);
        	this.Font = new System.Drawing.Font("Segoe UI", 10F);
        	this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        	this.MaximizeBox = false;
        	this.Name = "frmReturn";
        	this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        	this.Text = "Return Item";
        	this.Load += new System.EventHandler(this.FrmReturnLoad);
        	((System.ComponentModel.ISupportInitialize)(this.dgvActive)).EndInit();
        	this.grpReturn.ResumeLayout(false);
        	this.grpReturn.PerformLayout();
        	this.ResumeLayout(false);
        	this.PerformLayout();

        }

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.DataGridView dgvActive;
        private System.Windows.Forms.GroupBox grpReturn;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpReturnDate;
        private System.Windows.Forms.Label lblLate;
        private System.Windows.Forms.Label lblLateValue;
        private System.Windows.Forms.Label lblFine;
        private System.Windows.Forms.Label lblFineValue;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnClose;
    }
}
