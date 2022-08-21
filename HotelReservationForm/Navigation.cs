using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelReservationForm
{
    public partial class Navigation : Form
    {
        private UserLogin _userLogin;
        public Navigation(UserLogin login)
        {
            InitializeComponent();
            _userLogin = login;
        }

        private void MakeAReservationClick(object sender, EventArgs e)
        {
            var OpenForms = Application.OpenForms.Cast<Form>();
            bool isOpen = OpenForms.Any(x => x.Name == "CustomerReservation");
            if (!isOpen) { 
            var customerReservation = new CustomerReservation
            {
                MdiParent = this
            };
            customerReservation.Show();
            }
            return;
        }

        private void ManageReservationsClick(object sender, EventArgs e)
        {
            var OpenForms = Application.OpenForms.Cast<Form>();
            bool isOpen = OpenForms.Any(x => x.Name == "ManageReservations");
            if (!isOpen)
            {
                ManageReservations roomListing = new ManageReservations
                {
                    MdiParent = this
                };
                roomListing.Show();
            }
            return;
        }

        private void ViewArchiveClick(object sender, EventArgs e)
        {
            var OpenForms = Application.OpenForms.Cast<Form>();
            bool isOpen = OpenForms.Any(x => x.Name == "ManageRecords");
            if (!isOpen)
            {
                ManageRecords viewArchive = new ManageRecords
            {
                MdiParent = this
            };
            viewArchive.Show();
            }
            return;
        }

        private void BugReportClick(object sender, EventArgs e)
        {
            MessageMaker.LazyExcuse();
        }

        private void NavigationClosing(object sender, FormClosingEventArgs e)
        {
            _userLogin.Close();
        }
    }
}
