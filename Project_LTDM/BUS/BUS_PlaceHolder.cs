using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class BUS_Placeholder
    {
        public static void NormalTxtEnter (TextBox txt, string placeholder)
        {
            if (txt.Text == placeholder)
            {
                txt.Clear();
            }
        }

        public static void NormalTxtLeave (TextBox txt, string placeholder)
        {
            if (txt.Text == String.Empty)
            {
                txt.Text = placeholder;
            }
        }

        public static void PasswordTxtEnter (TextBox txt, string placeholder)
        {
            if (txt.Text == placeholder)
            {
                txt.Clear();
            }
            txt.PasswordChar = '*';
        }

        public static void PasswordTxtLeave (TextBox txt, string placeholder)
        {
            if (txt.Text == String.Empty)
            {
                txt.PasswordChar = (char)0;
                txt.Text = placeholder;
            }
        }
    }
}
