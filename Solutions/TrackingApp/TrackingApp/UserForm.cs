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
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }
        LogisticDataBaseEntities db = new LogisticDataBaseEntities();
        private void btnUsersTemizle_Click(object sender, EventArgs e)
        {
            CleanAndData();
        }
        public void CleanAndData()
        {
            txtUserCode.Clear();
            txtUserName.Clear();
            txtUserTerminalCode.Clear();
            dataGridView.DataSource = db.Users.ToList();
        }
        private void UserForm_Load(object sender, EventArgs e)
        {
            dataGridView.DataSource = db.Users.ToList();
            lblUserId.Visible = false;
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            if (txtUserName.Text == "") CleanAndData();
            else
            {
                dataGridView.DataSource = db.Users.Where(x => x.Name.Contains(txtUserName.Text)).ToList();
            }
        }
        int sayi = 0;
        private void txtUserCode_TextChanged(object sender, EventArgs e)
        {
            if (txtUserCode.Text == "") CleanAndData();
            else
            {
                var check = int.TryParse(txtUserCode.Text, out sayi);
                if (check)
                {
                    var userCode = Int32.Parse(txtUserCode.Text);
                    dataGridView.DataSource = db.Users.Where(x => x.UserCode == userCode).ToList();
                }
            }

        }

        private void txtUserTerminalCode_TextChanged(object sender, EventArgs e)
        {
            if (txtUserTerminalCode.Text == "") CleanAndData();
            else
            {
                var check = int.TryParse(txtUserTerminalCode.Text, out sayi);
                if (check)
                {
                    var TerminalCode = Int32.Parse(txtUserTerminalCode.Text);
                    dataGridView.DataSource = db.Users.Where(x => x.TerminalCode == TerminalCode).ToList();
                }
            }
        }

        private void dataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            lblUserId.Text = dataGridView.CurrentRow.Cells[0].Value.ToString();
            txtUserName.Text = dataGridView.CurrentRow.Cells[1].Value.ToString();
            txtUserCode.Text = dataGridView.CurrentRow.Cells[2].Value.ToString();
            txtUserTerminalCode.Text = dataGridView.CurrentRow.Cells[3].Value.ToString();

        }

        private void btnUsersSil_Click(object sender, EventArgs e)
        {
            var userCode = dataGridView.CurrentRow.Cells[2].Value.ToString();
            var userCode1 = Int32.Parse(userCode);
            var data = db.Users.Where(x => x.UserCode == userCode1).FirstOrDefault();
            db.Users.Remove(data);
            SaveAndUpdateDataBase();
        }

        private void SaveAndUpdateDataBase()
        {
            db.SaveChanges();
            dataGridView.DataSource = db.Users.ToList();
        }

        private void btnUsersKaydet_Click(object sender, EventArgs e)
        {
            if (txtUserTerminalCode.Text == "")
            {

                lblWarning.Visible = true;
            }
            else
            {


                var userCode1 = Int32.Parse(txtUserCode.Text);
                var dataCheckUser = db.Users.Where(x => x.UserCode == userCode1).FirstOrDefault();


                var terminalCode1 = Int32.Parse(txtUserTerminalCode.Text);
                var dataCheckTerminal = db.Users.Where(x => x.TerminalCode == terminalCode1).FirstOrDefault();

                if (dataCheckUser == null && (dataCheckTerminal == null || dataCheckTerminal.TerminalCode == 0))
                {
                    var userCount = db.Users.Count();

                    Users user = new Users();
                    
                    user.Name = txtUserName.Text;
                    user.UserCode = Int32.Parse(txtUserCode.Text);
                    var terminalCodeCheck1 = int.TryParse(txtUserTerminalCode.Text, out sayi);
                    if (terminalCodeCheck1)
                    {
                        user.TerminalCode = Int32.Parse(txtUserTerminalCode.Text);
                    }
                    user.Id = userCount + 1;
                    db.Users.Add(user);
                    SaveAndUpdateDataBase();
                }

                else MessageBox.Show("Kullanıcı Kodu Kullanılıyor ya da Terminal Kodu Kullanılıyor!");
            }
        }

        private void btnUsersGüncelle_Click(object sender, EventArgs e)
        {
            var userId = Int32.Parse(lblUserId.Text);
            var user = db.Users.Where(x => x.Id == userId).FirstOrDefault();
            user.Name = txtUserName.Text;
            user.UserCode = Int32.Parse(txtUserCode.Text);
            user.TerminalCode = Int32.Parse(txtUserTerminalCode.Text);
            SaveAndUpdateDataBase();
        }

        private void btnUsersKaydet_MouseHover(object sender, EventArgs e)
        {
            lblWarning.Visible = true;
        }

        
        
    }
}
