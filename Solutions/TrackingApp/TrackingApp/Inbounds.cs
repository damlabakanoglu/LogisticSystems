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
    public partial class Inbounds : Form
    {
        public Inbounds()
        {
            InitializeComponent();
        }
        LogisticDataBaseEntities db = new LogisticDataBaseEntities();
        private void Inbounds_Load(object sender, EventArgs e)
        {
            cbBrand.DataSource = db.Brand.ToList();
            ClearAndDatabase();


        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            ClearAndDatabase();
        }
        public void ClearAndDatabase()
        {
            txtConteynerCode.Clear();
            txtSku.Clear();
            txtSkuPiece.Clear();
            cbInboundType.Text = "";
            cbBrand.Text = "";
            dateTimePickerFinish.Text = "";
            dateTimePickerStart.Text = "";
            dtgwInbound.DataSource = db.Inbound.ToList();
        }

        private void txtSku_TextChanged(object sender, EventArgs e)
        {if (txtSku.Text == "") ClearAndDatabase();
            else
            {
                if (txtSku.TextLength > 3)
                {
                    var convertCheck = int.TryParse(txtSku.Text, out sayi);
                    if (convertCheck)
                    {
                        var converted = Int32.Parse(txtSku.Text);
                        var skuId = db.Sku.Where(x => x.Sku1 == converted).FirstOrDefault();
                        if (skuId != null)
                        {
                            dtgwInbound.DataSource = db.Inbound.Where(x => x.SkuId == skuId.Id).ToList();
                        }
                    }
                }
            }
           
        }
        int sayi = 0;
        private void txtSkuPiece_TextChanged(object sender, EventArgs e)
        {if (txtSkuPiece.Text == "") ClearAndDatabase();
            else
            {
                var convertCheck = int.TryParse(txtSkuPiece.Text, out sayi);
                if (convertCheck)
                {
                    var converted = Int32.Parse(txtSkuPiece.Text);
                    dtgwInbound.DataSource = db.Inbound.Where(x => x.SkuPiece == converted).ToList();
                }
            }
        }

        private void cbBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBrand.Text == "") ClearAndDatabase();
            else
            {
                dtgwInbound.DataSource = db.Inbound.Where(x => x.InboundBrand == cbBrand.SelectedValue).ToList();
            }
        }

        private void cbInboundType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbInboundType.Text == "") ClearAndDatabase();
            else
            {
                dtgwInbound.DataSource = db.Inbound.Where(x => x.InboundType == cbInboundType.SelectedItem.ToString()).ToList();
            }
        }

        private void txtConteynerCode_TextChanged(object sender, EventArgs e)
        {if (txtConteynerCode.Text == "") ClearAndDatabase();
            else
            {
                var convertCheck = int.TryParse(txtConteynerCode.Text, out sayi);
                if (convertCheck)
                {
                    var converted = Int32.Parse(txtConteynerCode.Text);
                    dtgwInbound.DataSource = db.Inbound.Where(x => x.InboundConteynerId == converted).ToList();
                }
            }
        }

        private void dateTimePickerStart_ValueChanged(object sender, EventArgs e)
        {
            dtgwInbound.DataSource = db.Inbound.Where(x => x.StartDate == dateTimePickerStart.Value.Date).ToList();
        }

        private void dateTimePickerFinish_ValueChanged(object sender, EventArgs e)
        {
            dtgwInbound.DataSource = db.Inbound.Where(x => x.FinalDate == dateTimePickerFinish.Value.Date).ToList();
        }

        private void btnInboundOlustur_Click(object sender, EventArgs e)
        {
            if (txtSku.Text == "" || txtSkuPiece.Text == ""|| cbBrand.Text == "" || cbInboundType.Text== "")
            {
                MessageBox.Show("Zorunlu Alanlar Boş Bırakılamaz!");
            }
            else
            {
                InboundOlustur inboundOlustur = new InboundOlustur();
                inboundOlustur.lblSku.Text = txtSku.Text;
                inboundOlustur.lblSkuPiece.Text = txtSkuPiece.Text;
                inboundOlustur.lblBrand.Text = cbBrand.SelectedValue.ToString();
                inboundOlustur.lblInboundType.Text = cbInboundType.SelectedItem.ToString();
                inboundOlustur.lblConteynerCode.Text = (db.Inbound.Max(x => x.InboundConteynerId) + 1).ToString();
                inboundOlustur.lblSiparisTarihi.Text = DateTime.Today.Date.ToString();
                inboundOlustur.lblUlaştırmaTarihi.Text = DateTime.Today.AddDays(15).Date.ToString();

                inboundOlustur.Show();
                btnInboundOlustur.Enabled = false;
            }
        }

       

    }
}
