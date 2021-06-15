namespace TrackingApp
{
    partial class UserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label5 = new System.Windows.Forms.Label();
            this.lblWarning = new System.Windows.Forms.Label();
            this.btnUsersSil = new System.Windows.Forms.Button();
            this.btnUsersGüncelle = new System.Windows.Forms.Button();
            this.btnUsersTemizle = new System.Windows.Forms.Button();
            this.btnUsersKaydet = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtUserTerminalCode = new System.Windows.Forms.TextBox();
            this.txtUserCode = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.lblUserId = new System.Windows.Forms.Label();
            this.Column21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(55, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 19);
            this.label5.TabIndex = 38;
            this.label5.Text = "Users";
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblWarning.Font = new System.Drawing.Font("Comic Sans MS", 9F);
            this.lblWarning.ForeColor = System.Drawing.Color.DarkRed;
            this.lblWarning.Location = new System.Drawing.Point(483, 202);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(187, 17);
            this.lblWarning.TabIndex = 36;
            this.lblWarning.Text = "Terminal Kodu Yoksa \"0\" Giriniz.";
            this.lblWarning.Visible = false;
            // 
            // btnUsersSil
            // 
            this.btnUsersSil.BackColor = System.Drawing.SystemColors.Control;
            this.btnUsersSil.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold);
            this.btnUsersSil.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnUsersSil.Location = new System.Drawing.Point(836, 141);
            this.btnUsersSil.Name = "btnUsersSil";
            this.btnUsersSil.Size = new System.Drawing.Size(147, 58);
            this.btnUsersSil.TabIndex = 32;
            this.btnUsersSil.Text = "Kayıt Sil";
            this.btnUsersSil.UseVisualStyleBackColor = false;
            this.btnUsersSil.Click += new System.EventHandler(this.btnUsersSil_Click);
            // 
            // btnUsersGüncelle
            // 
            this.btnUsersGüncelle.BackColor = System.Drawing.SystemColors.Control;
            this.btnUsersGüncelle.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold);
            this.btnUsersGüncelle.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnUsersGüncelle.Location = new System.Drawing.Point(1001, 73);
            this.btnUsersGüncelle.Name = "btnUsersGüncelle";
            this.btnUsersGüncelle.Size = new System.Drawing.Size(157, 58);
            this.btnUsersGüncelle.TabIndex = 31;
            this.btnUsersGüncelle.Text = "Kayıt Güncelle";
            this.btnUsersGüncelle.UseVisualStyleBackColor = false;
            this.btnUsersGüncelle.Click += new System.EventHandler(this.btnUsersGüncelle_Click);
            // 
            // btnUsersTemizle
            // 
            this.btnUsersTemizle.BackColor = System.Drawing.SystemColors.Control;
            this.btnUsersTemizle.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold);
            this.btnUsersTemizle.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnUsersTemizle.Location = new System.Drawing.Point(1001, 139);
            this.btnUsersTemizle.Name = "btnUsersTemizle";
            this.btnUsersTemizle.Size = new System.Drawing.Size(157, 58);
            this.btnUsersTemizle.TabIndex = 30;
            this.btnUsersTemizle.Text = "Temizle";
            this.btnUsersTemizle.UseVisualStyleBackColor = false;
            this.btnUsersTemizle.Click += new System.EventHandler(this.btnUsersTemizle_Click);
            // 
            // btnUsersKaydet
            // 
            this.btnUsersKaydet.BackColor = System.Drawing.SystemColors.Control;
            this.btnUsersKaydet.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold);
            this.btnUsersKaydet.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnUsersKaydet.Location = new System.Drawing.Point(836, 73);
            this.btnUsersKaydet.Name = "btnUsersKaydet";
            this.btnUsersKaydet.Size = new System.Drawing.Size(147, 58);
            this.btnUsersKaydet.TabIndex = 29;
            this.btnUsersKaydet.Text = "Kaydet";
            this.btnUsersKaydet.UseVisualStyleBackColor = false;
            this.btnUsersKaydet.Click += new System.EventHandler(this.btnUsersKaydet_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.label17.Location = new System.Drawing.Point(360, 177);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(106, 19);
            this.label17.TabIndex = 26;
            this.label17.Text = "Terminal Kodu:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.label16.Location = new System.Drawing.Point(360, 125);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(97, 19);
            this.label16.TabIndex = 25;
            this.label16.Text = "Kullanıcı Kodu";
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.txtUserName.Location = new System.Drawing.Point(478, 73);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(186, 26);
            this.txtUserName.TabIndex = 35;
            this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
            // 
            // txtUserTerminalCode
            // 
            this.txtUserTerminalCode.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.txtUserTerminalCode.Location = new System.Drawing.Point(478, 173);
            this.txtUserTerminalCode.Name = "txtUserTerminalCode";
            this.txtUserTerminalCode.Size = new System.Drawing.Size(186, 26);
            this.txtUserTerminalCode.TabIndex = 28;
            this.txtUserTerminalCode.TextChanged += new System.EventHandler(this.txtUserTerminalCode_TextChanged);
            // 
            // txtUserCode
            // 
            this.txtUserCode.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.txtUserCode.Location = new System.Drawing.Point(478, 125);
            this.txtUserCode.Name = "txtUserCode";
            this.txtUserCode.Size = new System.Drawing.Size(186, 26);
            this.txtUserCode.TabIndex = 27;
            this.txtUserCode.TextChanged += new System.EventHandler(this.txtUserCode_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.label18.Location = new System.Drawing.Point(360, 73);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(87, 19);
            this.label18.TabIndex = 34;
            this.label18.Text = "Kullanıcı Adı";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıdDataGridViewTextBoxColumn,
            this.Column21,
            this.Column18,
            this.Column19});
            this.dataGridView.DataSource = this.usersBindingSource1;
            this.dataGridView.Location = new System.Drawing.Point(81, 281);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(1175, 352);
            this.dataGridView.TabIndex = 33;
            this.dataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_CellMouseDoubleClick);
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Location = new System.Drawing.Point(40, 104);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(0, 13);
            this.lblUserId.TabIndex = 39;
            // 
            // Column21
            // 
            this.Column21.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column21.DataPropertyName = "Name";
            this.Column21.HeaderText = "Kullanıcı Adı";
            this.Column21.Name = "Column21";
            this.Column21.ReadOnly = true;
            // 
            // Column18
            // 
            this.Column18.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column18.DataPropertyName = "UserCode";
            this.Column18.HeaderText = "Kullanıcı Kodu";
            this.Column18.Name = "Column18";
            this.Column18.ReadOnly = true;
            // 
            // Column19
            // 
            this.Column19.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column19.DataPropertyName = "TerminalCode";
            this.Column19.HeaderText = "Terminal Kodu";
            this.Column19.Name = "Column19";
            this.Column19.ReadOnly = true;
            // 
            // ıdDataGridViewTextBoxColumn
            // 
            this.ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.ıdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
            this.ıdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usersBindingSource1
            // 
            this.usersBindingSource1.DataSource = typeof(TrackingApp.Users);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1370, 661);
            this.Controls.Add(this.lblUserId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.btnUsersSil);
            this.Controls.Add(this.btnUsersGüncelle);
            this.Controls.Add(this.btnUsersTemizle);
            this.Controls.Add(this.btnUsersKaydet);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtUserTerminalCode);
            this.Controls.Add(this.txtUserCode);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.dataGridView);
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.UserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.Button btnUsersSil;
        private System.Windows.Forms.Button btnUsersGüncelle;
        private System.Windows.Forms.Button btnUsersTemizle;
        private System.Windows.Forms.Button btnUsersKaydet;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtUserTerminalCode;
        private System.Windows.Forms.TextBox txtUserCode;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DataGridView dataGridView;
        public System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column21;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column18;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column19;
        private System.Windows.Forms.BindingSource usersBindingSource1;
    }
}