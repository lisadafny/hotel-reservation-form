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
    public partial class AddEditRoom : Form
    {
        private readonly HotelReservationEntities _hotelReservationEntities;
        private bool _isEditRoom = false;
        public AddEditRoom()
        {
            InitializeComponent();
            pageHeader.Text = "Add new room";
            _hotelReservationEntities = new HotelReservationEntities();
        }

        public AddEditRoom(TypeOfRoom roomEdit)
        {
            InitializeComponent();
            pageHeader.Text = "Edit room";
            PopulateFields(roomEdit);
            _hotelReservationEntities = new HotelReservationEntities();
            _isEditRoom = true;
        }

        private void PopulateFields(TypeOfRoom room)
        {
            var idRoom = room.id.ToString();
            idRoomLbl.Text = idRoom;
            tbRoomName.Text = room.name;
            tbPriceRoom.Text = room.price.ToString();

        }

        private void saveChangesClick(object sender, EventArgs e)
        {
            try
            {
                if (_isEditRoom)
                {
                    var id = int.Parse(idRoomLbl.Text);
                    var room = _hotelReservationEntities.TypeOfRooms.FirstOrDefault(x => x.id == id);
                    room.name = tbRoomName.Text;
                    room.price = decimal.Parse(tbPriceRoom.Text);
                    _hotelReservationEntities.SaveChanges();

                }
                else
                {
                    var newRoom = new TypeOfRoom
                    {
                        name = tbRoomName.Text,
                        price = decimal.Parse(tbPriceRoom.Text)
                    };
                    _hotelReservationEntities.TypeOfRooms.Add(newRoom);
                    _hotelReservationEntities.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cancelChangesClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
