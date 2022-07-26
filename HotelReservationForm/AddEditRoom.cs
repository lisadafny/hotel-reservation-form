﻿using System;
using System.Linq;
using System.Windows.Forms;

namespace HotelReservationForm
{
    public partial class AddEditRoom : Form
    {
        private readonly HotelReservationEntities _hotelReservationEntities;
        private readonly bool _isEditRoom = false;
        private readonly ManageReservations _roomsData;

        public AddEditRoom(ManageReservations roomsData)
        {
            InitializeComponent();
            pageHeader.Text = "Add new room";
            _hotelReservationEntities = new HotelReservationEntities();
            _roomsData = roomsData;
        }

        public AddEditRoom(TypeOfRoom roomEdit, ManageReservations roomsData)
        {
            InitializeComponent();
            pageHeader.Text = "Edit room";
            PopulateFields(roomEdit);
            _hotelReservationEntities = new HotelReservationEntities();
            _isEditRoom = true;
            _roomsData = roomsData;
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
                string warningFieldMsg = MessageMaker.EmptyValidation(tbRoomName.Text, tbPriceRoom.Text);
                string warningPriceMsg = MessageMaker.PriceValidation(tbPriceRoom.Text);
                string successMsg = MessageMaker.SuccessAddEdit(_isEditRoom, tbRoomName.Text);
                bool warningBool = ValidateStatus.HasWarning(warningFieldMsg, warningPriceMsg);
                string messageError = MessageMaker.WarningMessage(warningFieldMsg, warningPriceMsg);
                string title = MessageMaker.TitleMaker(warningBool);

                if (!warningBool)
                {
                    if (_isEditRoom)
                    {
                        var id = int.Parse(idRoomLbl.Text);
                        var room = _hotelReservationEntities.TypeOfRooms.FirstOrDefault(x => x.id == id);
                        room.name = tbRoomName.Text;
                        room.price = decimal.Parse(tbPriceRoom.Text);
                    }
                    else
                    {
                        var newRoom = new TypeOfRoom
                        {
                            name = tbRoomName.Text,
                            price = decimal.Parse(tbPriceRoom.Text)
                        };
                        _hotelReservationEntities.TypeOfRooms.Add(newRoom);
                    }
                    _hotelReservationEntities.SaveChanges();

                    MessageBox.Show(successMsg, title);
                    _roomsData.PopulateGrid();
                    Close();
                }
                else
                {
                    MessageBox.Show(messageError, title);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void CancelChangesClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
