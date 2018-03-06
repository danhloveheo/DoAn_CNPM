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
    public partial class Frm_Typing : Form
    {
        Timer aTimer = new Timer();
        string[] Chuoi = new string[11];
        Button btn_oldHighLight = new Button();
        int PositionKey = 0;
        public Frm_Typing()
        {
            InitializeComponent();
        }

        private void Frm_Typing_Load(object sender, EventArgs e)
        {
            aTimer.Tick += ATimer_Tick;
            aTimer.Interval = 3000;
            // danh cho check van ban
            //richTextBox1.Select(0,1);
            //richTextBox1.SelectionColor = Color.Green;
            //richTextBox1.Select(1, 3);
            //richTextBox1.SelectionColor = Color.Red;
            //RandomString();
            int iAscii = RTB_String.Text[PositionKey];
            Control ctn = FindControlByTag(pn_Keys, iAscii); //.Controls[name];
            if (ctn != null)
            {
                HighLight((Button)ctn);
            }
            if (PositionKey < RTB_String.Text.Length)
                SetFingerVisible(RTB_String.Text[PositionKey].ToString().ToLower());
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

        private void Frm_Typing_KeyDown(object sender, KeyEventArgs e)
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

        private void Frm_Typing_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {

                case Keys.Q: Normal(btnq); break;
                case Keys.W: Normal(btnw); break;
                case Keys.E: Normal(btne); break;
                case Keys.R: Normal(btnr); break;
            }
        }

        private void Frm_Typing_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (PositionKey >= RTB_String.Text.Length)
                return;
            char keyText = RTB_String.Text[PositionKey];// Chuoi[z];
            //string stringlabel = key.ToString().ToLower();
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
                        RTB_String.Select(PositionKey, 1);
                        RTB_String.SelectionColor = Color.Green;

                        PositionKey++;
                        if (PositionKey < RTB_String.Text.Length)
                        {
                            iAscii = RTB_String.Text[PositionKey];
                            ctn = FindControlByTag(pn_Keys, iAscii);//FindControl(pn_Keys, "btn" + stringlabel);
                            //if (ctn != null)
                            //{
                            //    HighLight((Button)ctn);
                            //    SetFingerVisible(RTB_String.Text[z].ToString().ToLower());
                            //}
                            while (ctn == null && PositionKey < RTB_String.Text.Length)
                            {
                                PositionKey++;
                                iAscii = RTB_String.Text[PositionKey];
                                ctn = FindControlByTag(pn_Keys, iAscii);
                            };
                            HighLight((Button)ctn);
                            SetFingerVisible(RTB_String.Text[PositionKey].ToString().ToLower());
                        }
                    }
                    else
                    {
                        RTB_String.Select(PositionKey, 1);
                        RTB_String.SelectionColor = Color.Red;
                    }

                }
            }
        }
    }
}
