﻿using System;
using System.Data;
using System.Linq;
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

        public void PopulateGrid()
        {
            var rooms = _hotelReservationEntities.TypeOfRooms
            .Select(x => new {x.id, Name = x.name, Price = x.price })
            .ToList();
            gvHotelReservations.DataSource = rooms;
            gvHotelReservations.Columns[0].Visible = false;
            gvHotelReservations.Columns[1].HeaderText = "NAME OF ROOM";
            gvHotelReservations.Columns[2].HeaderText = "DAILY COST";
        }

        private void ManageReservationsOnLoad(object sender, EventArgs e)
        {
            try
            {
                PopulateGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RefreshBtnClick(object sender, EventArgs e)
        {
            try
            {
                PopulateGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnAddRoomClick(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateStatus.FormIsOpen("AddEditRoom"))
                {
                    AddEditRoom addRoom = new AddEditRoom(this)
                    {
                        MdiParent = this.MdiParent
                    };
                    addRoom.Show();
                }
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnEditRoomClick(object sender, EventArgs e)
        {
            try
            {
                if (ValidateStatus.ZeroSelectedRows(gvHotelReservations))
                {
                    MessageBox.Show("Select a row!");
                }
                else
                {
                    if (!ValidateStatus.FormIsOpen("AddEditRoom"))
                    {
                        int id = (int)gvHotelReservations.SelectedRows[0].Cells["id"].Value;
                        TypeOfRoom selectedRoom = _hotelReservationEntities.TypeOfRooms.FirstOrDefault(x => x.id == id);
                        AddEditRoom editRoom = new AddEditRoom(selectedRoom, this)
                        {
                            MdiParent = this.MdiParent
                        };
                        editRoom.Show();
                    }
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnDeleteRoomClick(object sender, EventArgs e)
        {
            try
            {
                if (ValidateStatus.ZeroSelectedRows(gvHotelReservations))
                {
                    MessageBox.Show("Select a row!");
                }
                else
                {
                    DialogResult result = MessageBox.Show("Do you really want to delete this room?",
                    "ALERT", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        int id = (int)gvHotelReservations.SelectedRows[0].Cells["id"].Value;
                        TypeOfRoom selectedRoom = _hotelReservationEntities.TypeOfRooms.FirstOrDefault(x => x.id == id);
                        _hotelReservationEntities.TypeOfRooms.Remove(selectedRoom);
                        _hotelReservationEntities.SaveChanges();
                        PopulateGrid();
                        MessageBox.Show($"Removed Room ID {id} with success!");
                    }
                    else
                    {
                        MessageBox.Show("Operation cancelled");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
