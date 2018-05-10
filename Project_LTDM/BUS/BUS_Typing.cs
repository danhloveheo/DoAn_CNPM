using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class BUS_Typing
    {
        #region General
        public static void StopFocus(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c.Controls != null)
                {
                    StopFocus(c);
                }
                c.TabStop = false;
            }
        }
        #endregion
    }
}
