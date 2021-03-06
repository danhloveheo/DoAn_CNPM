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
using DTO;
using BUS;

namespace Project_LTDM
{
    public partial class Frm_Typing : Form
    {
        bool pause = false;
        Timer aTimer = new Timer();
        //string[] Chuoi = new string[11];
        Button btn_oldHighLight = new Button();
        Button btn_oldHighLight1 = new Button();
        DTO_Exercise objectmodel;
        bool finished = false;
        int PositionKey = 0;

        //Dùng cho ProgressBar
        int numSentence = 0; //Số câu trong đoạn văn.
        int curSentence = 0; //Stt câu hiện tại.

        string type;
        int time;
        int timeLeft;
        int location = 0;
        string NameFile;
        string Title;
        List<string> exerciseText = new List<string>();

        //Dùng xác định có thể remake hay không;
        bool canRemake = false;

        public Frm_Typing()
        {
            InitializeComponent();

            //Căn lề cho văn bản trong RTB_String
            /*RTB_String.SelectAll();
            RTB_String.SelectionAlignment = HorizontalAlignment.Center;
            RTB_String.DeselectAll();*/

            //Tìm index ký tự cuối cùng được hiển thị để scroll
            location = RTB_String.GetCharIndexFromPosition(new Point(RTB_String.ClientSize.Width, RTB_String.ClientSize.Height));
        }

        //public Frm_Typing(List<string> text, int t)
        //{
        //    //TODO: Thay đổi kích thước font chữ trong RTB_String theo từng loại

        //    InitializeComponent();
        //    time = t;
        //    timeLeft = t;
        //    exerciseText = text;
        //    if (time < 3600)
        //    {
        //        lbTimer.Text = TimeSpan.FromSeconds(timeLeft).ToString(@"mm\:ss");
        //    }
        //    else
        //    {
        //        lbTimer.Text = TimeSpan.FromSeconds(timeLeft).ToString(@"hh\:mm\:ss");
        //    }
        //    RTB_String.Lines = exerciseText.ToArray();

        //    //Tìm index ký tự cuối cùng được hiển thị để scroll
        //    location = RTB_String.GetCharIndexFromPosition(new Point(RTB_String.ClientSize.Width, RTB_String.ClientSize.Height));
        //}
        public Frm_Typing(DTO_Exercise ob)
        {
            InitializeComponent();
            objectmodel = ob;
            time = objectmodel.Timeleft;
            Title = objectmodel.Title;
            NameFile = objectmodel.FileName;
            PositionKey = objectmodel.Position;
            //exerciseText = objectmodel.ExerciseText;
            //BUS.BUS_Typing.FindContent(ob, ref time, ref Title, ref NameFile,ref exerciseText);
            this.type = objectmodel.ExerciseType;
            
            //Thay đổi kích thước font chữ trong RTB_String theo từng loại
            switch (type)
            {
                case "Word":
                    RTB_String.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
                    break;
                case "Sentence":
                    RTB_String.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.5F);
                    break;
                case "Paragraph":
                    RTB_String.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
                    break;
            }

            //Xoá các ký tự trằng đầu và cuối đoạn văn, thêm ký hiệu "↵" vào cuối đoạn.
            foreach (string line in objectmodel.ExerciseText)
            {
                if (line.Trim() != "")
                {
                    exerciseText.Add(line.Trim() + "↵");
                }

            }

            timeLeft = time;
            if (time < 3600)
            {
                lbTimer.Text = TimeSpan.FromSeconds(timeLeft).ToString(@"mm\:ss");
            }
            else
            {
                lbTimer.Text = TimeSpan.FromSeconds(timeLeft).ToString(@"hh\:mm\:ss");
            }
            RTB_String.Lines = exerciseText.ToArray();

            //Đếm số câu trong bài, dùng cho ProgressBar
            for (int i = 0; i < RTB_String.Text.Length; i++)
            {
                if (RTB_String.Text[i] == '.' || RTB_String.Text[i] == '?' || RTB_String.Text[i] == '↵')
                {
                    numSentence++;
                }

                if (i > 0 && RTB_String.Text[i] == '↵' && (RTB_String.Text[i - 1] == '.' || RTB_String.Text[i - 1] == '?'))
                {
                    numSentence--;
                }

                if (i < PositionKey)
                {
                    curSentence = numSentence;
                }
            }

            if (ob.Star > 0) //Đã hoàn thành
            {
                finished = true;
                curSentence = numSentence;
            }

            //Cập nhật ProgressBar
            progressBar1.Maximum = numSentence;
            lbStatus.Text = "Progress: " + curSentence + "/" + numSentence + " sentence.";

            //Nếu form dùng hiển thị bài học thì ẩn nút save
            if (objectmodel.IsLesson == true)
            {
                btn_save.Hide();
            }

            //Tìm index ký tự cuối cùng được hiển thị để scroll
            location = RTB_String.GetCharIndexFromPosition(new Point(RTB_String.ClientSize.Width, RTB_String.ClientSize.Height));
            LoadKeyPressed();
            ScrollText();
        }

        public Frm_Typing(DTO_Exercise ob, bool canRemake) : this(ob)
        {
            this.canRemake = canRemake;
        }

        private void Frm_Typing_Load(object sender, EventArgs e)
        {
            // Start the BackgroundWorker.
            backgroundWorker1.RunWorkerAsync();

            //finished = false;
            aTimer.Tick += ATimer_Tick;
            aTimer.Interval = 3000;
            // danh cho check van ban
            //richTextBox1.Select(0,1);
            //richTextBox1.SelectionColor = Color.Green;
            //richTextBox1.Select(1, 3);
            //richTextBox1.SelectionColor = Color.Red;
            //RandomString();

            if (finished == true && PositionKey != 0)
            {
                PositionKey--;
            }

            int iAscii = RTB_String.Text[PositionKey];
            RTB_String.Select(0, PositionKey);
            RTB_String.SelectionColor = Color.Green;
            RTB_String.SelectionFont = new System.Drawing.Font("Microsoft Sans Serif", 14.5F, System.Drawing.FontStyle.Underline);

            BUS_Typing.StopFocus(this);
            Control ctn = FindControlByTag(pn_Keys, iAscii); //.Controls[name];
            if (ctn != null)
            {
                HighLight((Button)ctn);
                HighLightShift(RTB_String.Text[PositionKey]);
            }
            if (PositionKey < RTB_String.Text.Length)
                SetFingerVisible(RTB_String.Text[PositionKey].ToString().ToLower());
            this.KeyPreview = true;

            if (finished == true)
            {
                Frm_Rating rating;

                if (canRemake == true)
                {
                    rating = new Frm_Rating(objectmodel.Star, objectmodel, timeLeft, PositionKey);
                }
                else
                {
                    rating = new Frm_Rating(objectmodel.Star);
                }

                this.Show();
                rating.ShowDialog(this);
                this.Close();
            }
        }
        private void Button_False(Button btn)
        {

            Normal(btn_oldHighLight1);
            btn.BackColor = Color.PaleVioletRed;

            btn_oldHighLight1 = btn;


        }
        private void ATimer_Tick(object sender, EventArgs e)
        {
            btn_oldHighLight.BackColor = Color.Red;
            aTimer.Stop();
        }
        void LoadKeyPressed()
        {
            RTB_String.Select(0, PositionKey);
            RTB_String.SelectionColor = Color.Green;
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
            skey = skey.ToLower();
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
        private void HighLightShift(char c)
        {
            Regex shift = new Regex("^[A-Z~!@#\\$%\\^\\\\*&()_\\+\\{\\}\\|:\"\\<\\>\\?]$");
            if (shift.IsMatch(c.ToString()))
            {
                btnShift.BackColor = Color.Green;
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
                btnShift.BackColor = Color.Green;
            }
            else
            {
                Normal(btnShift);
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
            ScrollText();

            if (timer1.Enabled == false)
            {
                timer1.Start();
            }

            if (PositionKey >= RTB_String.Text.Length)
                return;
            char keyText = RTB_String.Text[PositionKey];// Chuoi[z];
            int compare = keyText;

            if (keyText == '↵')
            {
                compare = 8629;
            }

            //string stringlabel = key.ToString().ToLower();
            if (e.KeyChar > 31 && e.KeyChar < 127 || e.KeyChar == 13)
            {
                //char ch = (char)e.KeyChar;
                //string str = ch.ToString();
                int iAscii = e.KeyChar;

                //8629 là mà Ascii của "↵"
                if (e.KeyChar == 13)
                {
                    iAscii = 8629;
                }

                Control ctn = FindControlByTag(pn_Keys, iAscii); //.Controls[name];
                if (ctn != null)
                {
                    //((Button)ctn).Focus();
                    //char cKeylabel = stringlabel.ToCharArray()[0];
                    //char cKeylabel = stringlabel.ToCharArray()[0];
                    //int iKeylabel = cKeylabel;

                    //if (SearchStringInTagControl(ctn, keyText) == true) //if (SearchStringInTagControl(ctn, iKeylabel) == true)
                    if (iAscii == compare)
                    {
                        if (e.KeyChar.ToString() == @"\")
                        {
                            SoundPlayer sn = new SoundPlayer(@"sound\secphai.wav");
                            sn.Play();
                        }
                        else if (e.KeyChar.ToString() == @"/")
                        {
                            SoundPlayer sn = new SoundPlayer(@"sound\sectrai.wav");
                            sn.Play();
                        }
                        else if (e.KeyChar.ToString() == ".")
                        {
                            SoundPlayer sn = new SoundPlayer(@"sound\cham.wav");
                            sn.Play();
                        }
                        else if (e.KeyChar.ToString() == " ")
                        {
                            SoundPlayer sn = new SoundPlayer(@"sound\space.wav");
                            sn.Play();
                        }
                        else if (e.KeyChar.ToString() == "[" || e.KeyChar.ToString() == "]")
                        {
                            SoundPlayer sn = new SoundPlayer(@"sound\[].wav");
                            sn.Play();
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

                        RTB_String.Select(PositionKey, 1);
                        RTB_String.SelectionColor = Color.Green;

                        if ((keyText == '.' || keyText == '?') && RTB_String.Text[PositionKey + 1] != '↵')
                        {
                            ChangeInfo();
                        }

                        if (keyText == '↵')
                        {
                            ChangeInfo();
                        }

                        switch (type)
                        {
                            case "Word":
                                RTB_String.SelectionFont = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Underline);
                                break;
                            case "Sentence":
                                RTB_String.SelectionFont = new System.Drawing.Font("Microsoft Sans Serif", 27.5F, System.Drawing.FontStyle.Underline);
                                break;
                            case "Paragraph":
                                RTB_String.SelectionFont = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Underline);
                                break;
                        }

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
                            HighLightShift(RTB_String.Text[PositionKey]);
                            Normal(btn_oldHighLight1);
                            SetFingerVisible(RTB_String.Text[PositionKey].ToString().ToLower());

                        }
                    }
                    else
                    {
                        SoundPlayer sn1 = new SoundPlayer(@"sound\wrong.wav");
                        sn1.Play();
                        RTB_String.Select(PositionKey, 1);
                        RTB_String.SelectionColor = Color.PaleVioletRed;

                        switch (type)
                        {
                            case "Word":
                                RTB_String.SelectionFont = new System.Drawing.Font("Microsoft Sans Serif", 36.5F, System.Drawing.FontStyle.Underline);
                                break;
                            case "Sentence":
                                RTB_String.SelectionFont = new System.Drawing.Font("Microsoft Sans Serif", 28.5F, System.Drawing.FontStyle.Underline);
                                break;
                            case "Paragraph":
                                RTB_String.SelectionFont = new System.Drawing.Font("Microsoft Sans Serif", 14.5F, System.Drawing.FontStyle.Underline);
                                break;
                        }

                        Button_FalseShift((char)e.KeyChar, RTB_String.Text[PositionKey]);
                        Button_False((Button)ctn);
                    }

                    if (PositionKey == RTB_String.Text.Length)
                    {
                        finished = true;
                    }
                }
            }
        }

        private void ScrollText()
        {
            //Tự động scroll văn bản trong RTB_String khi đánh đến dòng cuối đang được hiển thị
            if (PositionKey == location - 1 && location != RTB_String.Text.Length - 1)
            {
                //Xác định vị trí cần scroll
                RTB_String.SelectionStart = location;
                RTB_String.ScrollToCaret();

                //Tìm index ký tự cuối cùng được hiển thị để scroll lần sau
                location = RTB_String.GetCharIndexFromPosition(new Point(RTB_String.ClientSize.Width, RTB_String.ClientSize.Height));
            }
        }

        int dongho = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (finished == false)
            {
                if (timeLeft != 0)
                {
                    timeLeft--;
                    if (timeLeft < 3600)
                    {
                        lbTimer.Text = TimeSpan.FromSeconds(timeLeft).ToString(@"mm\:ss");
                    }
                    else
                    {
                        lbTimer.Text = TimeSpan.FromSeconds(timeLeft).ToString(@"hh\:mm\:ss");
                    }
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
                    FinishTyping(1);
                }

            }
            else if (finished == true)
            {
                if (timeLeft < time * 0.3)
                {
                    FinishTyping(1);
                }

                else if (timeLeft >= time * 0.3 && timeLeft < time * 0.5)
                {
                    FinishTyping(2);
                }

                else if (timeLeft >= time * 0.5 && timeLeft < time * 0.7)
                {
                    FinishTyping(3);
                }

                else if (timeLeft >= time * 0.7 && timeLeft < time * 0.9)
                {
                    FinishTyping(4);
                }

                else if (timeLeft > time * 0.9)
                {
                    FinishTyping(5);
                }
            }
        }

        private void FinishTyping(int star)
        {
            timer1.Stop();
            SoundPlayer spwinner = new SoundPlayer(@"sound\winner.wav");
            spwinner.Play();

            Frm_Rating rating;

            if (canRemake == true)
            {
                rating = new Frm_Rating(star, objectmodel, timeLeft, PositionKey);
            }
            else
            {
                rating = new Frm_Rating(star);
            }

            rating.ShowDialog(this);

            /*if (BUS.BUS_Typing.SaveDataPause(objectmodel, timeLeft, PositionKey, star) == true)
            {
                MessageBox.Show("Save successful");
                this.Close();
            }
            else
            {
                MessageBox.Show("Save Fail");
            }*/ 

            this.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
          
        }

        private void btnPause_Continue_Click(object sender, EventArgs e)
        {
          
        }

        //Xoá Focus để nhận phím Enter
        private void DismissFocus (object sender, EventArgs e)
        {
            label1.Focus();
        }

        //Thay đổi thông báo số dòng còn lại
        private void ChangeInfo ()
        {
            progressBar1.Increment(1);
            lbStatus.Text = "Progress: " + progressBar1.Value + "/" + numSentence + " sentence.";
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            // set the progress bar value and report it to the main UI
            int i = curSentence; // value between 0~100
            backgroundWorker1.ReportProgress(i);
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // Change the value of the ProgressBar to the BackgroundWorker progress.
            progressBar1.Value = e.ProgressPercentage;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (pause == false)//pause
            {
                pause = true;
                btnPause_Continue.Text = "Continue";
                timer1.Stop();
                pn_Keys.Enabled = false;
            }
            else
            {
                pause = false;
                btnPause_Continue.Text = "Pause";
                timer1.Start();
                pn_Keys.Enabled = true;
            }
            label1.Focus();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (BUS.BUS_Typing.SaveDataPause(objectmodel, timeLeft, PositionKey, 0) == true)
            {
                MessageBox.Show("Save successful");
                this.Close();
            }
            else
            {
                MessageBox.Show("Save Fail");
            }
            label1.Focus();
        }

        private void Frm_Typing_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop();
        }
    }
}
