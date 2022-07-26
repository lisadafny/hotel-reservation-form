﻿using System;
using System.Data;
using System.Linq;
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
            if (!ValidateStatus.FormIsOpen("AddEditRecord"))
            {
                AddEditRecord addRecord = new AddEditRecord(this)
                {
                    MdiParent = this.MdiParent
                };
                addRecord.Show();
            }
            return;
        }

        private void BtnEditRecordClick(object sender, EventArgs e)
        {
            try
            {
                bool noRowsSelected = ValidateStatus.ZeroSelectedRows(gvHotelRecord);

                if (noRowsSelected)
                {
                    MessageBox.Show("Select a row!");
                }
                else
                {
                    if (!ValidateStatus.FormIsOpen("AddEditRecord"))
                    {
                        int id = (int)gvHotelRecord.SelectedRows[0].Cells["id"].Value;
                        CustomerDetail selectedRecord = _hotelReservationEntities.CustomerDetails.FirstOrDefault(x => x.id == id);
                        AddEditRecord editRecord = new AddEditRecord(selectedRecord, this)
                        {
                            MdiParent = this.MdiParent
                        };
                        editRecord.Show();
                    }
                    return;
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
                bool noRowsSelected = ValidateStatus.ZeroSelectedRows(gvHotelRecord);

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
                        int id = (int)gvHotelRecord.SelectedRows[0].Cells["id"].Value;
                        CustomerDetail selectedRecord = _hotelReservationEntities.CustomerDetails.FirstOrDefault(x => x.id == id);
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

        public void GetRecords()
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
