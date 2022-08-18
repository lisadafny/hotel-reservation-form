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

        public void PopulateGrid()
        {
            var rooms = _hotelReservationEntities.TypeOfRooms
            .Select(x => new { id = x.id, Name = x.name, Price = x.price })
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
                var addRoom = new AddEditRoom();
                addRoom.MdiParent = this.MdiParent;
                addRoom.Show();
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
                bool noRowsSelected = ValidateStatus.ZeroSelectedRows(gvHotelReservations);

                if (noRowsSelected)
                {
                    MessageBox.Show("Select a row!");
                }
                else
                {
                    var id = (int)gvHotelReservations.SelectedRows[0].Cells["id"].Value;
                    var selectedRoom = _hotelReservationEntities.TypeOfRooms.FirstOrDefault(x => x.id == id);
                    var editRoom = new AddEditRoom(selectedRoom);
                    editRoom.MdiParent = this.MdiParent;
                    editRoom.Show();
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
                bool noRowsSelected = ValidateStatus.ZeroSelectedRows(gvHotelReservations);

                if (noRowsSelected)
                {
                    MessageBox.Show("Select a row!");
                }
                else
                {
                    DialogResult result = MessageBox.Show("Do you really want to delete this room?",
                    "ALERT", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        var id = (int)gvHotelReservations.SelectedRows[0].Cells["id"].Value;
                        var selectedRoom = _hotelReservationEntities.TypeOfRooms.FirstOrDefault(x => x.id == id);
                        _hotelReservationEntities.TypeOfRooms.Remove(selectedRoom);
                        _hotelReservationEntities.SaveChanges();
                        gvHotelReservations.Refresh();
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
