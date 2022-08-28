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
    public partial class UserResetPassword : Form
    {
        private readonly HotelReservationEntities _hotelReservationEntities;
        private readonly Login _credentials;
        public UserResetPassword(Login login)
        {
            InitializeComponent();
            _hotelReservationEntities = new HotelReservationEntities();
            _credentials = login;
        }

        private void BtnConfirmClick(object sender, EventArgs e)
        {
            try
            {
                string password = passwordEntryOne.Text;
                string confirmPassword = passwordEntryTwo.Text;

                if (password == confirmPassword)
                {
                    _credentials.password = Cryptography.EncryptPassword(password);
                    _hotelReservationEntities.SaveChanges();
                }
                else
                {
                    MessageMaker.PasswordConfirmationError();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
