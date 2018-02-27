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


            Random rand = new Random();

            int i = 0;
            for (; i < size; i++)
            {
                c = Convert.ToChar(Convert.ToInt32(rand.Next(97, 122)));
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
            Separator_True(Separator);
        }
        private void Separator_True(Bunifu.Framework.UI.BunifuSeparator sp)
        {
            sp.LineColor = Color.LightSeaGreen;

        }
        private void Separator_Default(Bunifu.Framework.UI.BunifuSeparator sp)
        {
            sp.LineColor = Color.LightGray;

        }
        private void Button_True(Button btn)
        {
            btn.BackColor = Color.LightSeaGreen;

        }

        private void Button_Default(Button btn)
        {
            btn.UseVisualStyleBackColor = true;
        }

        private void Button_False(Button btn)
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
                        Button_True(btnq);


                        if (z == 0)
                        {

                            Separator_Default(Separator);

                            Separator_True(Separator1);
                            ColorLabel_True(label);
                            z++;
                            return;
                        }
                        if (z == 1)
                        {
                            Separator_Default(Separator1);
                            Separator_True(Separator2);
                            ColorLabel_True(label1);
                            z++;
                            return;
                        }
                        if (z == 2)
                        {
                            Separator_Default(Separator2);
                            Separator_True(Separator3);
                            ColorLabel_True(label2);
                            z++; return;
                        }
                        if (z == 3)
                        {
                            Separator_Default(Separator3);
                            Separator_True(Separator4);
                            ColorLabel_True(label3);
                            z++; return;
                        }
                        if (z == 4)
                        {
                            Separator_Default(Separator4);
                            Separator_True(Separator5);
                            ColorLabel_True(label4);
                            z++; return;
                        }
                        if (z == 5)
                        {
                            Separator_Default(Separator5);
                            Separator_True(Separator6);
                            ColorLabel_True(label5);
                            z++; return;
                        }
                        if (z == 6)
                        {
                            Separator_Default(Separator6);
                            Separator_True(Separator7);
                            ColorLabel_True(label6);
                            z++; return;
                        }
                        if (z == 7)
                        {

                            ColorLabel_True(label7);
                            z++;
                            MessageBox.Show("Hoan Thanh");
                            Application.Exit();
                            return;
                        }

                    }
                    else
                    {
                        Button_False(btnq);
                    }
                    break;
                case Keys.W:
                    string w = btnw.Text;

                    if (string.Compare(w, stringlabel, true) == 0)
                    {

                        Button_True(btnw);

                        if (z == 0)
                        {
                            Separator_Default(Separator);
                            Separator_True(Separator1);
                            ColorLabel_True(label);
                            z++;
                            return;
                        }
                        if (z == 1)
                        {
                            Separator_Default(Separator1);
                            Separator_True(Separator2);
                            ColorLabel_True(label1);
                            z++;
                            return;
                        }
                        if (z == 2)
                        {
                            Separator_Default(Separator2);
                            Separator_True(Separator3);
                            ColorLabel_True(label2);
                            z++; return;
                        }
                        if (z == 3)
                        {
                            Separator_Default(Separator3);
                            Separator_True(Separator4);
                            ColorLabel_True(label3);
                            z++; return;
                        }
                        if (z == 4)
                        {
                            Separator_Default(Separator4);
                            Separator_True(Separator5);
                            ColorLabel_True(label4);
                            z++; return;
                        }
                        if (z == 5)
                        {
                            Separator_Default(Separator5);
                            Separator_True(Separator6);
                            ColorLabel_True(label5);
                            z++; return;
                        }
                        if (z == 6)
                        {
                            Separator_Default(Separator6);
                            Separator_True(Separator7);
                            ColorLabel_True(label6);
                            z++; return;
                        }
                        if (z == 7)
                        {
                            ColorLabel_True(label7);
                            z++;
                            MessageBox.Show("Hoan Thanh");
                            Application.Exit(); return;
                        }
                    }
                    else
                    {
                        Button_False(btnw);
                    }
                    break;
                case Keys.E:
                    string keye = btne.Text;

                    if (string.Compare(keye, stringlabel, true) == 0)
                    {
                        Button_True(btne);

                        if (z == 0)
                        {
                            Separator_Default(Separator);
                            Separator_True(Separator1);
                            ColorLabel_True(label);
                            z++;
                            return;
                        }
                        if (z == 1)
                        {
                            Separator_Default(Separator1);
                            Separator_True(Separator2);
                            ColorLabel_True(label1);
                            z++;
                            return;
                        }
                        if (z == 2)
                        {
                            Separator_Default(Separator2);
                            Separator_True(Separator3);
                            ColorLabel_True(label2);
                            z++; return;
                        }
                        if (z == 3)
                        {
                            Separator_Default(Separator3);
                            Separator_True(Separator4);
                            ColorLabel_True(label3);
                            z++; return;
                        }
                        if (z == 4)
                        {
                            Separator_Default(Separator4);
                            Separator_True(Separator5);
                            ColorLabel_True(label4);
                            z++; return;
                        }
                        if (z == 5)
                        {
                            Separator_Default(Separator5);
                            Separator_True(Separator6);
                            ColorLabel_True(label5);
                            z++; return;
                        }
                        if (z == 6)
                        {
                            Separator_Default(Separator6);
                            Separator_True(Separator7);
                            ColorLabel_True(label6);
                            z++; return;
                        }
                        if (z == 7)
                        {

                            ColorLabel_True(label7);
                            z++;
                            MessageBox.Show("Hoan Thanh");
                            Application.Exit(); return;
                        }
                    }
                    else
                    {
                        Button_False(btne);
                    }
                    break;
                case Keys.R:
                    string r = btnr.Text;

                    if (string.Compare(r, stringlabel, true) == 0)
                    {
                        Button_True(btnr);

                        if (z == 0)
                        {
                            Separator_Default(Separator);
                            Separator_True(Separator1);
                            ColorLabel_True(label);
                            z++;
                            return;
                        }
                        if (z == 1)
                        {
                            Separator_Default(Separator1);
                            Separator_True(Separator2);
                            ColorLabel_True(label1);
                            z++;
                            return;
                        }
                        if (z == 2)
                        {
                            Separator_Default(Separator2);
                            Separator_True(Separator3);
                            ColorLabel_True(label2);
                            z++; return;
                        }
                        if (z == 3)
                        {
                            Separator_Default(Separator3);
                            Separator_True(Separator4);
                            ColorLabel_True(label3);
                            z++; return;
                        }
                        if (z == 4)
                        {
                            Separator_Default(Separator4);
                            Separator_True(Separator5);
                            ColorLabel_True(label4);
                            z++; return;
                        }
                        if (z == 5)
                        {
                            Separator_Default(Separator5);
                            Separator_True(Separator6);
                            ColorLabel_True(label5);
                            z++; return;
                        }
                        if (z == 6)
                        {
                            Separator_Default(Separator6);
                            Separator_True(Separator7);
                            ColorLabel_True(label6);
                            z++; return;
                        }
                        if (z == 7)
                        {
                            ColorLabel_True(label7);
                            z++;
                            MessageBox.Show("Hoan Thanh");
                            Application.Exit(); return;
                        }
                    }
                    else
                    {
                        Button_False(btnr);
                    }
                    break;
                case Keys.T:
                    string t = btnt.Text;

                    if (string.Compare(t, stringlabel, true) == 0)
                    {
                        Button_True(btnt);

                        if (z == 0)
                        {
                            Separator_Default(Separator);
                            Separator_True(Separator1);
                            ColorLabel_True(label);
                            z++;
                            return;
                        }
                        if (z == 1)
                        {
                            Separator_Default(Separator1);
                            Separator_True(Separator2);
                            ColorLabel_True(label1);
                            z++;
                            return;
                        }
                        if (z == 2)
                        {
                            Separator_Default(Separator2);
                            Separator_True(Separator3);
                            ColorLabel_True(label2);
                            z++; return;
                        }
                        if (z == 3)
                        {
                            Separator_Default(Separator3);
                            Separator_True(Separator4);
                            ColorLabel_True(label3);
                            z++; return;
                        }
                        if (z == 4)
                        {
                            Separator_Default(Separator4);
                            Separator_True(Separator5);
                            ColorLabel_True(label4);
                            z++; return;
                        }
                        if (z == 5)
                        {
                            Separator_Default(Separator5);
                            Separator_True(Separator6);
                            ColorLabel_True(label5);
                            z++; return;
                        }
                        if (z == 6)
                        {
                            Separator_Default(Separator6);
                            Separator_True(Separator7);
                            ColorLabel_True(label6);
                            z++; return;
                        }
                        if (z == 7)
                        {
                            ColorLabel_True(label7);
                            z++;
                            MessageBox.Show("Hoan Thanh");
                            Application.Exit(); return;
                        }
                    }
                    else
                    {
                        Button_False(btnt);
                    }
                    break;
                case Keys.Y:
                    string y = btny.Text;

                    if (string.Compare(y, stringlabel, true) == 0)
                    {
                        Button_True(btny);

                        if (z == 0)
                        {
                            Separator_Default(Separator);
                            Separator_True(Separator1);
                            ColorLabel_True(label);
                            z++;
                            return;
                        }
                        if (z == 1)
                        {
                            Separator_Default(Separator1);
                            Separator_True(Separator2);
                            ColorLabel_True(label1);
                            z++;
                            return;
                        }
                        if (z == 2)
                        {
                            Separator_Default(Separator2);
                            Separator_True(Separator3);
                            ColorLabel_True(label2);
                            z++; return;
                        }
                        if (z == 3)
                        {
                            Separator_Default(Separator3);
                            Separator_True(Separator4);
                            ColorLabel_True(label3);
                            z++; return;
                        }
                        if (z == 4)
                        {
                            Separator_Default(Separator4);
                            Separator_True(Separator5);
                            ColorLabel_True(label4);
                            z++; return;
                        }
                        if (z == 5)
                        {
                            Separator_Default(Separator5);
                            Separator_True(Separator6);
                            ColorLabel_True(label5);
                            z++; return;
                        }
                        if (z == 6)
                        {
                            Separator_Default(Separator6);
                            Separator_True(Separator7);
                            ColorLabel_True(label6);
                            z++; return;
                        }
                        if (z == 7)
                        {
                            ColorLabel_True(label7);
                            z++;
                            MessageBox.Show("Hoan Thanh");
                            Application.Exit(); return;
                        }
                    }
                    else
                    {
                        Button_False(btny);
                    }
                    break;
                case Keys.U:
                    string u = btnu.Text;

                    if (string.Compare(u, stringlabel, true) == 0)
                    {
                        Button_True(btnu);

                        if (z == 0)
                        {
                            Separator_Default(Separator);
                            Separator_True(Separator1);
                            ColorLabel_True(label);
                            z++;
                            return;
                        }
                        if (z == 1)
                        {
                            Separator_Default(Separator1);
                            Separator_True(Separator2);
                            ColorLabel_True(label1);
                            z++;
                            return;
                        }
                        if (z == 2)
                        {
                            Separator_Default(Separator2);
                            Separator_True(Separator3);
                            ColorLabel_True(label2);
                            z++; return;
                        }
                        if (z == 3)
                        {
                            Separator_Default(Separator3);
                            Separator_True(Separator4);
                            ColorLabel_True(label3);
                            z++; return;
                        }
                        if (z == 4)
                        {
                            Separator_Default(Separator4);
                            Separator_True(Separator5);
                            ColorLabel_True(label4);
                            z++; return;
                        }
                        if (z == 5)
                        {
                            Separator_Default(Separator5);
                            Separator_True(Separator6);
                            ColorLabel_True(label5);
                            z++; return;
                        }
                        if (z == 6)
                        {
                            Separator_Default(Separator6);
                            Separator_True(Separator7);
                            ColorLabel_True(label6);
                            z++; return;
                        }
                        if (z == 7)
                        {
                            ColorLabel_True(label7);
                            z++;
                            MessageBox.Show("Hoan Thanh");
                            Application.Exit(); return;
                        }
                    }
                    else
                    {
                        Button_False(btnu);
                    }
                    break;
                case Keys.I:
                    string i = btni.Text;

                    if (string.Compare(i, stringlabel, true) == 0)
                    {
                        Button_True(btni);

                        if (z == 0)
                        {
                            Separator_Default(Separator);
                            Separator_True(Separator1);
                            ColorLabel_True(label);
                            z++;
                            return;
                        }
                        if (z == 1)
                        {
                            Separator_Default(Separator1);
                            Separator_True(Separator2);
                            ColorLabel_True(label1);
                            z++;
                            return;
                        }
                        if (z == 2)
                        {
                            Separator_Default(Separator2);
                            Separator_True(Separator3);
                            ColorLabel_True(label2);
                            z++; return;
                        }
                        if (z == 3)
                        {
                            Separator_Default(Separator3);
                            Separator_True(Separator4);
                            ColorLabel_True(label3);
                            z++; return;
                        }
                        if (z == 4)
                        {
                            Separator_Default(Separator4);
                            Separator_True(Separator5);
                            ColorLabel_True(label4);
                            z++; return;
                        }
                        if (z == 5)
                        {
                            Separator_Default(Separator5);
                            Separator_True(Separator6);
                            ColorLabel_True(label5);
                            z++; return;
                        }
                        if (z == 6)
                        {
                            Separator_Default(Separator6);
                            Separator_True(Separator7);
                            ColorLabel_True(label6);
                            z++; return;
                        }
                        if (z == 7)
                        {
                            ColorLabel_True(label7);
                            z++;
                            MessageBox.Show("Hoan Thanh");
                            Application.Exit(); return;
                        }
                    }
                    else
                    {
                        Button_False(btni);
                    }

                    break;
                case Keys.O:
                    string o = btno.Text;

                    if (string.Compare(o, stringlabel, true) == 0)
                    {
                        Button_True(btno);

                        if (z == 0)
                        {
                            Separator_Default(Separator);
                            Separator_True(Separator1);
                            ColorLabel_True(label);
                            z++;
                            return;
                        }
                        if (z == 1)
                        {
                            Separator_Default(Separator1);
                            Separator_True(Separator2);
                            ColorLabel_True(label1);
                            z++;
                            return;
                        }
                        if (z == 2)
                        {
                            Separator_Default(Separator2);
                            Separator_True(Separator3);
                            ColorLabel_True(label2);
                            z++; return;
                        }
                        if (z == 3)
                        {
                            Separator_Default(Separator3);
                            Separator_True(Separator4);
                            ColorLabel_True(label3);
                            z++; return;
                        }
                        if (z == 4)
                        {
                            Separator_Default(Separator4);
                            Separator_True(Separator5);
                            ColorLabel_True(label4);
                            z++; return;
                        }
                        if (z == 5)
                        {
                            Separator_Default(Separator5);
                            Separator_True(Separator6);
                            ColorLabel_True(label5);
                            z++; return;
                        }
                        if (z == 6)
                        {
                            Separator_Default(Separator6);
                            Separator_True(Separator7);
                            ColorLabel_True(label6);
                            z++; return;
                        }
                        if (z == 7)
                        {
                            ColorLabel_True(label7);
                            z++;
                            MessageBox.Show("Hoan Thanh");
                            Application.Exit(); return;
                        }
                    }
                    else
                    {
                        Button_False(btno);
                    }
                    break;
                case Keys.P:
                    string p = btnp.Text;

                    if (string.Compare(p, stringlabel, true) == 0)
                    {
                        Button_True(btnp);

                        if (z == 0)
                        {
                            Separator_Default(Separator);
                            Separator_True(Separator1);
                            ColorLabel_True(label);
                            z++;
                            return;
                        }
                        if (z == 1)
                        {
                            Separator_Default(Separator1);
                            Separator_True(Separator2);
                            ColorLabel_True(label1);
                            z++;
                            return;
                        }
                        if (z == 2)
                        {
                            Separator_Default(Separator2);
                            Separator_True(Separator3);
                            ColorLabel_True(label2);
                            z++; return;
                        }
                        if (z == 3)
                        {
                            Separator_Default(Separator3);
                            Separator_True(Separator4);
                            ColorLabel_True(label3);
                            z++; return;
                        }
                        if (z == 4)
                        {
                            Separator_Default(Separator4);
                            Separator_True(Separator5);
                            ColorLabel_True(label4);
                            z++; return;
                        }
                        if (z == 5)
                        {
                            Separator_Default(Separator5);
                            Separator_True(Separator6);
                            ColorLabel_True(label5);
                            z++; return;
                        }
                        if (z == 6)
                        {
                            Separator_Default(Separator6);
                            Separator_True(Separator7);
                            ColorLabel_True(label6);
                            z++; return;
                        }
                        if (z == 7)
                        {
                            ColorLabel_True(label7);
                            z++;
                            MessageBox.Show("Hoan Thanh");
                            Application.Exit(); return;
                        }
                    }
                    else
                    {
                        Button_False(btnp);
                    }
                    break;
                case Keys.A:
                    string a = btna.Text;
                    if (string.Compare(a, stringlabel, true) == 0)
                    {
                        Button_True(btna);



                        if (z == 0)
                        {
                            Separator_Default(Separator);
                            Separator_True(Separator1);
                            ColorLabel_True(label);
                            z++; return;
                        }
                        if (z == 1)
                        {
                            Separator_Default(Separator1);
                            Separator_True(Separator2);
                            ColorLabel_True(label1);
                            z++; return;
                        }
                        if (z == 2)
                        {
                            Separator_Default(Separator2);
                            Separator_True(Separator3);
                            ColorLabel_True(label2);
                            z++; return;
                        }
                        if (z == 3)
                        {
                            Separator_Default(Separator3);
                            Separator_True(Separator4);
                            ColorLabel_True(label3);
                            z++; return;
                        }
                        if (z == 4)
                        {
                            Separator_Default(Separator4);
                            Separator_True(Separator5);
                            ColorLabel_True(label4);
                            z++; return;
                        }
                        if (z == 5)
                        {
                            Separator_Default(Separator5);
                            Separator_True(Separator6);
                            ColorLabel_True(label5);
                            z++; return;
                        }
                        if (z == 6)
                        {
                            Separator_Default(Separator6);
                            Separator_True(Separator7);
                            ColorLabel_True(label6);
                            z++; return;
                        }
                        if (z == 7)
                        {
                            ColorLabel_True(label7);
                            z++;
                            MessageBox.Show("Hoan Thanh");
                            Application.Exit(); return;
                        }

                    }
                    else
                    {
                        Button_False(btna);
                    }
                    break;
                case Keys.S:

                    string s = btns.Text;
                    if (string.Compare(s, stringlabel, true) == 0)
                    {
                        Button_True(btns);

                        if (z == 0)
                        {
                            Separator_Default(Separator);
                            Separator_True(Separator1);
                            ColorLabel_True(label);
                            z++; return;
                        }
                        if (z == 1)
                        {
                            Separator_Default(Separator1);
                            Separator_True(Separator2);
                            ColorLabel_True(label1);
                            z++; return;
                        }
                        if (z == 2)
                        {
                            Separator_Default(Separator2);
                            Separator_True(Separator3);
                            ColorLabel_True(label2);
                            z++; return;
                        }
                        if (z == 3)
                        {
                            Separator_Default(Separator3);
                            Separator_True(Separator4);
                            ColorLabel_True(label3);
                            z++; return;
                        }
                        if (z == 4)
                        {
                            Separator_Default(Separator4);
                            Separator_True(Separator5);
                            ColorLabel_True(label4);
                            z++; return;
                        }
                        if (z == 5)
                        {
                            Separator_Default(Separator5);
                            Separator_True(Separator6);
                            ColorLabel_True(label5);
                            z++; return;
                        }
                        if (z == 6)
                        {
                            Separator_Default(Separator6);
                            Separator_True(Separator7);
                            ColorLabel_True(label6);
                            z++; return;
                        }
                        if (z == 7)
                        {
                            ColorLabel_True(label7);
                            z++;
                            MessageBox.Show("Hoan Thanh");
                            Application.Exit(); return;
                        }

                    }
                    else
                    {
                        Button_False(btns);
                    }
                    break;
                case Keys.D:
                    string d = btnd.Text;
                    if (string.Compare(d, stringlabel, true) == 0)
                    {
                        Button_True(btnd);

                        if (z == 0)
                        {
                            Separator_Default(Separator);
                            Separator_True(Separator1);
                            ColorLabel_True(label);
                            z++; return;
                        }
                        if (z == 1)
                        {
                            Separator_Default(Separator1);
                            Separator_True(Separator2);
                            ColorLabel_True(label1);
                            z++; return;
                        }
                        if (z == 2)
                        {
                            Separator_Default(Separator2);
                            Separator_True(Separator3);
                            ColorLabel_True(label2);
                            z++; return;
                        }
                        if (z == 3)
                        {
                            Separator_Default(Separator3);
                            Separator_True(Separator4);
                            ColorLabel_True(label3);
                            z++; return;
                        }
                        if (z == 4)
                        {
                            Separator_Default(Separator4);
                            Separator_True(Separator5);
                            ColorLabel_True(label4);
                            z++; return;
                        }
                        if (z == 5)
                        {
                            Separator_Default(Separator5);
                            Separator_True(Separator6);
                            ColorLabel_True(label5);
                            z++; return;
                        }
                        if (z == 6)
                        {
                            Separator_Default(Separator6);
                            Separator_True(Separator7);
                            ColorLabel_True(label6);
                            z++; return;
                        }
                        if (z == 7)
                        {
                            ColorLabel_True(label7);
                            z++;
                            MessageBox.Show("Hoan Thanh");
                            Application.Exit(); return;
                        }

                    }
                    else
                    {
                        Button_False(btnd);
                    }
                    break;
                case Keys.F:

                    string f = btnf.Text;
                    if (string.Compare(f, stringlabel, true) == 0)
                    {
                        Button_True(btnf);

                        if (z == 0)
                        {
                            Separator_Default(Separator);
                            Separator_True(Separator1);
                            ColorLabel_True(label);
                            z++; return;
                        }
                        if (z == 1)
                        {
                            Separator_Default(Separator1);
                            Separator_True(Separator2);
                            ColorLabel_True(label1);
                            z++; return;
                        }
                        if (z == 2)
                        {
                            Separator_Default(Separator2);
                            Separator_True(Separator3);
                            ColorLabel_True(label2);
                            z++; return;
                        }
                        if (z == 3)
                        {
                            Separator_Default(Separator3);
                            Separator_True(Separator4);
                            ColorLabel_True(label3);
                            z++; return;
                        }
                        if (z == 4)
                        {
                            Separator_Default(Separator4);
                            Separator_True(Separator5);
                            ColorLabel_True(label4);
                            z++; return;
                        }
                        if (z == 5)
                        {
                            Separator_Default(Separator5);
                            Separator_True(Separator6);
                            ColorLabel_True(label5);
                            z++; return;
                        }
                        if (z == 6)
                        {
                            Separator_Default(Separator6);
                            Separator_True(Separator7);
                            ColorLabel_True(label6);
                            z++; return;
                        }
                        if (z == 7)
                        {
                            ColorLabel_True(label7);
                            z++;
                            MessageBox.Show("Hoan Thanh");
                            Application.Exit(); return;
                        }

                    }
                    else
                    {
                        Button_False(btnf);
                    }
                    break;
                case Keys.G:

                    string g = btng.Text;
                    if (string.Compare(g, stringlabel, true) == 0)
                    {
                        Button_True(btng);

                        if (z == 0)
                        {
                            Separator_Default(Separator);
                            Separator_True(Separator1);
                            ColorLabel_True(label);
                            z++; return;
                        }
                        if (z == 1)
                        {
                            Separator_Default(Separator1);
                            Separator_True(Separator2);
                            ColorLabel_True(label1);
                            z++; return;
                        }
                        if (z == 2)
                        {
                            Separator_Default(Separator2);
                            Separator_True(Separator3);
                            ColorLabel_True(label2);
                            z++; return;
                        }
                        if (z == 3)
                        {
                            Separator_Default(Separator3);
                            Separator_True(Separator4);
                            ColorLabel_True(label3);
                            z++; return;
                        }
                        if (z == 4)
                        {
                            Separator_Default(Separator4);
                            Separator_True(Separator5);
                            ColorLabel_True(label4);
                            z++; return;
                        }
                        if (z == 5)
                        {
                            Separator_Default(Separator5);
                            Separator_True(Separator6);
                            ColorLabel_True(label5);
                            z++; return;
                        }
                        if (z == 6)
                        {
                            Separator_Default(Separator6);
                            Separator_True(Separator7);
                            ColorLabel_True(label6);
                            z++; return;
                        }
                        if (z == 7)
                        {

                            ColorLabel_True(label7);
                            z++;
                            MessageBox.Show("Hoan Thanh");
                            Application.Exit(); return;
                        }

                    }
                    else
                    {
                        Button_False(btng);
                    }
                    break;
                case Keys.H:
                    string h = btnh.Text;
                    if (string.Compare(h, stringlabel, true) == 0)
                    {
                        Button_True(btnh);

                        if (z == 0)
                        {
                            Separator_Default(Separator);
                            Separator_True(Separator1);
                            ColorLabel_True(label);
                            z++; return;
                        }
                        if (z == 1)
                        {
                            Separator_Default(Separator1);
                            Separator_True(Separator2);
                            ColorLabel_True(label1);
                            z++; return;
                        }
                        if (z == 2)
                        {
                            Separator_Default(Separator2);
                            Separator_True(Separator3);
                            ColorLabel_True(label2);
                            z++; return;
                        }
                        if (z == 3)
                        {
                            Separator_Default(Separator3);
                            Separator_True(Separator4);
                            ColorLabel_True(label3);
                            z++; return;
                        }
                        if (z == 4)
                        {
                            Separator_Default(Separator4);
                            Separator_True(Separator5);
                            ColorLabel_True(label4);
                            z++; return;
                        }
                        if (z == 5)
                        {
                            Separator_Default(Separator5);
                            Separator_True(Separator6);
                            ColorLabel_True(label5);
                            z++; return;
                        }
                        if (z == 6)
                        {
                            Separator_Default(Separator6);
                            Separator_True(Separator7);
                            ColorLabel_True(label6);
                            z++; return;
                        }
                        if (z == 7)
                        {
                            ColorLabel_True(label7);
                            z++;
                            MessageBox.Show("Hoan Thanh");
                            Application.Exit(); return;
                        }

                    }
                    else
                    {
                        Button_False(btnh);
                    }
                    break;
                case Keys.J:
                    string j = btnj.Text;
                    if (string.Compare(j, stringlabel, true) == 0)
                    {
                        Button_True(btnj);

                        if (z == 0)
                        {
                            Separator_Default(Separator);
                            Separator_True(Separator1);
                            ColorLabel_True(label);
                            z++; return;
                        }
                        if (z == 1)
                        {
                            Separator_Default(Separator1);
                            Separator_True(Separator2);
                            ColorLabel_True(label1);
                            z++; return;
                        }
                        if (z == 2)
                        {
                            Separator_Default(Separator2);
                            Separator_True(Separator3);
                            ColorLabel_True(label2);
                            z++; return;
                        }
                        if (z == 3)
                        {
                            Separator_Default(Separator3);
                            Separator_True(Separator4);
                            ColorLabel_True(label3);
                            z++; return;
                        }
                        if (z == 4)
                        {
                            Separator_Default(Separator4);
                            Separator_True(Separator5);
                            ColorLabel_True(label4);
                            z++; return;
                        }
                        if (z == 5)
                        {
                            Separator_Default(Separator5);
                            Separator_True(Separator6);
                            ColorLabel_True(label5);
                            z++; return;
                        }
                        if (z == 6)
                        {
                            Separator_Default(Separator6);
                            Separator_True(Separator7);
                            ColorLabel_True(label6);
                            z++; return;
                        }
                        if (z == 7)
                        {
                            ColorLabel_True(label7);
                            z++;
                            MessageBox.Show("Hoan Thanh");
                            Application.Exit(); return;
                        }

                    }
                    else
                    {
                        Button_False(btnj);
                    }
                    break;
                case Keys.K:
                    string keyk = btnk.Text;
                    if (string.Compare(keyk, stringlabel, true) == 0)
                    {
                        Button_True(btnk);

                        if (z == 0)
                        {

                            Separator_Default(Separator);
                            Separator_True(Separator1);
                            ColorLabel_True(label);
                            z++; return;


                           
                            z++; return;
                        }
                        if (z == 1)
                        {
                            Separator_Default(Separator1);
                            Separator_True(Separator2);
                            ColorLabel_True(label1);
                            z++; return;
                        }
                        if (z == 2)
                        {
                            Separator_Default(Separator2);
                            Separator_True(Separator3);
                            ColorLabel_True(label2);
                            z++; return;
                        }
                        if (z == 3)
                        {
                            Separator_Default(Separator3);
                            Separator_True(Separator4);
                            ColorLabel_True(label3);
                            z++; return;
                        }
                        if (z == 4)
                        {
                            Separator_Default(Separator4);
                            Separator_True(Separator5);
                            ColorLabel_True(label4);
                            z++; return;
                        }
                        if (z == 5)
                        {
                            Separator_Default(Separator5);
                            Separator_True(Separator6);
                            ColorLabel_True(label5);
                            z++; return;
                        }
                        if (z == 6)
                        {
                            Separator_Default(Separator6);
                            Separator_True(Separator7);
                            ColorLabel_True(label6);
                            z++; return;
                        }
                        if (z == 7)
                        {
                            ColorLabel_True(label7);
                            z++;
                            MessageBox.Show("Hoan Thanh");
                            Application.Exit(); return;
                        }

                    }
                    else
                    {
                        Button_False(btnk);
                    }
                    break;
                case Keys.L:
                    string l = btnl.Text;
                    if (string.Compare(l, stringlabel, true) == 0)
                    {
                        Button_True(btnl);

                        if (z == 0)
                        {
                            Separator_Default(Separator);
                            Separator_True(Separator1);
                            ColorLabel_True(label);
                            z++; return;
                        }
                        if (z == 1)
                        {
                            Separator_Default(Separator1);
                            Separator_True(Separator2);
                            ColorLabel_True(label1);
                            z++; return;
                        }
                        if (z == 2)
                        {
                            Separator_Default(Separator2);
                            Separator_True(Separator3);
                            ColorLabel_True(label2);
                            z++; return;
                        }
                        if (z == 3)
                        {
                            Separator_Default(Separator3);
                            Separator_True(Separator4);
                            ColorLabel_True(label3);
                            z++; return;
                        }
                        if (z == 4)
                        {
                            Separator_Default(Separator4);
                            Separator_True(Separator5);
                            ColorLabel_True(label4);
                            z++; return;
                        }
                        if (z == 5)
                        {
                            Separator_Default(Separator5);
                            Separator_True(Separator6);
                            ColorLabel_True(label5);
                            z++; return;
                        }
                        if (z == 6)
                        {
                            Separator_Default(Separator6);
                            Separator_True(Separator7);
                            ColorLabel_True(label6);
                            z++; return;
                        }
                        if (z == 7)
                        {
                            ColorLabel_True(label7);
                            z++;
                            MessageBox.Show("Hoan Thanh");
                            Application.Exit(); return;
                        }

                    }
                    else
                    {
                        Button_False(btnl);
                    }
                    break;
                case Keys.Z:
                    string keyz = btnz.Text;
                    if (string.Compare(keyz, stringlabel, true) == 0)
                    {
                        Button_True(btnz);

                        if (z == 0)
                        {
                            Separator_Default(Separator);
                            Separator_True(Separator1);
                            ColorLabel_True(label);
                            z++; return;
                        }
                        if (z == 1)
                        {
                            Separator_Default(Separator1);
                            Separator_True(Separator2);
                            ColorLabel_True(label1);
                            z++; return;
                        }
                        if (z == 2)
                        {
                            Separator_Default(Separator2);
                            Separator_True(Separator3);
                            ColorLabel_True(label2);
                            z++; return;
                        }
                        if (z == 3)
                        {
                            Separator_Default(Separator3);
                            Separator_True(Separator4);
                            ColorLabel_True(label3);
                            z++; return;
                        }
                        if (z == 4)
                        {
                            Separator_Default(Separator4);
                            Separator_True(Separator5);
                            ColorLabel_True(label4);
                            z++; return;
                        }
                        if (z == 5)
                        {
                            Separator_Default(Separator5);
                            Separator_True(Separator6);
                            ColorLabel_True(label5);
                            z++; return;
                        }
                        if (z == 6)
                        {
                            Separator_Default(Separator6);
                            Separator_True(Separator7);
                            ColorLabel_True(label6);
                            z++; return;
                        }
                        if (z == 7)
                        {
                            ColorLabel_True(label7);
                            z++;
                            MessageBox.Show("Hoan Thanh");
                            Application.Exit(); return;
                        }

                    }
                    else
                    {
                        Button_False(btnz);
                    }
                    break;
                case Keys.X:
                    string x = btnx.Text;
                    if (string.Compare(x, stringlabel, true) == 0)
                    {
                        Button_True(btnx);

                        if (z == 0)
                        {
                            Separator_Default(Separator);
                            Separator_True(Separator1);
                            ColorLabel_True(label);
                            z++; return;
                        }
                        if (z == 1)
                        {
                            Separator_Default(Separator1);
                            Separator_True(Separator2);
                            ColorLabel_True(label1);
                            z++; return;
                        }
                        if (z == 2)
                        {
                            Separator_Default(Separator2);
                            Separator_True(Separator3);
                            ColorLabel_True(label2);
                            z++; return;
                        }
                        if (z == 3)
                        {
                            Separator_Default(Separator3);
                            Separator_True(Separator4);
                            ColorLabel_True(label3);
                            z++; return;
                        }
                        if (z == 4)
                        {
                            Separator_Default(Separator4);
                            Separator_True(Separator5);
                            ColorLabel_True(label4);
                            z++; return;
                        }
                        if (z == 5)
                        {
                            Separator_Default(Separator5);
                            Separator_True(Separator6);
                            ColorLabel_True(label5);
                            z++; return;
                        }
                        if (z == 6)
                        {
                            Separator_Default(Separator6);
                            Separator_True(Separator7);
                            ColorLabel_True(label6);
                            z++; return;
                        }
                        if (z == 7)
                        {
                            ColorLabel_True(label7);
                            z++;
                            MessageBox.Show("Hoan Thanh");
                            Application.Exit(); return;
                        }

                    }
                    else
                    {
                        Button_False(btnx);
                    }
                    break;
                case Keys.C:
                    string c = btnc.Text;
                    if (string.Compare(c, stringlabel, true) == 0)
                    {
                        Button_True(btnc);

                        if (z == 0)
                        {
                            Separator_Default(Separator);
                            Separator_True(Separator1);
                            ColorLabel_True(label);
                            z++; return;
                        }
                        if (z == 1)
                        {
                            Separator_Default(Separator1);
                            Separator_True(Separator2);
                            ColorLabel_True(label1);
                            z++; return;
                        }
                        if (z == 2)
                        {
                            Separator_Default(Separator2);
                            Separator_True(Separator3);
                            ColorLabel_True(label2);
                            z++; return;
                        }
                        if (z == 3)
                        {
                            Separator_Default(Separator3);
                            Separator_True(Separator4);
                            ColorLabel_True(label3);
                            z++; return;
                        }
                        if (z == 4)
                        {
                            Separator_Default(Separator4);
                            Separator_True(Separator5);
                            ColorLabel_True(label4);
                            z++; return;
                        }
                        if (z == 5)
                        {
                            Separator_Default(Separator5);
                            Separator_True(Separator6);
                            ColorLabel_True(label5);
                            z++; return;
                        }
                        if (z == 6)
                        {
                            Separator_Default(Separator6);
                            Separator_True(Separator7);
                            ColorLabel_True(label6);
                            z++; return;
                        }
                        if (z == 7)
                        {
                            ColorLabel_True(label7);
                            z++;
                            MessageBox.Show("Hoan Thanh");
                            Application.Exit(); return;
                        }

                    }
                    else
                    {
                        Button_False(btnc);
                    }
                    break;
                case Keys.V:
                    string v = btnv.Text;
                    if (string.Compare(v, stringlabel, true) == 0)
                    {
                        Button_True(btnv);

                        if (z == 0)
                        {
                            Separator_Default(Separator);
                            Separator_True(Separator1);
                            ColorLabel_True(label);
                            z++; return;
                        }
                        if (z == 1)
                        {
                            Separator_Default(Separator1);
                            Separator_True(Separator2);
                            ColorLabel_True(label1);
                            z++; return;
                        }
                        if (z == 2)
                        {
                            Separator_Default(Separator2);
                            Separator_True(Separator3);
                            ColorLabel_True(label2);
                            z++; return;
                        }
                        if (z == 3)
                        {
                            Separator_Default(Separator3);
                            Separator_True(Separator4);
                            ColorLabel_True(label3);
                            z++; return;
                        }
                        if (z == 4)
                        {
                            Separator_Default(Separator4);
                            Separator_True(Separator5);
                            ColorLabel_True(label4);
                            z++; return;
                        }
                        if (z == 5)
                        {
                            Separator_Default(Separator5);
                            Separator_True(Separator6);
                            ColorLabel_True(label5);
                            z++; return;
                        }
                        if (z == 6)
                        {
                            Separator_Default(Separator6);
                            Separator_True(Separator7);
                            ColorLabel_True(label6);
                            z++; return;
                        }
                        if (z == 7)
                        {
                            ColorLabel_True(label7);
                            z++;
                            MessageBox.Show("Hoan Thanh");
                            Application.Exit(); return;
                        }

                    }
                    else
                    {
                        Button_False(btnv);
                    }
                    break;
                case Keys.B:
                    string b = btnb.Text;
                    if (string.Compare(b, stringlabel, true) == 0)
                    {
                        Button_True(btnb);

                        if (z == 0)
                        {
                            Separator_Default(Separator);
                            Separator_True(Separator1);
                            ColorLabel_True(label);
                            z++; return;
                        }
                        if (z == 1)
                        {
                            Separator_Default(Separator1);
                            Separator_True(Separator2);
                            ColorLabel_True(label1);
                            z++; return;
                        }
                        if (z == 2)
                        {
                            Separator_Default(Separator2);
                            Separator_True(Separator3);
                            ColorLabel_True(label2);
                            z++; return;
                        }
                        if (z == 3)
                        {
                            Separator_Default(Separator3);
                            Separator_True(Separator4);
                            ColorLabel_True(label3);
                            z++; return;
                        }
                        if (z == 4)
                        {
                            Separator_Default(Separator4);
                            Separator_True(Separator5);
                            ColorLabel_True(label4);
                            z++; return;
                        }
                        if (z == 5)
                        {
                            Separator_Default(Separator5);
                            Separator_True(Separator6);
                            ColorLabel_True(label5);
                            z++; return;
                        }
                        if (z == 6)
                        {
                            Separator_Default(Separator6);
                            Separator_True(Separator7);
                            ColorLabel_True(label6);
                            z++; return;
                        }
                        if (z == 7)
                        {
                            ColorLabel_True(label7);
                            z++;
                            MessageBox.Show("Hoan Thanh");
                            Application.Exit(); return;
                        }

                    }
                    else
                    {
                        Button_False(btnb);
                    }
                    break;
                case Keys.N:
                    string n = btnn.Text;
                    if (string.Compare(n, stringlabel, true) == 0)
                    {
                        Button_True(btnn);

                        if (z == 0)
                        {
                            Separator_Default(Separator);
                            Separator_True(Separator1);
                            ColorLabel_True(label);
                            z++; return;
                        }
                        if (z == 1)
                        {
                            Separator_Default(Separator1);
                            Separator_True(Separator2);
                            ColorLabel_True(label1);
                            z++; return;
                        }
                        if (z == 2)
                        {
                            Separator_Default(Separator2);
                            Separator_True(Separator3);
                            ColorLabel_True(label2);
                            z++; return;
                        }
                        if (z == 3)
                        {
                            Separator_Default(Separator3);
                            Separator_True(Separator4);
                            ColorLabel_True(label3);
                            z++; return;
                        }
                        if (z == 4)
                        {
                            Separator_Default(Separator4);
                            Separator_True(Separator5);
                            ColorLabel_True(label4);
                            z++; return;
                        }
                        if (z == 5)
                        {
                            Separator_Default(Separator5);
                            Separator_True(Separator6);
                            ColorLabel_True(label5);
                            z++; return;
                        }
                        if (z == 6)
                        {
                            Separator_Default(Separator6);
                            Separator_True(Separator7);
                            ColorLabel_True(label6);
                            z++; return;
                        }
                        if (z == 7)
                        {
                            ColorLabel_True(label7);
                            z++;
                            MessageBox.Show("Hoan Thanh");
                            Application.Exit(); return;
                        }

                    }
                    else
                    {
                        Button_False(btnn);
                    }
                    break;
                case Keys.M:
                    string m = btnm.Text;
                    if (string.Compare(m, stringlabel, true) == 0)
                    {
                        Button_True(btnf);

                        if (z == 0)
                        {
                            Separator_Default(Separator);
                            Separator_True(Separator1);
                            ColorLabel_True(label);
                            z++; return;
                        }
                        if (z == 1)
                        {
                            Separator_Default(Separator1);
                            Separator_True(Separator2);
                            ColorLabel_True(label1);
                            z++; return;
                        }
                        if (z == 2)
                        {
                            Separator_Default(Separator2);
                            Separator_True(Separator3);
                            ColorLabel_True(label2);
                            z++; return;
                        }
                        if (z == 3)
                        {
                            Separator_Default(Separator3);
                            Separator_True(Separator4);
                            ColorLabel_True(label3);
                            z++; return;
                        }
                        if (z == 4)
                        {
                            Separator_Default(Separator4);
                            Separator_True(Separator5);
                            ColorLabel_True(label4);
                            z++; return;
                        }
                        if (z == 5)
                        {
                            Separator_Default(Separator5);
                            Separator_True(Separator6);
                            ColorLabel_True(label5);
                            z++; return;
                        }
                        if (z == 6)
                        {
                            Separator_Default(Separator6);
                            Separator_True(Separator7);
                            ColorLabel_True(label6);
                            z++; return;
                        }
                        if (z == 7)
                        {
                            ColorLabel_True(label7);
                            z++;
                            MessageBox.Show("Hoan Thanh");
                            Application.Exit(); return;
                        }

                    }
                    else
                    {
                        Button_False(btnm);
                    }
                    break;





            }
        }

        private void Frm_LuyenTap_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {

                case Keys.Q: Button_Default(btnq); break;
                case Keys.W: Button_Default(btnw); break;
                case Keys.E: Button_Default(btne); break;
                case Keys.R: Button_Default(btnr); break;
                case Keys.T: Button_Default(btnt); break;
                case Keys.Y: Button_Default(btny); break;
                case Keys.U: Button_Default(btnu); break;
                case Keys.I: Button_Default(btni); break;
                case Keys.O: Button_Default(btno); break;
                case Keys.P: Button_Default(btnp); break;
                case Keys.A: Button_Default(btna);


                    break;



                case Keys.S: Button_Default(btns); break;

                case Keys.D: Button_Default(btnd); break;
                case Keys.F: Button_Default(btnf); break;
                case Keys.G: Button_Default(btng); break;
                case Keys.H: Button_Default(btnh); break;
                case Keys.J: Button_Default(btnj); break;
                case Keys.K: Button_Default(btnk); break;
                case Keys.L: Button_Default(btnl); break;
                case Keys.Z: Button_Default(btnz); break;
                case Keys.X: Button_Default(btnx); break;
                case Keys.C: Button_Default(btnc); break;
                case Keys.V: Button_Default(btnv); break;
                case Keys.B: Button_Default(btnb); break;
                case Keys.N: Button_Default(btnn); break;
                case Keys.M: Button_Default(btnm); break;
                case Keys.Space: Button_Default(btnspace); break;
            }
        }


    }
}
