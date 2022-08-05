using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelReservationForm
{
    public class MessageMakerClass
    {
        
        public static string EmptyValidation(string fieldOne, string fieldTwo)
        {
            if (string.IsNullOrEmpty(fieldOne) || string.IsNullOrEmpty(fieldTwo))
            {
               return "Please don't leave any field empty!";
            } else { return string.Empty; }
        }

        public static string DateValidation(DateTime start, DateTime end)
        {
            if(start >= end)
            {
                return "Your final date must be higher than your initial date";
            } else { return string.Empty;}
        }

        public static bool HasWarning(string validationOne, string validationTwo)
        {
            if(validationOne != string.Empty || validationTwo != string.Empty)
            {
                return true;
            } else { return false;}
        }

        public static string WarningMessage(string warningTypeOne, string warningTypeTwo)
        {
            return $"{warningTypeOne}\n\r" +
                        $"{warningTypeTwo}";
        }
        public static string SucessMessage(string fieldOne, string fieldTwo, DateTime start, DateTime end)
        {
            return $"Thank you {fieldOne}!\n\r" +
                    $"Your reservation was requested\n\r" +
                    $"You choose the {fieldTwo}\n\r" +
                    $"at {start} until {end}!";
        }
    }
}
