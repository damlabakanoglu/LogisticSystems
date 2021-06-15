namespace TrackingApp
{
    partial class Inbounds
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
            this.label6 = new System.Windows.Forms.Label();
            this.txtSkuPiece = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbBrand = new System.Windows.Forms.ComboBox();
            this.ınboundBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.brandBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtSku = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.cbInboundType = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.txtConteynerCode = new System.Windows.Forms.TextBox();
            this.btnInboundOlustur = new System.Windows.Forms.Button();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerFinish = new System.Windows.Forms.DateTimePicker();
            this.label23 = new System.Windows.Forms.Label();
            this.dtgwInbound = new System.Windows.Forms.DataGridView();
            this.ıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ınboundBrandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skuIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skuPieceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ınboundTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ınboundConteynerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finalDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ınboundBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandBindingSource)).BeginInit();
            this.groupBox10.SuspendLayout();
            this.groupBox11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgwInbound)).BeginInit();
            this.groupBox12.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(37, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 19);
            this.label6.TabIndex = 26;
            this.label6.Text = "Inbounds";
            // 
            // txtSkuPiece
            // 
            this.txtSkuPiece.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSkuPiece.Location = new System.Drawing.Point(125, 81);
            this.txtSkuPiece.Name = "txtSkuPiece";
            this.txtSkuPiece.Size = new System.Drawing.Size(167, 26);
            this.txtSkuPiece.TabIndex = 10;
            this.txtSkuPiece.TextChanged += new System.EventHandler(this.txtSkuPiece_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(10, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Sku Piece :";
            // 
            // cbBrand
            // 
            this.cbBrand.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ınboundBindingSource, "InboundBrand", true));
            this.cbBrand.DataSource = this.brandBindingSource;
            this.cbBrand.DisplayMember = "BrandName";
            this.cbBrand.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbBrand.FormattingEnabled = true;
            this.cbBrand.Location = new System.Drawing.Point(125, 141);
            this.cbBrand.Name = "cbBrand";
            this.cbBrand.Size = new System.Drawing.Size(167, 26);
            this.cbBrand.TabIndex = 6;
            this.cbBrand.ValueMember = "BrandName";
            this.cbBrand.SelectedIndexChanged += new System.EventHandler(this.cbBrand_SelectedIndexChanged);
            // 
            // ınboundBindingSource
            // 
            this.ınboundBindingSource.DataSource = typeof(TrackingApp.Inbound);
            // 
            // brandBindingSource
            // 
            this.brandBindingSource.DataSource = typeof(TrackingApp.Brand);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(10, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Brand :";
            // 
            // txtSku
            // 
            this.txtSku.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSku.Location = new System.Drawing.Point(125, 23);
            this.txtSku.Name = "txtSku";
            this.txtSku.Size = new System.Drawing.Size(167, 26);
            this.txtSku.TabIndex = 2;
            this.txtSku.TextChanged += new System.EventHandler(this.txtSku_TextChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label19.Location = new System.Drawing.Point(10, 28);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(42, 19);
            this.label19.TabIndex = 0;
            this.label19.Text = "Sku :";
            // 
            // cbInboundType
            // 
            this.cbInboundType.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ınboundBindingSource, "InboundType", true));
            this.cbInboundType.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.ınboundBindingSource, "InboundType", true));
            this.cbInboundType.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbInboundType.FormattingEnabled = true;
            this.cbInboundType.Items.AddRange(new object[] {
            "A",
            "K",
            "T"});
            this.cbInboundType.Location = new System.Drawing.Point(131, 36);
            this.cbInboundType.Name = "cbInboundType";
            this.cbInboundType.Size = new System.Drawing.Size(167, 26);
            this.cbInboundType.TabIndex = 4;
            this.cbInboundType.SelectedIndexChanged += new System.EventHandler(this.cbInboundType_SelectedIndexChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label22.Location = new System.Drawing.Point(19, 42);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(105, 19);
            this.label22.TabIndex = 2;
            this.label22.Text = "Inbound Type :";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.txtSkuPiece);
            this.groupBox10.Controls.Add(this.label3);
            this.groupBox10.Controls.Add(this.cbBrand);
            this.groupBox10.Controls.Add(this.label1);
            this.groupBox10.Controls.Add(this.txtSku);
            this.groupBox10.Controls.Add(this.label19);
            this.groupBox10.Location = new System.Drawing.Point(75, 60);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(297, 207);
            this.groupBox10.TabIndex = 25;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Sku";
            // 
            // txtConteynerCode
            // 
            this.txtConteynerCode.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtConteynerCode.Location = new System.Drawing.Point(131, 107);
            this.txtConteynerCode.Name = "txtConteynerCode";
            this.txtConteynerCode.Size = new System.Drawing.Size(167, 26);
            this.txtConteynerCode.TabIndex = 8;
            this.txtConteynerCode.TextChanged += new System.EventHandler(this.txtConteynerCode_TextChanged);
            // 
            // btnInboundOlustur
            // 
            this.btnInboundOlustur.BackColor = System.Drawing.SystemColors.Control;
            this.btnInboundOlustur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnInboundOlustur.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnInboundOlustur.Location = new System.Drawing.Point(1173, 82);
            this.btnInboundOlustur.Name = "btnInboundOlustur";
            this.btnInboundOlustur.Size = new System.Drawing.Size(153, 58);
            this.btnInboundOlustur.TabIndex = 27;
            this.btnInboundOlustur.Text = "Inbound Oluştur";
            this.btnInboundOlustur.UseVisualStyleBackColor = false;
            this.btnInboundOlustur.Click += new System.EventHandler(this.btnInboundOlustur_Click);
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.cbInboundType);
            this.groupBox11.Controls.Add(this.label22);
            this.groupBox11.Controls.Add(this.txtConteynerCode);
            this.groupBox11.Controls.Add(this.label2);
            this.groupBox11.Location = new System.Drawing.Point(418, 60);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(316, 207);
            this.groupBox11.TabIndex = 20;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Konteynır";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(16, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Conteyner Code :";
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePickerStart.Location = new System.Drawing.Point(136, 51);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(200, 26);
            this.dateTimePickerStart.TabIndex = 4;
            this.dateTimePickerStart.ValueChanged += new System.EventHandler(this.dateTimePickerStart_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(6, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sipariş Tarihi :";
            // 
            // dateTimePickerFinish
            // 
            this.dateTimePickerFinish.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePickerFinish.Location = new System.Drawing.Point(136, 109);
            this.dateTimePickerFinish.Name = "dateTimePickerFinish";
            this.dateTimePickerFinish.Size = new System.Drawing.Size(200, 26);
            this.dateTimePickerFinish.TabIndex = 2;
            this.dateTimePickerFinish.ValueChanged += new System.EventHandler(this.dateTimePickerFinish_ValueChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label23.Location = new System.Drawing.Point(6, 114);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(124, 19);
            this.label23.TabIndex = 0;
            this.label23.Text = "Ulaştırma Tarihi :";
            // 
            // dtgwInbound
            // 
            this.dtgwInbound.AutoGenerateColumns = false;
            this.dtgwInbound.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgwInbound.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıdDataGridViewTextBoxColumn,
            this.ınboundBrandDataGridViewTextBoxColumn,
            this.skuIdDataGridViewTextBoxColumn,
            this.skuPieceDataGridViewTextBoxColumn,
            this.ınboundTypeDataGridViewTextBoxColumn,
            this.ınboundConteynerIdDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn,
            this.finalDateDataGridViewTextBoxColumn});
            this.dtgwInbound.DataSource = this.ınboundBindingSource;
            this.dtgwInbound.Location = new System.Drawing.Point(29, 282);
            this.dtgwInbound.Name = "dtgwInbound";
            this.dtgwInbound.Size = new System.Drawing.Size(1297, 377);
            this.dtgwInbound.TabIndex = 22;
            // 
            // ıdDataGridViewTextBoxColumn
            // 
            this.ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.ıdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
            // 
            // ınboundBrandDataGridViewTextBoxColumn
            // 
            this.ınboundBrandDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ınboundBrandDataGridViewTextBoxColumn.DataPropertyName = "InboundBrand";
            this.ınboundBrandDataGridViewTextBoxColumn.HeaderText = "InboundBrand";
            this.ınboundBrandDataGridViewTextBoxColumn.Name = "ınboundBrandDataGridViewTextBoxColumn";
            // 
            // skuIdDataGridViewTextBoxColumn
            // 
            this.skuIdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.skuIdDataGridViewTextBoxColumn.DataPropertyName = "SkuId";
            this.skuIdDataGridViewTextBoxColumn.HeaderText = "SkuId";
            this.skuIdDataGridViewTextBoxColumn.Name = "skuIdDataGridViewTextBoxColumn";
            this.skuIdDataGridViewTextBoxColumn.Width = 60;
            // 
            // skuPieceDataGridViewTextBoxColumn
            // 
            this.skuPieceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.skuPieceDataGridViewTextBoxColumn.DataPropertyName = "SkuPiece";
            this.skuPieceDataGridViewTextBoxColumn.HeaderText = "SkuPiece";
            this.skuPieceDataGridViewTextBoxColumn.Name = "skuPieceDataGridViewTextBoxColumn";
            // 
            // ınboundTypeDataGridViewTextBoxColumn
            // 
            this.ınboundTypeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ınboundTypeDataGridViewTextBoxColumn.DataPropertyName = "InboundType";
            this.ınboundTypeDataGridViewTextBoxColumn.HeaderText = "InboundType";
            this.ınboundTypeDataGridViewTextBoxColumn.Name = "ınboundTypeDataGridViewTextBoxColumn";
            // 
            // ınboundConteynerIdDataGridViewTextBoxColumn
            // 
            this.ınboundConteynerIdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ınboundConteynerIdDataGridViewTextBoxColumn.DataPropertyName = "InboundConteynerId";
            this.ınboundConteynerIdDataGridViewTextBoxColumn.HeaderText = "InboundConteynerId";
            this.ınboundConteynerIdDataGridViewTextBoxColumn.Name = "ınboundConteynerIdDataGridViewTextBoxColumn";
            this.ınboundConteynerIdDataGridViewTextBoxColumn.Width = 128;
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            this.startDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            this.startDateDataGridViewTextBoxColumn.HeaderText = "StartDate";
            this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            // 
            // finalDateDataGridViewTextBoxColumn
            // 
            this.finalDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.finalDateDataGridViewTextBoxColumn.DataPropertyName = "FinalDate";
            this.finalDateDataGridViewTextBoxColumn.HeaderText = "FinalDate";
            this.finalDateDataGridViewTextBoxColumn.Name = "finalDateDataGridViewTextBoxColumn";
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.dateTimePickerStart);
            this.groupBox12.Controls.Add(this.label4);
            this.groupBox12.Controls.Add(this.dateTimePickerFinish);
            this.groupBox12.Controls.Add(this.label23);
            this.groupBox12.Location = new System.Drawing.Point(789, 60);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(340, 207);
            this.groupBox12.TabIndex = 21;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Tarih";
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.SystemColors.Control;
            this.btnTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnTemizle.Location = new System.Drawing.Point(1173, 169);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(153, 58);
            this.btnTemizle.TabIndex = 24;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // Inbounds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1351, 694);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.btnInboundOlustur);
            this.Controls.Add(this.groupBox11);
            this.Controls.Add(this.dtgwInbound);
            this.Controls.Add(this.groupBox12);
            this.Controls.Add(this.btnTemizle);
            this.Name = "Inbounds";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inbounds";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Inbounds_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ınboundBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandBindingSource)).EndInit();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgwInbound)).EndInit();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSkuPiece;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbBrand;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSku;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cbInboundType;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.TextBox txtConteynerCode;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerFinish;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.BindingSource ınboundBindingSource;
        private System.Windows.Forms.BindingSource brandBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ınboundBrandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn skuIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn skuPieceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ınboundTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ınboundConteynerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn finalDateDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridView dtgwInbound;
        public System.Windows.Forms.Button btnInboundOlustur;
    }
}