using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace Project_LTDM
{
    public partial class Frm_Rating : Form
    {
        public Frm_Rating()
        {
            InitializeComponent();
        }

        int z;
        int i = 1;
        bool canSave;
        DTO_Exercise ex;

        public Frm_Rating(int numStar)
        {
            InitializeComponent();
            btnRemake.Hide();
            canSave = false;
            z = numStar;
            switch (numStar)
            {
                case 1:
                    lbComment.Text = "Maybe try harder next time?";
                    break;
                case 2:
                    lbComment.Text = "Not bad, but you could improve.";
                    break;
                case 3:
                    lbComment.Text = "It's ok, now try to be perfect!";
                    break;
                case 4:
                    lbComment.Text = "You're almost there!!!";
                    break;
                case 5:
                    lbComment.Text = "Fantastic, absolutely awesome!";
                    break;
                default:
                    lbComment.Text = "Congrat!";
                    break;
            }

            //Căn giữa lbComment
            int locX = (this.Size.Width - lbComment.Size.Width) / 2;
            lbComment.Location = (new Point(locX, 33));
            timer1.Start();
         
        }

        int timeLeft;
        int PositionKey;
        int numStar;

        public Frm_Rating (int numStar, DTO_Exercise ex, int timeLeft, int PositionKey) : this (numStar)
        {
            btnRemake.Show();
            canSave = true;
            this.ex = ex;
            this.numStar = numStar;
            this.timeLeft = timeLeft;
            this.PositionKey = PositionKey;
        }
       
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (i <= z)
            {
                PictureBox pcbStar = panel1.Controls.Find("pcbStar" + i, true).FirstOrDefault() as PictureBox;
                pcbStar.Image = global::Project_LTDM.Properties.Resources.OK_Star;
                i++;
            }
        }

        private void btnChangeCourse_Click(object sender, EventArgs e)
        {
            if (canSave == true)
            {
                if (BUS.BUS_Typing.SaveDataPause(ex, timeLeft, PositionKey, numStar) == true)
                {
                    MessageBox.Show("Save successful");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Save Fail");
                }
            }
            
            this.Close();
        }

        private void btnRemake_Click(object sender, EventArgs e)
        {
            ex.Position = 0;
            ex.Star = 0;
            ex.Timeleft = ex.Time;

            if (BUS.BUS_Typing.SaveDataPause(ex, ex.Time, 0, 0) == true)
            {
                MessageBox.Show("Remake successful");
                this.Close();
            }
            else
            {
                MessageBox.Show("Remake Fail");
            }
        }
    }
}
