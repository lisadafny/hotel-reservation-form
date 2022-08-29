using System.Linq;
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

        public static bool FormIsOpen(string name)
        {
            var OpenForms = Application.OpenForms.Cast<Form>();
            bool isOpen = OpenForms.Any(x => x.Name == name);
            return isOpen;
        }
    }
}
