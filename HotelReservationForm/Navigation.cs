using System;
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
            if (!ValidateStatus.FormIsOpen("CustomerReservation"))
            {
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
            if (!ValidateStatus.FormIsOpen("ManageReservations"))
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
            if (!ValidateStatus.FormIsOpen("ManageRecords"))
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

        private void ManageUsersClick(object sender, EventArgs e)
        {
            if (!ValidateStatus.FormIsOpen("ManageUsers"))
            {
                ManageUsers manageUsers = new ManageUsers
                {
                    MdiParent = this
                };
                manageUsers.Show();
            }
            return;
        }
    }
}
