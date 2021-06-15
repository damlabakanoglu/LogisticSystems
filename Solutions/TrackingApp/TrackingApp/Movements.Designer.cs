namespace TrackingApp
{
    partial class Movements
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
            this.checkedListMovements = new System.Windows.Forms.CheckedListBox();
            this.btnMovementsTemizle = new System.Windows.Forms.Button();
            this.btnMovementsSiparisAra = new System.Windows.Forms.Button();
            this.checkMovementsSelectAll = new System.Windows.Forms.CheckBox();
            this.txtMovementsPozitions = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMovementsUser = new System.Windows.Forms.TextBox();
            this.txtMovementTerminal = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtQuadrant = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMovementsSku = new System.Windows.Forms.TextBox();
            this.dtgwMovements = new System.Windows.Forms.DataGridView();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.dateTimePickerFinish = new System.Windows.Forms.DateTimePicker();
            this.label23 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.workBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TerminalCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quadrantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pozition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgwMovements)).BeginInit();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // checkedListMovements
            // 
            this.checkedListMovements.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.checkedListMovements.FormattingEnabled = true;
            this.checkedListMovements.Items.AddRange(new object[] {
            "Guide By Picture",
            "Free Picking",
            "Packing",
            "Shipping",
            "Inbound Audit",
            "General Audit",
            "Inbound",
            "Transfer By Sku",
            "Error"});
            this.checkedListMovements.Location = new System.Drawing.Point(6, 67);
            this.checkedListMovements.Name = "checkedListMovements";
            this.checkedListMovements.Size = new System.Drawing.Size(384, 88);
            this.checkedListMovements.TabIndex = 1;
            this.checkedListMovements.SelectedIndexChanged += new System.EventHandler(this.checkedListMovements_SelectedIndexChanged);
            // 
            // btnMovementsTemizle
            // 
            this.btnMovementsTemizle.BackColor = System.Drawing.SystemColors.Control;
            this.btnMovementsTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMovementsTemizle.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnMovementsTemizle.Location = new System.Drawing.Point(219, 148);
            this.btnMovementsTemizle.Name = "btnMovementsTemizle";
            this.btnMovementsTemizle.Size = new System.Drawing.Size(155, 36);
            this.btnMovementsTemizle.TabIndex = 14;
            this.btnMovementsTemizle.Text = "Temizle";
            this.btnMovementsTemizle.UseVisualStyleBackColor = false;
            this.btnMovementsTemizle.Click += new System.EventHandler(this.btnMovementsTemizle_Click);
            // 
            // btnMovementsSiparisAra
            // 
            this.btnMovementsSiparisAra.BackColor = System.Drawing.SystemColors.Control;
            this.btnMovementsSiparisAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMovementsSiparisAra.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnMovementsSiparisAra.Location = new System.Drawing.Point(40, 148);
            this.btnMovementsSiparisAra.Name = "btnMovementsSiparisAra";
            this.btnMovementsSiparisAra.Size = new System.Drawing.Size(155, 36);
            this.btnMovementsSiparisAra.TabIndex = 13;
            this.btnMovementsSiparisAra.Text = "Hareket Ara";
            this.btnMovementsSiparisAra.UseVisualStyleBackColor = false;
            this.btnMovementsSiparisAra.Click += new System.EventHandler(this.btnMovementsSiparisAra_Click_1);
            // 
            // checkMovementsSelectAll
            // 
            this.checkMovementsSelectAll.AutoSize = true;
            this.checkMovementsSelectAll.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.checkMovementsSelectAll.Location = new System.Drawing.Point(6, 32);
            this.checkMovementsSelectAll.Name = "checkMovementsSelectAll";
            this.checkMovementsSelectAll.Size = new System.Drawing.Size(93, 23);
            this.checkMovementsSelectAll.TabIndex = 0;
            this.checkMovementsSelectAll.Text = "Select All";
            this.checkMovementsSelectAll.UseVisualStyleBackColor = true;
            this.checkMovementsSelectAll.CheckedChanged += new System.EventHandler(this.checkMovementsSelectAll_CheckedChanged);
            // 
            // txtMovementsPozitions
            // 
            this.txtMovementsPozitions.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.txtMovementsPozitions.Location = new System.Drawing.Point(127, 65);
            this.txtMovementsPozitions.Name = "txtMovementsPozitions";
            this.txtMovementsPozitions.Size = new System.Drawing.Size(235, 26);
            this.txtMovementsPozitions.TabIndex = 4;
            this.txtMovementsPozitions.TextChanged += new System.EventHandler(this.txtMovementsPozitions_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(6, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 19);
            this.label5.TabIndex = 24;
            this.label5.Text = "Movements";
            // 
            // txtMovementsUser
            // 
            this.txtMovementsUser.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.txtMovementsUser.Location = new System.Drawing.Point(97, 49);
            this.txtMovementsUser.Name = "txtMovementsUser";
            this.txtMovementsUser.Size = new System.Drawing.Size(209, 26);
            this.txtMovementsUser.TabIndex = 7;
            this.txtMovementsUser.TextChanged += new System.EventHandler(this.txtMovementsUser_TextChanged);
            // 
            // txtMovementTerminal
            // 
            this.txtMovementTerminal.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.txtMovementTerminal.Location = new System.Drawing.Point(97, 103);
            this.txtMovementTerminal.Name = "txtMovementTerminal";
            this.txtMovementTerminal.Size = new System.Drawing.Size(209, 26);
            this.txtMovementTerminal.TabIndex = 8;
            this.txtMovementTerminal.TextChanged += new System.EventHandler(this.txtMovementTerminal_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.label12.Location = new System.Drawing.Point(8, 103);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 19);
            this.label12.TabIndex = 5;
            this.label12.Text = "Terminal";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.label11.Location = new System.Drawing.Point(8, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 19);
            this.label11.TabIndex = 4;
            this.label11.Text = "Kullanıcı";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtQuadrant);
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Controls.Add(this.txtMovementTerminal);
            this.groupBox6.Controls.Add(this.txtMovementsUser);
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.groupBox6.Location = new System.Drawing.Point(26, 56);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(347, 191);
            this.groupBox6.TabIndex = 19;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Filtre";
            // 
            // txtQuadrant
            // 
            this.txtQuadrant.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.txtQuadrant.Location = new System.Drawing.Point(97, 150);
            this.txtQuadrant.Name = "txtQuadrant";
            this.txtQuadrant.Size = new System.Drawing.Size(209, 26);
            this.txtQuadrant.TabIndex = 10;
            this.txtQuadrant.TextChanged += new System.EventHandler(this.txtQuadrant_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.label1.Location = new System.Drawing.Point(6, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Quadrant";
            // 
            // txtMovementsSku
            // 
            this.txtMovementsSku.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.txtMovementsSku.Location = new System.Drawing.Point(127, 28);
            this.txtMovementsSku.Name = "txtMovementsSku";
            this.txtMovementsSku.Size = new System.Drawing.Size(235, 26);
            this.txtMovementsSku.TabIndex = 3;
            this.txtMovementsSku.TextChanged += new System.EventHandler(this.txtMovementsSku_TextChanged);
            // 
            // dtgwMovements
            // 
            this.dtgwMovements.AutoGenerateColumns = false;
            this.dtgwMovements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgwMovements.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıdDataGridViewTextBoxColumn,
            this.workTypeDataGridViewTextBoxColumn,
            this.workNameDataGridViewTextBoxColumn,
            this.userCodeDataGridViewTextBoxColumn,
            this.TerminalCode,
            this.workDateDataGridViewTextBoxColumn,
            this.quadrantDataGridViewTextBoxColumn,
            this.skuDataGridViewTextBoxColumn,
            this.Pozition});
            this.dtgwMovements.DataSource = this.workBindingSource;
            this.dtgwMovements.Location = new System.Drawing.Point(26, 264);
            this.dtgwMovements.Name = "dtgwMovements";
            this.dtgwMovements.Size = new System.Drawing.Size(1289, 366);
            this.dtgwMovements.TabIndex = 23;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.checkedListMovements);
            this.groupBox8.Controls.Add(this.checkMovementsSelectAll);
            this.groupBox8.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.groupBox8.Location = new System.Drawing.Point(458, 56);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(391, 190);
            this.groupBox8.TabIndex = 21;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Hareket Tipi";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.label15.Location = new System.Drawing.Point(8, 31);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(38, 19);
            this.label15.TabIndex = 2;
            this.label15.Text = "Sku ";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.dateTimePickerFinish);
            this.groupBox9.Controls.Add(this.label23);
            this.groupBox9.Controls.Add(this.btnMovementsTemizle);
            this.groupBox9.Controls.Add(this.btnMovementsSiparisAra);
            this.groupBox9.Controls.Add(this.txtMovementsPozitions);
            this.groupBox9.Controls.Add(this.txtMovementsSku);
            this.groupBox9.Controls.Add(this.label15);
            this.groupBox9.Controls.Add(this.label13);
            this.groupBox9.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.groupBox9.Location = new System.Drawing.Point(934, 58);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(380, 190);
            this.groupBox9.TabIndex = 22;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Sku";
            // 
            // dateTimePickerFinish
            // 
            this.dateTimePickerFinish.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.dateTimePickerFinish.Location = new System.Drawing.Point(127, 101);
            this.dateTimePickerFinish.Name = "dateTimePickerFinish";
            this.dateTimePickerFinish.Size = new System.Drawing.Size(235, 26);
            this.dateTimePickerFinish.TabIndex = 16;
            this.dateTimePickerFinish.ValueChanged += new System.EventHandler(this.dateTimePickerFinish_ValueChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.label23.Location = new System.Drawing.Point(8, 108);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(52, 19);
            this.label23.TabIndex = 15;
            this.label23.Text = "Tarih :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.label13.Location = new System.Drawing.Point(8, 68);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 19);
            this.label13.TabIndex = 0;
            this.label13.Text = "Pozisyon";
            // 
            // workBindingSource
            // 
            this.workBindingSource.DataSource = typeof(TrackingApp.Work);
            // 
            // ıdDataGridViewTextBoxColumn
            // 
            this.ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.ıdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
            // 
            // workTypeDataGridViewTextBoxColumn
            // 
            this.workTypeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.workTypeDataGridViewTextBoxColumn.DataPropertyName = "WorkType";
            this.workTypeDataGridViewTextBoxColumn.HeaderText = "WorkType";
            this.workTypeDataGridViewTextBoxColumn.Name = "workTypeDataGridViewTextBoxColumn";
            // 
            // workNameDataGridViewTextBoxColumn
            // 
            this.workNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.workNameDataGridViewTextBoxColumn.DataPropertyName = "WorkName";
            this.workNameDataGridViewTextBoxColumn.HeaderText = "WorkName";
            this.workNameDataGridViewTextBoxColumn.Name = "workNameDataGridViewTextBoxColumn";
            // 
            // userCodeDataGridViewTextBoxColumn
            // 
            this.userCodeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.userCodeDataGridViewTextBoxColumn.DataPropertyName = "UserCode";
            this.userCodeDataGridViewTextBoxColumn.HeaderText = "UserCode";
            this.userCodeDataGridViewTextBoxColumn.Name = "userCodeDataGridViewTextBoxColumn";
            this.userCodeDataGridViewTextBoxColumn.Width = 79;
            // 
            // TerminalCode
            // 
            this.TerminalCode.DataPropertyName = "TerminalCode";
            this.TerminalCode.HeaderText = "TerminalCode";
            this.TerminalCode.Name = "TerminalCode";
            // 
            // workDateDataGridViewTextBoxColumn
            // 
            this.workDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.workDateDataGridViewTextBoxColumn.DataPropertyName = "WorkDate";
            this.workDateDataGridViewTextBoxColumn.HeaderText = "WorkDate";
            this.workDateDataGridViewTextBoxColumn.Name = "workDateDataGridViewTextBoxColumn";
            // 
            // quadrantDataGridViewTextBoxColumn
            // 
            this.quadrantDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.quadrantDataGridViewTextBoxColumn.DataPropertyName = "Quadrant";
            this.quadrantDataGridViewTextBoxColumn.HeaderText = "Quadrant";
            this.quadrantDataGridViewTextBoxColumn.Name = "quadrantDataGridViewTextBoxColumn";
            // 
            // skuDataGridViewTextBoxColumn
            // 
            this.skuDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.skuDataGridViewTextBoxColumn.DataPropertyName = "Sku";
            this.skuDataGridViewTextBoxColumn.HeaderText = "Sku";
            this.skuDataGridViewTextBoxColumn.Name = "skuDataGridViewTextBoxColumn";
            // 
            // Pozition
            // 
            this.Pozition.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Pozition.DataPropertyName = "Pozition";
            this.Pozition.HeaderText = "Pozition";
            this.Pozition.Name = "Pozition";
            // 
            // Movements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1351, 643);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.dtgwMovements);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox9);
            this.Name = "Movements";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movements";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Movements_Load);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgwMovements)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListMovements;
        private System.Windows.Forms.Button btnMovementsTemizle;
        private System.Windows.Forms.Button btnMovementsSiparisAra;
        private System.Windows.Forms.CheckBox checkMovementsSelectAll;
        private System.Windows.Forms.TextBox txtMovementsPozitions;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMovementsUser;
        private System.Windows.Forms.TextBox txtMovementTerminal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtMovementsSku;
        private System.Windows.Forms.DataGridView dtgwMovements;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dateTimePickerFinish;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.BindingSource workBindingSource;
        private System.Windows.Forms.TextBox txtQuadrant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TerminalCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn workDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quadrantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn skuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pozition;
    }
}