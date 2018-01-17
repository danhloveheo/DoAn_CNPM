using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_LTDM
{
    public partial class Frm_LuyenTap : Form
    {
        public Frm_LuyenTap()
        {
            InitializeComponent();
        }
        private string RandomString(int size, bool lowerCase)
        {
            StringBuilder sb = new StringBuilder();
            char c;
            int numb, numb1, numb2, numb3, numb4;

            Random rand = new Random();

            int i = 0;
            for (; i < size; i++)
            {
                c = Convert.ToChar(Convert.ToInt32(rand.Next(65, 87)));
                numb = rand.Next(0, 9);
                numb1 = rand.Next(0, 9);
                numb2 = rand.Next(0, 9);
                numb3 = rand.Next(0, 9);
                numb4 = rand.Next(0, 9);
                if ((i == numb) || (i == numb1) || (i == numb2) || (i == numb3) || (i == numb4))
                {
                    string e = c + " ";
                    sb.Append(e);
                }
                else
                    sb.Append(c);

            }
            if (lowerCase)
                return sb.ToString().ToLower();
            return sb.ToString();

        }

        private void Frm_LuyenTap_Load(object sender, EventArgs e)
        {
            Frm_LuyenTap p = new Frm_LuyenTap();
            string s1 = p.RandomString(10, true);
            textBox1.Text = s1;
        }
    }
}
