using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace BUS
{
    public class BUS_Validation
    {
        #region Login and Register
        public static bool ValidTextFormat(string text, ref string errorMessage)
        {
            if (text.Length < 8)
            {
                errorMessage += " must contain at least 8 characters.";
                return false;
            }

            Regex rgx = new Regex(@"^[a-zA-Z0-9]*$");
            if (!rgx.IsMatch(text))
            {
                errorMessage += " must contain only letter and number.";
                return false;
            }

            errorMessage = "";
            return true;
        }

        public static bool ValidConfirmPassword(string text1, string text2, ref string errorMessage)
        {
            if (text1 != text2)
            {
                errorMessage += "Password does not match.";
                return false;
            }

            errorMessage = "";
            return true;
        }

        public static bool ValidEmailFormat(string text, ref string errorMessage)
        {
            Regex rgx = new Regex(@"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*"
                                    + "@"
                                    + @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$");
            if (!rgx.IsMatch(text))
            {
                errorMessage += "Invalid email.";
                return false;
            }

            errorMessage = "";
            return true;
        }
        #endregion

        #region SaveExercise
        // Tên bài tập phải có ít nhất 1 ký tự, chỉ có số hoặc chữ
        public static bool ValidName (string text, ref string errorMessage)
        {
            if (text.Length < 1)
            {
                errorMessage += " must contain at least 1 characters.";
                return false;
            }

            Regex rgx = new Regex(@"^[a-zA-Z0-9]*$");
            if (!rgx.IsMatch(text))
            {
                errorMessage += " must contain only letter and number.";
                return false;
            }

            errorMessage = "";
            return true;
        }

        //Time textbox chỉ chứa số
        public static bool ValidTime (string text, ref string errorMessage)
        {
            if (text.Length < 1)
            {
                errorMessage += " must contain at least 1 characters.";
                return false;
            }

            int time;

            if (int.TryParse(text,out time))
            {
                errorMessage = "";
                return true;
            }

            errorMessage += " must contain only number";
            return false;
        }

        //Nội dung bài tập phải có ít nhất 1 ký tự
        public static bool ValidText (string text, ref string errorMessage)
        {
            if (text.Length < 1)
            {
                errorMessage += " must contain at least 1 characters.";
                return false;
            }

            errorMessage = "";
            return true;
        }
        #endregion
    }
}
