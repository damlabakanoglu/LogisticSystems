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
    public partial class InboundOlustur : Form
    {
        public InboundOlustur()
        {
            InitializeComponent();
        }
        LogisticDataBaseEntities db = new LogisticDataBaseEntities();
        private void btnİptal_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("İşlemi İptal Etmek İstediğinize Emin Misiniz ?", "İptal", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Inbounds inbound = new Inbounds();
                inbound.btnInboundOlustur.Enabled = true;
                this.Close();
                
            }
           
        }

        private void btnOluştur_Click(object sender, EventArgs e)
        {
            
            Inbound inbound = new Inbound();

            int id= db.Inbound.Count() + 1;
            var check = db.Inbound.Where(x => x.Id == id).FirstOrDefault();
            inbound.Id = id;
            var convertedSku = Int32.Parse(lblSku.Text);
            var skuId = db.Sku.Where(x => x.Sku1 == convertedSku).FirstOrDefault();
            inbound.SkuId = skuId.Id;
            inbound.SkuPiece= Int32.Parse(lblSkuPiece.Text);
            inbound.InboundBrand = lblBrand.Text;
            inbound.InboundType = lblInboundType.Text;
            inbound.InboundConteynerId = Int32.Parse(lblConteynerCode.Text);
            inbound.StartDate = DateTime.Today.Date;
            inbound.FinalDate = DateTime.Today.AddDays(15).Date;
            if (check == null)
            {
                db.Inbound.Add(inbound);
                db.SaveChanges();
                Inbounds inboundOlustur = new Inbounds();
                inboundOlustur.dtgwInbound.DataSource = db.Inbound.ToList();
                inboundOlustur.btnInboundOlustur.Enabled = true;
                this.Close();
            }
            else
                MessageBox.Show("Inbound Daha önceden oluşturulmuş!");
        }
    }
}
