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
                string warningFieldMsg = MessageMaker.EmptyValidation(customerName, room);
                string warningDateMsg = MessageMaker.DateValidation(dateIn, dateOut);
                bool warningBool = ValidateStatus.HasWarning(warningFieldMsg, warningDateMsg);
                string messageError = MessageMaker.WarningMessage(warningFieldMsg, warningDateMsg);
                string messageSucess = MessageMaker.SuccessReservationMessage(customerName, room, dateIn, dateOut);
                string title = MessageMaker.TitleMaker(warningBool);

                if (warningBool)
                {
                   MessageBox.Show(messageError, title);
                }
                else
                {
                    var reservationRecord = new CustomerDetail
                    {
                        CustomerName = customerName,
                        ReservStart = dateIn,
                        ReservEnd = dateOut,
                        TypeOfRoom = (int)typeRoom.SelectedValue
                    };

                    _hotelReservationEntities.CustomerDetails.Add(reservationRecord);
                    _hotelReservationEntities.SaveChanges();

                    MessageBox.Show(messageSucess, title);
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
