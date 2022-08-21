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
    public partial class UserLogin : Form
    {
        private readonly HotelReservationEntities _hotelReservationEntities;
        public UserLogin()
        {
            InitializeComponent();
            _hotelReservationEntities = new HotelReservationEntities();
        }

        private void BtnLoginClick(object sender, EventArgs e)
        {
            try
            {
                string username = tbUsername.Text.ToLower();
                string password = tbPassword.Text.ToLower();

                var user = _hotelReservationEntities.Logins.FirstOrDefault(x => x.username == username && x.password == password);
                if(user != null)
                {
                    Navigation navigation = new Navigation(this);
                    navigation.Show();
                    Hide();
                }
                else
                {
                    MessageMaker.InvalidCredentials();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageMaker.ErrorMessage();
            }
        }
    }
}
