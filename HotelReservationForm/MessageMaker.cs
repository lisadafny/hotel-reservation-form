using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelReservationForm
{
    public class MessageMaker
    {
        
        public static string EmptyValidation(string fieldOne, string fieldTwo)
        {
            if (string.IsNullOrEmpty(fieldOne) || string.IsNullOrEmpty(fieldTwo))
            {
               return "Please don't leave any field empty!";
            } 
            return string.Empty;
        }

        public static string DateValidation(DateTime start, DateTime end)
        {
            if(start >= end)
            {
                return "Your final date must be higher than your initial date";
            }
            return string.Empty;
        }

        public static string PriceValidation(string price)
        {
            var priceValue = decimal.TryParse(price, out decimal priceDecimal);
            if (priceValue)
            {
                if (priceDecimal > 0)
                {
                    return string.Empty;
                }
                return "Price needs to be above zero";
            }
            return "Please put a valid price";
        }


        public static bool HasWarning(string validationOne, string validationTwo)
        {
            if(validationOne != string.Empty || validationTwo != string.Empty)
            {
                return true;
            }
            return false;
        }

        public static bool HasWarning(string validation)
        {
            if (validation != string.Empty)
            {
                return true;
            }
            return false;
        }

        public static string WarningMessage(string warningTypeOne, string warningTypeTwo)
        {
            return $"{warningTypeOne}\n\r" +
                        $"{warningTypeTwo}";
        }
        public static string SuccessReservationMessage(string fieldOne, string fieldTwo, DateTime start, DateTime end)
        {
            return $"Thank you {fieldOne}!\n\r" +
                    $"Your reservation was requested\n\r" +
                    $"You choose the {fieldTwo}\n\r" +
                    $"at {start} until {end}!";
        }
        public static string SuccessAddEdit(bool edit, string name)
        {
            if (edit)
            {
                return $"{name} was edited with success!";
            }
            return $"{name} was created with success!";
        }
        public static string TitleMaker(bool error)
        {
            if (error)
            {
                return "WARNING";
            }
            return "SUCCESS";
        }

        public static void LazyExcuse()
        {
            MessageBox.Show("Sorry, not available", ":(");
        }
    }
}
