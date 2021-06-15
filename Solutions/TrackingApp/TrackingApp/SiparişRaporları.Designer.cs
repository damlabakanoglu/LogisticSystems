namespace TrackingApp
{
    partial class SiparişRaporları
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
            this.checkedListStatus = new System.Windows.Forms.CheckedListBox();
            this.checkSelectAll = new System.Windows.Forms.CheckBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.txtQuadrant = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbBrand = new System.Windows.Forms.ComboBox();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.brandBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.txtSku = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.cbOrderType = new System.Windows.Forms.ComboBox();
            this.orderTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtCustomerId = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label21 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.dtgwSiparişRaporları = new System.Windows.Forms.DataGridView();
            this.ıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderSkuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quadrantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnSiparişAra = new System.Windows.Forms.Button();
            this.groupBox10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderTypeBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgwSiparişRaporları)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(11, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 19);
            this.label5.TabIndex = 31;
            this.label5.Text = "Order Reports";
            // 
            // checkedListStatus
            // 
            this.checkedListStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkedListStatus.FormattingEnabled = true;
            this.checkedListStatus.Items.AddRange(new object[] {
            "Picking",
            "Packing",
            "Shipping",
            "Done",
            "Incidence"});
            this.checkedListStatus.Location = new System.Drawing.Point(118, 19);
            this.checkedListStatus.Name = "checkedListStatus";
            this.checkedListStatus.Size = new System.Drawing.Size(160, 76);
            this.checkedListStatus.TabIndex = 1;
            this.checkedListStatus.SelectedIndexChanged += new System.EventHandler(this.checkedListStatus_SelectedIndexChanged);
            // 
            // checkSelectAll
            // 
            this.checkSelectAll.AutoSize = true;
            this.checkSelectAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkSelectAll.Location = new System.Drawing.Point(15, 43);
            this.checkSelectAll.Name = "checkSelectAll";
            this.checkSelectAll.Size = new System.Drawing.Size(85, 21);
            this.checkSelectAll.TabIndex = 0;
            this.checkSelectAll.Text = "Select All";
            this.checkSelectAll.UseVisualStyleBackColor = true;
            this.checkSelectAll.CheckedChanged += new System.EventHandler(this.checkSelectAll_CheckedChanged);
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.txtQuadrant);
            this.groupBox10.Controls.Add(this.label2);
            this.groupBox10.Controls.Add(this.cbBrand);
            this.groupBox10.Controls.Add(this.label3);
            this.groupBox10.Controls.Add(this.txtSku);
            this.groupBox10.Controls.Add(this.label19);
            this.groupBox10.Location = new System.Drawing.Point(27, 46);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(297, 207);
            this.groupBox10.TabIndex = 30;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Sku";
            // 
            // txtQuadrant
            // 
            this.txtQuadrant.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtQuadrant.Location = new System.Drawing.Point(117, 153);
            this.txtQuadrant.Name = "txtQuadrant";
            this.txtQuadrant.Size = new System.Drawing.Size(167, 26);
            this.txtQuadrant.TabIndex = 8;
            this.txtQuadrant.TextChanged += new System.EventHandler(this.txtQuadrant_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(10, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Quadrant :";
            // 
            // cbBrand
            // 
            this.cbBrand.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.orderBindingSource, "OrderBrandId", true));
            this.cbBrand.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.orderBindingSource, "OrderBrandId", true));
            this.cbBrand.DataSource = this.brandBindingSource;
            this.cbBrand.DisplayMember = "BrandName";
            this.cbBrand.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbBrand.FormattingEnabled = true;
            this.cbBrand.Location = new System.Drawing.Point(117, 93);
            this.cbBrand.Name = "cbBrand";
            this.cbBrand.Size = new System.Drawing.Size(167, 26);
            this.cbBrand.TabIndex = 6;
            this.cbBrand.ValueMember = "BrandName";
            this.cbBrand.SelectedIndexChanged += new System.EventHandler(this.cbBrand_SelectedIndexChanged);
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(TrackingApp.Order);
            // 
            // brandBindingSource
            // 
            this.brandBindingSource.DataSource = typeof(TrackingApp.Brand);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(10, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Brand :";
            // 
            // txtSku
            // 
            this.txtSku.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSku.Location = new System.Drawing.Point(117, 34);
            this.txtSku.Name = "txtSku";
            this.txtSku.Size = new System.Drawing.Size(167, 26);
            this.txtSku.TabIndex = 2;
            this.txtSku.TextChanged += new System.EventHandler(this.txtSku_TextChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label19.Location = new System.Drawing.Point(10, 39);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(42, 19);
            this.label19.TabIndex = 0;
            this.label19.Text = "Sku :";
            // 
            // cbOrderType
            // 
            this.cbOrderType.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.orderBindingSource, "OrderTypeId", true));
            this.cbOrderType.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.orderBindingSource, "OrderTypeId", true));
            this.cbOrderType.DataSource = this.orderTypeBindingSource;
            this.cbOrderType.DisplayMember = "OrderType1";
            this.cbOrderType.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbOrderType.FormattingEnabled = true;
            this.cbOrderType.Location = new System.Drawing.Point(131, 32);
            this.cbOrderType.Name = "cbOrderType";
            this.cbOrderType.Size = new System.Drawing.Size(160, 26);
            this.cbOrderType.TabIndex = 4;
            this.cbOrderType.ValueMember = "OrderType1";
            this.cbOrderType.SelectedIndexChanged += new System.EventHandler(this.cbOrderType_SelectedIndexChanged);
            // 
            // orderTypeBindingSource
            // 
            this.orderTypeBindingSource.DataSource = typeof(TrackingApp.OrderType);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkedListStatus);
            this.groupBox3.Controls.Add(this.checkSelectAll);
            this.groupBox3.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(14, 77);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(307, 124);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Status";
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCustomerId.Location = new System.Drawing.Point(141, 40);
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.Size = new System.Drawing.Size(167, 26);
            this.txtCustomerId.TabIndex = 5;
            this.txtCustomerId.TextChanged += new System.EventHandler(this.txtCustomerId_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.Location = new System.Drawing.Point(108, 140);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label21.Location = new System.Drawing.Point(36, 45);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(99, 19);
            this.label21.TabIndex = 3;
            this.label21.Text = "Customer Id :";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label23.Location = new System.Drawing.Point(4, 146);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(98, 19);
            this.label23.TabIndex = 0;
            this.label23.Text = "Sipariş Tarihi";
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.txtCustomerId);
            this.groupBox12.Controls.Add(this.dateTimePicker1);
            this.groupBox12.Controls.Add(this.label21);
            this.groupBox12.Controls.Add(this.label23);
            this.groupBox12.Location = new System.Drawing.Point(806, 46);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(313, 207);
            this.groupBox12.TabIndex = 29;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Tarih";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.cbOrderType);
            this.groupBox11.Controls.Add(this.groupBox3);
            this.groupBox11.Controls.Add(this.label22);
            this.groupBox11.Location = new System.Drawing.Point(400, 46);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(343, 207);
            this.groupBox11.TabIndex = 28;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Konteynır";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label22.Location = new System.Drawing.Point(19, 39);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(94, 19);
            this.label22.TabIndex = 2;
            this.label22.Text = "Order Type :";
            // 
            // dtgwSiparişRaporları
            // 
            this.dtgwSiparişRaporları.AutoGenerateColumns = false;
            this.dtgwSiparişRaporları.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgwSiparişRaporları.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıdDataGridViewTextBoxColumn,
            this.orderSkuDataGridViewTextBoxColumn,
            this.brandDataGridViewTextBoxColumn,
            this.quadrantDataGridViewTextBoxColumn,
            this.orderTypeDataGridViewTextBoxColumn,
            this.orderStatusDataGridViewTextBoxColumn,
            this.customerIdDataGridViewTextBoxColumn,
            this.orderDateDataGridViewTextBoxColumn});
            this.dtgwSiparişRaporları.DataSource = this.orderBindingSource;
            this.dtgwSiparişRaporları.Location = new System.Drawing.Point(27, 303);
            this.dtgwSiparişRaporları.Name = "dtgwSiparişRaporları";
            this.dtgwSiparişRaporları.RowHeadersWidth = 51;
            this.dtgwSiparişRaporları.Size = new System.Drawing.Size(1332, 349);
            this.dtgwSiparişRaporları.TabIndex = 26;
            // 
            // ıdDataGridViewTextBoxColumn
            // 
            this.ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.ıdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
            // 
            // orderSkuDataGridViewTextBoxColumn
            // 
            this.orderSkuDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.orderSkuDataGridViewTextBoxColumn.DataPropertyName = "OrderSku";
            this.orderSkuDataGridViewTextBoxColumn.HeaderText = "OrderSku";
            this.orderSkuDataGridViewTextBoxColumn.Name = "orderSkuDataGridViewTextBoxColumn";
            // 
            // brandDataGridViewTextBoxColumn
            // 
            this.brandDataGridViewTextBoxColumn.DataPropertyName = "OrderBrandId";
            this.brandDataGridViewTextBoxColumn.HeaderText = "Brand";
            this.brandDataGridViewTextBoxColumn.Name = "brandDataGridViewTextBoxColumn";
            // 
            // quadrantDataGridViewTextBoxColumn
            // 
            this.quadrantDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.quadrantDataGridViewTextBoxColumn.DataPropertyName = "Quadrant";
            this.quadrantDataGridViewTextBoxColumn.HeaderText = "Quadrant";
            this.quadrantDataGridViewTextBoxColumn.Name = "quadrantDataGridViewTextBoxColumn";
            // 
            // orderTypeDataGridViewTextBoxColumn
            // 
            this.orderTypeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.orderTypeDataGridViewTextBoxColumn.DataPropertyName = "OrderTypeId";
            this.orderTypeDataGridViewTextBoxColumn.HeaderText = "OrderType";
            this.orderTypeDataGridViewTextBoxColumn.Name = "orderTypeDataGridViewTextBoxColumn";
            // 
            // orderStatusDataGridViewTextBoxColumn
            // 
            this.orderStatusDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.orderStatusDataGridViewTextBoxColumn.DataPropertyName = "OrderStatus";
            this.orderStatusDataGridViewTextBoxColumn.HeaderText = "OrderStatus";
            this.orderStatusDataGridViewTextBoxColumn.Name = "orderStatusDataGridViewTextBoxColumn";
            // 
            // customerIdDataGridViewTextBoxColumn
            // 
            this.customerIdDataGridViewTextBoxColumn.DataPropertyName = "CustomerId";
            this.customerIdDataGridViewTextBoxColumn.HeaderText = "CustomerId";
            this.customerIdDataGridViewTextBoxColumn.Name = "customerIdDataGridViewTextBoxColumn";
            // 
            // orderDateDataGridViewTextBoxColumn
            // 
            this.orderDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.orderDateDataGridViewTextBoxColumn.DataPropertyName = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.HeaderText = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.SystemColors.Control;
            this.btnTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnTemizle.Location = new System.Drawing.Point(1206, 160);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(135, 58);
            this.btnTemizle.TabIndex = 25;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnSiparişAra
            // 
            this.btnSiparişAra.BackColor = System.Drawing.SystemColors.Control;
            this.btnSiparişAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSiparişAra.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnSiparişAra.Location = new System.Drawing.Point(1206, 78);
            this.btnSiparişAra.Name = "btnSiparişAra";
            this.btnSiparişAra.Size = new System.Drawing.Size(135, 58);
            this.btnSiparişAra.TabIndex = 27;
            this.btnSiparişAra.Text = "Sipariş Ara";
            this.btnSiparişAra.UseVisualStyleBackColor = false;
            this.btnSiparişAra.Click += new System.EventHandler(this.btnSiparişAra_Click);
            // 
            // SiparişRaporları
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1370, 663);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.groupBox12);
            this.Controls.Add(this.groupBox11);
            this.Controls.Add(this.dtgwSiparişRaporları);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnSiparişAra);
            this.Name = "SiparişRaporları";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SiparişRaporları";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SiparişRaporları_Load);
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderTypeBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgwSiparişRaporları)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckedListBox checkedListStatus;
        private System.Windows.Forms.CheckBox checkSelectAll;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.TextBox txtQuadrant;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbBrand;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSku;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cbOrderType;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.DataGridView dtgwSiparişRaporları;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnSiparişAra;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.BindingSource brandBindingSource;
        private System.Windows.Forms.BindingSource orderTypeBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderSkuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quadrantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
    }
}