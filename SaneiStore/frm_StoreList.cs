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
    public partial class frm_StoreList : Form
    {
        public frm_StoreList()
        {
            InitializeComponent();
            dgvStore.AutoGenerateColumns = false;
        }

        private void frm_StoreList_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            using (SaneiStore.SaneiStoreEntities2 db = new SaneiStoreEntities2())
            {
                dgvStore.DataSource = db.Store
                    .Where(s => s.PlotName.Contains(txtPlotName.Text))
                    .Join(db.Provider,
                    s => s.Provider,
                    p => p.ID,
                    (store, provider) => new StoreVM
                    {
                        PlotId = store.PlotId,
                        ProviderName = provider.Name,
                        PlotName = store.PlotName,
                        Price = store.Price,
                        Count = store.Count,
                        Dsc = store.Dsc,
                        PurchaseDate = store.PurchaseDate
                    }).ToList();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_StoreList form2 = new frm_StoreList();
            form2.Show();
        }

        private void dgvStore_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            tsslInfo2.Text = "";
            if (e.RowIndex < 0)
            {
                return;
            }
            tsslInfo2.Text = $"{e.RowIndex + 1}از{dgvStore.Rows.Count}";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void txtPlotName_KeyDown(object sender, KeyEventArgs e)
        {
            if(Convert.ToInt32( e.KeyCode)==13)
            {
                LoadData();
            }
        }
    }
}
