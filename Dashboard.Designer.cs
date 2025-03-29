namespace MidTerm_DNet
{
    partial class Dashboard
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
            btnTour = new Button();
            btnCustomer = new Button();
            btnBooking = new Button();
            btnSchedule = new Button();
            btnReport = new Button();
            btnImExport = new Button();
            SuspendLayout();
            // 
            // btnTour
            // 
            btnTour.Location = new Point(384, 50);
            btnTour.Name = "btnTour";
            btnTour.Size = new Size(142, 23);
            btnTour.TabIndex = 0;
            btnTour.Text = "Quản lý tour";
            btnTour.UseVisualStyleBackColor = true;
            btnTour.Click += btnTour_Click;
            // 
            // btnCustomer
            // 
            btnCustomer.Location = new Point(384, 120);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(142, 23);
            btnCustomer.TabIndex = 1;
            btnCustomer.Text = "Quản lý khách hàng";
            btnCustomer.UseVisualStyleBackColor = true;
            btnCustomer.Click += btnCustomer_Click;
            // 
            // btnBooking
            // 
            btnBooking.Location = new Point(384, 188);
            btnBooking.Name = "btnBooking";
            btnBooking.Size = new Size(142, 23);
            btnBooking.TabIndex = 2;
            btnBooking.Text = "Quản lý đơn đặt tour";
            btnBooking.UseVisualStyleBackColor = true;
            btnBooking.Click += btnBooking_Click;
            // 
            // btnSchedule
            // 
            btnSchedule.Location = new Point(384, 258);
            btnSchedule.Name = "btnSchedule";
            btnSchedule.Size = new Size(142, 23);
            btnSchedule.TabIndex = 3;
            btnSchedule.Text = "Quản lý lịch trình";
            btnSchedule.UseVisualStyleBackColor = true;
            btnSchedule.Click += btnSchedule_Click;
            // 
            // btnReport
            // 
            btnReport.Location = new Point(384, 333);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(142, 23);
            btnReport.TabIndex = 4;
            btnReport.Text = "Báo cáo thống kê";
            btnReport.UseVisualStyleBackColor = true;
            btnReport.Click += btnReport_Click;
            // 
            // btnImExport
            // 
            btnImExport.Location = new Point(384, 404);
            btnImExport.Name = "btnImExport";
            btnImExport.Size = new Size(142, 23);
            btnImExport.TabIndex = 5;
            btnImExport.Text = "xuất nhập dữ liệu";
            btnImExport.UseVisualStyleBackColor = true;
            btnImExport.Click += btnImExport_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(954, 516);
            Controls.Add(btnImExport);
            Controls.Add(btnReport);
            Controls.Add(btnSchedule);
            Controls.Add(btnBooking);
            Controls.Add(btnCustomer);
            Controls.Add(btnTour);
            Name = "Dashboard";
            Text = "Dashboard";
            Load += Dashboard_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnTour;
        private Button btnCustomer;
        private Button btnBooking;
        private Button btnSchedule;
        private Button btnReport;
        private Button btnImExport;
    }
}