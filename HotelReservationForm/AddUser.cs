using System;
using System.Linq;
using System.Windows.Forms;

namespace HotelReservationForm
{
    public partial class AddUser : Form
    {
        private readonly HotelReservationEntities _hotelReservationEntities;
        private readonly ManageUsers _userGrid;
        public AddUser(ManageUsers usersGrid)
        {
             InitializeComponent();
            _hotelReservationEntities = new HotelReservationEntities();
            _userGrid = usersGrid;
        }

        private void AddUserOnLoad(object sender, EventArgs e)
        {
            var roles = _hotelReservationEntities.Roles.ToList();
            cbUserRoles.DataSource = roles;
            cbUserRoles.ValueMember = "id";
            cbUserRoles.DisplayMember = "name";
        }

        private void SaveChangesClick(object sender, EventArgs e)
        {
            try
            {
                var username = tbUserName.Text;
                var roleId = (int)cbUserRoles.SelectedValue;
                var password = Cryptography.DefaultPassword();
                Login user = new Login
                {
                    username = username,
                    password = password,
                    active = true
                };
                _hotelReservationEntities.Logins.Add(user);
                _hotelReservationEntities.SaveChanges();

                int id = user.id;

                UserRole userRole = new UserRole
                {
                    roleID = roleId,
                    userID = id
                };
                _hotelReservationEntities.UserRoles.Add(userRole);
                _hotelReservationEntities.SaveChanges();
                _userGrid.PopulateGrid();
                MessageBox.Show("New user added!");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CancelChangesClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
