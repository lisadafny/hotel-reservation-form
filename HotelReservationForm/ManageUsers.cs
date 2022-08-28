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

    public partial class ManageUsers : Form
    {
        private readonly HotelReservationEntities _hotelReservationEntities;
        public ManageUsers()
        {
            InitializeComponent();
            _hotelReservationEntities = new HotelReservationEntities();
        }

        private void BtnAddUserClick(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateStatus.FormIsOpen("AddUser"))
                {
                    AddUser addUser = new AddUser(this)
                    {
                        MdiParent = this
                    };
                }
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnResetPasswordClick(object sender, EventArgs e)
        {
            try
            {
                if (ValidateStatus.ZeroSelectedRows(gvUserLogin))
                {
                    MessageBox.Show("Select a row!");
                }
                else
                {
                    DialogResult result = MessageBox.Show("Reset user password?",
                    "ALERT", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        int id = (int)gvUserLogin.SelectedRows[0].Cells["id"].Value;
                        var selectedUser = _hotelReservationEntities.Logins.FirstOrDefault(x => x.id == id);
                        string newPassword = "password";
                        string hashNewPassword = Cryptography.EncryptPassword(newPassword);
                        selectedUser.password = hashNewPassword;
                        _hotelReservationEntities.SaveChanges();
                        MessageBox.Show($"{selectedUser.username}, password reset was sucessful, use {newPassword} to log in!");
                        PopulateGrid();
                    }
                    else
                    {
                        MessageBox.Show("Operation cancelled");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnDisableUserClick(object sender, EventArgs e)
        {
            try
            {
                if (ValidateStatus.ZeroSelectedRows(gvUserLogin))
                {
                    MessageBox.Show("Select a row!");
                }
                else
                {
                    DialogResult result = MessageBox.Show("Disable user?",
            "ALERT", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        int id = (int)gvUserLogin.SelectedRows[0].Cells["id"].Value;
                        var selectedUser = _hotelReservationEntities.Logins.FirstOrDefault(x => x.id == id);
                        selectedUser.active = selectedUser.active != true;
                        string userStatus = selectedUser.active == true ? "enabled" : "disabled";
                        _hotelReservationEntities.SaveChanges();
                        MessageBox.Show($"{selectedUser.username} is now {userStatus}");
                        PopulateGrid();
                    }
                    else
                    {
                        MessageBox.Show("Operation cancelled");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnRefreshClick(object sender, EventArgs e)
        {
            PopulateGrid();
        }

        public void PopulateGrid()
        {
            var users = _hotelReservationEntities.Logins.Select(x => new
            {
                ID = x.id,
                Username = x.username,
                Role = x.UserRoles.FirstOrDefault().Role.name,
                x.active,
            }).ToList();
            gvUserLogin.DataSource = users;
            gvUserLogin.Columns["active"].HeaderText = "Is Active?";
        }

        private void ManageUsersOnLoad(object sender, EventArgs e)
        {
            PopulateGrid();
        }
    }
}
