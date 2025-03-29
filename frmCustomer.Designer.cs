namespace MidTerm_DNet
{
    partial class frmCustomer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtName = new TextBox();
            txtPhone = new TextBox();
            txtAddress = new TextBox();
            txtEmail = new TextBox();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            dgvCustomer = new DataGridView();
            txtSearch = new TextBox();
            btnSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "Họ tên";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 48);
            label2.Name = "label2";
            label2.Size = new Size(26, 15);
            label2.TabIndex = 1;
            label2.Text = "SDT";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(268, 8);
            label3.Name = "label3";
            label3.Size = new Size(23, 15);
            label3.TabIndex = 2;
            label3.Text = "DC";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(268, 48);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 3;
            label4.Text = "Email";
            // 
            // txtName
            // 
            txtName.Location = new Point(56, 9);
            txtName.Name = "txtName";
            txtName.Size = new Size(190, 23);
            txtName.TabIndex = 6;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(56, 48);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(190, 23);
            txtPhone.TabIndex = 7;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(312, 9);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(190, 23);
            txtAddress.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(312, 48);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(190, 23);
            txtEmail.TabIndex = 9;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(535, 90);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "Xoá";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(535, 48);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 15;
            btnUpdate.Text = "Sửa";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(535, 9);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 14;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvCustomer
            // 
            dgvCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomer.Location = new Point(12, 231);
            dgvCustomer.Name = "dgvCustomer";
            dgvCustomer.Size = new Size(930, 273);
            dgvCustomer.TabIndex = 17;
            dgvCustomer.CellClick += dgvCustomer_CellClick_1;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(637, 12);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(190, 23);
            txtSearch.TabIndex = 18;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(689, 48);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 19;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // frmCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(954, 516);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(dgvCustomer);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtEmail);
            Controls.Add(txtAddress);
            Controls.Add(txtPhone);
            Controls.Add(txtName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmCustomer";
            Text = "Quản_lý_khách_hàng";
            Load += frmCustomer_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtName;
        private TextBox txtPhone;
        private TextBox txtAddress;
        private TextBox txtEmail;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private DataGridView dgvCustomer;
        private TextBox txtSearch;
        private Button btnSearch;
    }
}