using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_LTDM.Global;

namespace Project_LTDM.UserControls
{
    public partial class LuyenTap : UserControl
    {
        public LuyenTap()
        {
            InitializeComponent();
        }

       

        private void LuyenTap_Load(object sender, EventArgs e)
        {

        }

        private void btnmotngon_Click(object sender, EventArgs e)
        {
            Frm_LuyenTap frm = new Frm_LuyenTap(Finger.NgonTro);
            frm.ShowDialog();
        }

        private void btnhaingon_Click(object sender, EventArgs e)
        {
            Frm_LuyenTap frm = new Frm_LuyenTap(Finger.NgonTro_NgonGiua);
            frm.ShowDialog();
        }

        private void btnbangon_Click(object sender, EventArgs e)
        {
            Frm_LuyenTap frm = new Frm_LuyenTap(Finger.NgonTro_NgonGiua_ApUt);
            frm.ShowDialog();
        }

        private void btnbonngon_Click(object sender, EventArgs e)
        {
            Frm_LuyenTap frm = new Frm_LuyenTap(Finger.NgonTro_NgonGiua_ApUt_Ut);
            frm.ShowDialog();
        }

        private void btnnamngon_Click(object sender, EventArgs e)
        {
            Frm_LuyenTap frm = new Frm_LuyenTap(Finger.NgonTro_NgonGiua_ApUt_Ut_Cai);
            frm.ShowDialog();
        }

        private void radRandom_CheckedChanged(object sender, EventArgs e)
        {
            if (radRandom.Checked == true)
            {
                grbrandom.Enabled = true;
                grbfinger.Enabled = false;
            }
            else
            {
                grbrandom.Enabled = false;
                grbfinger.Enabled = true;
            }
        }

        private void btnstart_Click(object sender, EventArgs e)
        {
            if (txtrandomkeys.Text == "")
            {
                MessageBox.Show("Vui lòng nhập kí tự ");
                txtrandomkeys.Select();
            }
            else
            {
                Frm_LuyenTap frm = new Frm_LuyenTap(txtrandomkeys.Text);
                frm.Show();
            }
        }       
    }
}
