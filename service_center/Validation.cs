using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace service_center
{
    public static class Validation
    {
        public static bool NotNullOrEmpty(string value)
        {
            if (value == null)
            {
                return false;
            }
            if (string.IsNullOrEmpty(value))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static bool OnlyLetters(string value)
        {
            string pattern = @"^[а-яА-я\s]+$";

            bool isValid = Regex.IsMatch(value, pattern);
            if (NotNullOrEmpty(value) && isValid)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool OnlyNumbers(string value)
        {
            string pattern = @"^\d+$";

            bool isValid = Regex.IsMatch(value, pattern);

            if (NotNullOrEmpty(value) && isValid)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool PhoneNumberValidate(string value)
        {
            
            if (value.Length < 13)
            {
                MyMessageBox.Show("Невірно введений номер");
                return false;
            }
            string pattern = @"^\+380\d{9}$";

            bool isValid = Regex.IsMatch(value, pattern);

            if (NotNullOrEmpty(value) && isValid)
            {
                return true;
            }
            else
            {
                MyMessageBox.Show("Невірно введений номер");
                return false;
            }
        }
        public static bool PassportID(string value)
        {
            
            string pattern = @"^[0-9]{9}$";

            bool isValid = Regex.IsMatch(value, pattern);

            if (NotNullOrEmpty(value) && isValid)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
