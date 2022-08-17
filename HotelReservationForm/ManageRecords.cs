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
    public partial class ManageRecords : Form
    {
        private readonly HotelReservationEntities _hotelReservationEntities;
        public ManageRecords()
        {
            InitializeComponent();
            _hotelReservationEntities = new HotelReservationEntities();
        }

        private void BtnAddRecordClick(object sender, EventArgs e)
        {
            MessageMaker.LazyExcuse();
        }

        private void BtnEditRecordClick(object sender, EventArgs e)
        {
            try
            {
                if (!gvHotelRecord.SelectedRows.Count.Equals(0))
                {
                    //var id = (int)gvHotelRecord.SelectedRows[0].Cells["id"].Value;
                    //var selectedRecord = _hotelReservationEntities.CustomerDetails.FirstOrDefault(x => x.id == id);
                    //var editRoom = new AddEditRoom(selectedRoom);
                    //editRoom.MdiParent = this.MdiParent;
                    //editRoom.Show();
                    MessageMaker.LazyExcuse();
                }
                else
                {
                    MessageBox.Show("Select a row!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnDeleteRecordClick(object sender, EventArgs e)
        {
            try
            {

                if (!gvHotelRecord.SelectedRows.Count.Equals(0))
                {
                    DialogResult result = MessageBox.Show("Do you really want to delete this room?",
                    "ALERT", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        var id = (int)gvHotelRecord.SelectedRows[0].Cells["id"].Value;
                        var selectedRecord = _hotelReservationEntities.CustomerDetails.FirstOrDefault(x => x.id == id);
                        _hotelReservationEntities.CustomerDetails.Remove(selectedRecord);
                        _hotelReservationEntities.SaveChanges();
                        GetRecords();
                        MessageBox.Show($"Removed Room ID {id} with success!");
                    }
                    else
                    {
                        MessageBox.Show("Operation cancelled");
                    }
                }
                else
                {
                    MessageBox.Show("Select a row!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnRefreshClick(object sender, EventArgs e)
        {
            try
            {
                GetRecords();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ManageRecordsOnLoad(object sender, EventArgs e)
        {
            try
            {
                GetRecords();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GetRecords()
        {
            var records = _hotelReservationEntities.CustomerDetails.Select(x => new
            {
                Customer = x.CustomerName,
                DateStart = x.ReservStart,
                DateEnd = x.ReservEnd,
                Id = x.id,
                Cost = x.Price,
                Room = x.TypeOfRoomInfo.name
            }).ToList();
            gvHotelRecord.DataSource = records;
            gvHotelRecord.Columns["Id"].Visible = false;
            gvHotelRecord.Columns["DateStart"].HeaderText = "Reservation Start";
            gvHotelRecord.Columns["DateEnd"].HeaderText = "Reservation End";
        }
    }
}
