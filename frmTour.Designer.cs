namespace MidTerm_DNet
{
    partial class frmTour
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
            label5 = new Label();
            txtTourName = new TextBox();
            txtPrice = new TextBox();
            cmbTransportation = new ComboBox();
            cmbTourType = new ComboBox();
            rtbDescription = new RichTextBox();
            dgvTour = new DataGridView();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            chkActive = new CheckBox();
            cmbSearchTourType = new ComboBox();
            btnSearch = new Button();
            groupBox1 = new GroupBox();
            cmbSearchTransportation = new ComboBox();
            cmbSearchBudget = new ComboBox();
            btnClear = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTour).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 20);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 0;
            label1.Text = "Tour Name :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 59);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Price :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 115);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 2;
            label3.Text = "Description :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(298, 20);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 3;
            label4.Text = "Tour Type :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(298, 59);
            label5.Name = "label5";
            label5.Size = new Size(89, 15);
            label5.TabIndex = 4;
            label5.Text = "Transportation :";
            // 
            // txtTourName
            // 
            txtTourName.Location = new Point(86, 12);
            txtTourName.Name = "txtTourName";
            txtTourName.Size = new Size(190, 23);
            txtTourName.TabIndex = 5;
            txtTourName.TextChanged += txtTourName_TextChanged_1;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(86, 51);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(190, 23);
            txtPrice.TabIndex = 6;
            txtPrice.TextChanged += txtPrice_TextChanged;
            // 
            // cmbTransportation
            // 
            cmbTransportation.FormattingEnabled = true;
            cmbTransportation.Location = new Point(393, 51);
            cmbTransportation.Name = "cmbTransportation";
            cmbTransportation.Size = new Size(188, 23);
            cmbTransportation.TabIndex = 7;
            // 
            // cmbTourType
            // 
            cmbTourType.FormattingEnabled = true;
            cmbTourType.Location = new Point(394, 12);
            cmbTourType.Name = "cmbTourType";
            cmbTourType.Size = new Size(188, 23);
            cmbTourType.TabIndex = 8;
            // 
            // rtbDescription
            // 
            rtbDescription.Location = new Point(88, 115);
            rtbDescription.Name = "rtbDescription";
            rtbDescription.Size = new Size(493, 87);
            rtbDescription.TabIndex = 9;
            rtbDescription.Text = "";
            rtbDescription.TextChanged += richTextBox1_TextChanged;
            // 
            // dgvTour
            // 
            dgvTour.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTour.Location = new Point(12, 231);
            dgvTour.Name = "dgvTour";
            dgvTour.Size = new Size(930, 273);
            dgvTour.TabIndex = 10;
            dgvTour.CellClick += dgvTour_CellClick;
            dgvTour.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(605, 12);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(605, 50);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(605, 89);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // chkActive
            // 
            chkActive.AutoSize = true;
            chkActive.Location = new Point(86, 89);
            chkActive.Name = "chkActive";
            chkActive.Size = new Size(59, 19);
            chkActive.TabIndex = 14;
            chkActive.Text = "Active";
            chkActive.UseVisualStyleBackColor = true;
            chkActive.CheckedChanged += chkActive_CheckedChanged;
            // 
            // cmbSearchTourType
            // 
            cmbSearchTourType.FormattingEnabled = true;
            cmbSearchTourType.Location = new Point(22, 22);
            cmbSearchTourType.Name = "cmbSearchTourType";
            cmbSearchTourType.Size = new Size(187, 23);
            cmbSearchTourType.TabIndex = 15;
            cmbSearchTourType.SelectedIndexChanged += cmbSearchTourType_SelectedIndexChanged;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(22, 147);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 16;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnClear);
            groupBox1.Controls.Add(cmbSearchTransportation);
            groupBox1.Controls.Add(cmbSearchBudget);
            groupBox1.Controls.Add(cmbSearchTourType);
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Location = new Point(698, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(226, 199);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search";
            // 
            // cmbSearchTransportation
            // 
            cmbSearchTransportation.FormattingEnabled = true;
            cmbSearchTransportation.Location = new Point(22, 100);
            cmbSearchTransportation.Name = "cmbSearchTransportation";
            cmbSearchTransportation.Size = new Size(187, 23);
            cmbSearchTransportation.TabIndex = 18;
            cmbSearchTransportation.SelectedIndexChanged += cmbSearchTransportation_SelectedIndexChanged;
            // 
            // cmbSearchBudget
            // 
            cmbSearchBudget.FormattingEnabled = true;
            cmbSearchBudget.Location = new Point(22, 62);
            cmbSearchBudget.Name = "cmbSearchBudget";
            cmbSearchBudget.Size = new Size(187, 23);
            cmbSearchBudget.TabIndex = 17;
            cmbSearchBudget.SelectedIndexChanged += cmbSearchBudget_SelectedIndexChanged;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(134, 147);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 19;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // frmTour
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(954, 516);
            Controls.Add(groupBox1);
            Controls.Add(chkActive);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(dgvTour);
            Controls.Add(rtbDescription);
            Controls.Add(cmbTourType);
            Controls.Add(cmbTransportation);
            Controls.Add(txtPrice);
            Controls.Add(txtTourName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmTour";
            Text = "Quản_lý_đơn_đặt_tour";
            Load += frmTour_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTour).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtTourName;
        private TextBox txtPrice;
        private ComboBox cmbTransportation;
        private ComboBox cmbTourType;
        private RichTextBox rtbDescription;
        private DataGridView dgvTour;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private CheckBox chkActive;
        private ComboBox cmbSearchTourType;
        private Button btnSearch;
        private GroupBox groupBox1;
        private ComboBox cmbSearchTransportation;
        private ComboBox cmbSearchBudget;
        private Button btnClear;
    }
}