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
    public partial class BaiTap : UserControl
    {
        public BaiTap()
        {
            InitializeComponent();
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

       
    }
}
