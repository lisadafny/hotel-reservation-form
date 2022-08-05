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
    
    public partial class Form1 : Form
    {
        private readonly HotelReservationEntities _hotelReservationEntities;
        public Form1()
        {
            InitializeComponent();
            _hotelReservationEntities = new HotelReservationEntities();
        }

        bool warningBool = false;
        string warningFieldMsg = string.Empty;
        string warningDateMsg = string.Empty;
        string messageError = string.Empty;
        string messageSucess = string.Empty;

        private void BtnSubmitClick(object sender, EventArgs e)
        {

            string customerName = tbCustomer.Text;
            string room = typeRoom.Text;
            DateTime dateIn = dtInitial.Value.Date;
            DateTime dateOut = dtFinal.Value.Date;


            try
            {
                warningFieldMsg = MessageMakerClass.EmptyValidation(customerName, room);
                warningDateMsg = MessageMakerClass.DateValidation(dateIn, dateOut);
                warningBool = MessageMakerClass.HasWarning(warningFieldMsg, warningDateMsg);
                messageError = MessageMakerClass.WarningMessage(warningFieldMsg, warningDateMsg);
                messageSucess = MessageMakerClass.SucessMessage(customerName, room, dateIn, dateOut);

                if (warningBool)
                {
                   MessageBox.Show(messageError, "WARNING");
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

                    MessageBox.Show(messageSucess, "SUCCESS");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var room = _hotelReservationEntities.TypeOfRooms.ToList();
            typeRoom.DisplayMember = "Name";
            typeRoom.ValueMember = "Id";
            typeRoom.DataSource = room;
        }
    }
}
