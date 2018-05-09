﻿using Project_LTDM.Global;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Text.RegularExpressions;

namespace Project_LTDM
{
    public partial class Frm_FingerExercise : Form
    {
        Timer aTimer = new Timer();
        //string[] Chuoi = new string[11];
        Button btn_oldHighLight = new Button();
        Button btn_oldHighLight1 = new Button();
        Panel label_oldDefault = new Panel();
        //List<string> ListNgon;

        List<string> exerciseText = new List<string>(); //Chứa nội dung bài tập đánh máy
        string text = ""; //Chứa dòng đang xét

        int v = 0;
        int PositionKey = 0;
        public Frm_FingerExercise()
        {
            InitializeComponent();
        }

        public Frm_FingerExercise(List<string> text)
        {
            InitializeComponent();
            exerciseText = text;
            //RandomStringFollowList();
        }

        public void ShowKeys (int line) //Chuyển dòng trong file bài tập sang các label trên pn_stringKeys  
        {
            text = exerciseText[line]; // Lấy dòng đang xét
            int count = text.Count(); //Lấy số phần tử trong dòng được xét

            //Căn lại các label cho cân với pn_stringKeys
            if ( count > 12)
            {
                for (int i = 0; i < 10; i++)
                {
                    Label lbKey = new Label();
                    lbKey.BackColor = System.Drawing.SystemColors.Control;
                    lbKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                    lbKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lbKey.Location = new System.Drawing.Point(40 + (i * 105), 10);
                    lbKey.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                    lbKey.Name = "label" + i;
                    lbKey.Size = new System.Drawing.Size(60, 60);
                    lbKey.UseMnemonic = false;
                    lbKey.Text = text[i].ToString();
                    lbKey.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

                    Panel separator = new Panel();
                    separator.BackColor = System.Drawing.Color.LightGray;
                    separator.Location = new System.Drawing.Point(40 + (i * 105), 75);
                    separator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
                    separator.Name = "Separator" + i;
                    separator.Size = new System.Drawing.Size(60, 5);

                    pn_stringKeys.Controls.AddRange(new Control[] { lbKey, separator });
                }

                for (int i = 10; i < count; i++)
                {
                    Label lbKey = new Label();
                    lbKey.BackColor = System.Drawing.SystemColors.Control;
                    lbKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                    lbKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lbKey.Location = new System.Drawing.Point(40 + ((i - 10) * 105), 95);
                    lbKey.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                    lbKey.Name = "label" + i;
                    lbKey.Size = new System.Drawing.Size(60, 60);
                    lbKey.UseMnemonic = false;
                    lbKey.Text = text[i].ToString();
                    lbKey.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

                    Panel separator = new Panel();
                    separator.BackColor = System.Drawing.Color.LightGray;
                    separator.Location = new System.Drawing.Point(40 + ((i - 10) * 105), 160);
                    separator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
                    separator.Name = "Separator" + i;
                    separator.Size = new System.Drawing.Size(60, 5);

                    pn_stringKeys.Controls.AddRange(new Control[] { lbKey, separator });
                }
            }

            if (count <= 12)
            {
                for (int i = 0; i < 6; i++)
                {
                    Label lbKey = new Label();
                    lbKey.BackColor = System.Drawing.SystemColors.Control;
                    lbKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                    lbKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lbKey.Location = new System.Drawing.Point(250 + (i * 105), 10);
                    lbKey.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                    lbKey.Name = "label" + i;
                    lbKey.Size = new System.Drawing.Size(60, 60);
                    lbKey.UseMnemonic = false;
                    lbKey.Text = text[i].ToString();
                    lbKey.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

                    Panel separator = new Panel();
                    separator.BackColor = System.Drawing.Color.LightGray;
                    separator.Location = new System.Drawing.Point(250 + (i * 105), 75);
                    separator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
                    separator.Name = "Separator" + i;
                    separator.Size = new System.Drawing.Size(60, 5);

                    pn_stringKeys.Controls.AddRange(new Control[] { lbKey, separator });
                }

                for (int i = 6; i < count; i++)
                {
                    Label lbKey = new Label();
                    lbKey.BackColor = System.Drawing.SystemColors.Control;
                    lbKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                    lbKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lbKey.Location = new System.Drawing.Point(250 + ((i - 6) * 105), 95);
                    lbKey.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                    lbKey.Name = "label" + i;
                    lbKey.Size = new System.Drawing.Size(60, 60);
                    lbKey.UseMnemonic = false;
                    lbKey.Text = text[i].ToString();
                    lbKey.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

                    Panel separator = new Panel();
                    separator.BackColor = System.Drawing.Color.LightGray;
                    separator.Location = new System.Drawing.Point(250 + ((i - 6) * 105), 160);
                    separator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
                    separator.Name = "Separator" + i;
                    separator.Size = new System.Drawing.Size(60, 5);

                    pn_stringKeys.Controls.AddRange(new Control[] { lbKey, separator });
                }
            }
            Separator_True((Panel)pn_stringKeys.Controls[1]); //Chuyển màu separator đầu tiên
            int iAscii = text[0];
            Control ctn = FindControlByTag(pn_Keys, iAscii); //.Controls[name];
            if (ctn != null)
            {
                HighLight((Button)ctn);
                HighLightShift(text[0]);
            }

            if (PositionKey < text.Length)
                SetFingerVisible(text[PositionKey].ToString());
        }

        /*private void RandomString()
        {
            Random rnd = new Random();

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
        }*/

        /*private void RandomStringFollowList()
        {

            Random rnd = new Random();
            for (int i = 0; i < 11; i++)
            {
                string name = "label" + i;
                Control ctn = FindControl(pn_stringKeys, name);
                if (ctn != null)
                {
                    string skeys = ListNgon[rnd.Next(ListNgon.Count)];

                    ((Label)ctn).Text = skeys;
                    Chuoi[i] = skeys;
                }
            }
        }*/
     
        private void Frm_LuyenTap_Load(object sender, EventArgs e)
        {
            //StopFocus(this);
            aTimer.Tick += ATimer_Tick;
            aTimer.Interval = 3000;
      
            this.KeyPreview = true;
            ShowKeys(0);                 
        }

        private void ATimer_Tick(object sender, EventArgs e)
        {
            btn_oldHighLight.BackColor = Color.Red;
            aTimer.Stop();
        }

       
        private void HighLight(Button btn)
        {
            Normal(btn_oldHighLight);

            btn.BackColor = Color.LightSeaGreen;
            btn_oldHighLight = btn;

        }
        private void Button_False(Button btn)
        {

            Normal(btn_oldHighLight1);
            btn.BackColor = Color.PaleVioletRed;

            btn_oldHighLight1 = btn;


        }
        private void Separator_True(Panel sp)
        {
            Separator_Default(label_oldDefault);
            sp.BackColor = Color.LightSeaGreen;
            label_oldDefault = sp;

        }
        private void Separator_Default(Panel sp)
        {
            sp.BackColor = Color.LightGray;

        }
       /* private void ATimer_Tick(object sender, EventArgs e)
        {
            btn_oldHighLight.BackColor = Color.Red;
            aTimer.Stop();
        }*/
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

            btn.BackColor = Color.PaleVioletRed;
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
                        {
                            return true;
                        }
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

        //Kiểm tra ký tự xem có phải nhấn shift khi nhập không, nếu phải thì hightlight phím shift
        private void HighLightShift (char c)
        {
            Regex shift = new Regex("^[A-Z~!@#\\$%\\^\\\\*&()_\\+\\{\\}\\|:\"\\<\\>\\?]$");
            if (shift.IsMatch(c.ToString()))
            {
                btnShift.BackColor = Color.LightSeaGreen;
            }
            else
            {
                Normal(btnShift);
            }
        }

        private void Button_FalseShift(char c, char k)
        {
            Regex shift = new Regex("^[A-Z~!@#\\$%\\^\\\\*&()_\\+\\{\\}\\|:\"\\<\\>\\?]$");
            if (shift.IsMatch(c.ToString()))
            {
                btnShift.BackColor = Color.PaleVioletRed;
            }
            else if (shift.IsMatch(k.ToString()))
            {
                btnShift.BackColor = Color.LightSeaGreen;
            }
            else
            {
                Normal(btnShift);
            }
        }

        int currentLine = 0;

        private void Frm_LuyenTap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (timer1.Enabled == false)
            {
                timer1.Start();
            }
            if (PositionKey >= text.Length)
            {
                return;
            }
            
            char keyText = text[PositionKey];
            int compare = keyText;

            Control ctnkey = FindControl(pn_stringKeys, "label" + PositionKey);

            if ((e.KeyChar > 31 && e.KeyChar < 127))
            {
                int iAscii = e.KeyChar;
                Control ctn = FindControlByTag(pn_Keys, iAscii); //.Controls[name];
                if (ctn != null)
                {
                    //if (SearchStringInTagControl(ctn, keyText) == true)
                    if (iAscii == compare)
                    {
                        if (e.KeyChar.ToString() == @"\")
                        {
                            SoundPlayer sn1 = new SoundPlayer(@"sound\secphai.wav");
                            sn1.Play();
                        }
                        else if (e.KeyChar.ToString() == @"/")
                        {
                            SoundPlayer sn1 = new SoundPlayer(@"sound\sectrai.wav");
                            sn1.Play();
                        }
                        else if (e.KeyChar.ToString() == ".")
                        {
                            SoundPlayer sn1 = new SoundPlayer(@"sound\cham.wav");
                            sn1.Play();
                        }
                        else if (e.KeyChar.ToString() == " ")
                        {
                            SoundPlayer sn1 = new SoundPlayer(@"sound\space.wav");
                            sn1.Play();
                        }
                        else if (e.KeyChar.ToString() == "[" || e.KeyChar.ToString() == "]")
                        {
                            SoundPlayer sn1 = new SoundPlayer(@"sound\[].wav");
                            sn1.Play();
                        }
                        else if (Regex.Match(e.KeyChar.ToString(), "[A-Za-z0-9]").Length != 0)
                        {
                            SoundPlayer sn = new SoundPlayer(@"sound\" + e.KeyChar.ToString().ToLower() + ".wav");
                            sn.Play();
                        }
                        else
                        {
                            SoundPlayer sn = new SoundPlayer(@"sound\shift-key.wav");
                            sn.Play();
                        }

                        ColorLabel_True(((Label)ctnkey));
                        PositionKey++;

                        if (PositionKey < text.Length)
                        {
                            iAscii = text[PositionKey];
                            ctn = FindControlByTag(pn_Keys, iAscii);
                            Control ctnspr = FindControl(pn_stringKeys, "Separator" + PositionKey);

                            while (ctn == null && PositionKey < text.Length)
                            {
                                PositionKey++;
                                iAscii = text[PositionKey];
                                ctn = FindControlByTag(pn_Keys, iAscii);
                            }

                            HighLight((Button)ctn);
                            HighLightShift(text[PositionKey]);
                            Normal(btn_oldHighLight1);
                            Separator_True(((Panel)ctnspr));

                            SetFingerVisible(text[PositionKey].ToString().ToLower());
                        }
                    }
                    else
                    {
                        SoundPlayer sn1 = new SoundPlayer(@"sound\wrong.wav");
                        sn1.Play();
                        Button_False((Button)ctn);
                        Button_FalseShift((char)e.KeyChar, text[PositionKey]);
                        WrongKey((Label)ctnkey);
                    }
                    if (PositionKey == text.Length) 
                    {
                        /*Nếu PositionKey đã ở cuối dòng nhưng vẫn còn dòng trong bài tập
                         * thì xoá toàn bộ control trong pn_stringKeys, sau đó hiển thị các
                         * control mới, trả PositionKey về vị trí đầu dòng mới  */
                        if (currentLine < exerciseText.Count - 1) 
                        {
                            currentLine++;
                            pn_stringKeys.Controls.Clear();
                            ShowKeys(currentLine);
                            PositionKey = 0;
                        }
                        else
                        {
                            v = 1;
                        }
                    }
                }
            }
        }

        int dongho = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            SoundPlayer spwinner = new SoundPlayer(@"sound\winner.wav");
            int i = Convert.ToInt32(label11.Text);
            if (v == 0)
            {
                if (i != 0)
                {
                    i = Convert.ToInt32(label11.Text);
                    i--;
                    label11.Text = i.ToString();
                    picwatch.Image = null;
                    if (dongho == 0)
                    {
                        picwatch.Image = Image.FromFile("xoaytrai.png");
                        dongho = 1;
                    }
                    else
                    {
                        picwatch.Image = Image.FromFile("xoayphai.png");
                        dongho = 0;
                    }
                }
                else
                {
                    if (pictureBox4.Visible == false)
                    {
                        pictureBox4.Visible = true;

                        return;
                    }
                    else
                    {
                        pictureBox5.Visible = true;

                        v = 2;
                        MessageBox.Show("Ban duoc 2 sao va 0 giay");
                    }
                }

            }
            else if (v == 1)
            {

                if (i < 10)
                {
                    pictureBox5.Visible = true;

                    v = 2;
                    MessageBox.Show("Ban duoc 1 sao");
                    spwinner.Play();

                }

                else if (i >= 10 && i < 30)
                {
                    if (pictureBox4.Visible == false)
                    {
                        pictureBox4.Visible = true;
                        spwinner.Play();
                        return;
                    }
                    else
                    {
                        pictureBox2.Visible = true;

                        v = 2;
                        MessageBox.Show("Ban duoc 2 sao");
                    }

                }
                else if (i >= 30 && i < 40)
                {
                    if (pictureBox4.Visible == false)
                    {
                        pictureBox4.Visible = true;
                        spwinner.Play();
                        return;
                    }
                    else if (pictureBox5.Visible == false)
                    {
                        pictureBox5.Visible = true;
                        return;
                    }
                    else
                    {
                        pictureBox2.Visible = true;

                        v = 2;
                        MessageBox.Show("Ban duoc 3 sao");
                    }

                }
                else if (i >= 40 && i < 50)
                {
                    if (pictureBox3.Visible == false)
                    {
                        pictureBox3.Visible = true;
                        spwinner.Play();
                        return;
                    }
                    else if (pictureBox4.Visible == false)
                    {
                        pictureBox4.Visible = true;
                        return;
                    }
                    else if (pictureBox5.Visible == false)
                    {
                        pictureBox5.Visible = true;
                        return;
                    }
                    else
                    {
                        pictureBox2.Visible = true;

                        v = 2;
                        MessageBox.Show("Ban duoc 4 sao");
                    }

                }
                else if (i >= 50 && i < 60)
                {
                    if (pictureBox3.Visible == false)
                    {
                        pictureBox3.Visible = true;
                        spwinner.Play();
                        return;
                    }
                    else if (pictureBox4.Visible == false)
                    {
                        pictureBox4.Visible = true;
                        return;
                    }
                    else if (pictureBox5.Visible == false)
                    {
                        pictureBox5.Visible = true;
                        return;
                    }
                    else if (pictureBox2.Visible == false)
                    {
                        pictureBox2.Visible = true;
                        return;
                    }
                    else
                    {
                        pictureBox6.Visible = true;

                        v = 2;
                        MessageBox.Show("Ban duoc 5 sao");
                    }


                }

            }
        }

        /*public void StopFocus (Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c.Controls != null)
                {
                    StopFocus(c);
                }
                c.TabStop = false;
            }
        }*/
    }
}