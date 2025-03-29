
namespace MidTerm_DNet
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Btn_1 = new Button();
            txtName = new TextBox();
            txtPassWord = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblError = new Label();
            SuspendLayout();
            // 
            // Btn_1
            // 
            Btn_1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Btn_1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_1.Location = new Point(162, 307);
            Btn_1.Name = "Btn_1";
            Btn_1.Size = new Size(100, 35);
            Btn_1.TabIndex = 0;
            Btn_1.Text = "Login";
            Btn_1.UseVisualStyleBackColor = true;
            Btn_1.Click += Btn_1_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(150, 172);
            txtName.Name = "txtName";
            txtName.Size = new Size(182, 23);
            txtName.TabIndex = 1;
            txtName.TextChanged += textBox1_TextChanged;
            // 
            // txtPassWord
            // 
            txtPassWord.Location = new Point(150, 235);
            txtPassWord.Name = "txtPassWord";
            txtPassWord.Size = new Size(182, 23);
            txtPassWord.TabIndex = 2;
            txtPassWord.TextChanged += txtPassWord_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(76, 172);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 3;
            label1.Text = "Name :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(76, 235);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 4;
            label2.Text = "Pasword :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(177, 68);
            label3.Name = "label3";
            label3.Size = new Size(85, 31);
            label3.TabIndex = 5;
            label3.Text = "Login";
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            lblError.Location = new Point(150, 261);
            lblError.Name = "lblError";
            lblError.Size = new Size(0, 15);
            lblError.TabIndex = 6;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 413);
            Controls.Add(lblError);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPassWord);
            Controls.Add(txtName);
            Controls.Add(Btn_1);
            Name = "frmLogin";
            Text = "Login";
            Load += frmLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        #endregion

        private Button Btn_1;
        private TextBox txtName;
        private TextBox txtPassWord;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblError;
    }
}
