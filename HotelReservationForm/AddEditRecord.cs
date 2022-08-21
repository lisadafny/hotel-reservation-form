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
    public partial class AddEditRecord : Form
    {
        private readonly HotelReservationEntities _hotelReservationEntities;
        private readonly bool _isEditRecord = false;
        private readonly ManageRecords _recordsData;
        public AddEditRecord(ManageRecords records)
        {
            InitializeComponent();
            _hotelReservationEntities = new HotelReservationEntities();
            _recordsData = records;
        }
        public AddEditRecord(CustomerDetail recordEdit, ManageRecords records)
        {
            InitializeComponent();
            _hotelReservationEntities = new HotelReservationEntities();
            titleAddEdit.Text = "EDIT";
            this.Text = "Edit Record Info";
            PopulateFields(recordEdit);
            _isEditRecord = true;
            _recordsData = records; 
        }

        private void PopulateFields(CustomerDetail record)
        {
            var idReservation = record.id.ToString();
            tbId.Text = idReservation;
            tbName.Text = record.CustomerName;
            dtInitial.Value = record.ReservStart;
            dtFinal.Value = record.ReservEnd;
            typeRoom.SelectedValue = record.TypeOfRoomInfo.id;
            typeRoom.SelectedText = record.TypeOfRoomInfo.name;
            tbPrice.Text = record.Price.ToString();
        }


        private void SaveChangesClick(object sender, EventArgs e)
        {
            string customerName = tbName.Text;
            string room = typeRoom.Text;
            DateTime dateIn = dtInitial.Value.Date;
            DateTime dateOut = dtFinal.Value.Date;

            try
            {
                string warningFieldMsg = MessageMaker.EmptyValidation(customerName, room);
                string warningDateMsg = MessageMaker.DateValidation(dateIn, dateOut);
                string warningPriceMsg = MessageMaker.PriceValidation(tbPrice.Text);
                bool warningBool = ValidateStatus.HasWarning(warningFieldMsg, warningDateMsg, warningPriceMsg);
                string messageError = MessageMaker.WarningMessage(warningFieldMsg, warningDateMsg, warningPriceMsg);
                string messageSucess = MessageMaker.SuccessAddEdit(_isEditRecord);
                string title = MessageMaker.TitleMaker(warningBool);


                if (warningBool)
                {
                    MessageBox.Show(messageError, title);
                }
                else
                {
                    if (_isEditRecord)
                    {
                        var id = int.Parse(tbId.Text);
                        var record = _hotelReservationEntities.CustomerDetails.FirstOrDefault(x => x.id == id);
                        record.CustomerName = customerName;
                        record.ReservStart = dateIn;
                        record.ReservEnd = dateOut;
                        record.TypeOfRoom = (int)typeRoom.SelectedValue;
                        record.Price = decimal.Parse(tbPrice.Text);
                    }
                    else
                    {
                        var reservationRecord = new CustomerDetail
                        {
                            CustomerName = customerName,
                            ReservStart = dateIn,
                            ReservEnd = dateOut,
                            TypeOfRoom = (int)typeRoom.SelectedValue,
                            Price = decimal.Parse(tbPrice.Text)
                        };
                        _hotelReservationEntities.CustomerDetails.Add(reservationRecord);
                    }
                    _hotelReservationEntities.SaveChanges();

                    MessageBox.Show(messageSucess, title);
                    _recordsData.GetRecords();
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void CancelChangesClick(object sender, EventArgs e)
        {
            Close();
        }

        private void AddEditRecordOnLoad(object sender, EventArgs e)
        {
            var room = _hotelReservationEntities.TypeOfRooms.ToList();
            typeRoom.DisplayMember = "Name";
            typeRoom.ValueMember = "Id";
            typeRoom.DataSource = room;
        }
    }
}
