using System;
using System.Linq;
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
                string warningFieldMsg = customerName.EmptyValidation(room);
                string warningDateMsg = dateIn.DateValidation(dateOut);
                string warningPriceMsg = tbPrice.Text.PriceValidation();
                bool warningBool = ValidateStatus.HasWarning(warningFieldMsg, warningDateMsg, warningPriceMsg);
                string messageError = warningFieldMsg.WarningMessage(warningDateMsg, warningPriceMsg);
                string messageSucess = _isEditRecord.SuccessAddEdit();
                string title = warningBool.TitleMaker();


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

                    messageSucess.MessageBoxMaker(title);
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
