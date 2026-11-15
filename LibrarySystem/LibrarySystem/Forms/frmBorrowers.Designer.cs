namespace LibrarySystem
{
    partial class frmBorrowers
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
        	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBorrowers));
        	this.lblHeader = new System.Windows.Forms.Label();
        	this.grpDetails = new System.Windows.Forms.GroupBox();
        	this.lblId = new System.Windows.Forms.Label();
        	this.txtPersonId = new System.Windows.Forms.TextBox();
        	this.lblName = new System.Windows.Forms.Label();
        	this.txtName = new System.Windows.Forms.TextBox();
        	this.lblContact = new System.Windows.Forms.Label();
        	this.txtContact = new System.Windows.Forms.TextBox();
        	this.lblType = new System.Windows.Forms.Label();
        	this.cboType = new System.Windows.Forms.ComboBox();
        	this.btnUpdate = new System.Windows.Forms.Button();
        	this.btnClear = new System.Windows.Forms.Button();
        	this.btnAdd = new System.Windows.Forms.Button();
        	this.btnDelete = new System.Windows.Forms.Button();
        	this.lblSearch = new System.Windows.Forms.Label();
        	this.txtSearch = new System.Windows.Forms.TextBox();
        	this.dgvBorrowers = new System.Windows.Forms.DataGridView();
        	this.btnClose = new System.Windows.Forms.Button();
        	this.pictureBox1 = new System.Windows.Forms.PictureBox();
        	this.label1 = new System.Windows.Forms.Label();
        	this.grpDetails.SuspendLayout();
        	((System.ComponentModel.ISupportInitialize)(this.dgvBorrowers)).BeginInit();
        	((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
        	this.SuspendLayout();
        	// 
        	// lblHeader
        	// 
        	this.lblHeader.BackColor = System.Drawing.Color.DodgerBlue;
        	this.lblHeader.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.lblHeader.ForeColor = System.Drawing.Color.White;
        	this.lblHeader.Location = new System.Drawing.Point(12, 187);
        	this.lblHeader.Name = "lblHeader";
        	this.lblHeader.Size = new System.Drawing.Size(330, 33);
        	this.lblHeader.TabIndex = 0;
        	this.lblHeader.Text = "MANAGE BORROWERS";
        	// 
        	// grpDetails
        	// 
        	this.grpDetails.BackColor = System.Drawing.Color.White;
        	this.grpDetails.Controls.Add(this.lblId);
        	this.grpDetails.Controls.Add(this.txtPersonId);
        	this.grpDetails.Controls.Add(this.lblName);
        	this.grpDetails.Controls.Add(this.txtName);
        	this.grpDetails.Controls.Add(this.lblContact);
        	this.grpDetails.Controls.Add(this.txtContact);
        	this.grpDetails.Controls.Add(this.lblType);
        	this.grpDetails.Controls.Add(this.cboType);
        	this.grpDetails.Controls.Add(this.btnUpdate);
        	this.grpDetails.Controls.Add(this.btnClear);
        	this.grpDetails.Controls.Add(this.btnAdd);
        	this.grpDetails.Controls.Add(this.btnDelete);
        	this.grpDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        	this.grpDetails.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.grpDetails.Location = new System.Drawing.Point(12, 208);
        	this.grpDetails.Name = "grpDetails";
        	this.grpDetails.Size = new System.Drawing.Size(330, 345);
        	this.grpDetails.TabIndex = 0;
        	this.grpDetails.TabStop = false;
        	this.grpDetails.Enter += new System.EventHandler(this.GrpDetailsEnter);
        	// 
        	// lblId
        	// 
        	this.lblId.AutoSize = true;
        	this.lblId.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.lblId.Location = new System.Drawing.Point(15, 45);
        	this.lblId.Name = "lblId";
        	this.lblId.Size = new System.Drawing.Size(34, 19);
        	this.lblId.TabIndex = 0;
        	this.lblId.Text = "ID:";
        	this.lblId.Click += new System.EventHandler(this.LblIdClick);
        	// 
        	// txtPersonId
        	// 
        	this.txtPersonId.Location = new System.Drawing.Point(116, 39);
        	this.txtPersonId.Name = "txtPersonId";
        	this.txtPersonId.Size = new System.Drawing.Size(195, 30);
        	this.txtPersonId.TabIndex = 0;
        	// 
        	// lblName
        	// 
        	this.lblName.AutoSize = true;
        	this.lblName.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.lblName.Location = new System.Drawing.Point(15, 81);
        	this.lblName.Name = "lblName";
        	this.lblName.Size = new System.Drawing.Size(66, 19);
        	this.lblName.TabIndex = 1;
        	this.lblName.Text = "Name:";
        	// 
        	// txtName
        	// 
        	this.txtName.Location = new System.Drawing.Point(116, 75);
        	this.txtName.Name = "txtName";
        	this.txtName.Size = new System.Drawing.Size(195, 30);
        	this.txtName.TabIndex = 1;
        	// 
        	// lblContact
        	// 
        	this.lblContact.AutoSize = true;
        	this.lblContact.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.lblContact.Location = new System.Drawing.Point(15, 121);
        	this.lblContact.Name = "lblContact";
        	this.lblContact.Size = new System.Drawing.Size(97, 19);
        	this.lblContact.TabIndex = 2;
        	this.lblContact.Text = "Contact:";
        	// 
        	// txtContact
        	// 
        	this.txtContact.Location = new System.Drawing.Point(116, 115);
        	this.txtContact.Name = "txtContact";
        	this.txtContact.Size = new System.Drawing.Size(195, 30);
        	this.txtContact.TabIndex = 2;
        	// 
        	// lblType
        	// 
        	this.lblType.AutoSize = true;
        	this.lblType.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.lblType.Location = new System.Drawing.Point(15, 161);
        	this.lblType.Name = "lblType";
        	this.lblType.Size = new System.Drawing.Size(57, 19);
        	this.lblType.TabIndex = 3;
        	this.lblType.Text = "Type:";
        	// 
        	// cboType
        	// 
        	this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        	this.cboType.FormattingEnabled = true;
        	this.cboType.Items.AddRange(new object[] {
			"Student",
			"Faculty"});
        	this.cboType.Location = new System.Drawing.Point(116, 155);
        	this.cboType.Name = "cboType";
        	this.cboType.Size = new System.Drawing.Size(195, 31);
        	this.cboType.TabIndex = 3;
        	// 
        	// btnUpdate
        	// 
        	this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        	this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
        	this.btnUpdate.Location = new System.Drawing.Point(10, 263);
        	this.btnUpdate.Name = "btnUpdate";
        	this.btnUpdate.Size = new System.Drawing.Size(154, 52);
        	this.btnUpdate.TabIndex = 5;
        	this.btnUpdate.Text = "Update";
        	this.btnUpdate.UseVisualStyleBackColor = true;
        	this.btnUpdate.Click += new System.EventHandler(this.BtnUpdateClick);
        	// 
        	// btnClear
        	// 
        	this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        	this.btnClear.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
        	this.btnClear.Location = new System.Drawing.Point(170, 263);
        	this.btnClear.Name = "btnClear";
        	this.btnClear.Size = new System.Drawing.Size(154, 52);
        	this.btnClear.TabIndex = 7;
        	this.btnClear.Text = "Clear";
        	this.btnClear.UseVisualStyleBackColor = true;
        	this.btnClear.Click += new System.EventHandler(this.BtnClearClick);
        	// 
        	// btnAdd
        	// 
        	this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        	this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.btnAdd.ForeColor = System.Drawing.Color.DodgerBlue;
        	this.btnAdd.Location = new System.Drawing.Point(10, 205);
        	this.btnAdd.Name = "btnAdd";
        	this.btnAdd.Size = new System.Drawing.Size(154, 52);
        	this.btnAdd.TabIndex = 4;
        	this.btnAdd.Text = "Add";
        	this.btnAdd.UseVisualStyleBackColor = true;
        	this.btnAdd.Click += new System.EventHandler(this.BtnAddClick);
        	// 
        	// btnDelete
        	// 
        	this.btnDelete.BackColor = System.Drawing.Color.White;
        	this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        	this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.btnDelete.ForeColor = System.Drawing.Color.Red;
        	this.btnDelete.Location = new System.Drawing.Point(170, 205);
        	this.btnDelete.Name = "btnDelete";
        	this.btnDelete.Size = new System.Drawing.Size(154, 52);
        	this.btnDelete.TabIndex = 6;
        	this.btnDelete.Text = "Delete";
        	this.btnDelete.UseVisualStyleBackColor = false;
        	this.btnDelete.Click += new System.EventHandler(this.BtnDeleteClick);
        	// 
        	// lblSearch
        	// 
        	this.lblSearch.AutoSize = true;
        	this.lblSearch.Location = new System.Drawing.Point(351, 153);
        	this.lblSearch.Name = "lblSearch";
        	this.lblSearch.Size = new System.Drawing.Size(65, 23);
        	this.lblSearch.TabIndex = 1;
        	this.lblSearch.Text = "Search:";
        	this.lblSearch.Click += new System.EventHandler(this.LblSearchClick);
        	// 
        	// txtSearch
        	// 
        	this.txtSearch.Location = new System.Drawing.Point(422, 151);
        	this.txtSearch.Name = "txtSearch";
        	this.txtSearch.Size = new System.Drawing.Size(303, 30);
        	this.txtSearch.TabIndex = 8;
        	this.txtSearch.TextChanged += new System.EventHandler(this.TxtSearchTextChanged);
        	// 
        	// dgvBorrowers
        	// 
        	this.dgvBorrowers.AllowUserToAddRows = false;
        	this.dgvBorrowers.AllowUserToDeleteRows = false;
        	this.dgvBorrowers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
        	this.dgvBorrowers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        	this.dgvBorrowers.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
        	this.dgvBorrowers.Location = new System.Drawing.Point(351, 187);
        	this.dgvBorrowers.MultiSelect = false;
        	this.dgvBorrowers.Name = "dgvBorrowers";
        	this.dgvBorrowers.ReadOnly = true;
        	this.dgvBorrowers.RowHeadersVisible = false;
        	this.dgvBorrowers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        	this.dgvBorrowers.Size = new System.Drawing.Size(681, 378);
        	this.dgvBorrowers.TabIndex = 9;
        	this.dgvBorrowers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvBorrowersCellClick);
        	// 
        	// btnClose
        	// 
        	this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
        	this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        	this.btnClose.ForeColor = System.Drawing.Color.DodgerBlue;
        	this.btnClose.Location = new System.Drawing.Point(934, 580);
        	this.btnClose.Name = "btnClose";
        	this.btnClose.Size = new System.Drawing.Size(98, 32);
        	this.btnClose.TabIndex = 10;
        	this.btnClose.Text = "Close";
        	this.btnClose.UseVisualStyleBackColor = true;
        	this.btnClose.Click += new System.EventHandler(this.BtnCloseClick);
        	// 
        	// pictureBox1
        	// 
        	this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
        	this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
        	this.pictureBox1.Location = new System.Drawing.Point(27, 30);
        	this.pictureBox1.Name = "pictureBox1";
        	this.pictureBox1.Size = new System.Drawing.Size(122, 120);
        	this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        	this.pictureBox1.TabIndex = 11;
        	this.pictureBox1.TabStop = false;
        	// 
        	// label1
        	// 
        	this.label1.BackColor = System.Drawing.Color.DodgerBlue;
        	this.label1.Font = new System.Drawing.Font("Showcard Gothic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label1.ForeColor = System.Drawing.Color.White;
        	this.label1.Location = new System.Drawing.Point(182, 43);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(837, 84);
        	this.label1.TabIndex = 12;
        	this.label1.Text = "LIBRARY BORROWING MANAGEMENT SYSTEM";
        	this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        	this.label1.Click += new System.EventHandler(this.Label1Click);
        	// 
        	// frmBorrowers
        	// 
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
        	this.BackColor = System.Drawing.Color.White;
        	this.ClientSize = new System.Drawing.Size(1044, 625);
        	this.Controls.Add(this.label1);
        	this.Controls.Add(this.pictureBox1);
        	this.Controls.Add(this.lblHeader);
        	this.Controls.Add(this.grpDetails);
        	this.Controls.Add(this.lblSearch);
        	this.Controls.Add(this.txtSearch);
        	this.Controls.Add(this.dgvBorrowers);
        	this.Controls.Add(this.btnClose);
        	this.Font = new System.Drawing.Font("Segoe UI", 10F);
        	this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        	this.MaximizeBox = false;
        	this.Name = "frmBorrowers";
        	this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        	this.Text = "Manage Borrowers";
        	this.Load += new System.EventHandler(this.FrmBorrowersLoad);
        	this.grpDetails.ResumeLayout(false);
        	this.grpDetails.PerformLayout();
        	((System.ComponentModel.ISupportInitialize)(this.dgvBorrowers)).EndInit();
        	((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
        	this.ResumeLayout(false);
        	this.PerformLayout();

        }

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.GroupBox grpDetails;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtPersonId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvBorrowers;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}
