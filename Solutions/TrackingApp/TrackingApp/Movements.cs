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
    public partial class Movements : Form
    {
        public Movements()
        {
            InitializeComponent();
        }

        LogisticDataBaseEntities db = new LogisticDataBaseEntities();
        int sayi = 0;
        private void txtMovementsUser_TextChanged(object sender, EventArgs e)
        {
            if (txtMovementsUser.Text == "") { CleanAndData(); }
            else
            {
                var convertCheck = int.TryParse(txtMovementsUser.Text, out sayi);
                if (convertCheck)
                {
                    var convertedUser = Int32.Parse(txtMovementsUser.Text);
                    dtgwMovements.DataSource = db.Work.Where(x => x.UserCode == convertedUser).ToList();
                }
            }
        }

        private void btnMovementsTemizle_Click(object sender, EventArgs e)
        {
            CleanAndData();
        }
        public void CleanAndData()
        {
            txtMovementsSku.Clear();
            txtMovementsPozitions.Clear();
            txtMovementsUser.Clear();
            txtQuadrant.Clear();
            txtMovementTerminal.Clear();
            dateTimePickerFinish.Text = "";
            checkMovementsSelectAll.Checked = false;
            for (int i = 0; i <= 4; i++)
            {
                checkedListMovements.SetItemChecked(i, false);
            }
            dtgwMovements.DataSource = db.Work.ToList();
        }

        private void checkedListMovements_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            dtgwMovements.DataSource = db.Work.Where(x => x.WorkName == checkedListMovements.SelectedItem.ToString()).ToList();
        }
        int sayac = 0;
        private void checkMovementsSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            sayac++;
            if (sayac % 2 != 0)
            {
                for (int i = 0; i <= 4; i++)
                {
                    checkedListMovements.SetItemChecked(i, true);
                }
            }
            else
            {
                for (int i = 0; i <= 4; i++)
                {
                    checkedListMovements.SetItemChecked(i, false);
                }
            }
        }

        private void Movements_Load(object sender, EventArgs e)
        {
            CleanAndData();
        }

        private void txtMovementTerminal_TextChanged(object sender, EventArgs e)
        {
            if (txtMovementTerminal.Text == "")
            { CleanAndData(); }
            else
            {
                var convertCheck = int.TryParse(txtMovementTerminal.Text, out sayi);
                if (convertCheck)
                {
                    var converted = Int32.Parse(txtMovementTerminal.Text);
                    dtgwMovements.DataSource = db.Work.Where(x => x.TerminalCode == converted).ToList();
                }
            }
        }

        private void txtMovementsSku_TextChanged(object sender, EventArgs e)
        {
            if (txtMovementsSku.Text == "") CleanAndData();
            else
            {
                var convertCheck = int.TryParse(txtMovementsSku.Text, out sayi);
                if (convertCheck)
                {
                    var convertedSku = Int32.Parse(txtMovementsSku.Text);
                    dtgwMovements.DataSource = db.Work.Where(x => x.Sku == convertedSku).ToList();
                }
            }
        }

        private void txtMovementsPozitions_TextChanged(object sender, EventArgs e)
        {
            if (txtMovementsPozitions.Text == "") CleanAndData();
            else
            {
                dtgwMovements.DataSource = db.Work.Where(x => x.Pozition.Contains(txtMovementsPozitions.Text)).ToList();
            }
        }

        private void dateTimePickerFinish_ValueChanged(object sender, EventArgs e)
        {
             dtgwMovements.DataSource = db.Work.Where(x => x.WorkDate == dateTimePickerFinish.Value.Date).ToList();
        }

       

       
        private void btnMovementsSiparisAra_Click_1(object sender, EventArgs e)
        {
            if (txtQuadrant.Text == "" || txtMovementsPozitions.Text == "" || txtMovementsSku.Text == "" || txtMovementsUser.Text == "" || txtMovementTerminal.Text == "")
            {
                MessageBox.Show("Zorunlu Alanlar Boş Bırakılamaz");
            }
            else
            {
                var convertedUser = Int32.Parse(txtMovementsUser.Text);
                var convertedTerminal = Int32.Parse(txtMovementTerminal.Text);
                var convertedSku = Int32.Parse(txtMovementsSku.Text);
                dtgwMovements.DataSource = db.Work.Where(x => x.Sku == convertedSku
                && x.Pozition.Contains(txtMovementsPozitions.Text)
                && x.TerminalCode == convertedTerminal
                && x.WorkName == checkedListMovements.SelectedItem.ToString()
                && x.UserCode == convertedUser
                && x.WorkDate == dateTimePickerFinish.Value.Date
                && x.Quadrant.Contains(txtQuadrant.Text)
                ).ToList();
            }
        }

        private void txtQuadrant_TextChanged(object sender, EventArgs e)
        {
            if (txtQuadrant.Text == "") CleanAndData();
            else
            {
                dtgwMovements.DataSource = db.Work.Where(x => x.Quadrant.Contains(txtQuadrant.Text)).ToList();
            }
        }
    }
}
