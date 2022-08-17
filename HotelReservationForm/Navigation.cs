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

        private void MakeAReservationClick(object sender, EventArgs e)
        {
            var customerReservation = new CustomerReservation
            {
                MdiParent = this
            };
            customerReservation.Show();
        }

        private void ManageReservationsClick(object sender, EventArgs e)
        {
            var roomListing = new ManageReservations
            {
                MdiParent = this
            };
            roomListing.Show();
        }

        private void ViewArchiveClick(object sender, EventArgs e)
        {
            var viewArchive = new ManageRecords
            {
                MdiParent = this
            };
            viewArchive.Show();
        }

        private void bugReportClick(object sender, EventArgs e)
        {
            MessageMaker.LazyExcuse();
        }
    }
}
