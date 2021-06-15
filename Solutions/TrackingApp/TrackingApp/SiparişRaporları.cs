using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrackingApp
{
    public partial class SiparişRaporları : Form
    {
        public SiparişRaporları()
        {
            InitializeComponent();
        }
        LogisticDataBaseEntities db = new LogisticDataBaseEntities();

        private void SiparişRaporları_Load(object sender, EventArgs e)
        {
             
            cbBrand.DataSource = db.Brand.ToList();
            cbOrderType.DataSource = db.OrderType.ToList();
            CleanAndData();
        }
        
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            CleanAndData();
        }
        public void CleanAndData()
        {
            txtCustomerId.Clear();
            txtQuadrant.Clear();
            txtSku.Clear();
            cbOrderType.Text = "";
            cbBrand.Text = "";
            dateTimePicker1.Text = "";
            checkSelectAll.Checked = false;
            for (int i = 0; i <= 4; i++)
            {
                checkedListStatus.SetItemChecked(i, false);
            }
            dtgwSiparişRaporları.DataSource = db.Order.ToList();
        }
        int sayi = 0;
        private void txtSku_TextChanged(object sender, EventArgs e)
        {
            if (txtSku.Text == "") CleanAndData();
            else
            {
                var check = int.TryParse(txtSku.Text, out sayi);
                if (check)
                {
                    var convertedSku = Int32.Parse(txtSku.Text);
                    dtgwSiparişRaporları.DataSource = db.Order.Where(x => x.OrderSku == convertedSku).ToList();
                }
            }
        }

        private void cbBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBrand.Text == "") CleanAndData();
            else
            {
                var brandCheck = db.Brand.Where(x => x.BrandName == cbBrand.SelectedValue).FirstOrDefault();

                if (brandCheck != null)
                {
                    dtgwSiparişRaporları.DataSource = db.Order.Where(x => x.OrderBrandId == brandCheck.Id).ToList();
                }
            }
        }

        private void txtQuadrant_TextChanged(object sender, EventArgs e)
        {  if (txtQuadrant.Text == "") CleanAndData();
            else
            {
                dtgwSiparişRaporları.DataSource = db.Order.Where(x => x.Quadrant.Contains(txtQuadrant.Text)).ToList();
            }
        }

        private void cbOrderType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbOrderType.Text == "") CleanAndData();
            else
            {
            
            var orderTypeCheck = db.OrderType.Where(x => x.OrderType1 == cbOrderType.SelectedValue).FirstOrDefault();
            if (orderTypeCheck != null)
            {
                dtgwSiparişRaporları.DataSource = db.Order.Where(x => x.OrderTypeId == orderTypeCheck.Id).ToList();
            }
            }
        }

        private void checkedListStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtgwSiparişRaporları.DataSource = db.Order.Where(x => x.OrderStatus == checkedListStatus.SelectedItem.ToString()).ToList();
        }
        int sayac = 0;
        private void checkSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            sayac++;
            if (sayac % 2 != 0)
            {
                for (int i = 0; i <= 4; i++)
                {
                    checkedListStatus.SetItemChecked(i, true);
                }
            }
            else
            {
                for (int i = 0; i <= 4; i++)
                {
                    checkedListStatus.SetItemChecked(i, false);
                }
            }
        }

        private void txtCustomerId_TextChanged(object sender, EventArgs e)
        {
            if (txtCustomerId.Text == "") CleanAndData();
            else
            {
                var check = int.TryParse(txtCustomerId.Text, out sayi);
                if (check)
                {
                    var convertedCustomerId = Int32.Parse(txtCustomerId.Text);
                    dtgwSiparişRaporları.DataSource = db.Order.Where(x => x.CustomerId == convertedCustomerId).ToList();
                }
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dtgwSiparişRaporları.DataSource = db.Order.Where(x => x.OrderDate == dateTimePicker1.Value.Date).ToList();
        }

        private void btnSiparişAra_Click(object sender, EventArgs e)
        {
            try
            {
              
                    var convertedSku = Int32.Parse(txtSku.Text);
                    var convertedCustomerId = Int32.Parse(txtCustomerId.Text);
                    dtgwSiparişRaporları.DataSource = db.Order.Where(x => x.OrderSku == convertedSku
                    && x.Quadrant.Contains(txtQuadrant.Text)
                    && x.OrderStatus == checkedListStatus.SelectedItem.ToString()
                    && x.OrderDate == dateTimePicker1.Value.Date
                    && x.CustomerId == convertedCustomerId).ToList();
                
            }
            catch (Exception)
            {
                MessageBox.Show("Zorunlu Alanlar Boş Bırakılamaz!");

            }
        }
    }
}
