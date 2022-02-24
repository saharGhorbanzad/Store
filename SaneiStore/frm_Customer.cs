using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaneiStore
{
    public partial class frm_Customer : Form
    {
        public frm_Customer()
        {
            InitializeComponent();
        }

        private void FillComboBox()
        {
            using (SaneiStore.SaneiStoreEntities2 db = new SaneiStoreEntities2())
            {
                var m = db.Store.Select(p => new ViewModel.IdNamePairVM
                {
                    Id = p.PlotId,
                    Name = p.PlotName,
                    Price=p.Price
                }).ToList();

                m.Insert(0, new ViewModel.IdNamePairVM { Name = "", Id = 0 });

                cmbPlot.DataSource = m;
                cmbPlot.DisplayMember = "Name";
                cmbPlot.ValueMember = "Id";
            }
        }

        private void tsSave_Click(object sender, EventArgs e)
        {
            //if (HasChanges())
            {
                // if (IsValid())
                {
                    SaveData();
                }
            }
        }

        public void SaveData()
        {
            try
            {
                using (SaneiStore.SaneiStoreEntities2 db = new SaneiStoreEntities2())
                {

                    var output = new Customer
                    {
                        Name = txtCustomerName.Text,
                        Phone = txtPhone.Text,
                        Address = txtAddress.Text,
                        Date = maskDate.Text.Replace("/", ""),
                        PlotId = Convert.ToInt32(cmbPlot.SelectedValue),
                        Transportation = Convert.ToDecimal(txtTransportation.Text.Replace(",", "")),
                        TheCostOfRepair = Convert.ToDecimal(txtPrice.Text.Replace(",", "")),
                        FortyPercent = Convert.ToDecimal(txtFortyPercent.Text.Replace(",", "")),
                        SixtyPercent = Convert.ToDecimal(txtSixtyPercent.Text.Replace(",", "")),
                        Total = Convert.ToDecimal(txtTotal.Text.Replace(",", "")),
                        Dsc = txtDsc.Text,

                    };
                    db.Customer.Add(output);
                    db.SaveChanges();


                    MessageBox.Show("مشتری جدید با موفقیت ثبت شد", "ثبت", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        private void txtPrice_Leave(object sender, EventArgs e)
        {
            var m = ((Convert.ToInt64(txtPrice.Text.Replace(",", "")) -
                  Convert.ToInt64(txtConsumerPrices.Text.Replace(",", "")))).ToString();

            txtFortyPercent.Text = ((Convert.ToInt64(m.Replace(",", "")) / 10) * 4).ToString();

            txtSixtyPercent.Text = ((Convert.ToInt64(m.Replace(",", "")) / 10) * 6).ToString();



            txtTotal.Text = ((Convert.ToInt64(txtConsumerPrices.Text.Replace(",", "")) +
                Convert.ToInt64(txtSixtyPercent.Text.Replace(",", "")))).ToString();
        }

        private void cmbPlot_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPlot.SelectedIndex != 0)
            {
                using (SaneiStore.SaneiStoreEntities2 db = new SaneiStoreEntities2())
                {
                    var plotSelected = Convert.ToInt64(cmbPlot.SelectedValue);
                    var plot = db.Store.Where(s => s.PlotId == plotSelected).FirstOrDefault();
                    txtConsumerPrices.Text = plot.Price.ToString();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void txtTransportation_TextChanged(object sender, EventArgs e)
        {
            //txtTransportation.Text = double.Parse(txtTransportation.Text).ToString("0,0");
            if (txtTransportation.Text != string.Empty)
            {
                txtTransportation.Text = string.Format("{0:N0}", double.Parse(txtTransportation.Text.Replace(",", "")));
                txtTransportation.Select(txtTransportation.TextLength, 0);
            }
        }

        private void txtConsumerPrices_TextChanged(object sender, EventArgs e)
        {
            if (txtConsumerPrices.Text != string.Empty)
            {
                txtConsumerPrices.Text = string.Format("{0:N0}", double.Parse(txtConsumerPrices.Text.Replace(",", "")));
                txtConsumerPrices.Select(txtConsumerPrices.TextLength, 0);
            }
        }

        private void txtFortyPercent_TextChanged(object sender, EventArgs e)
        {
            if (txtFortyPercent.Text != string.Empty)
            {
                txtFortyPercent.Text = string.Format("{0:N0}", double.Parse(txtFortyPercent.Text.Replace(",", "")));
                txtFortyPercent.Select(txtFortyPercent.TextLength, 0);
            }
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            if (txtPrice.Text != string.Empty)
            {
                txtPrice.Text = string.Format("{0:N0}", double.Parse(txtPrice.Text.Replace(",", "")));
                txtPrice.Select(txtPrice.TextLength, 0);
            }
        }

        private void txtSixtyPercent_TextChanged(object sender, EventArgs e)
        {
            if (txtSixtyPercent.Text != string.Empty)
            {
                txtSixtyPercent.Text = string.Format("{0:N0}", double.Parse(txtSixtyPercent.Text.Replace(",", "")));
                txtSixtyPercent.Select(txtSixtyPercent.TextLength, 0);
            }
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
            if (txtTotal.Text != string.Empty)
            {
                txtTotal.Text = string.Format("{0:N0}", double.Parse(txtTotal.Text.Replace(",", "")));
                txtTotal.Select(txtTotal.TextLength, 0);
            }
        }

        private void frm_Customer_Load(object sender, EventArgs e)
        {
            FillComboBox();

            PersianCalendar pcDate = new PersianCalendar();
            string persianYear = pcDate.GetYear(DateTime.Now).ToString();
            string persianMonth =  pcDate.GetMonth(DateTime.Now).ToString().Length==1?"0"+ pcDate.GetMonth(DateTime.Now).ToString() : pcDate.GetMonth(DateTime.Now) .ToString();
            string persianDay = pcDate.GetDayOfMonth(DateTime.Now).ToString().Length == 1 ? "0" + pcDate.GetDayOfMonth(DateTime.Now).ToString() : pcDate.GetDayOfMonth(DateTime.Now).ToString();

            maskDate.Text = persianYear + persianMonth + persianDay;
            lblDay.Text = PersianDatetime(DateTime.Now.DayOfWeek.ToString());

        }

        public static string PersianDatetime(string DateType)
        {
            PersianCalendar pcDate = new PersianCalendar();
            int persianYear = pcDate.GetYear(DateTime.Now);
            int persianMonth = pcDate.GetMonth(DateTime.Now);
            int persianDay = pcDate.GetDayOfMonth(DateTime.Now);

            string DayName = "";
            switch (DateTime.Now.DayOfWeek)
            {
                case DayOfWeek.Saturday:
                    DayName = " شنبه ";
                    break;
                case DayOfWeek.Sunday:
                    DayName = " یکشنبه ";
                    break;
                case DayOfWeek.Monday:
                    DayName = " دوشنبه ";
                    break;
                case DayOfWeek.Tuesday:
                    DayName = " سه شنبه ";
                    break;
                case DayOfWeek.Wednesday:
                    DayName = " چهارشنبه ";
                    break;
                case DayOfWeek.Thursday:
                    DayName = " پنج شنبه ";
                    break;
                case DayOfWeek.Friday:
                    DayName = " جمـــعه ";
                    break;
            }


            string fullPersianDate =  DayName;
            return fullPersianDate;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           // if (txtAdd.Text.Trim().Length == 0 || txtAdd.Text.Trim().Length != 11)
            {
               // errorProvider.SetError(txtAdd, "تعداد کاراکترهای شماره همراه مجاز نمی باشد");
            }
            //else
            {

            }

            var dd = cmbPlot.DataSource;
            DataTable dt = new DataTable();
            dt.Clear();
            dt.Columns.Add("Id");
            dt.Columns.Add("Name");
            dt.Columns.Add("Price");
            DataRow row = dt.NewRow();
            row["Id"] = cmbPlot.SelectedValue; 
            row["Name"] = cmbPlot.Text;
            row["Price"] = cmbPlot.ValueMember;
            dt.Rows.Add(row);
            var m=dt.Rows.Count;







        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            listNumbers.Items.Remove(txtDelete.Text);
            txtDelete.ResetText();
        }

        private void btnTotalConsumedGoods_Click(object sender, EventArgs e)
        {
            // lblSumKala.Text=listNumbers.Items(p=>p.)
            foreach (var item in listNumbers.Items.ToString())
            {
                var sitem = item;
            }
        }
    }
}
