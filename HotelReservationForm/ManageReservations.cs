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
                .Select(x => new { id = x.id, Name = x.name, Price = x.price})
                .ToList();
            gvHotelReservations.DataSource = rooms;
            gvHotelReservations.Columns[0].Visible = false;
            gvHotelReservations.Columns[1].HeaderText = "NAME OF ROOM";
            gvHotelReservations.Columns[2].HeaderText = "DAILY COST";
        }

        private void btnAddRoomClick(object sender, EventArgs e)
        {
            var addRoom = new AddEditRoom();
            addRoom.MdiParent = this.MdiParent;
            addRoom.Show();
        }

        private void btnEditRoomClick(object sender, EventArgs e)
        {
            var id = (int)gvHotelReservations.SelectedRows[0].Cells["id"].Value;
            var selectedRoom = _hotelReservationEntities.TypeOfRooms.FirstOrDefault(x => x.id == id);
            var editRoom = new AddEditRoom(selectedRoom);
            editRoom.MdiParent = this.MdiParent;
            editRoom.Show();
        }

        private void btnDeleteRoomClick(object sender, EventArgs e)
        {
            var id = (int)gvHotelReservations.SelectedRows[0].Cells["id"].Value;
            var selectedRoom = _hotelReservationEntities.TypeOfRooms.FirstOrDefault(x => x.id == id);
            _hotelReservationEntities.TypeOfRooms.Remove(selectedRoom);
            _hotelReservationEntities.SaveChanges();
            gvHotelReservations.Refresh();
        }
    }
}
