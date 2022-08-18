using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelReservationForm
{
    public class ValidateStatus
    {
        public static bool HasWarning(string validationOne, string validationTwo = "", string validationThree = "")
        {
            if (validationOne != string.Empty || validationTwo != string.Empty || validationThree != string.Empty)
            {
                return true;
            }
            return false;
        }

        public static bool ZeroSelectedRows(DataGridView grid)
        {
            if (grid.SelectedRows.Count.Equals(0))
            {
                return true;
            }
            return false;
        }
    }
}
