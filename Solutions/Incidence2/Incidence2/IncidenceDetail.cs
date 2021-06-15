using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Incidence2
{

    

    public partial class IncidenceDetail : Form
    { 

        public IncidenceDetail()
        {
            InitializeComponent();
        }
        LogisticEntities1 db = new LogisticEntities1();
        Form1 incidence = new Form1();
        public string id;
        private void IncidenceDetail_Load(object sender, EventArgs e)
        {
            
           
        }
        
        private void btnCancel_Click(object sender, EventArgs e)
        {

            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Sipariş iptal edilsin mi?", "İptal", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                int intId = int.Parse(id);
                MessageBox.Show("Sipariş İptal edildi");
                var orderId = int.Parse(lblOrderId.Text);
                var data = db.Incidence.Where(x => x.Id==intId).FirstOrDefault();
                db.Incidence.Remove(data);
                db.SaveChanges();
                this.Close();
                incidence.dataGridView1.DataSource = db.Incidence.ToList();

                
            }


        }

       
    }
}
