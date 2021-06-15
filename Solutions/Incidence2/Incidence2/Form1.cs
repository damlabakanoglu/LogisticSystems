using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace Incidence2
  
{
    public partial class Form1 : Form
    {
        
        
        public Form1()
        {
            InitializeComponent();
        }
        LogisticEntities1 db = new LogisticEntities1();
        private void CleanAllFilters()
        {
            txtSku.Clear();
            txtOrderId.Clear();
            txtQuadrant.Clear();
            cbBrand.Text = "";
            cbOrderType.Text = "";
            cbStatus.Text = "";
            dateTimePicker1.Refresh();
            dataGridView1.DataSource = db.Incidence.ToList();
        }
        
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            CleanAllFilters();
        }

      

        private void Form1_Load(object sender, EventArgs e)
        {

            cbBrand.DataSource = db.Brand.ToList();
            cbStatus.DataSource = db.IncidenceStatusTbl.ToList();
            cbOrderType.DataSource = db.OrderType.ToList();
            CleanAllFilters();
            
        }
        private void btnsiparisara_Click(object sender, EventArgs e)
        {
            if (txtQuadrant.Text == "" || txtSku.Text == "")
            {
                MessageBox.Show("Zorunlu Alanlar Boş Bırakılamaz!");

            }
            else
            {

                var convertedSku1 = Int32.Parse(txtSku.Text);
                dataGridView1.DataSource = db.Incidence.Where(x => x.BrandName == cbBrand.SelectedValue
                 && x.IncidenceStatus == cbStatus.SelectedValue
                 && x.OrderType == cbOrderType.SelectedValue
                 && x.Sku == convertedSku1
                 && x.Quadrant == txtQuadrant.Text
                 ).ToList();
            }
            

        }

        private void cbtrOrderTypeelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Incidence.Where(x => x.OrderType == cbOrderType.SelectedValue).ToList();

        }

        private void cbBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Incidence.Where(x => x.BrandName == cbBrand.SelectedValue).ToList();
        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Incidence.Where(x => x.IncidenceStatus == cbStatus.SelectedValue).ToList();
        }

        private void txtSku_TextChanged(object sender, EventArgs e)
        {
            int sayi = 0;
            var convertedSku = int.TryParse(txtSku.Text,out sayi);
            if (convertedSku)
            {
                var convertedSku1 = Int32.Parse(txtSku.Text);
                dataGridView1.DataSource = db.Incidence.Where(x => x.Sku == convertedSku1).ToList();
            }
            
            
        }

        private void txtQuadrant_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Incidence.Where(x => x.Quadrant.Contains(txtQuadrant.Text)).ToList();
        }

        private void txtOrderId_TextChanged(object sender, EventArgs e)
        {
            int sayi = 0;
            var orderId1=int.TryParse(txtOrderId.Text,out sayi);
            if(orderId1)
            {
                var orderId = Convert.ToInt32(txtOrderId.Text);
                dataGridView1.DataSource = db.Incidence.Where(x => x.OrderId == orderId).ToList();
            }
           
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = db.Incidence.Where(x => x.IncidenceDate.Value== dateTimePicker1.Value.Date).ToList();
        }

        private void txtUserCode_TextChanged(object sender, EventArgs e)
        {
            int sayi = 0;
            var userId1 = int.TryParse(txtUserCode.Text, out sayi);
            if (userId1)
            {
                var userId = int.Parse(txtUserCode.Text);
                dataGridView1.DataSource = db.Incidence.Where(x => x.UserCode == userId).ToList();
            }
        }

       

        

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            IncidenceDetail incidenceDetail = new IncidenceDetail();
           
            incidenceDetail.Show();
            incidenceDetail.lblSku.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            incidenceDetail.lblBrandName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            incidenceDetail.lblQuadrant.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            incidenceDetail.lblOrderId.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            incidenceDetail.lblOrderType.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            incidenceDetail.lblStatus.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            incidenceDetail.lblDate.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            incidenceDetail.lblUserCode.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            incidenceDetail.id = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            CleanAllFilters();
        }

        private void cbOrderType_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Incidence.Where(x => x.OrderType == cbOrderType.SelectedValue).ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
