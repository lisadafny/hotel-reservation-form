using System;
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

        public static string WarningMessage(string warningTypeOne, string warningTypeTwo = "", string warningTypeThree = "")
        {
            return $"{warningTypeOne}\n\r" +
                        $"{warningTypeTwo}\n\r" +
                        $"{warningTypeThree}";
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
        public static string SuccessAddEdit(bool edit)
        {
            if (edit)
            {
                return $"Edited with success!";
            }
            return $"Created with success!";
        }
        public static string TitleMaker(bool error)
        {
            if (error)
            {
                return "WARNING";
            }
            return "SUCCESS";
        }

        public static void PasswordConfirmationError()
        {
            MessageBox.Show("The password confirmation does not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }


        public static void InvalidCredentials()
        {
            MessageBox.Show("Invalid credentials");
        }

        public static void ErrorMessage()
        {
            MessageBox.Show("Something went wrong... Please try again later");
        }

        public static void LazyExcuse()
        {
            MessageBox.Show("Sorry, not available", ":(");
        }
    }
}
