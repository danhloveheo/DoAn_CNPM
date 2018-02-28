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
        string[] mang = new string[8];
        private void Frm_LuyenTap_Load(object sender, EventArgs e)
        {

            for (int i = 0; i < 8; i++)
            {
                mang[i] = RandomString(1, true);
                for (int j = 0; j < 3; j++)
                {

                    Frm_LuyenTap p = new Frm_LuyenTap();


                }

            }

            label.Text = mang[0];
            label1.Text = mang[1];
            label2.Text = mang[2];
            label3.Text = mang[3];
            label4.Text = mang[4];
            label5.Text = mang[5];
            label6.Text = mang[6];
            label7.Text = mang[7];

            this.KeyPreview = true;
            Separator_True(Separator);
            Separator.BackColor = Color.LightSeaGreen;
        }
        private void Separator_True(Panel sp)
        {
            sp.BackColor = Color.LightSeaGreen;

        }
        private void Separator_Default(Panel sp)
        {
            sp.BackColor = Color.LightGray;

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
            btn.BackColor = Color.PaleVioletRed;
        }

        private void ColorLabel_True(Label lb)
        {
            lb.BackColor = Color.LightSeaGreen;
        }
        private void ColorLabel_False(Label lb)
        {
            lb.BackColor = Color.PaleVioletRed;
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
                        if (z == 0)
                        {
                            ColorLabel_False(label);
                        }
                        if (z == 1)
                        {
                            ColorLabel_False(label1);
                        }
                        if (z == 2)
                        {
                            ColorLabel_False(label2);
                        }
                        if (z == 3)
                        {
                            ColorLabel_False(label3);
                        }
                        if (z == 4)
                        {
                            ColorLabel_False(label4);
                        }
                        if (z == 5)
                        {
                            ColorLabel_False(label5);
                        }
                        if (z == 6)
                        {
                            ColorLabel_False(label6);
                        }
                        if (z == 7)
                        {
                            ColorLabel_False(label7);
                        }

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
                        if (z == 0)
                        {
                            ColorLabel_False(label);
                        }
                        if (z == 1)
                        {
                            ColorLabel_False(label1);
                        }
                        if (z == 2)
                        {
                            ColorLabel_False(label2);
                        }
                        if (z == 3)
                        {
                            ColorLabel_False(label3);
                        }
                        if (z == 4)
                        {
                            ColorLabel_False(label4);
                        }
                        if (z == 5)
                        {
                            ColorLabel_False(label5);
                        }
                        if (z == 6)
                        {
                            ColorLabel_False(label6);
                        }
                        if (z == 7)
                        {
                            ColorLabel_False(label7);
                        }
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
                        if (z == 0)
                        {
                            ColorLabel_False(label);
                        }
                        if (z == 1)
                        {
                            ColorLabel_False(label1);
                        }
                        if (z == 2)
                        {
                            ColorLabel_False(label2);
                        }
                        if (z == 3)
                        {
                            ColorLabel_False(label3);
                        }
                        if (z == 4)
                        {
                            ColorLabel_False(label4);
                        }
                        if (z == 5)
                        {
                            ColorLabel_False(label5);
                        }
                        if (z == 6)
                        {
                            ColorLabel_False(label6);
                        }
                        if (z == 7)
                        {
                            ColorLabel_False(label7);
                        }
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
                        if (z == 0)
                        {
                            ColorLabel_False(label);
                        }
                        if (z == 1)
                        {
                            ColorLabel_False(label1);
                        }
                        if (z == 2)
                        {
                            ColorLabel_False(label2);
                        }
                        if (z == 3)
                        {
                            ColorLabel_False(label3);
                        }
                        if (z == 4)
                        {
                            ColorLabel_False(label4);
                        }
                        if (z == 5)
                        {
                            ColorLabel_False(label5);
                        }
                        if (z == 6)
                        {
                            ColorLabel_False(label6);
                        }
                        if (z == 7)
                        {
                            ColorLabel_False(label7);
                        }
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
                        if (z == 0)
                        {
                            ColorLabel_False(label);
                        }
                        if (z == 1)
                        {
                            ColorLabel_False(label1);
                        }
                        if (z == 2)
                        {
                            ColorLabel_False(label2);
                        }
                        if (z == 3)
                        {
                            ColorLabel_False(label3);
                        }
                        if (z == 4)
                        {
                            ColorLabel_False(label4);
                        }
                        if (z == 5)
                        {
                            ColorLabel_False(label5);
                        }
                        if (z == 6)
                        {
                            ColorLabel_False(label6);
                        }
                        if (z == 7)
                        {
                            ColorLabel_False(label7);
                        }
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
                        if (z == 0)
                        {
                            ColorLabel_False(label);
                        }
                        if (z == 1)
                        {
                            ColorLabel_False(label1);
                        }
                        if (z == 2)
                        {
                            ColorLabel_False(label2);
                        }
                        if (z == 3)
                        {
                            ColorLabel_False(label3);
                        }
                        if (z == 4)
                        {
                            ColorLabel_False(label4);
                        }
                        if (z == 5)
                        {
                            ColorLabel_False(label5);
                        }
                        if (z == 6)
                        {
                            ColorLabel_False(label6);
                        }
                        if (z == 7)
                        {
                            ColorLabel_False(label7);
                        }
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
                        if (z == 0)
                        {
                            ColorLabel_False(label);
                        }
                        if (z == 1)
                        {
                            ColorLabel_False(label1);
                        }
                        if (z == 2)
                        {
                            ColorLabel_False(label2);
                        }
                        if (z == 3)
                        {
                            ColorLabel_False(label3);
                        }
                        if (z == 4)
                        {
                            ColorLabel_False(label4);
                        }
                        if (z == 5)
                        {
                            ColorLabel_False(label5);
                        }
                        if (z == 6)
                        {
                            ColorLabel_False(label6);
                        }
                        if (z == 7)
                        {
                            ColorLabel_False(label7);
                        }
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
                        if (z == 0)
                        {
                            ColorLabel_False(label);
                        }
                        if (z == 1)
                        {
                            ColorLabel_False(label1);
                        }
                        if (z == 2)
                        {
                            ColorLabel_False(label2);
                        }
                        if (z == 3)
                        {
                            ColorLabel_False(label3);
                        }
                        if (z == 4)
                        {
                            ColorLabel_False(label4);
                        }
                        if (z == 5)
                        {
                            ColorLabel_False(label5);
                        }
                        if (z == 6)
                        {
                            ColorLabel_False(label6);
                        }
                        if (z == 7)
                        {
                            ColorLabel_False(label7);
                        }
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
                        if (z == 0)
                        {
                            ColorLabel_False(label);
                        }
                        if (z == 1)
                        {
                            ColorLabel_False(label1);
                        }
                        if (z == 2)
                        {
                            ColorLabel_False(label2);
                        }
                        if (z == 3)
                        {
                            ColorLabel_False(label3);
                        }
                        if (z == 4)
                        {
                            ColorLabel_False(label4);
                        }
                        if (z == 5)
                        {
                            ColorLabel_False(label5);
                        }
                        if (z == 6)
                        {
                            ColorLabel_False(label6);
                        }
                        if (z == 7)
                        {
                            ColorLabel_False(label7);
                        }
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
                        if (z == 0)
                        {
                            ColorLabel_False(label);
                        }
                        if (z == 1)
                        {
                            ColorLabel_False(label1);
                        }
                        if (z == 2)
                        {
                            ColorLabel_False(label2);
                        }
                        if (z == 3)
                        {
                            ColorLabel_False(label3);
                        }
                        if (z == 4)
                        {
                            ColorLabel_False(label4);
                        }
                        if (z == 5)
                        {
                            ColorLabel_False(label5);
                        }
                        if (z == 6)
                        {
                            ColorLabel_False(label6);
                        }
                        if (z == 7)
                        {
                            ColorLabel_False(label7);
                        }
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
                        if (z == 0)
                        {
                            ColorLabel_False(label);
                        }
                        if (z == 1)
                        {
                            ColorLabel_False(label1);
                        }
                        if (z == 2)
                        {
                            ColorLabel_False(label2);
                        }
                        if (z == 3)
                        {
                            ColorLabel_False(label3);
                        }
                        if (z == 4)
                        {
                            ColorLabel_False(label4);
                        }
                        if (z == 5)
                        {
                            ColorLabel_False(label5);
                        }
                        if (z == 6)
                        {
                            ColorLabel_False(label6);
                        }
                        if (z == 7)
                        {
                            ColorLabel_False(label7);
                        }
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
                        if (z == 0)
                        {
                            ColorLabel_False(label);
                        }
                        if (z == 1)
                        {
                            ColorLabel_False(label1);
                        }
                        if (z == 2)
                        {
                            ColorLabel_False(label2);
                        }
                        if (z == 3)
                        {
                            ColorLabel_False(label3);
                        }
                        if (z == 4)
                        {
                            ColorLabel_False(label4);
                        }
                        if (z == 5)
                        {
                            ColorLabel_False(label5);
                        }
                        if (z == 6)
                        {
                            ColorLabel_False(label6);
                        }
                        if (z == 7)
                        {
                            ColorLabel_False(label7);
                        }
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
                        if (z == 0)
                        {
                            ColorLabel_False(label);
                        }
                        if (z == 1)
                        {
                            ColorLabel_False(label1);
                        }
                        if (z == 2)
                        {
                            ColorLabel_False(label2);
                        }
                        if (z == 3)
                        {
                            ColorLabel_False(label3);
                        }
                        if (z == 4)
                        {
                            ColorLabel_False(label4);
                        }
                        if (z == 5)
                        {
                            ColorLabel_False(label5);
                        }
                        if (z == 6)
                        {
                            ColorLabel_False(label6);
                        }
                        if (z == 7)
                        {
                            ColorLabel_False(label7);
                        }
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
                        if (z == 0)
                        {
                            ColorLabel_False(label);
                        }
                        if (z == 1)
                        {
                            ColorLabel_False(label1);
                        }
                        if (z == 2)
                        {
                            ColorLabel_False(label2);
                        }
                        if (z == 3)
                        {
                            ColorLabel_False(label3);
                        }
                        if (z == 4)
                        {
                            ColorLabel_False(label4);
                        }
                        if (z == 5)
                        {
                            ColorLabel_False(label5);
                        }
                        if (z == 6)
                        {
                            ColorLabel_False(label6);
                        }
                        if (z == 7)
                        {
                            ColorLabel_False(label7);
                        }
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
                        if (z == 0)
                        {
                            ColorLabel_False(label);
                        }
                        if (z == 1)
                        {
                            ColorLabel_False(label1);
                        }
                        if (z == 2)
                        {
                            ColorLabel_False(label2);
                        }
                        if (z == 3)
                        {
                            ColorLabel_False(label3);
                        }
                        if (z == 4)
                        {
                            ColorLabel_False(label4);
                        }
                        if (z == 5)
                        {
                            ColorLabel_False(label5);
                        }
                        if (z == 6)
                        {
                            ColorLabel_False(label6);
                        }
                        if (z == 7)
                        {
                            ColorLabel_False(label7);
                        }
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
                        if (z == 0)
                        {
                            ColorLabel_False(label);
                        }
                        if (z == 1)
                        {
                            ColorLabel_False(label1);
                        }
                        if (z == 2)
                        {
                            ColorLabel_False(label2);
                        }
                        if (z == 3)
                        {
                            ColorLabel_False(label3);
                        }
                        if (z == 4)
                        {
                            ColorLabel_False(label4);
                        }
                        if (z == 5)
                        {
                            ColorLabel_False(label5);
                        }
                        if (z == 6)
                        {
                            ColorLabel_False(label6);
                        }
                        if (z == 7)
                        {
                            ColorLabel_False(label7);
                        }
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
                        if (z == 0)
                        {
                            ColorLabel_False(label);
                        }
                        if (z == 1)
                        {
                            ColorLabel_False(label1);
                        }
                        if (z == 2)
                        {
                            ColorLabel_False(label2);
                        }
                        if (z == 3)
                        {
                            ColorLabel_False(label3);
                        }
                        if (z == 4)
                        {
                            ColorLabel_False(label4);
                        }
                        if (z == 5)
                        {
                            ColorLabel_False(label5);
                        }
                        if (z == 6)
                        {
                            ColorLabel_False(label6);
                        }
                        if (z == 7)
                        {
                            ColorLabel_False(label7);
                        }
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
                        if (z == 0)
                        {
                            ColorLabel_False(label);
                        }
                        if (z == 1)
                        {
                            ColorLabel_False(label1);
                        }
                        if (z == 2)
                        {
                            ColorLabel_False(label2);
                        }
                        if (z == 3)
                        {
                            ColorLabel_False(label3);
                        }
                        if (z == 4)
                        {
                            ColorLabel_False(label4);
                        }
                        if (z == 5)
                        {
                            ColorLabel_False(label5);
                        }
                        if (z == 6)
                        {
                            ColorLabel_False(label6);
                        }
                        if (z == 7)
                        {
                            ColorLabel_False(label7);
                        }
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
                        if (z == 0)
                        {
                            ColorLabel_False(label);
                        }
                        if (z == 1)
                        {
                            ColorLabel_False(label1);
                        }
                        if (z == 2)
                        {
                            ColorLabel_False(label2);
                        }
                        if (z == 3)
                        {
                            ColorLabel_False(label3);
                        }
                        if (z == 4)
                        {
                            ColorLabel_False(label4);
                        }
                        if (z == 5)
                        {
                            ColorLabel_False(label5);
                        }
                        if (z == 6)
                        {
                            ColorLabel_False(label6);
                        }
                        if (z == 7)
                        {
                            ColorLabel_False(label7);
                        }
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
                        if (z == 0)
                        {
                            ColorLabel_False(label);
                        }
                        if (z == 1)
                        {
                            ColorLabel_False(label1);
                        }
                        if (z == 2)
                        {
                            ColorLabel_False(label2);
                        }
                        if (z == 3)
                        {
                            ColorLabel_False(label3);
                        }
                        if (z == 4)
                        {
                            ColorLabel_False(label4);
                        }
                        if (z == 5)
                        {
                            ColorLabel_False(label5);
                        }
                        if (z == 6)
                        {
                            ColorLabel_False(label6);
                        }
                        if (z == 7)
                        {
                            ColorLabel_False(label7);
                        }
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
                        if (z == 0)
                        {
                            ColorLabel_False(label);
                        }
                        if (z == 1)
                        {
                            ColorLabel_False(label1);
                        }
                        if (z == 2)
                        {
                            ColorLabel_False(label2);
                        }
                        if (z == 3)
                        {
                            ColorLabel_False(label3);
                        }
                        if (z == 4)
                        {
                            ColorLabel_False(label4);
                        }
                        if (z == 5)
                        {
                            ColorLabel_False(label5);
                        }
                        if (z == 6)
                        {
                            ColorLabel_False(label6);
                        }
                        if (z == 7)
                        {
                            ColorLabel_False(label7);
                        }
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
                        if (z == 0)
                        {
                            ColorLabel_False(label);
                        }
                        if (z == 1)
                        {
                            ColorLabel_False(label1);
                        }
                        if (z == 2)
                        {
                            ColorLabel_False(label2);
                        }
                        if (z == 3)
                        {
                            ColorLabel_False(label3);
                        }
                        if (z == 4)
                        {
                            ColorLabel_False(label4);
                        }
                        if (z == 5)
                        {
                            ColorLabel_False(label5);
                        }
                        if (z == 6)
                        {
                            ColorLabel_False(label6);
                        }
                        if (z == 7)
                        {
                            ColorLabel_False(label7);
                        }
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
                        if (z == 0)
                        {
                            ColorLabel_False(label);
                        }
                        if (z == 1)
                        {
                            ColorLabel_False(label1);
                        }
                        if (z == 2)
                        {
                            ColorLabel_False(label2);
                        }
                        if (z == 3)
                        {
                            ColorLabel_False(label3);
                        }
                        if (z == 4)
                        {
                            ColorLabel_False(label4);
                        }
                        if (z == 5)
                        {
                            ColorLabel_False(label5);
                        }
                        if (z == 6)
                        {
                            ColorLabel_False(label6);
                        }
                        if (z == 7)
                        {
                            ColorLabel_False(label7);
                        }
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
                        if (z == 0)
                        {
                            ColorLabel_False(label);
                        }
                        if (z == 1)
                        {
                            ColorLabel_False(label1);
                        }
                        if (z == 2)
                        {
                            ColorLabel_False(label2);
                        }
                        if (z == 3)
                        {
                            ColorLabel_False(label3);
                        }
                        if (z == 4)
                        {
                            ColorLabel_False(label4);
                        }
                        if (z == 5)
                        {
                            ColorLabel_False(label5);
                        }
                        if (z == 6)
                        {
                            ColorLabel_False(label6);
                        }
                        if (z == 7)
                        {
                            ColorLabel_False(label7);
                        }
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
                        if (z == 0)
                        {
                            ColorLabel_False(label);
                        }
                        if (z == 1)
                        {
                            ColorLabel_False(label1);
                        }
                        if (z == 2)
                        {
                            ColorLabel_False(label2);
                        }
                        if (z == 3)
                        {
                            ColorLabel_False(label3);
                        }
                        if (z == 4)
                        {
                            ColorLabel_False(label4);
                        }
                        if (z == 5)
                        {
                            ColorLabel_False(label5);
                        }
                        if (z == 6)
                        {
                            ColorLabel_False(label6);
                        }
                        if (z == 7)
                        {
                            ColorLabel_False(label7);
                        }
                    }
                    break;
                case Keys.M:
                    string m = btnm.Text;
                    if (string.Compare(m, stringlabel, true) == 0)
                    {
                        Button_True(btnm);

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
                        if (z == 0)
                        {
                            ColorLabel_False(label);
                        }
                        if (z == 1)
                        {
                            ColorLabel_False(label1);
                        }
                        if (z == 2)
                        {
                            ColorLabel_False(label2);
                        }
                        if (z == 3)
                        {
                            ColorLabel_False(label3);
                        }
                        if (z == 4)
                        {
                            ColorLabel_False(label4);
                        }
                        if (z == 5)
                        {
                            ColorLabel_False(label5);
                        }
                        if (z == 6)
                        {
                            ColorLabel_False(label6);
                        }
                        if (z == 7)
                        {
                            ColorLabel_False(label7);
                        }
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
