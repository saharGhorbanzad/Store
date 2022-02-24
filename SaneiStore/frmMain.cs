using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaneiStore
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private void ثبتمشتریToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Customer frm_Customer = new frm_Customer();
            frm_Customer.Show();
        }

        private void لیستمشتریهاToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_CustomerList frm_CustomerList = new frm_CustomerList();
            frm_CustomerList.Show();
        }

        private void انبارToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_StoreList frm_StoreList = new frm_StoreList();
            frm_StoreList.Show();
        }
    }
}
