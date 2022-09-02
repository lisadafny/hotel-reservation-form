using System;
using System.Linq;
using System.Windows.Forms;

namespace HotelReservationForm
{
    public partial class CustomerReservation : Form
    {
        private readonly HotelReservationEntities _hotelReservationEntities;
        public CustomerReservation()
        {
            InitializeComponent();
            _hotelReservationEntities = new HotelReservationEntities();
        }

        private void BtnSubmitClick(object sender, EventArgs e)
        {

            string customerName = tbCustomer.Text;
            string room = typeRoom.Text;
            DateTime dateIn = dtInitial.Value.Date;
            DateTime dateOut = dtFinal.Value.Date;


            try
            {
                string warningFieldMsg = customerName.EmptyValidation(room);
                string warningDateMsg = dateIn.DateValidation(dateOut);
                bool warningBool = ValidateStatus.HasWarning(warningFieldMsg, warningDateMsg);
                string messageError = warningFieldMsg.WarningMessage(warningDateMsg);
                string messageSucess = customerName.SuccessReservationMessage(room, dateIn, dateOut);
                string title = warningBool.TitleMaker();

                if (warningBool)
                {
                   MessageBox.Show(messageError, title);
                }
                else
                {
                    CustomerDetail reservationRecord = new CustomerDetail
                    {
                        CustomerName = customerName,
                        ReservStart = dateIn,
                        ReservEnd = dateOut,
                        TypeOfRoom = (int)typeRoom.SelectedValue
                    };

                    _hotelReservationEntities.CustomerDetails.Add(reservationRecord);
                    _hotelReservationEntities.SaveChanges();

                    messageSucess.MessageBoxMaker(title);
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void CustomerReservationLoad(object sender, EventArgs e)
        {
            var room = _hotelReservationEntities.TypeOfRooms.ToList();
            typeRoom.DisplayMember = "Name";
            typeRoom.ValueMember = "Id";
            typeRoom.DataSource = room;
        }
    }
}
