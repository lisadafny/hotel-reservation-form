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
    public partial class ManageReservations : Form
    {
        private readonly HotelReservationEntities _hotelReservationEntities;
        public ManageReservations()
        {
            InitializeComponent();
            _hotelReservationEntities = new HotelReservationEntities();
        }

        private void ManageReservationsOnLoad(object sender, EventArgs e)
        {
            var rooms = _hotelReservationEntities.TypeOfRooms
                .Select(x => new { ID = x.id, Name = x.name })
                .ToList();
            gvHotelReservations.DataSource = rooms;
            gvHotelReservations.Columns[0].HeaderText = "ID";
            gvHotelReservations.Columns[1].HeaderText = "NAME";
        }

        private void btnAddRoomClick(object sender, EventArgs e)
        {

        }

        private void btnEditRoomClick(object sender, EventArgs e)
        {

        }

        private void btnDeleteRoomClick(object sender, EventArgs e)
        {

        }
    }
}
