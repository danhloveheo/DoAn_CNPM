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
            string a = p.RandomString(1, true);
            label.Text = a;

            Frm_LuyenTap p1 = new Frm_LuyenTap();
            string a1 = p1.RandomString(1, true);
            label1.Text = a1;

            Frm_LuyenTap p2 = new Frm_LuyenTap();
            string a2 = p2.RandomString(1, true);
            label2.Text = a2;

            Frm_LuyenTap p3 = new Frm_LuyenTap();
            string a3 = p3.RandomString(1, true);
            label3.Text = a3;

            Frm_LuyenTap p4 = new Frm_LuyenTap();
            string a4 = p4.RandomString(1, true);
            label4.Text = a4;

            Frm_LuyenTap p5 = new Frm_LuyenTap();
            string a5 = p5.RandomString(1, true);
            label5.Text = a5;

            Frm_LuyenTap p6 = new Frm_LuyenTap();
            string a6 = p6.RandomString(1, true);
            label6.Text = a6;

            Frm_LuyenTap p7 = new Frm_LuyenTap();
            string a7 = p7.RandomString(1, true);
            label7.Text = a7;

            this.KeyPreview = true;
        }
        private void HighLight(Button btn)
        {
            btn.BackColor = Color.LightSeaGreen;

        }

        private void Normal(Button btn)
        {
            btn.UseVisualStyleBackColor = true;
        }

        private void Sai(Button btn)
        {
            btn.BackColor = Color.Red;
        }

        private void ColorLabel_True(Label lb)
        {
            lb.BackColor = Color.LightSeaGreen;
        }


        private void ColorLabel_Default(Label lb)
        {
            lb.BackColor = SystemColors.Control;
        }

        int z = 0;
        int k = 0;

        private void Frm_LuyenTap_KeyDown(object sender, KeyEventArgs e)
        {
            string[] chuoi = new string[8];
            chuoi[0] = label.Text;
            chuoi[1] = label1.Text;
            chuoi[2] = label2.Text;
            chuoi[3] = label3.Text;
            chuoi[4] = label4.Text;
            chuoi[5] = label5.Text;
            chuoi[6] = label6.Text;
            chuoi[7] = label7.Text;

            string stringlabel = chuoi[z];
            switch (e.KeyCode)
            {
                case Keys.Q:
                    string q = btnq.Text;
                    if (string.Compare(q, stringlabel, true) == 0)
                    {
                        HighLight(btnq);
                        z++;

                        if (k == 0)
                        {
                            ColorLabel_True(label);
                            k++;
                            return;
                        }
                        if (k == 1)
                        {
                            ColorLabel_True(label1);
                            k++;
                            return;
                        }
                        if (k == 2)
                        {
                            ColorLabel_True(label2);
                            k++; return;
                        }
                        if (k == 3)
                        {
                            ColorLabel_True(label3);
                            k++; return;
                        }
                        if (k == 4)
                        {
                            ColorLabel_True(label4);
                            k++; return;
                        }
                        if (k == 5)
                        {
                            ColorLabel_True(label5);
                            k++; return;
                        }
                        if (k == 6)
                        {
                            ColorLabel_True(label6);
                            k++; return;
                        }
                        if (k == 7)
                        {
                            ColorLabel_True(label7);
                            k++;
                            MessageBox.Show("Hoan Thanh");
                            Application.Exit();
                            return;
                        }

                    }
                    else
                    {
                        Sai(btnq);
                    }
                    break;
                case Keys.W:
                    string w = btnw.Text;

                    if (string.Compare(w, stringlabel, true) == 0)
                    {

                        HighLight(btnw);
                        z++;
                        if (k == 0)
                        {
                            ColorLabel_True(label);
                            k++;
                            return;
                        }
                        if (k == 1)
                        {
                            ColorLabel_True(label1);
                            k++;
                            return;
                        }
                        if (k == 2)
                        {
                            ColorLabel_True(label2);
                            k++; return;
                        }
                        if (k == 3)
                        {
                            ColorLabel_True(label3);
                            k++; return;
                        }
                        if (k == 4)
                        {
                            ColorLabel_True(label4);
                            k++; return;
                        }
                        if (k == 5)
                        {
                            ColorLabel_True(label5);
                            k++; return;
                        }
                        if (k == 6)
                        {
                            ColorLabel_True(label6);
                            k++; return;
                        }
                        if (k == 7)
                        {
                            ColorLabel_True(label7);
                            k++;
                            MessageBox.Show("Hoan Thanh");
                            Application.Exit(); return;
                        }
                    }
                    else
                    {
                        Sai(btnw);
                    }
                    break;
                case Keys.E:
                    string keye = btne.Text;

                    if (string.Compare(keye, stringlabel, true) == 0)
                    {
                        HighLight(btne);
                        z++;
                        if (k == 0)
                        {
                            ColorLabel_True(label);
                            k++;
                            return;
                        }
                        if (k == 1)
                        {
                            ColorLabel_True(label1);
                            k++;
                            return;
                        }
                        if (k == 2)
                        {
                            ColorLabel_True(label2);
                            k++; return;
                        }
                        if (k == 3)
                        {
                            ColorLabel_True(label3);
                            k++; return;
                        }
                        if (k == 4)
                        {
                            ColorLabel_True(label4);
                            k++; return;
                        }
                        if (k == 5)
                        {
                            ColorLabel_True(label5);
                            k++; return;
                        }
                        if (k == 6)
                        {
                            ColorLabel_True(label6);
                            k++; return;
                        }
                        if (k == 7)
                        {
                            ColorLabel_True(label7);
                            k++;
                            MessageBox.Show("Hoan Thanh");
                            Application.Exit(); return;
                        }
                    }
                    else
                    {
                        Sai(btne);
                    }
                    break;
                case Keys.R:
                    string r = btnr.Text;

                    if (string.Compare(r, stringlabel, true) == 0)
                    {
                        HighLight(btnr);
                        z++;
                        if (k == 0)
                        {
                            ColorLabel_True(label);
                            k++;
                            return;
                        }
                        if (k == 1)
                        {
                            ColorLabel_True(label1);
                            k++;
                            return;
                        }
                        if (k == 2)
                        {
                            ColorLabel_True(label2);
                            k++; return;
                        }
                        if (k == 3)
                        {
                            ColorLabel_True(label3);
                            k++; return;
                        }
                        if (k == 4)
                        {
                            ColorLabel_True(label4);
                            k++; return;
                        }
                        if (k == 5)
                        {
                            ColorLabel_True(label5);
                            k++; return;
                        }
                        if (k == 6)
                        {
                            ColorLabel_True(label6);
                            k++; return;
                        }
                        if (k == 7)
                        {
                            ColorLabel_True(label7);
                            k++;
                            MessageBox.Show("Hoan Thanh");
                            Application.Exit(); return;
                        }
                    }
                    else
                    {
                        Sai(btnr);
                    }
                    break;
                case Keys.T:
                    string t = btnt.Text;

                    if (string.Compare(t, stringlabel, true) == 0)
                    {
                        HighLight(btnt);
                        z++;
                        if (k == 0)
                        {
                            ColorLabel_True(label);
                            k++;
                            return;
                        }
                        if (k == 1)
                        {
                            ColorLabel_True(label1);
                            k++;
                            return;
                        }
                        if (k == 2)
                        {
                            ColorLabel_True(label2);
                            k++; return;
                        }
                        if (k == 3)
                        {
                            ColorLabel_True(label3);
                            k++; return;
                        }
                        if (k == 4)
                        {
                            ColorLabel_True(label4);
                            k++; return;
                        }
                        if (k == 5)
                        {
                            ColorLabel_True(label5);
                            k++; return;
                        }
                        if (k == 6)
                        {
                            ColorLabel_True(label6);
                            k++; return;
                        }
                        if (k == 7)
                        {
                            ColorLabel_True(label7);
                            k++;
                            MessageBox.Show("Hoan Thanh");
                            Application.Exit(); return;
                        }
                    }
                    else
                    {
                        Sai(btnt);
                    }
                    break;
                case Keys.Y:
                    string y = btny.Text;

                    if (string.Compare(y, stringlabel, true) == 0)
                    {
                        HighLight(btny);
                        z++;
                        if (k == 0)
                        {
                            ColorLabel_True(label);
                            k++;
                            return;
                        }
                        if (k == 1)
                        {
                            ColorLabel_True(label1);
                            k++;
                            return;
                        }
                        if (k == 2)
                        {
                            ColorLabel_True(label2);
                            k++; return;
                        }
                        if (k == 3)
                        {
                            ColorLabel_True(label3);
                            k++; return;
                        }
                        if (k == 4)
                        {
                            ColorLabel_True(label4);
                            k++; return;
                        }
                        if (k == 5)
                        {
                            ColorLabel_True(label5);
                            k++; return;
                        }
                        if (k == 6)
                        {
                            ColorLabel_True(label6);
                            k++; return;
                        }
                        if (k == 7)
                        {
                            ColorLabel_True(label7);
                            k++;
                            MessageBox.Show("Hoan Thanh");
                            Application.Exit(); return;
                        }
                    }
                    else
                    {
                        Sai(btny);
                    }
                    break;
                case Keys.U:
                    string u = btnu.Text;

                    if (string.Compare(u, stringlabel, true) == 0)
                    {
                        HighLight(btnu);
                        z++;
                        if (k == 0)
                        {
                            ColorLabel_True(label);
                            k++;
                            return;
                        }
                        if (k == 1)
                        {
                            ColorLabel_True(label1);
                            k++;
                            return;
                        }
                        if (k == 2)
                        {
                            ColorLabel_True(label2);
                            k++; return;
                        }
                        if (k == 3)
                        {
                            ColorLabel_True(label3);
                            k++; return;
                        }
                        if (k == 4)
                        {
                            ColorLabel_True(label4);
                            k++; return;
                        }
                        if (k == 5)
                        {
                            ColorLabel_True(label5);
                            k++; return;
                        }
                        if (k == 6)
                        {
                            ColorLabel_True(label6);
                            k++; return;
                        }
                        if (k == 7)
                        {
                            ColorLabel_True(label7);
                            k++;
                            MessageBox.Show("Hoan Thanh");
                            Application.Exit(); return;
                        }
                    }
                    else
                    {
                        Sai(btnu);
                    }
                    break;
                case Keys.I:
                    string i = btni.Text;

                    if (string.Compare(i, stringlabel, true) == 0)
                    {
                        HighLight(btni);
                        z++;
                        if (k == 0)
                        {
                            ColorLabel_True(label);
                            k++;
                            return;
                        }
                        if (k == 1)
                        {
                            ColorLabel_True(label1);
                            k++;
                            return;
                        }
                        if (k == 2)
                        {
                            ColorLabel_True(label2);
                            k++; return;
                        }
                        if (k == 3)
                        {
                            ColorLabel_True(label3);
                            k++; return;
                        }
                        if (k == 4)
                        {
                            ColorLabel_True(label4);
                            k++; return;
                        }
                        if (k == 5)
                        {
                            ColorLabel_True(label5);
                            k++; return;
                        }
                        if (k == 6)
                        {
                            ColorLabel_True(label6);
                            k++; return;
                        }
                        if (k == 7)
                        {
                            ColorLabel_True(label7);
                            k++;
                            MessageBox.Show("Hoan Thanh");
                            Application.Exit(); return;
                        }
                    }
                    else
                    {
                        Sai(btni);
                    }

                    break;
                case Keys.O:
                    string o = btno.Text;

                    if (string.Compare(o, stringlabel, true) == 0)
                    {
                        HighLight(btno);
                        z++;
                        if (k == 0)
                        {
                            ColorLabel_True(label);
                            k++;
                            return;
                        }
                        if (k == 1)
                        {
                            ColorLabel_True(label1);
                            k++;
                            return;
                        }
                        if (k == 2)
                        {
                            ColorLabel_True(label2);
                            k++; return;
                        }
                        if (k == 3)
                        {
                            ColorLabel_True(label3);
                            k++; return;
                        }
                        if (k == 4)
                        {
                            ColorLabel_True(label4);
                            k++; return;
                        }
                        if (k == 5)
                        {
                            ColorLabel_True(label5);
                            k++; return;
                        }
                        if (k == 6)
                        {
                            ColorLabel_True(label6);
                            k++; return;
                        }
                        if (k == 7)
                        {
                            ColorLabel_True(label7);
                            k++;
                            MessageBox.Show("Hoan Thanh");
                            Application.Exit(); return;
                        }
                    }
                    else
                    {
                        Sai(btno);
                    }
                    break;
                case Keys.P:
                    string p = btnp.Text;

                    if (string.Compare(p, stringlabel, true) == 0)
                    {
                        HighLight(btnp);
                        z++;
                        if (k == 0)
                        {
                            ColorLabel_True(label);
                            k++;
                            return;
                        }
                        if (k == 1)
                        {
                            ColorLabel_True(label1);
                            k++;
                            return;
                        }
                        if (k == 2)
                        {
                            ColorLabel_True(label2);
                            k++; return;
                        }
                        if (k == 3)
                        {
                            ColorLabel_True(label3);
                            k++; return;
                        }
                        if (k == 4)
                        {
                            ColorLabel_True(label4);
                            k++; return;
                        }
                        if (k == 5)
                        {
                            ColorLabel_True(label5);
                            k++; return;
                        }
                        if (k == 6)
                        {
                            ColorLabel_True(label6);
                            k++; return;
                        }
                        if (k == 7)
                        {
                            ColorLabel_True(label7);
                            k++;
                            MessageBox.Show("Hoan Thanh");
                            Application.Exit(); return;
                        }
                    }
                    else
                    {
                        Sai(btnp);
                    }
                    break;
                case Keys.A:
                    string a = btna.Text;
                    if (string.Compare(a, stringlabel, true) == 0)
                    {
                        HighLight(btna);
                        z++;


                        if (k == 0)
                        {
                            ColorLabel_True(label);
                            k++; return;
                        }
                        if (k == 1)
                        {
                            ColorLabel_True(label1);
                            k++; return;
                        }
                        if (k == 2)
                        {
                            ColorLabel_True(label2);
                            k++; return;
                        }
                        if (k == 3)
                        {
                            ColorLabel_True(label3);
                            k++; return;
                        }
                        if (k == 4)
                        {
                            ColorLabel_True(label4);
                            k++; return;
                        }
                        if (k == 5)
                        {
                            ColorLabel_True(label5);
                            k++; return;
                        }
                        if (k == 6)
                        {
                            ColorLabel_True(label6);
                            k++; return;
                        }
                        if (k == 7)
                        {
                            ColorLabel_True(label7);
                            k++;
                            MessageBox.Show("Hoan Thanh");
                            Application.Exit(); return;
                        }

                    }
                    else
                    {
                        Sai(btna);
                    }
                    break;
                case Keys.S:

                    string s = btns.Text;
                    if (string.Compare(s, stringlabel, true) == 0)
                    {
                        HighLight(btns);
                        z++;
                        if (k == 0)
                        {
                            ColorLabel_True(label);
                            k++; return;
                        }
                        if (k == 1)
                        {
                            ColorLabel_True(label1);
                            k++; return;
                        }
                        if (k == 2)
                        {
                            ColorLabel_True(label2);
                            k++; return;
                        }
                        if (k == 3)
                        {
                            ColorLabel_True(label3);
                            k++; return;
                        }
                        if (k == 4)
                        {
                            ColorLabel_True(label4);
                            k++; return;
                        }
                        if (k == 5)
                        {
                            ColorLabel_True(label5);
                            k++; return;
                        }
                        if (k == 6)
                        {
                            ColorLabel_True(label6);
                            k++; return;
                        }
                        if (k == 7)
                        {
                            ColorLabel_True(label7);
                            k++;
                            MessageBox.Show("Hoan Thanh");
                            Application.Exit(); return;
                        }

                    }
                    else
                    {
                        Sai(btns);
                    }
                    break;
                case Keys.D:
                    string d = btnd.Text;
                    if (string.Compare(d, stringlabel, true) == 0)
                    {
                        HighLight(btnd);
                        z++;
                        if (k == 0)
                        {
                            ColorLabel_True(label);
                            k++; return;
                        }
                        if (k == 1)
                        {
                            ColorLabel_True(label1);
                            k++; return;
                        }
                        if (k == 2)
                        {
                            ColorLabel_True(label2);
                            k++; return;
                        }
                        if (k == 3)
                        {
                            ColorLabel_True(label3);
                            k++; return;
                        }
                        if (k == 4)
                        {
                            ColorLabel_True(label4);
                            k++; return;
                        }
                        if (k == 5)
                        {
                            ColorLabel_True(label5);
                            k++; return;
                        }
                        if (k == 6)
                        {
                            ColorLabel_True(label6);
                            k++; return;
                        }
                        if (k == 7)
                        {
                            ColorLabel_True(label7);
                            k++;
                            MessageBox.Show("Hoan Thanh");
                            Application.Exit(); return;
                        }

                    }
                    else
                    {
                        Sai(btnd);
                    }
                    break;
                case Keys.F:

                    string f = btnf.Text;
                    if (string.Compare(f, stringlabel, true) == 0)
                    {
                        HighLight(btnf);
                        z++;
                        if (k == 0)
                        {
                            ColorLabel_True(label);
                            k++; return;
                        }
                        if (k == 1)
                        {
                            ColorLabel_True(label1);
                            k++; return;
                        }
                        if (k == 2)
                        {
                            ColorLabel_True(label2);
                            k++; return;
                        }
                        if (k == 3)
                        {
                            ColorLabel_True(label3);
                            k++; return;
                        }
                        if (k == 4)
                        {
                            ColorLabel_True(label4);
                            k++; return;
                        }
                        if (k == 5)
                        {
                            ColorLabel_True(label5);
                            k++; return;
                        }
                        if (k == 6)
                        {
                            ColorLabel_True(label6);
                            k++; return;
                        }
                        if (k == 7)
                        {
                            ColorLabel_True(label7);
                            k++;
                            MessageBox.Show("Hoan Thanh");
                            Application.Exit(); return;
                        }

                    }
                    else
                    {
                        Sai(btnf);
                    }
                    break;
                case Keys.G:

                    string g = btng.Text;
                    if (string.Compare(g, stringlabel, true) == 0)
                    {
                        HighLight(btng);
                        z++;
                        if (k == 0)
                        {
                            ColorLabel_True(label);
                            k++; return;
                        }
                        if (k == 1)
                        {
                            ColorLabel_True(label1);
                            k++; return;
                        }
                        if (k == 2)
                        {
                            ColorLabel_True(label2);
                            k++; return;
                        }
                        if (k == 3)
                        {
                            ColorLabel_True(label3);
                            k++; return;
                        }
                        if (k == 4)
                        {
                            ColorLabel_True(label4);
                            k++; return;
                        }
                        if (k == 5)
                        {
                            ColorLabel_True(label5);
                            k++; return;
                        }
                        if (k == 6)
                        {
                            ColorLabel_True(label6);
                            k++; return;
                        }
                        if (k == 7)
                        {
                            ColorLabel_True(label7);
                            k++;
                            MessageBox.Show("Hoan Thanh");
                            Application.Exit(); return;
                        }

                    }
                    else
                    {
                        Sai(btng);
                    }
                    break;
                case Keys.H:
                    string h = btnh.Text;
                    if (string.Compare(h, stringlabel, true) == 0)
                    {
                        HighLight(btnh);
                        z++;
                        if (k == 0)
                        {
                            ColorLabel_True(label);
                            k++; return;
                        }
                        if (k == 1)
                        {
                            ColorLabel_True(label1);
                            k++; return;
                        }
                        if (k == 2)
                        {
                            ColorLabel_True(label2);
                            k++; return;
                        }
                        if (k == 3)
                        {
                            ColorLabel_True(label3);
                            k++; return;
                        }
                        if (k == 4)
                        {
                            ColorLabel_True(label4);
                            k++; return;
                        }
                        if (k == 5)
                        {
                            ColorLabel_True(label5);
                            k++; return;
                        }
                        if (k == 6)
                        {
                            ColorLabel_True(label6);
                            k++; return;
                        }
                        if (k == 7)
                        {
                            ColorLabel_True(label7);
                            k++;
                            MessageBox.Show("Hoan Thanh");
                            Application.Exit(); return;
                        }

                    }
                    else
                    {
                        Sai(btnh);
                    }
                    break;
                case Keys.J:
                    string j = btnj.Text;
                    if (string.Compare(j, stringlabel, true) == 0)
                    {
                        HighLight(btnj);
                        z++;
                        if (k == 0)
                        {
                            ColorLabel_True(label);
                            k++; return;
                        }
                        if (k == 1)
                        {
                            ColorLabel_True(label1);
                            k++; return;
                        }
                        if (k == 2)
                        {
                            ColorLabel_True(label2);
                            k++; return;
                        }
                        if (k == 3)
                        {
                            ColorLabel_True(label3);
                            k++; return;
                        }
                        if (k == 4)
                        {
                            ColorLabel_True(label4);
                            k++; return;
                        }
                        if (k == 5)
                        {
                            ColorLabel_True(label5);
                            k++; return;
                        }
                        if (k == 6)
                        {
                            ColorLabel_True(label6);
                            k++; return;
                        }
                        if (k == 7)
                        {
                            ColorLabel_True(label7);
                            k++;
                            MessageBox.Show("Hoan Thanh");
                            Application.Exit(); return;
                        }

                    }
                    else
                    {
                        Sai(btnj);
                    }
                    break;
                case Keys.K:
                    string keyk = btnk.Text;
                    if (string.Compare(keyk, stringlabel, true) == 0)
                    {
                        HighLight(btnk);
                        z++;
                        if (k == 0)
                        {
                            ColorLabel_True(label);
                            k++; return;
                        }
                        if (k == 1)
                        {
                            ColorLabel_True(label1);
                            k++; return;
                        }
                        if (k == 2)
                        {
                            ColorLabel_True(label2);
                            k++; return;
                        }
                        if (k == 3)
                        {
                            ColorLabel_True(label3);
                            k++; return;
                        }
                        if (k == 4)
                        {
                            ColorLabel_True(label4);
                            k++; return;
                        }
                        if (k == 5)
                        {
                            ColorLabel_True(label5);
                            k++; return;
                        }
                        if (k == 6)
                        {
                            ColorLabel_True(label6);
                            k++; return;
                        }
                        if (k == 7)
                        {
                            ColorLabel_True(label7);
                            k++;
                            MessageBox.Show("Hoan Thanh");
                            Application.Exit(); return;
                        }

                    }
                    else
                    {
                        Sai(btnk);
                    }
                    break;
                case Keys.L:
                    string l = btnl.Text;
                    if (string.Compare(l, stringlabel, true) == 0)
                    {
                        HighLight(btnl);
                        z++;
                        if (k == 0)
                        {
                            ColorLabel_True(label);
                            k++; return;
                        }
                        if (k == 1)
                        {
                            ColorLabel_True(label1);
                            k++; return;
                        }
                        if (k == 2)
                        {
                            ColorLabel_True(label2);
                            k++; return;
                        }
                        if (k == 3)
                        {
                            ColorLabel_True(label3);
                            k++; return;
                        }
                        if (k == 4)
                        {
                            ColorLabel_True(label4);
                            k++; return;
                        }
                        if (k == 5)
                        {
                            ColorLabel_True(label5);
                            k++; return;
                        }
                        if (k == 6)
                        {
                            ColorLabel_True(label6);
                            k++; return;
                        }
                        if (k == 7)
                        {
                            ColorLabel_True(label7);
                            k++;
                            MessageBox.Show("Hoan Thanh");
                            Application.Exit(); return;
                        }

                    }
                    else
                    {
                        Sai(btnl);
                    }
                    break;
                case Keys.Z:
                    string keyz = btnz.Text;
                    if (string.Compare(keyz, stringlabel, true) == 0)
                    {
                        HighLight(btnz);
                        z++;
                        if (k == 0)
                        {
                            ColorLabel_True(label);
                            k++; return;
                        }
                        if (k == 1)
                        {
                            ColorLabel_True(label1);
                            k++; return;
                        }
                        if (k == 2)
                        {
                            ColorLabel_True(label2);
                            k++; return;
                        }
                        if (k == 3)
                        {
                            ColorLabel_True(label3);
                            k++; return;
                        }
                        if (k == 4)
                        {
                            ColorLabel_True(label4);
                            k++; return;
                        }
                        if (k == 5)
                        {
                            ColorLabel_True(label5);
                            k++; return;
                        }
                        if (k == 6)
                        {
                            ColorLabel_True(label6);
                            k++; return;
                        }
                        if (k == 7)
                        {
                            ColorLabel_True(label7);
                            k++;
                            MessageBox.Show("Hoan Thanh");
                            Application.Exit(); return;
                        }

                    }
                    else
                    {
                        Sai(btnz);
                    }
                    break;
                case Keys.X:
                    string x = btnx.Text;
                    if (string.Compare(x, stringlabel, true) == 0)
                    {
                        HighLight(btnx);
                        z++;
                        if (k == 0)
                        {
                            ColorLabel_True(label);
                            k++; return;
                        }
                        if (k == 1)
                        {
                            ColorLabel_True(label1);
                            k++; return;
                        }
                        if (k == 2)
                        {
                            ColorLabel_True(label2);
                            k++; return;
                        }
                        if (k == 3)
                        {
                            ColorLabel_True(label3);
                            k++; return;
                        }
                        if (k == 4)
                        {
                            ColorLabel_True(label4);
                            k++; return;
                        }
                        if (k == 5)
                        {
                            ColorLabel_True(label5);
                            k++; return;
                        }
                        if (k == 6)
                        {
                            ColorLabel_True(label6);
                            k++; return;
                        }
                        if (k == 7)
                        {
                            ColorLabel_True(label7);
                            k++;
                            MessageBox.Show("Hoan Thanh");
                            Application.Exit(); return;
                        }

                    }
                    else
                    {
                        Sai(btnx);
                    }
                    break;
                case Keys.C:
                    string c = btnc.Text;
                    if (string.Compare(c, stringlabel, true) == 0)
                    {
                        HighLight(btnc);
                        z++;
                        if (k == 0)
                        {
                            ColorLabel_True(label);
                            k++; return;
                        }
                        if (k == 1)
                        {
                            ColorLabel_True(label1);
                            k++; return;
                        }
                        if (k == 2)
                        {
                            ColorLabel_True(label2);
                            k++; return;
                        }
                        if (k == 3)
                        {
                            ColorLabel_True(label3);
                            k++; return;
                        }
                        if (k == 4)
                        {
                            ColorLabel_True(label4);
                            k++; return;
                        }
                        if (k == 5)
                        {
                            ColorLabel_True(label5);
                            k++; return;
                        }
                        if (k == 6)
                        {
                            ColorLabel_True(label6);
                            k++; return;
                        }
                        if (k == 7)
                        {
                            ColorLabel_True(label7);
                            k++;
                            MessageBox.Show("Hoan Thanh");
                            Application.Exit(); return;
                        }

                    }
                    else
                    {
                        Sai(btnc);
                    }
                    break;
                case Keys.V:
                    string v = btnv.Text;
                    if (string.Compare(v, stringlabel, true) == 0)
                    {
                        HighLight(btnv);
                        z++;
                        if (k == 0)
                        {
                            ColorLabel_True(label);
                            k++; return;
                        }
                        if (k == 1)
                        {
                            ColorLabel_True(label1);
                            k++; return;
                        }
                        if (k == 2)
                        {
                            ColorLabel_True(label2);
                            k++; return;
                        }
                        if (k == 3)
                        {
                            ColorLabel_True(label3);
                            k++; return;
                        }
                        if (k == 4)
                        {
                            ColorLabel_True(label4);
                            k++; return;
                        }
                        if (k == 5)
                        {
                            ColorLabel_True(label5);
                            k++; return;
                        }
                        if (k == 6)
                        {
                            ColorLabel_True(label6);
                            k++; return;
                        }
                        if (k == 7)
                        {
                            ColorLabel_True(label7);
                            k++;
                            MessageBox.Show("Hoan Thanh");
                            Application.Exit(); return;
                        }

                    }
                    else
                    {
                        Sai(btnv);
                    }
                    break;
                case Keys.B:
                    string b = btnb.Text;
                    if (string.Compare(b, stringlabel, true) == 0)
                    {
                        HighLight(btnb);
                        z++;
                        if (k == 0)
                        {
                            ColorLabel_True(label);
                            k++; return;
                        }
                        if (k == 1)
                        {
                            ColorLabel_True(label1);
                            k++; return;
                        }
                        if (k == 2)
                        {
                            ColorLabel_True(label2);
                            k++; return;
                        }
                        if (k == 3)
                        {
                            ColorLabel_True(label3);
                            k++; return;
                        }
                        if (k == 4)
                        {
                            ColorLabel_True(label4);
                            k++; return;
                        }
                        if (k == 5)
                        {
                            ColorLabel_True(label5);
                            k++; return;
                        }
                        if (k == 6)
                        {
                            ColorLabel_True(label6);
                            k++; return;
                        }
                        if (k == 7)
                        {
                            ColorLabel_True(label7);
                            k++;
                            MessageBox.Show("Hoan Thanh");
                            Application.Exit(); return;
                        }

                    }
                    else
                    {
                        Sai(btnb);
                    }
                    break;
                case Keys.N:
                    string n = btnn.Text;
                    if (string.Compare(n, stringlabel, true) == 0)
                    {
                        HighLight(btnn);
                        z++;
                        if (k == 0)
                        {
                            ColorLabel_True(label);
                            k++; return;
                        }
                        if (k == 1)
                        {
                            ColorLabel_True(label1);
                            k++; return;
                        }
                        if (k == 2)
                        {
                            ColorLabel_True(label2);
                            k++; return;
                        }
                        if (k == 3)
                        {
                            ColorLabel_True(label3);
                            k++; return;
                        }
                        if (k == 4)
                        {
                            ColorLabel_True(label4);
                            k++; return;
                        }
                        if (k == 5)
                        {
                            ColorLabel_True(label5);
                            k++; return;
                        }
                        if (k == 6)
                        {
                            ColorLabel_True(label6);
                            k++; return;
                        }
                        if (k == 7)
                        {
                            ColorLabel_True(label7);
                            k++;
                            MessageBox.Show("Hoan Thanh");
                            Application.Exit(); return;
                        }

                    }
                    else
                    {
                        Sai(btnn);
                    }
                    break;
                case Keys.M:
                    string m = btnm.Text;
                    if (string.Compare(m, stringlabel, true) == 0)
                    {
                        HighLight(btnf);
                        z++;
                        if (k == 0)
                        {
                            ColorLabel_True(label);
                            k++; return;
                        }
                        if (k == 1)
                        {
                            ColorLabel_True(label1);
                            k++; return;
                        }
                        if (k == 2)
                        {
                            ColorLabel_True(label2);
                            k++; return;
                        }
                        if (k == 3)
                        {
                            ColorLabel_True(label3);
                            k++; return;
                        }
                        if (k == 4)
                        {
                            ColorLabel_True(label4);
                            k++; return;
                        }
                        if (k == 5)
                        {
                            ColorLabel_True(label5);
                            k++; return;
                        }
                        if (k == 6)
                        {
                            ColorLabel_True(label6);
                            k++; return;
                        }
                        if (k == 7)
                        {
                            ColorLabel_True(label7);
                            k++;
                            MessageBox.Show("Hoan Thanh");
                            Application.Exit(); return;
                        }

                    }
                    else
                    {
                        Sai(btnm);
                    }
                    break;





            }
        }

        private void Frm_LuyenTap_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {

                case Keys.Q: Normal(btnq); break;
                case Keys.W: Normal(btnw); break;
                case Keys.E: Normal(btne); break;
                case Keys.R: Normal(btnr); break;
                case Keys.T: Normal(btnt); break;
                case Keys.Y: Normal(btny); break;
                case Keys.U: Normal(btnu); break;
                case Keys.I: Normal(btni); break;
                case Keys.O: Normal(btno); break;
                case Keys.P: Normal(btnp); break;
                case Keys.A: Normal(btna);


                    break;



                case Keys.S: Normal(btns); break;

                case Keys.D: Normal(btnd); break;
                case Keys.F: Normal(btnf); break;
                case Keys.G: Normal(btng); break;
                case Keys.H: Normal(btnh); break;
                case Keys.J: Normal(btnj); break;
                case Keys.K: Normal(btnk); break;
                case Keys.L: Normal(btnl); break;
                case Keys.Z: Normal(btnz); break;
                case Keys.X: Normal(btnx); break;
                case Keys.C: Normal(btnc); break;
                case Keys.V: Normal(btnv); break;
                case Keys.B: Normal(btnb); break;
                case Keys.N: Normal(btnn); break;
                case Keys.M: Normal(btnm); break;
                case Keys.Space: Normal(btnspace); break;
            }
        }


    }
}
