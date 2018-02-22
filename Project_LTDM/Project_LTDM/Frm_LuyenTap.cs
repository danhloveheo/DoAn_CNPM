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
                    string e = c.ToString();
                    sb.Append(e);
                }
                else
                    sb.Append(c);

            }
            if (lowerCase)
                return sb.ToString().ToLower();
            return sb.ToString();

        }
        int i = 0;
        private void Frm_LuyenTap_Load(object sender, EventArgs e)
        {
            Frm_LuyenTap p = new Frm_LuyenTap();
            string s1 = p.RandomString(5, true);
            textBox1.Text = s1;
            this.KeyPreview = true;
        }

        private void Frm_LuyenTap_KeyDown(object sender, KeyEventArgs e)
        {
             int[] k = new int[5];

            for (int z = 0; z < 5; z++)
            {
                k[z] = z;
            }


            string keya = button50.Text;
            string keyc = button69.Text;
            string keyb = button71.Text;
            string keye = button36.Text;
            string keyq = button34.Text;
            string keyw = button35.Text;
            string keyr = button37.Text;
            string keyt = button38.Text;
            string keyy = button39.Text;
            string keyu = button99.Text;
            string keyi = button9.Text;
            string keyo = button15.Text;
            string keyp = button28.Text;
            string keys = button51.Text;
            string keyd = button52.Text;
            string keyf = button53.Text;
            string keyg = button54.Text;
            string keyh = button55.Text;
            string keyj = button100.Text;
            string keyk = button10.Text;
            string keyl = button16.Text;
            string keyz = button67.Text;
            string keyx = button68.Text;
            string keyv = button70.Text;
            string keyn = button101.Text;
            string keym = button11.Text;

            string b = textBox1.Text;

            b = b.Substring(k[i], 1);
          
            if (e.KeyCode == Keys.M)
            {
                if (string.Compare(keym, b, true) != 0)
                {
                    button11.BackColor = Color.Red;
                    return;

                }
                else
                {
                    button11.BackColor = Color.Green;

                    if (i == 4)
                    {
                        MessageBox.Show("Hoan thanh");
                        Application.Exit();
                        return;
                    }
                    i++;
                    return;
                }

            }
            if (e.KeyCode == Keys.N)
            {
                if (string.Compare(keyn, b, true) != 0)
                {
                    button101.BackColor = Color.Red;
                    return;

                }
                else
                {
                    button101.BackColor = Color.Green;

                    if (i == 4)
                    {
                        MessageBox.Show("Hoan thanh");
                        Application.Exit();
                        return;
                    }
                    i++;
                    return;
                }

            }
            if (e.KeyCode == Keys.B)
            {
                if (string.Compare(keyb, b, true) != 0)
                {
                    button71.BackColor = Color.Red;
                    return;

                }
                else
                {
                    button71.BackColor = Color.Green;

                    if (i == 4)
                    {
                        MessageBox.Show("Hoan thanh");
                        Application.Exit();
                        return;
                    }
                    i++;
                    return;
                }

            }
            if (e.KeyCode == Keys.V)
            {
                if (string.Compare(keyv, b, true) != 0)
                {
                    button70.BackColor = Color.Red;
                    return;

                }
                else
                {
                    button70.BackColor = Color.Green;

                    if (i == 4)
                    {
                        MessageBox.Show("Hoan thanh");
                        Application.Exit();
                        return;
                    }
                    i++;
                    return;
                }

            }
            if (e.KeyCode == Keys.C)
            {
                if (string.Compare(keyc, b, true) != 0)
                {
                    button69.BackColor = Color.Red;
                    return;

                }
                else
                {
                    button69.BackColor = Color.Green;
                    i++;
                    return;
                }

            }
            if (e.KeyCode == Keys.X)
            {
                if (string.Compare(keyx, b, true) != 0)
                {
                    button68.BackColor = Color.Red;
                    return;

                }
                else
                {
                    button68.BackColor = Color.Green;

                    if (i == 4)
                    {
                        MessageBox.Show("Hoan thanh");
                        Application.Exit();
                        return;
                    }
                    i++;
                    return;
                }

            }
            if (e.KeyCode == Keys.Z)
            {
                if (string.Compare(keyz, b, true) != 0)
                {
                    button67.BackColor = Color.Red;
                    return;

                }
                else
                {
                    button67.BackColor = Color.Green;

                    if (i == 4)
                    {
                        MessageBox.Show("Hoan thanh");
                        Application.Exit();
                        return;
                    }
                    i++;
                    return;
                }

            }
            if (e.KeyCode == Keys.L)
            {
                if (string.Compare(keyl, b, true) != 0)
                {
                    button16.BackColor = Color.Red;
                    return;

                }
                else
                {
                    button16.BackColor = Color.Green;
                    i++;
                    return;
                }

            }
            if (e.KeyCode == Keys.K)
            {
                if (string.Compare(keyk, b, true) != 0)
                {
                    button10.BackColor = Color.Red;
                    return;

                }
                else
                {
                    button10.BackColor = Color.Green;

                    if (i == 4)
                    {
                        MessageBox.Show("Hoan thanh");
                        Application.Exit();
                        return;
                    }
                    i++;
                    return;
                }

            }
            if (e.KeyCode == Keys.J)
            {
                if (string.Compare(keyj, b, true) != 0)
                {
                    button100.BackColor = Color.Red;
                    return;

                }
                else
                {
                    button100.BackColor = Color.Green;

                    if (i == 4)
                    {
                        MessageBox.Show("Hoan thanh");
                        Application.Exit();
                        return;
                    }
                    i++;
                    return;
                }

            }
            if (e.KeyCode == Keys.H)
            {
                if (string.Compare(keyh, b, true) != 0)
                {
                    button55.BackColor = Color.Red;
                    return;

                }
                else
                {
                    button55.BackColor = Color.Green;

                    if (i == 4)
                    {
                        MessageBox.Show("Hoan thanh");
                        Application.Exit();
                        return;
                    }
                    i++;
                    return;
                }

            }
            if (e.KeyCode == Keys.G)
            {
                if (string.Compare(keyg, b, true) != 0)
                {
                    button54.BackColor = Color.Red;
                    return;

                }
                else
                {
                    button54.BackColor = Color.Green;

                    if (i == 4)
                    {
                        MessageBox.Show("Hoan thanh");
                        Application.Exit();
                        return;
                    }
                    i++;
                    return;
                }

            }
            if (e.KeyCode == Keys.F)
            {
                if (string.Compare(keyf, b, true) != 0)
                {
                    button53.BackColor = Color.Red;
                    return;

                }
                else
                {
                    button53.BackColor = Color.Green;

                    if (i == 4)
                    {
                        MessageBox.Show("Hoan thanh");
                        Application.Exit();
                        return;
                    }
                    i++;
                    return;
                }

            }
            if (e.KeyCode == Keys.D)
            {
                if (string.Compare(keyd, b, true) != 0)
                {
                    button52.BackColor = Color.Red;
                    return;

                }
                else
                {
                    button52.BackColor = Color.Green;

                    if (i == 4)
                    {
                        MessageBox.Show("Hoan thanh");
                        Application.Exit();
                        return;
                    }
                    i++;
                    return;
                }

            }

            if (e.KeyCode == Keys.S)
            {
                if (string.Compare(keys, b, true) != 0)
                {
                    button51.BackColor = Color.Red;
                    return;

                }
                else
                {
                    button51.BackColor = Color.Green;

                    if (i == 4)
                    {
                        MessageBox.Show("Hoan thanh");
                        Application.Exit();
                        return;
                    }
                    i++;
                    return;
                }

            }

            if (e.KeyCode == Keys.A)
            {
                if (string.Compare(keya, b, true) != 0)
                {
                    button50.BackColor = Color.Red;
                    return;

                }
                else
                {
                    button50.BackColor = Color.Green;

                    if (i == 4)
                    {
                        MessageBox.Show("Hoan thanh");
                        Application.Exit();
                        return;
                    }
                    i++;
                    return;
                }

            }
            if (e.KeyCode == Keys.P)
            {
                if (string.Compare(keyp, b, true) != 0)
                {
                    button28.BackColor = Color.Red;
                    return;

                }
                else
                {
                    button28.BackColor = Color.Green;

                    if (i == 4)
                    {
                        MessageBox.Show("Hoan thanh");
                        Application.Exit();
                        return;
                    }
                    i++;
                    return;
                }

            }

            if (e.KeyCode == Keys.O)
            {
                if (string.Compare(keyo, b, true) != 0)
                {
                    button15.BackColor = Color.Red;
                    return;

                }
                else
                {
                    button15.BackColor = Color.Green;

                    if (i == 4)
                    {
                        MessageBox.Show("Hoan thanh");
                        Application.Exit();
                        return;
                    }
                    i++;
                    return;
                }

            }
            if (e.KeyCode == Keys.Q)
            {
                if (string.Compare(keyq, b, true) != 0)
                {
                    button34.BackColor = Color.Red;

                    return;

                }
                else
                {
                    button34.BackColor = Color.Green;

                    if (i == 4)
                    {
                        MessageBox.Show("Hoan thanh");
                        Application.Exit();
                        return;
                    }
                    i++;
                    return;
                }

            }
            if (e.KeyCode == Keys.Y)
            {
                if (string.Compare(keyy, b, true) != 0)
                {
                    button39.BackColor = Color.Red;
                    return;

                }
                else
                {
                    button39.BackColor = Color.Green;

                    if (i == 4)
                    {
                        MessageBox.Show("Hoan thanh");
                        Application.Exit();
                        return;
                    }
                    i++;
                    return;
                }

            }
            if (e.KeyCode == Keys.U)
            {
                if (string.Compare(keyu, b, true) != 0)
                {
                    button99.BackColor = Color.Red;
                    return;

                }
                else
                {
                    button99.BackColor = Color.Green;

                    if (i == 4)
                    {
                        MessageBox.Show("Hoan thanh");
                        Application.Exit();
                        return;
                    }
                    i++;
                    return;
                }

            }
            if (e.KeyCode == Keys.I)
            {
                if (string.Compare(keyi, b, true) != 0)
                {
                    button9.BackColor = Color.Red;
                    return;

                }
                else
                {
                    button9.BackColor = Color.Green;

                    if (i == 4)
                    {
                        MessageBox.Show("Hoan thanh");
                        Application.Exit();
                        return;
                    }
                    i++;
                    return;
                }

            }
            if (e.KeyCode == Keys.T)
            {
                if (string.Compare(keyt, b, true) != 0)
                {
                    button38.BackColor = Color.Red;
                    return;

                }
                else
                {
                    button38.BackColor = Color.Green;

                    if (i == 4)
                    {
                        MessageBox.Show("Hoan thanh");
                        Application.Exit();
                        return;
                    }
                    i++;
                    return;
                }

            }
            if (e.KeyCode == Keys.R)
            {
                if (string.Compare(keyr, b, true) != 0)
                {
                    button37.BackColor = Color.Red;
                    return;

                }
                else
                {
                    button37.BackColor = Color.Green;

                    if (i == 4)
                    {
                        MessageBox.Show("Hoan thanh");
                        Application.Exit();
                        return;
                    }
                    i++;
                    return;
                }

            }
            if (e.KeyCode == Keys.W)
            {
                if (string.Compare(keyw, b, true) != 0)
                {
                    button35.BackColor = Color.Red;
                    return;

                }
                else
                {
                    button35.BackColor = Color.Green;

                    if (i == 4)
                    {
                        MessageBox.Show("Hoan thanh");
                        Application.Exit();
                        return;
                    }
                    i++;
                    return;
                }

            }

            if (e.KeyCode == Keys.E)
            {

                if (string.Compare(keye, b, true) != 0)
                {
                    button36.BackColor = Color.Red;
                    return;

                }
                else
                    button36.BackColor = Color.Green;

                if (i == 4)
                {
                    MessageBox.Show("Hoan thanh");
                    Application.Exit();
                    return;
                }
                i++;
                return;
            }
            
        }
        }
    }

