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
        public Navigation()
        {
            InitializeComponent();
        }

        private void makeAReservationClick(object sender, EventArgs e)
        {
            var customerReservation = new CustomerReservation();
            customerReservation.MdiParent = this;
            customerReservation.Show();
        }

        private void manageReservationsClick(object sender, EventArgs e)
        {
            var dbListing = new ManageReservations();
            dbListing.MdiParent = this;
            dbListing.Show();
        }
    }
}
