using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_LTDM.UserControls
{
    public partial class KhoaHoc : UserControl
    {
        public event EventHandler btnC1Click;
        public event EventHandler btnC2Click;
        public event EventHandler btnC3Click;
        public event EventHandler btnC4Click;

        public KhoaHoc()
        {
            InitializeComponent();
        }

        private void btnC1_Click(object sender, EventArgs e)
        {
            //Bubble the event up to the parent
            if (this.btnC1Click != null) //Null check makes sure the main page is attached to the event
            {
                this.btnC1Click(this, e);
            }
        }

        private void btnC2_Click(object sender, EventArgs e)
        {
            //Bubble the event up to the parent
            if (this.btnC2Click != null) //Null check makes sure the main page is attached to the event
            {
                this.btnC2Click(this, e);
            }
        }

        private void btnC3_Click(object sender, EventArgs e)
        {
            //Bubble the event up to the parent
            if (this.btnC3Click != null) //Null check makes sure the main page is attached to the event
            {
                this.btnC3Click(this, e);
            }
        }

        private void btnC4_Click(object sender, EventArgs e)
        {
            //Bubble the event up to the parent
            if (this.btnC4Click != null) //Null check makes sure the main page is attached to the event
            {
                this.btnC4Click(this, e);
            }
        }

        private void btnC1_Click_1(object sender, EventArgs e)
        {
            //Bubble the event up to the parent
            if (this.btnC1Click != null) //Null check makes sure the main page is attached to the event
            {
                this.btnC1Click(this, e);
            }
        }

        private void btnC2_Click_1(object sender, EventArgs e)
        {
            //Bubble the event up to the parent
            if (this.btnC2Click != null) //Null check makes sure the main page is attached to the event
            {
                this.btnC2Click(this, e);
            }
        }

        private void btnC3_Click_1(object sender, EventArgs e)
        {
            //Bubble the event up to the parent
            if (this.btnC3Click != null) //Null check makes sure the main page is attached to the event
            {
                this.btnC3Click(this, e);
            }
        }

        private void btnC4_Click_1(object sender, EventArgs e)
        {
            //Bubble the event up to the parent
            if (this.btnC4Click != null) //Null check makes sure the main page is attached to the event
            {
                this.btnC4Click(this, e);
            }
        }
    }
}
