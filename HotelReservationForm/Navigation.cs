using System;
using System.Linq;
using System.Windows.Forms;

namespace HotelReservationForm
{
    public partial class Navigation : Form
    {
        private readonly UserLogin _userLogin;
        public Login credentials;
        public string roleName;
        public Navigation(UserLogin login, Login user)
        {
            InitializeComponent();
            _userLogin = login;
            credentials = user;
            roleName = credentials.UserRoles.FirstOrDefault().Role.name;
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

        private void NavigationOnLoad(object sender, EventArgs e)
        {
            if(roleName != "Admin")
            {
                adminMenu.Enabled = false;
            }
            else
            {
                adminMenu.Enabled = true;
            }
            tsLoginText.Text = $"Logged in as: {credentials.username.ToUpperInvariant()}";
        }
    }
}
