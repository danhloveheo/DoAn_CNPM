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
        Button btn_oldHighLight1 = new Button();
        Panel label_oldDefault = new Panel();
        List<string> ListNgon;
     
        int v = 0;
        int PositionKey = 0;
        public Frm_LuyenTap()
        {
            InitializeComponent();
        }

        public Frm_LuyenTap(List<string> listNgon)
        {
            InitializeComponent();
            ListNgon = listNgon;
            RandomStringFollowList();
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

        private void RandomStringFollowList()
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
        }
     
        private void Frm_LuyenTap_Load(object sender, EventArgs e)
        {
            aTimer.Tick += ATimer_Tick;
            aTimer.Interval = 3000;

       

            this.KeyPreview = true;
            Separator_True(Separator0);


         

            int iAscii = Chuoi[PositionKey].ToCharArray()[0];
            Control ctn = FindControlByTag(pn_Keys, iAscii); //.Controls[name];
            if (ctn != null)
            {
                HighLight((Button)ctn);
            }

            if (PositionKey < Chuoi.Length)
                SetFingerVisible(Chuoi[PositionKey]);

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

      

        private void Frm_LuyenTap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (timer1.Enabled == false)
            {
                timer1.Start();
            }
            if (PositionKey >= Chuoi.Length)
                return;
            char keyText = Chuoi[PositionKey].ToCharArray()[0];
            Control ctnkey = FindControl(pn_stringKeys, "label" + PositionKey);

            if ((e.KeyChar > 31 && e.KeyChar < 127))
            {
                int iAscii = e.KeyChar;
                Control ctn = FindControlByTag(pn_Keys, iAscii); //.Controls[name];
                if (ctn != null)
                {



                    if (SearchStringInTagControl(ctn, keyText) == true) 
                    {
                        ColorLabel_True(((Label)ctnkey));
                        PositionKey++;
                      
                        if (PositionKey < Chuoi.Length)
                        {
                            iAscii = Chuoi[PositionKey].ToCharArray()[0];
                            ctn = FindControlByTag(pn_Keys, iAscii);
                            Control ctnspr = FindControl(pn_stringKeys, "Separator" + PositionKey);


                            while (ctn == null && PositionKey < Chuoi.Length)
                            {
                                PositionKey++;
                                iAscii = Chuoi[PositionKey].ToCharArray()[0];
                                ctn = FindControlByTag(pn_Keys, iAscii);
                            }
                                HighLight((Button)ctn);
                            Normal(btn_oldHighLight1);
                            Separator_True(((Panel)ctnspr));

                            SetFingerVisible(Chuoi[PositionKey].ToLower());
                        }
                    }
                    else
                    {
                        Button_False((Button)ctn);
                        WrongKey((Label)ctnkey);
                    }
                    if (PositionKey == 11)
                    {

                        v = 1;

                    }
                }
            }
          
        }
        int dongho = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
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


                }

                else if (i >= 10 && i < 30)
                {
                    if (pictureBox4.Visible == false)
                    {
                        pictureBox4.Visible = true;

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
    }
}
