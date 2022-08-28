using System;
using System.Linq;
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
                Login userLogin = _hotelReservationEntities.Logins.FirstOrDefault(x => x.id == _credentials.id);
                if (password != "password")
                {
                    if (password == confirmPassword)
                    {
                        userLogin.password = Cryptography.EncryptPassword(password);
                        _hotelReservationEntities.SaveChanges();
                        MessageBox.Show("Password changed!");
                        Close();
                    }
                    else
                    {
                        MessageMaker.PasswordConfirmationError();
                    }
                }
                else
                {
                    MessageMaker.OldPasswordError();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
