using SaneiStore.ViewModel;
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
    public partial class frm_CustomerList : Form
    {
        public frm_CustomerList()
        {
            InitializeComponent();
            dgvCustomer.AutoGenerateColumns = false;
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            LoadData();
            FillComboBox();
        }

        private void FillComboBox()
        {
            using (SaneiStore.SaneiStoreEntities2 db = new SaneiStoreEntities2())
            {
                var m = db.Store.Select(p => new ViewModel.IdNamePairVM
                {
                    Id = p.PlotId,
                    Name = p.PlotName
                }).ToList();

                m.Insert(0, new ViewModel.IdNamePairVM { Name = "", Id = 0 });

                cmbPlotName.DataSource = m;
                cmbPlotName.DisplayMember = "Name";
                cmbPlotName.ValueMember = "Id";
            }
        }

        private void LoadData()
        {
            string aDate = txtADate.Text.Replace("/", "").Trim();

            if (string.IsNullOrEmpty(aDate) ||
               string.IsNullOrEmpty(txtAddress.Text) ||
               string.IsNullOrEmpty(txtCustomerName.Text) ||
               string.IsNullOrEmpty(cmbPlotName.Text))
            {
                using (SaneiStore.SaneiStoreEntities2 db = new SaneiStoreEntities2())
                {
                    dgvCustomer.DataSource = db.Customer
                        .Join(db.Store,
                        c => c.PlotId,
                        s => s.PlotId,
                        (customer, store) => new ViewModel.CustomerVM
                        {
                            CustomerID = customer.CustomerID,
                            Name = customer.Name,
                            Phone = customer.Phone,
                            Address = customer.Address,
                            Date = customer.Date,
                            Transportation = customer.Transportation,
                            TheCostOfRepair = customer.TheCostOfRepair,
                            FortyPercent = customer.FortyPercent,
                            SixtyPercent = customer.SixtyPercent,
                            Total = customer.Total,
                            PlotId = customer.PlotId,
                            PlotName = store.PlotName,
                            Dsc = store.Dsc,
                        })
                        .ToList();
                }
            }
            else
            {
                using (SaneiStore.SaneiStoreEntities2 db = new SaneiStoreEntities2())
                {
                    dgvCustomer.DataSource = db.Customer
                        .Join(db.Store,
                        c => c.PlotId,
                        s => s.PlotId,
                        (customer, store) => new ViewModel.CustomerVM
                        {
                            CustomerID = customer.CustomerID,
                            Name = customer.Name,
                            Phone = customer.Phone,
                            Address = customer.Address,
                            Date = customer.Date,
                            Transportation = customer.Transportation,
                            TheCostOfRepair = customer.TheCostOfRepair,
                            FortyPercent = customer.FortyPercent,
                            SixtyPercent = customer.SixtyPercent,
                            Total = customer.Total,
                            PlotId = customer.PlotId,
                            PlotName = store.PlotName,
                            Dsc = store.Dsc,
                        })
                        .Where(c => c.Name.Contains(txtCustomerName.Text) &&
                         c.Address.Contains(txtAddress.Text) &&
                         c.Date.Contains(aDate)&&
                         c.PlotName == cmbPlotName.Text.ToString())

                        //  .Where(c =>c.PlotName== cmbPlotName.Text)
                        // .Where(c => c.Address.Contains( txtAddress.Text))
                        //  .Where(c =>Convert.ToInt32( c.Date) >= Convert.ToInt32( txtADate.Text))

                        .ToList();
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvCustomer_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            tsslInfo2.Text = "";
            if (e.RowIndex < 0)
            {
                return;
            }
            tsslInfo2.Text = $"{e.RowIndex + 1}از{dgvCustomer.Rows.Count}";
        }

        private void txtCustomerName_KeyDown(object sender, KeyEventArgs e)
        {
            if (Convert.ToInt32(e.KeyCode) == 13)
            {
                LoadData();
            }
        }

        private void txtADate_KeyDown(object sender, KeyEventArgs e)
        {
            if (Convert.ToInt32(e.KeyCode) == 13)
            {
                LoadData();
            }
        }

        private void txtAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (Convert.ToInt32(e.KeyCode) == 13)
            {
                LoadData();
            }
        }
    }
}
