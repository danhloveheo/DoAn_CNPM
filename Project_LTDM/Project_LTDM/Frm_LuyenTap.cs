using Project_LTDM.Global;
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
        Timer aTimer = new Timer();
        string[] Chuoi = new string[11];
        Button btn_oldHighLight = new Button();
        public Frm_LuyenTap()
        {
            InitializeComponent();
        }
        private string RandomString_old(int size, bool lowerCase)
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

        private void RandomString()
        {
            Random rnd = new Random();
            //string txtRand = string.Empty;
            //for (int i = 0; i < 8; i++) txtRand += ((char)rnd.Next(97, 122)).ToString();
            for (int i = 0; i < 11; i++)
            {
                string name = "label" + i;
                Control ctn = FindControl(pn_stringKeys, name); //.Controls[name];
                if (ctn != null)
                {
                    string skeys = ((char)rnd.Next(97, 122)).ToString();
                    ((Label)ctn).Text = skeys;
                    Chuoi[i] = skeys;
                }
            }
        }

        int i = 0;
        private void Frm_LuyenTap_Load(object sender, EventArgs e)
        {
            aTimer.Tick += ATimer_Tick;
            aTimer.Interval = 3000;
            // danh cho check van ban
            //richTextBox1.Select(0,1);
            //richTextBox1.SelectionColor = Color.Green;
            //richTextBox1.Select(1, 3);
            //richTextBox1.SelectionColor = Color.Red;
            RandomString();
            int iAscii = Chuoi[PositionKey].ToCharArray()[0];
            Control ctn = FindControlByTag(pn_Keys, iAscii); //.Controls[name];
            if (ctn != null)
            {
                HighLight((Button)ctn);
            }
            if (PositionKey < Chuoi.Length)
                SetFingerVisible(Chuoi[PositionKey]);
            this.KeyPreview = true;
        }

        private void ATimer_Tick(object sender, EventArgs e)
        {
            btn_oldHighLight.BackColor = Color.Red;
            aTimer.Stop();
        }

        private void HighLight(Button btn)
        {
            Normal(btn_oldHighLight);
            //btn_oldHighLight = btn;
            //aTimer.Start();
            btn.BackColor = Color.Green;
            btn_oldHighLight = btn;

        }

        private void ATimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Normal(Button btn)
        {
            btn.UseVisualStyleBackColor = true;
        }

        private void WrongKey(Control btn)
        {
            //btn.BackColor = Color.Red;
            btn.Font = new Font("Microsoft Sans Serif", 38F, ((System.Drawing.FontStyle)((FontStyle.Bold | FontStyle.Underline))), GraphicsUnit.Point, ((byte)(0)));
        }

        private void ColorLabel_True(Label lb)
        {
            lb.BackColor = Color.LightSeaGreen;
        }


        private void ColorLabel_Default(Label lb)
        {
            lb.BackColor = SystemColors.Control;
        }

        int PositionKey = 0;
        int k = 0;

        private Control FindControl(Control parent, string name)
        {
            // Check the parent.
            if (parent.Name == name) return parent;

            // Recursively search the parent's children.
            foreach (Control ctl in parent.Controls)
            {
                Control found = FindControl(ctl, name);
                if (found != null) return found;
            }

            // If we still haven't found it, it's not here.
            return null;
        }
        bool SearchStringInTagControl(Control Ctr, int Tag)
        {
            try
            {
                if (Ctr.Tag != null)
                {
                    string[] str = new string[5];
                    str = Ctr.Tag.ToString().Split(',');
                    foreach (string item in str)
                    {
                        if (int.Parse(item) == Tag)
                            return true;
                    }
                }
            }
            catch
            { }
            return false;

        }
        private Control FindControlByTag(Control parent, int Tagname)
        {
            if (SearchStringInTagControl(parent, Tagname) == true)
                return parent;
            // Check the parent.
            //if (parent.Tag!=null && int.Parse(parent.Tag.ToString()) == Tagname) return parent;

            // Recursively search the parent's children.
            foreach (Control ctl in parent.Controls)
            {
                Control found = FindControlByTag(ctl, Tagname);
                if (found != null) return found;
            }

            // If we still haven't found it, it's not here.
            return null;
        }
        private void Frm_LuyenTap_KeyDown(object sender, KeyEventArgs e)
        {
            //k phai la 2 ky tu va k phai la ky tu dac biet
            //if (z >= Chuoi.Length)
            //    return;
            //string stringlabel = Chuoi[z];
            //string name = "btn" + e.KeyCode.ToString().ToLower();
            //Control ctn = FindControl(pn_Keys, name); //.Controls[name];
            //if( ctn!=null)
            //{
            //    //HighLight((Button)ctn);
            //    ((Button)ctn).Focus();
            //    if (string.Compare(((Button)ctn).Text, stringlabel, true) == 0)
            //    {
            //        Control ctnkey = FindControl(pn_stringKeys, "label" + z);
            //        ColorLabel_True(((Label)ctnkey));
            //        z++;
            //        if (z < Chuoi.Length)
            //        {
            //            ctn = FindControl(pn_Keys, "btn" + Chuoi[z]);
            //            SetFingerVisible(Chuoi[z]);
            //        }
            //    }
            //}
        }

        private void SetFingerVisible(string skey)
        {
            //string result = Finger.Left_NgonUt.Single(s => s == skey);
            int idex = -2;
            if (Finger.Left_NgonUt.FindIndex(s => s == skey) != -1)
                idex = 0;
            else if (Finger.Left_NgonApUt.FindIndex(s => s == skey) != -1)
                idex = 1;
            else if (Finger.Left_NgonGiua.FindIndex(s => s == skey) != -1)
                idex = 2;
            else if (Finger.Left_NgonTro.FindIndex(s => s == skey) != -1)
                idex = 3;
            else if (Finger.NgonCai.FindIndex(s => s == skey) != -1)
                idex = 4;
            //else if (Finger.NgonCai.FindIndex(s => s == skey) != -1)
            //{ MessageBox.Show("5"); }
            else if (Finger.Right_NgonTro.FindIndex(s => s == skey) != -1)
                idex = 6;
            else if (Finger.Right_NgonGiua.FindIndex(s => s == skey) != -1)
                idex = 7;
            else if (Finger.Right_NgonApUt.FindIndex(s => s == skey) != -1)
                idex = 8;
            else if (Finger.Right_NgonUt.FindIndex(s => s == skey) != -1)
                idex = 9;

            Control ctn = FindControl(pn_LH, "btn_Finger" + idex);
            if (ctn != null)
            {
                ((Button)ctn).Visible = true;
            }
            else
            {
                ctn = FindControl(pn_RH, "btn_Finger" + idex);
                if (ctn != null)
                {
                    ((Button)ctn).Visible = true;
                }
            }
            for (int i = 0; i < 10; i++)
            {
                if (i == idex)
                    continue;
                ctn = FindControl(pn_LH, "btn_Finger" + i);
                if (ctn != null)
                {
                    ((Button)ctn).Visible = false;
                }
                else
                {
                    ctn = FindControl(pn_RH, "btn_Finger" + i);
                    if (ctn != null)
                    {
                        ((Button)ctn).Visible = false;
                    }
                }

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

        private void Frm_LuyenTap_KeyDown_old(object sender, KeyEventArgs e)
        {
            //string[] chuoi = new string[8];
            //chuoi[0] = label0.Text;
            //chuoi[1] = label1.Text;
            //chuoi[2] = label2.Text;
            //chuoi[3] = label3.Text;
            //chuoi[4] = label4.Text;
            //chuoi[5] = label5.Text;
            //chuoi[6] = label6.Text;
            //chuoi[7] = label7.Text;

            //string stringlabel = chuoi[z];
            //switch (e.KeyCode)
            //{
            //    case Keys.Q:
            //        string q = btnq.Text;
            //        if (string.Compare(q, stringlabel, true) == 0)
            //        {
            //            HighLight(btnq);
            //            z++;

            //            if (k == 0)
            //            {
            //                ColorLabel_True(label0);
            //                k++;
            //                return;
            //            }
            //            if (k == 1)
            //            {
            //                ColorLabel_True(label1);
            //                k++;
            //                return;
            //            }
            //            if (k == 2)
            //            {
            //                ColorLabel_True(label2);
            //                k++; return;
            //            }
            //            if (k == 3)
            //            {
            //                ColorLabel_True(label3);
            //                k++; return;
            //            }
            //            if (k == 4)
            //            {
            //                ColorLabel_True(label4);
            //                k++; return;
            //            }
            //            if (k == 5)
            //            {
            //                ColorLabel_True(label5);
            //                k++; return;
            //            }
            //            if (k == 6)
            //            {
            //                ColorLabel_True(label6);
            //                k++; return;
            //            }
            //            if (k == 7)
            //            {
            //                ColorLabel_True(label7);
            //                k++;
            //                MessageBox.Show("Hoan Thanh");
            //                //this.Close();
            //                this.Close();
            //                return;
            //            }

            //        }
            //        else
            //        {
            //            Sai(btnq);
            //        }
            //        break;
            //    case Keys.W:
            //        string w = btnw.Text;

            //        if (string.Compare(w, stringlabel, true) == 0)
            //        {

            //            HighLight(btnw);
            //            z++;
            //            if (k == 0)
            //            {
            //                ColorLabel_True(label0);
            //                k++;
            //                return;
            //            }
            //            if (k == 1)
            //            {
            //                ColorLabel_True(label1);
            //                k++;
            //                return;
            //            }
            //            if (k == 2)
            //            {
            //                ColorLabel_True(label2);
            //                k++; return;
            //            }
            //            if (k == 3)
            //            {
            //                ColorLabel_True(label3);
            //                k++; return;
            //            }
            //            if (k == 4)
            //            {
            //                ColorLabel_True(label4);
            //                k++; return;
            //            }
            //            if (k == 5)
            //            {
            //                ColorLabel_True(label5);
            //                k++; return;
            //            }
            //            if (k == 6)
            //            {
            //                ColorLabel_True(label6);
            //                k++; return;
            //            }
            //            if (k == 7)
            //            {
            //                ColorLabel_True(label7);
            //                k++;
            //                MessageBox.Show("Hoan Thanh");
            //                this.Close(); return;
            //            }
            //        }
            //        else
            //        {
            //            Sai(btnw);
            //        }
            //        break;
            //    case Keys.E:
            //        string keye = btne.Text;

            //        if (string.Compare(keye, stringlabel, true) == 0)
            //        {
            //            HighLight(btne);
            //            z++;
            //            if (k == 0)
            //            {
            //                ColorLabel_True(label0);
            //                k++;
            //                return;
            //            }
            //            if (k == 1)
            //            {
            //                ColorLabel_True(label1);
            //                k++;
            //                return;
            //            }
            //            if (k == 2)
            //            {
            //                ColorLabel_True(label2);
            //                k++; return;
            //            }
            //            if (k == 3)
            //            {
            //                ColorLabel_True(label3);
            //                k++; return;
            //            }
            //            if (k == 4)
            //            {
            //                ColorLabel_True(label4);
            //                k++; return;
            //            }
            //            if (k == 5)
            //            {
            //                ColorLabel_True(label5);
            //                k++; return;
            //            }
            //            if (k == 6)
            //            {
            //                ColorLabel_True(label6);
            //                k++; return;
            //            }
            //            if (k == 7)
            //            {
            //                ColorLabel_True(label7);
            //                k++;
            //                MessageBox.Show("Hoan Thanh");
            //                this.Close(); return;
            //            }
            //        }
            //        else
            //        {
            //            Sai(btne);
            //        }
            //        break;
            //    case Keys.R:
            //        string r = btnr.Text;

            //        if (string.Compare(r, stringlabel, true) == 0)
            //        {
            //            HighLight(btnr);
            //            z++;
            //            if (k == 0)
            //            {
            //                ColorLabel_True(label0);
            //                k++;
            //                return;
            //            }
            //            if (k == 1)
            //            {
            //                ColorLabel_True(label1);
            //                k++;
            //                return;
            //            }
            //            if (k == 2)
            //            {
            //                ColorLabel_True(label2);
            //                k++; return;
            //            }
            //            if (k == 3)
            //            {
            //                ColorLabel_True(label3);
            //                k++; return;
            //            }
            //            if (k == 4)
            //            {
            //                ColorLabel_True(label4);
            //                k++; return;
            //            }
            //            if (k == 5)
            //            {
            //                ColorLabel_True(label5);
            //                k++; return;
            //            }
            //            if (k == 6)
            //            {
            //                ColorLabel_True(label6);
            //                k++; return;
            //            }
            //            if (k == 7)
            //            {
            //                ColorLabel_True(label7);
            //                k++;
            //                MessageBox.Show("Hoan Thanh");
            //                this.Close(); return;
            //            }
            //        }
            //        else
            //        {
            //            Sai(btnr);
            //        }
            //        break;
            //    case Keys.T:
            //        string t = btnt.Text;

            //        if (string.Compare(t, stringlabel, true) == 0)
            //        {
            //            HighLight(btnt);
            //            z++;
            //            if (k == 0)
            //            {
            //                ColorLabel_True(label0);
            //                k++;
            //                return;
            //            }
            //            if (k == 1)
            //            {
            //                ColorLabel_True(label1);
            //                k++;
            //                return;
            //            }
            //            if (k == 2)
            //            {
            //                ColorLabel_True(label2);
            //                k++; return;
            //            }
            //            if (k == 3)
            //            {
            //                ColorLabel_True(label3);
            //                k++; return;
            //            }
            //            if (k == 4)
            //            {
            //                ColorLabel_True(label4);
            //                k++; return;
            //            }
            //            if (k == 5)
            //            {
            //                ColorLabel_True(label5);
            //                k++; return;
            //            }
            //            if (k == 6)
            //            {
            //                ColorLabel_True(label6);
            //                k++; return;
            //            }
            //            if (k == 7)
            //            {
            //                ColorLabel_True(label7);
            //                k++;
            //                MessageBox.Show("Hoan Thanh");
            //                this.Close(); return;
            //            }
            //        }
            //        else
            //        {
            //            Sai(btnt);
            //        }
            //        break;
            //    case Keys.Y:
            //        string y = btny.Text;

            //        if (string.Compare(y, stringlabel, true) == 0)
            //        {
            //            HighLight(btny);
            //            z++;
            //            if (k == 0)
            //            {
            //                ColorLabel_True(label0);
            //                k++;
            //                return;
            //            }
            //            if (k == 1)
            //            {
            //                ColorLabel_True(label1);
            //                k++;
            //                return;
            //            }
            //            if (k == 2)
            //            {
            //                ColorLabel_True(label2);
            //                k++; return;
            //            }
            //            if (k == 3)
            //            {
            //                ColorLabel_True(label3);
            //                k++; return;
            //            }
            //            if (k == 4)
            //            {
            //                ColorLabel_True(label4);
            //                k++; return;
            //            }
            //            if (k == 5)
            //            {
            //                ColorLabel_True(label5);
            //                k++; return;
            //            }
            //            if (k == 6)
            //            {
            //                ColorLabel_True(label6);
            //                k++; return;
            //            }
            //            if (k == 7)
            //            {
            //                ColorLabel_True(label7);
            //                k++;
            //                MessageBox.Show("Hoan Thanh");
            //                this.Close(); return;
            //            }
            //        }
            //        else
            //        {
            //            Sai(btny);
            //        }
            //        break;
            //    case Keys.U:
            //        string u = btnu.Text;

            //        if (string.Compare(u, stringlabel, true) == 0)
            //        {
            //            HighLight(btnu);
            //            z++;
            //            if (k == 0)
            //            {
            //                ColorLabel_True(label0);
            //                k++;
            //                return;
            //            }
            //            if (k == 1)
            //            {
            //                ColorLabel_True(label1);
            //                k++;
            //                return;
            //            }
            //            if (k == 2)
            //            {
            //                ColorLabel_True(label2);
            //                k++; return;
            //            }
            //            if (k == 3)
            //            {
            //                ColorLabel_True(label3);
            //                k++; return;
            //            }
            //            if (k == 4)
            //            {
            //                ColorLabel_True(label4);
            //                k++; return;
            //            }
            //            if (k == 5)
            //            {
            //                ColorLabel_True(label5);
            //                k++; return;
            //            }
            //            if (k == 6)
            //            {
            //                ColorLabel_True(label6);
            //                k++; return;
            //            }
            //            if (k == 7)
            //            {
            //                ColorLabel_True(label7);
            //                k++;
            //                MessageBox.Show("Hoan Thanh");
            //                this.Close(); return;
            //            }
            //        }
            //        else
            //        {
            //            Sai(btnu);
            //        }
            //        break;
            //    case Keys.I:
            //        string i = btni.Text;

            //        if (string.Compare(i, stringlabel, true) == 0)
            //        {
            //            HighLight(btni);
            //            z++;
            //            if (k == 0)
            //            {
            //                ColorLabel_True(label0);
            //                k++;
            //                return;
            //            }
            //            if (k == 1)
            //            {
            //                ColorLabel_True(label1);
            //                k++;
            //                return;
            //            }
            //            if (k == 2)
            //            {
            //                ColorLabel_True(label2);
            //                k++; return;
            //            }
            //            if (k == 3)
            //            {
            //                ColorLabel_True(label3);
            //                k++; return;
            //            }
            //            if (k == 4)
            //            {
            //                ColorLabel_True(label4);
            //                k++; return;
            //            }
            //            if (k == 5)
            //            {
            //                ColorLabel_True(label5);
            //                k++; return;
            //            }
            //            if (k == 6)
            //            {
            //                ColorLabel_True(label6);
            //                k++; return;
            //            }
            //            if (k == 7)
            //            {
            //                ColorLabel_True(label7);
            //                k++;
            //                MessageBox.Show("Hoan Thanh");
            //                this.Close(); return;
            //            }
            //        }
            //        else
            //        {
            //            Sai(btni);
            //        }

            //        break;
            //    case Keys.O:
            //        string o = btno.Text;

            //        if (string.Compare(o, stringlabel, true) == 0)
            //        {
            //            HighLight(btno);
            //            z++;
            //            if (k == 0)
            //            {
            //                ColorLabel_True(label0);
            //                k++;
            //                return;
            //            }
            //            if (k == 1)
            //            {
            //                ColorLabel_True(label1);
            //                k++;
            //                return;
            //            }
            //            if (k == 2)
            //            {
            //                ColorLabel_True(label2);
            //                k++; return;
            //            }
            //            if (k == 3)
            //            {
            //                ColorLabel_True(label3);
            //                k++; return;
            //            }
            //            if (k == 4)
            //            {
            //                ColorLabel_True(label4);
            //                k++; return;
            //            }
            //            if (k == 5)
            //            {
            //                ColorLabel_True(label5);
            //                k++; return;
            //            }
            //            if (k == 6)
            //            {
            //                ColorLabel_True(label6);
            //                k++; return;
            //            }
            //            if (k == 7)
            //            {
            //                ColorLabel_True(label7);
            //                k++;
            //                MessageBox.Show("Hoan Thanh");
            //                this.Close(); return;
            //            }
            //        }
            //        else
            //        {
            //            Sai(btno);
            //        }
            //        break;
            //    case Keys.P:
            //        string p = btnp.Text;

            //        if (string.Compare(p, stringlabel, true) == 0)
            //        {
            //            HighLight(btnp);
            //            z++;
            //            if (k == 0)
            //            {
            //                ColorLabel_True(label0);
            //                k++;
            //                return;
            //            }
            //            if (k == 1)
            //            {
            //                ColorLabel_True(label1);
            //                k++;
            //                return;
            //            }
            //            if (k == 2)
            //            {
            //                ColorLabel_True(label2);
            //                k++; return;
            //            }
            //            if (k == 3)
            //            {
            //                ColorLabel_True(label3);
            //                k++; return;
            //            }
            //            if (k == 4)
            //            {
            //                ColorLabel_True(label4);
            //                k++; return;
            //            }
            //            if (k == 5)
            //            {
            //                ColorLabel_True(label5);
            //                k++; return;
            //            }
            //            if (k == 6)
            //            {
            //                ColorLabel_True(label6);
            //                k++; return;
            //            }
            //            if (k == 7)
            //            {
            //                ColorLabel_True(label7);
            //                k++;
            //                MessageBox.Show("Hoan Thanh");
            //                this.Close(); return;
            //            }
            //        }
            //        else
            //        {
            //            Sai(btnp);
            //        }
            //        break;
            //    case Keys.A:
            //        string a = btna.Text;
            //        if (string.Compare(a, stringlabel, true) == 0)
            //        {
            //            HighLight(btna);
            //            z++;


            //            if (k == 0)
            //            {
            //                ColorLabel_True(label0);
            //                k++; return;
            //            }
            //            if (k == 1)
            //            {
            //                ColorLabel_True(label1);
            //                k++; return;
            //            }
            //            if (k == 2)
            //            {
            //                ColorLabel_True(label2);
            //                k++; return;
            //            }
            //            if (k == 3)
            //            {
            //                ColorLabel_True(label3);
            //                k++; return;
            //            }
            //            if (k == 4)
            //            {
            //                ColorLabel_True(label4);
            //                k++; return;
            //            }
            //            if (k == 5)
            //            {
            //                ColorLabel_True(label5);
            //                k++; return;
            //            }
            //            if (k == 6)
            //            {
            //                ColorLabel_True(label6);
            //                k++; return;
            //            }
            //            if (k == 7)
            //            {
            //                ColorLabel_True(label7);
            //                k++;
            //                MessageBox.Show("Hoan Thanh");
            //                this.Close(); return;
            //            }

            //        }
            //        else
            //        {
            //            Sai(btna);
            //        }
            //        break;
            //    case Keys.S:

            //        string s = btns.Text;
            //        if (string.Compare(s, stringlabel, true) == 0)
            //        {
            //            HighLight(btns);
            //            z++;
            //            if (k == 0)
            //            {
            //                ColorLabel_True(label0);
            //                k++; return;
            //            }
            //            if (k == 1)
            //            {
            //                ColorLabel_True(label1);
            //                k++; return;
            //            }
            //            if (k == 2)
            //            {
            //                ColorLabel_True(label2);
            //                k++; return;
            //            }
            //            if (k == 3)
            //            {
            //                ColorLabel_True(label3);
            //                k++; return;
            //            }
            //            if (k == 4)
            //            {
            //                ColorLabel_True(label4);
            //                k++; return;
            //            }
            //            if (k == 5)
            //            {
            //                ColorLabel_True(label5);
            //                k++; return;
            //            }
            //            if (k == 6)
            //            {
            //                ColorLabel_True(label6);
            //                k++; return;
            //            }
            //            if (k == 7)
            //            {
            //                ColorLabel_True(label7);
            //                k++;
            //                MessageBox.Show("Hoan Thanh");
            //                this.Close(); return;
            //            }

            //        }
            //        else
            //        {
            //            Sai(btns);
            //        }
            //        break;
            //    case Keys.D:
            //        string d = btnd.Text;
            //        if (string.Compare(d, stringlabel, true) == 0)
            //        {
            //            HighLight(btnd);
            //            z++;
            //            if (k == 0)
            //            {
            //                ColorLabel_True(label0);
            //                k++; return;
            //            }
            //            if (k == 1)
            //            {
            //                ColorLabel_True(label1);
            //                k++; return;
            //            }
            //            if (k == 2)
            //            {
            //                ColorLabel_True(label2);
            //                k++; return;
            //            }
            //            if (k == 3)
            //            {
            //                ColorLabel_True(label3);
            //                k++; return;
            //            }
            //            if (k == 4)
            //            {
            //                ColorLabel_True(label4);
            //                k++; return;
            //            }
            //            if (k == 5)
            //            {
            //                ColorLabel_True(label5);
            //                k++; return;
            //            }
            //            if (k == 6)
            //            {
            //                ColorLabel_True(label6);
            //                k++; return;
            //            }
            //            if (k == 7)
            //            {
            //                ColorLabel_True(label7);
            //                k++;
            //                MessageBox.Show("Hoan Thanh");
            //                this.Close(); return;
            //            }

            //        }
            //        else
            //        {
            //            Sai(btnd);
            //        }
            //        break;
            //    case Keys.F:

            //        string f = btnf.Text;
            //        if (string.Compare(f, stringlabel, true) == 0)
            //        {
            //            HighLight(btnf);
            //            z++;
            //            if (k == 0)
            //            {
            //                ColorLabel_True(label0);
            //                k++; return;
            //            }
            //            if (k == 1)
            //            {
            //                ColorLabel_True(label1);
            //                k++; return;
            //            }
            //            if (k == 2)
            //            {
            //                ColorLabel_True(label2);
            //                k++; return;
            //            }
            //            if (k == 3)
            //            {
            //                ColorLabel_True(label3);
            //                k++; return;
            //            }
            //            if (k == 4)
            //            {
            //                ColorLabel_True(label4);
            //                k++; return;
            //            }
            //            if (k == 5)
            //            {
            //                ColorLabel_True(label5);
            //                k++; return;
            //            }
            //            if (k == 6)
            //            {
            //                ColorLabel_True(label6);
            //                k++; return;
            //            }
            //            if (k == 7)
            //            {
            //                ColorLabel_True(label7);
            //                k++;
            //                MessageBox.Show("Hoan Thanh");
            //                this.Close(); return;
            //            }

            //        }
            //        else
            //        {
            //            Sai(btnf);
            //        }
            //        break;
            //    case Keys.G:

            //        string g = btng.Text;
            //        if (string.Compare(g, stringlabel, true) == 0)
            //        {
            //            HighLight(btng);
            //            z++;
            //            if (k == 0)
            //            {
            //                ColorLabel_True(label0);
            //                k++; return;
            //            }
            //            if (k == 1)
            //            {
            //                ColorLabel_True(label1);
            //                k++; return;
            //            }
            //            if (k == 2)
            //            {
            //                ColorLabel_True(label2);
            //                k++; return;
            //            }
            //            if (k == 3)
            //            {
            //                ColorLabel_True(label3);
            //                k++; return;
            //            }
            //            if (k == 4)
            //            {
            //                ColorLabel_True(label4);
            //                k++; return;
            //            }
            //            if (k == 5)
            //            {
            //                ColorLabel_True(label5);
            //                k++; return;
            //            }
            //            if (k == 6)
            //            {
            //                ColorLabel_True(label6);
            //                k++; return;
            //            }
            //            if (k == 7)
            //            {
            //                ColorLabel_True(label7);
            //                k++;
            //                MessageBox.Show("Hoan Thanh");
            //                this.Close(); return;
            //            }

            //        }
            //        else
            //        {
            //            Sai(btng);
            //        }
            //        break;
            //    case Keys.H:
            //        string h = btnh.Text;
            //        if (string.Compare(h, stringlabel, true) == 0)
            //        {
            //            HighLight(btnh);
            //            z++;
            //            if (k == 0)
            //            {
            //                ColorLabel_True(label0);
            //                k++; return;
            //            }
            //            if (k == 1)
            //            {
            //                ColorLabel_True(label1);
            //                k++; return;
            //            }
            //            if (k == 2)
            //            {
            //                ColorLabel_True(label2);
            //                k++; return;
            //            }
            //            if (k == 3)
            //            {
            //                ColorLabel_True(label3);
            //                k++; return;
            //            }
            //            if (k == 4)
            //            {
            //                ColorLabel_True(label4);
            //                k++; return;
            //            }
            //            if (k == 5)
            //            {
            //                ColorLabel_True(label5);
            //                k++; return;
            //            }
            //            if (k == 6)
            //            {
            //                ColorLabel_True(label6);
            //                k++; return;
            //            }
            //            if (k == 7)
            //            {
            //                ColorLabel_True(label7);
            //                k++;
            //                MessageBox.Show("Hoan Thanh");
            //                this.Close(); return;
            //            }

            //        }
            //        else
            //        {
            //            Sai(btnh);
            //        }
            //        break;
            //    case Keys.J:
            //        string j = btnj.Text;
            //        if (string.Compare(j, stringlabel, true) == 0)
            //        {
            //            HighLight(btnj);
            //            z++;
            //            if (k == 0)
            //            {
            //                ColorLabel_True(label0);
            //                k++; return;
            //            }
            //            if (k == 1)
            //            {
            //                ColorLabel_True(label1);
            //                k++; return;
            //            }
            //            if (k == 2)
            //            {
            //                ColorLabel_True(label2);
            //                k++; return;
            //            }
            //            if (k == 3)
            //            {
            //                ColorLabel_True(label3);
            //                k++; return;
            //            }
            //            if (k == 4)
            //            {
            //                ColorLabel_True(label4);
            //                k++; return;
            //            }
            //            if (k == 5)
            //            {
            //                ColorLabel_True(label5);
            //                k++; return;
            //            }
            //            if (k == 6)
            //            {
            //                ColorLabel_True(label6);
            //                k++; return;
            //            }
            //            if (k == 7)
            //            {
            //                ColorLabel_True(label7);
            //                k++;
            //                MessageBox.Show("Hoan Thanh");
            //                this.Close(); return;
            //            }

            //        }
            //        else
            //        {
            //            Sai(btnj);
            //        }
            //        break;
            //    case Keys.K:
            //        string keyk = btnk.Text;
            //        if (string.Compare(keyk, stringlabel, true) == 0)
            //        {
            //            HighLight(btnk);
            //            z++;
            //            if (k == 0)
            //            {
            //                ColorLabel_True(label0);
            //                k++; return;
            //            }
            //            if (k == 1)
            //            {
            //                ColorLabel_True(label1);
            //                k++; return;
            //            }
            //            if (k == 2)
            //            {
            //                ColorLabel_True(label2);
            //                k++; return;
            //            }
            //            if (k == 3)
            //            {
            //                ColorLabel_True(label3);
            //                k++; return;
            //            }
            //            if (k == 4)
            //            {
            //                ColorLabel_True(label4);
            //                k++; return;
            //            }
            //            if (k == 5)
            //            {
            //                ColorLabel_True(label5);
            //                k++; return;
            //            }
            //            if (k == 6)
            //            {
            //                ColorLabel_True(label6);
            //                k++; return;
            //            }
            //            if (k == 7)
            //            {
            //                ColorLabel_True(label7);
            //                k++;
            //                MessageBox.Show("Hoan Thanh");
            //                this.Close(); return;
            //            }

            //        }
            //        else
            //        {
            //            Sai(btnk);
            //        }
            //        break;
            //    case Keys.L:
            //        string l = btnl.Text;
            //        if (string.Compare(l, stringlabel, true) == 0)
            //        {
            //            HighLight(btnl);
            //            z++;
            //            if (k == 0)
            //            {
            //                ColorLabel_True(label0);
            //                k++; return;
            //            }
            //            if (k == 1)
            //            {
            //                ColorLabel_True(label1);
            //                k++; return;
            //            }
            //            if (k == 2)
            //            {
            //                ColorLabel_True(label2);
            //                k++; return;
            //            }
            //            if (k == 3)
            //            {
            //                ColorLabel_True(label3);
            //                k++; return;
            //            }
            //            if (k == 4)
            //            {
            //                ColorLabel_True(label4);
            //                k++; return;
            //            }
            //            if (k == 5)
            //            {
            //                ColorLabel_True(label5);
            //                k++; return;
            //            }
            //            if (k == 6)
            //            {
            //                ColorLabel_True(label6);
            //                k++; return;
            //            }
            //            if (k == 7)
            //            {
            //                ColorLabel_True(label7);
            //                k++;
            //                MessageBox.Show("Hoan Thanh");
            //                this.Close(); return;
            //            }

            //        }
            //        else
            //        {
            //            Sai(btnl);
            //        }
            //        break;
            //    case Keys.Z:
            //        string keyz = btnz.Text;
            //        if (string.Compare(keyz, stringlabel, true) == 0)
            //        {
            //            HighLight(btnz);
            //            z++;
            //            if (k == 0)
            //            {
            //                ColorLabel_True(label0);
            //                k++; return;
            //            }
            //            if (k == 1)
            //            {
            //                ColorLabel_True(label1);
            //                k++; return;
            //            }
            //            if (k == 2)
            //            {
            //                ColorLabel_True(label2);
            //                k++; return;
            //            }
            //            if (k == 3)
            //            {
            //                ColorLabel_True(label3);
            //                k++; return;
            //            }
            //            if (k == 4)
            //            {
            //                ColorLabel_True(label4);
            //                k++; return;
            //            }
            //            if (k == 5)
            //            {
            //                ColorLabel_True(label5);
            //                k++; return;
            //            }
            //            if (k == 6)
            //            {
            //                ColorLabel_True(label6);
            //                k++; return;
            //            }
            //            if (k == 7)
            //            {
            //                ColorLabel_True(label7);
            //                k++;
            //                MessageBox.Show("Hoan Thanh");
            //                this.Close(); return;
            //            }

            //        }
            //        else
            //        {
            //            Sai(btnz);
            //        }
            //        break;
            //    case Keys.X:
            //        string x = btnx.Text;
            //        if (string.Compare(x, stringlabel, true) == 0)
            //        {
            //            HighLight(btnx);
            //            z++;
            //            if (k == 0)
            //            {
            //                ColorLabel_True(label0);
            //                k++; return;
            //            }
            //            if (k == 1)
            //            {
            //                ColorLabel_True(label1);
            //                k++; return;
            //            }
            //            if (k == 2)
            //            {
            //                ColorLabel_True(label2);
            //                k++; return;
            //            }
            //            if (k == 3)
            //            {
            //                ColorLabel_True(label3);
            //                k++; return;
            //            }
            //            if (k == 4)
            //            {
            //                ColorLabel_True(label4);
            //                k++; return;
            //            }
            //            if (k == 5)
            //            {
            //                ColorLabel_True(label5);
            //                k++; return;
            //            }
            //            if (k == 6)
            //            {
            //                ColorLabel_True(label6);
            //                k++; return;
            //            }
            //            if (k == 7)
            //            {
            //                ColorLabel_True(label7);
            //                k++;
            //                MessageBox.Show("Hoan Thanh");
            //                this.Close(); return;
            //            }

            //        }
            //        else
            //        {
            //            Sai(btnx);
            //        }
            //        break;
            //    case Keys.C:
            //        string c = btnc.Text;
            //        if (string.Compare(c, stringlabel, true) == 0)
            //        {
            //            HighLight(btnc);
            //            z++;
            //            if (k == 0)
            //            {
            //                ColorLabel_True(label0);
            //                k++; return;
            //            }
            //            if (k == 1)
            //            {
            //                ColorLabel_True(label1);
            //                k++; return;
            //            }
            //            if (k == 2)
            //            {
            //                ColorLabel_True(label2);
            //                k++; return;
            //            }
            //            if (k == 3)
            //            {
            //                ColorLabel_True(label3);
            //                k++; return;
            //            }
            //            if (k == 4)
            //            {
            //                ColorLabel_True(label4);
            //                k++; return;
            //            }
            //            if (k == 5)
            //            {
            //                ColorLabel_True(label5);
            //                k++; return;
            //            }
            //            if (k == 6)
            //            {
            //                ColorLabel_True(label6);
            //                k++; return;
            //            }
            //            if (k == 7)
            //            {
            //                ColorLabel_True(label7);
            //                k++;
            //                MessageBox.Show("Hoan Thanh");
            //                this.Close(); return;
            //            }

            //        }
            //        else
            //        {
            //            Sai(btnc);
            //        }
            //        break;
            //    case Keys.V:
            //        string v = btnv.Text;
            //        if (string.Compare(v, stringlabel, true) == 0)
            //        {
            //            HighLight(btnv);
            //            z++;
            //            if (k == 0)
            //            {
            //                ColorLabel_True(label0);
            //                k++; return;
            //            }
            //            if (k == 1)
            //            {
            //                ColorLabel_True(label1);
            //                k++; return;
            //            }
            //            if (k == 2)
            //            {
            //                ColorLabel_True(label2);
            //                k++; return;
            //            }
            //            if (k == 3)
            //            {
            //                ColorLabel_True(label3);
            //                k++; return;
            //            }
            //            if (k == 4)
            //            {
            //                ColorLabel_True(label4);
            //                k++; return;
            //            }
            //            if (k == 5)
            //            {
            //                ColorLabel_True(label5);
            //                k++; return;
            //            }
            //            if (k == 6)
            //            {
            //                ColorLabel_True(label6);
            //                k++; return;
            //            }
            //            if (k == 7)
            //            {
            //                ColorLabel_True(label7);
            //                k++;
            //                MessageBox.Show("Hoan Thanh");
            //                this.Close(); return;
            //            }

            //        }
            //        else
            //        {
            //            Sai(btnv);
            //        }
            //        break;
            //    case Keys.B:
            //        string b = btnb.Text;
            //        if (string.Compare(b, stringlabel, true) == 0)
            //        {
            //            HighLight(btnb);
            //            z++;
            //            if (k == 0)
            //            {
            //                ColorLabel_True(label0);
            //                k++; return;
            //            }
            //            if (k == 1)
            //            {
            //                ColorLabel_True(label1);
            //                k++; return;
            //            }
            //            if (k == 2)
            //            {
            //                ColorLabel_True(label2);
            //                k++; return;
            //            }
            //            if (k == 3)
            //            {
            //                ColorLabel_True(label3);
            //                k++; return;
            //            }
            //            if (k == 4)
            //            {
            //                ColorLabel_True(label4);
            //                k++; return;
            //            }
            //            if (k == 5)
            //            {
            //                ColorLabel_True(label5);
            //                k++; return;
            //            }
            //            if (k == 6)
            //            {
            //                ColorLabel_True(label6);
            //                k++; return;
            //            }
            //            if (k == 7)
            //            {
            //                ColorLabel_True(label7);
            //                k++;
            //                MessageBox.Show("Hoan Thanh");
            //                this.Close(); return;
            //            }

            //        }
            //        else
            //        {
            //            Sai(btnb);
            //        }
            //        break;
            //    case Keys.N:
            //        string n = btnn.Text;
            //        if (string.Compare(n, stringlabel, true) == 0)
            //        {
            //            HighLight(btnn);
            //            z++;
            //            if (k == 0)
            //            {
            //                ColorLabel_True(label0);
            //                k++; return;
            //            }
            //            if (k == 1)
            //            {
            //                ColorLabel_True(label1);
            //                k++; return;
            //            }
            //            if (k == 2)
            //            {
            //                ColorLabel_True(label2);
            //                k++; return;
            //            }
            //            if (k == 3)
            //            {
            //                ColorLabel_True(label3);
            //                k++; return;
            //            }
            //            if (k == 4)
            //            {
            //                ColorLabel_True(label4);
            //                k++; return;
            //            }
            //            if (k == 5)
            //            {
            //                ColorLabel_True(label5);
            //                k++; return;
            //            }
            //            if (k == 6)
            //            {
            //                ColorLabel_True(label6);
            //                k++; return;
            //            }
            //            if (k == 7)
            //            {
            //                ColorLabel_True(label7);
            //                k++;
            //                MessageBox.Show("Hoan Thanh");
            //                this.Close(); return;
            //            }

            //        }
            //        else
            //        {
            //            Sai(btnn);
            //        }
            //        break;
            //    case Keys.M:
            //        string m = btnm.Text;
            //        if (string.Compare(m, stringlabel, true) == 0)
            //        {
            //            HighLight(btnf);
            //            z++;
            //            if (k == 0)
            //            {
            //                ColorLabel_True(label0);
            //                k++; return;
            //            }
            //            if (k == 1)
            //            {
            //                ColorLabel_True(label1);
            //                k++; return;
            //            }
            //            if (k == 2)
            //            {
            //                ColorLabel_True(label2);
            //                k++; return;
            //            }
            //            if (k == 3)
            //            {
            //                ColorLabel_True(label3);
            //                k++; return;
            //            }
            //            if (k == 4)
            //            {
            //                ColorLabel_True(label4);
            //                k++; return;
            //            }
            //            if (k == 5)
            //            {
            //                ColorLabel_True(label5);
            //                k++; return;
            //            }
            //            if (k == 6)
            //            {
            //                ColorLabel_True(label6);
            //                k++; return;
            //            }
            //            if (k == 7)
            //            {
            //                ColorLabel_True(label7);
            //                k++;
            //                MessageBox.Show("Hoan Thanh");
            //                this.Close(); return;
            //            }

            //        }
            //        else
            //        {
            //            Sai(btnm);
            //        }
            //        break;





            //}
        }

        private void Frm_LuyenTap_KeyPress_old1(object sender, KeyPressEventArgs e)
        {
            if (PositionKey >= Chuoi.Length)
                return;
            string stringlabel = Chuoi[PositionKey];
            Control ctnkey = FindControl(pn_stringKeys, "label" + PositionKey);
            if ((e.KeyChar > 96 && e.KeyChar < 123) || (e.KeyChar > 64 && e.KeyChar < 91)) //a->z || A->Z
            {
                string name = "btn" + e.KeyChar.ToString().ToLower();
                Control ctn = FindControl(pn_Keys, name);
                if (ctn != null)
                {
                    //HighLight((Button)ctn);
                    ((Button)ctn).Focus();
                    //Control ctnkey = FindControl(pn_stringKeys, "label" + z);
                    if (string.Compare(((Button)ctn).Text, stringlabel, true) == 0)
                    {
                        ColorLabel_True(((Label)ctnkey));
                        PositionKey++;
                        if (PositionKey < Chuoi.Length)
                        {
                            ctn = FindControl(pn_Keys, "btn" + Chuoi[PositionKey]);
                            if (ctn != null)
                                HighLight((Button)ctn);
                            SetFingerVisible(Chuoi[PositionKey]);
                        }
                    }
                    else
                    {
                        WrongKey((Label)ctnkey);
                    }
                }
            }
            else if (e.KeyChar > 31 && e.KeyChar < 127)
            {
                //char ch = (char)e.KeyChar;
                //string str = ch.ToString();
                int iAscii = e.KeyChar;
                Control ctn = FindControlByTag(pn_Keys, iAscii); //.Controls[name];
                if (ctn != null)
                {
                    ((Button)ctn).Focus();
                    char cKeylabel = stringlabel.ToCharArray()[0];
                    int iKeylabel = cKeylabel;
                    if (SearchStringInTagControl(ctn, iKeylabel) == true)
                    {
                        ColorLabel_True(((Label)ctnkey));
                        PositionKey++;
                        if (PositionKey < Chuoi.Length)
                        {
                            ctn = FindControl(pn_Keys, "btn" + Chuoi[PositionKey]);
                            if (ctn != null)
                                HighLight((Button)ctn);
                            SetFingerVisible(Chuoi[PositionKey]);
                        }
                    }
                    else
                    {
                        WrongKey((Label)ctnkey);
                    }

                }
            }
        }

        private void Frm_LuyenTap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (PositionKey >= Chuoi.Length)
                return;
            char keyText = Chuoi[PositionKey].ToCharArray()[0];// Chuoi[z];
            Control ctnkey = FindControl(pn_stringKeys, "label" + PositionKey);
            if (e.KeyChar > 31 && e.KeyChar < 127)
            {
                //char ch = (char)e.KeyChar;
                //string str = ch.ToString();
                int iAscii = e.KeyChar;
                Control ctn = FindControlByTag(pn_Keys, iAscii); //.Controls[name];
                if (ctn != null)
                {
                    ((Button)ctn).Focus();
                    //char cKeylabel = stringlabel.ToCharArray()[0];
                    //char cKeylabel = stringlabel.ToCharArray()[0];
                    //int iKeylabel = cKeylabel;

                    if (SearchStringInTagControl(ctn, keyText) == true) //if (SearchStringInTagControl(ctn, iKeylabel) == true)
                    {
                        ColorLabel_True(((Label)ctnkey));
                        PositionKey++;
                        if (PositionKey < Chuoi.Length)
                        {
                            iAscii = Chuoi[PositionKey].ToCharArray()[0];
                            ctn = FindControlByTag(pn_Keys, iAscii);//FindControl(pn_Keys, "btn" + stringlabel);
                            //if (ctn != null)
                            //{
                            //    HighLight((Button)ctn);
                            //    SetFingerVisible(RTB_String.Text[z].ToString().ToLower());
                            //}
                            while (ctn == null && PositionKey < Chuoi.Length)
                            {
                                PositionKey++;
                                iAscii = Chuoi[PositionKey].ToCharArray()[0];
                                ctn = FindControlByTag(pn_Keys, iAscii);
                            };
                            HighLight((Button)ctn);
                            SetFingerVisible(Chuoi[PositionKey].ToLower());
                        }
                    }
                    else
                    {
                        WrongKey((Label)ctnkey);
                    }

                }
            }
        }
    }
}
