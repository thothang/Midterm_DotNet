using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidTerm_DNet
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            this.FormClosing += Dashboard_FormClosing;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true; 
            }
        }



        private void NavigateToTour()
        {
            this.Hide();
            frmTour tour = new frmTour();
            tour.FormClosed += (s, args) =>
            {
                this.Show();
                tour.Dispose(); 
            };
            tour.ShowDialog();
        }

        private void NavigateToCustomer()
        {
            this.Hide();
            frmCustomer customer = new frmCustomer();
            customer.FormClosed += (s, args) =>
            {
                this.Show();
                customer.Dispose(); 
            };
            customer.ShowDialog();
        }

        private void NavigateToBooking()
        {
            this.Hide();
            frmBooking booking = new frmBooking();
            booking.FormClosed += (s, args) =>
            {
                this.Show();
                booking.Dispose(); 
            };
            booking.ShowDialog();
        }

        private void NavigateToSchedule()
        {
            this.Hide();
            frmSchedule schedule = new frmSchedule();
            schedule.FormClosed += (s, args) =>
            {
                this.Show();
                schedule.Dispose(); 
            };
            schedule.ShowDialog();
        }

        private void NavigateToReport()
        {
            this.Hide();
            frmReport report = new frmReport();
            report.FormClosed += (s, args) =>
            {
                this.Show();
                report.Dispose(); 
            };
            report.ShowDialog();
        }

        private void NavigateToImportExport()
        {
            this.Hide();
            frmImportExport importExport = new frmImportExport();
            importExport.FormClosed += (s, args) =>
            {
                this.Show();
                importExport.Dispose(); 
            };
            importExport.ShowDialog();
        }


        private void btnTour_Click(object sender, EventArgs e)
        {
            NavigateToTour();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            NavigateToCustomer();
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            NavigateToBooking();
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            NavigateToSchedule();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            NavigateToReport();
        }

        private void btnImExport_Click(object sender, EventArgs e)
        {
            NavigateToImportExport();
        }
    }
}
