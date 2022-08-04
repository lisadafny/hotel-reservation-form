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

        private void btnSubmitClick(object sender, EventArgs e)
        {
            try
            {
                string customerName = tbCustomer.Text;
                string room = typeRoom.Text;
                DateTime dateIn = dtInitial.Value.Date;
                DateTime dateOut = dtFinal.Value.Date;
                bool warning = false;
                string warningFieldMsg = string.Empty;
                string warningDateMsg = string.Empty;

                if (string.IsNullOrEmpty(customerName) || string.IsNullOrEmpty(room))
                {
                    warning = true;
                    warningFieldMsg = "Please don't leave any field empty!";
                }
                if (dateOut < dateIn)
                {
                    warning = true;
                    warningDateMsg = "Your final date must be higher than your initial date";
                }
                if (warning)
                {
                    MessageBox.Show($"{warningFieldMsg}\n\r" +
                        $"{warningDateMsg}", "WARNING");
                }
                if (!warning)
                {
                    MessageBox.Show($"Thank you {customerName}!\n\r" +
                    $"Your reservation was requested\n\r" +
                    $"You choose the {room}\n\r" +
                    $"at {dateIn} until {dateOut}!", "SUCCESS");
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
            var kind = _hotelReservationEntities.TypeOfRooms;
            var room = _hotelReservationEntities.TypeOfRooms.ToList();
            typeRoom.DisplayMember = "Name";
            typeRoom.ValueMember = "Id";
            typeRoom.DataSource = room;
        }
    }
}
