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
    public partial class TrackingAppMdi : Form
    {
       
        public TrackingAppMdi()
        {
            InitializeComponent();
        }

        public void OpenForm(Form formName)
        {
            panel1.Controls.Clear();
            formName.MdiParent = this;
            formName.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Add(formName);
            formName.Show();
        }
       
        private void TrackingAppMdi_Load(object sender, EventArgs e)
        {
            Movements movement = new Movements();
            OpenForm(movement);
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserForm user = new UserForm();
            OpenForm(user);
        }

        private void orderReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SiparişRaporları siparisRaporlari = new SiparişRaporları();
            OpenForm(siparisRaporlari);
        }

        private void ınboundsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Inbounds inbound = new Inbounds();
            OpenForm(inbound);
        }

       
        private void movementsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Movements movement = new Movements();
            OpenForm(movement);
        }
    }
}
