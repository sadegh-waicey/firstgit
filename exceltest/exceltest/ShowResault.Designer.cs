namespace exceltest
{
    partial class ShowResault
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.webServiceNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pointDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distanseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.webServiceNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pointDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distanseDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keywordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availablityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.throghputDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reliablityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.latencyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.privacyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.responseTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.longitudeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.latitudeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sMSDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.eMailDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.iMDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.deviceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.webServiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.webServiceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(12, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(836, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "بازگشت";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeight = 33;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.webServiceNameDataGridViewTextBoxColumn1,
            this.pointDataGridViewTextBoxColumn1,
            this.distanseDataGridViewTextBoxColumn1,
            this.keywordDataGridViewTextBoxColumn,
            this.availablityDataGridViewTextBoxColumn,
            this.throghputDataGridViewTextBoxColumn,
            this.reliablityDataGridViewTextBoxColumn,
            this.latencyDataGridViewTextBoxColumn,
            this.privacyDataGridViewTextBoxColumn,
            this.responseTimeDataGridViewTextBoxColumn,
            this.longitudeDataGridViewTextBoxColumn,
            this.latitudeDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.sMSDataGridViewCheckBoxColumn,
            this.eMailDataGridViewCheckBoxColumn,
            this.iMDataGridViewCheckBoxColumn,
            this.deviceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.webServiceBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 35;
            this.dataGridView1.Size = new System.Drawing.Size(836, 421);
            this.dataGridView1.TabIndex = 1;
            // 
            // webServiceNameDataGridViewTextBoxColumn
            // 
            this.webServiceNameDataGridViewTextBoxColumn.DataPropertyName = "WebServiceName";
            this.webServiceNameDataGridViewTextBoxColumn.HeaderText = "نام وب سرویس";
            this.webServiceNameDataGridViewTextBoxColumn.Name = "webServiceNameDataGridViewTextBoxColumn";
            this.webServiceNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.webServiceNameDataGridViewTextBoxColumn.Width = 300;
            // 
            // pointDataGridViewTextBoxColumn
            // 
            this.pointDataGridViewTextBoxColumn.DataPropertyName = "Point";
            this.pointDataGridViewTextBoxColumn.HeaderText = "امتیاز";
            this.pointDataGridViewTextBoxColumn.Name = "pointDataGridViewTextBoxColumn";
            this.pointDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // distanseDataGridViewTextBoxColumn
            // 
            this.distanseDataGridViewTextBoxColumn.DataPropertyName = "Distanse";
            this.distanseDataGridViewTextBoxColumn.HeaderText = "فاصله";
            this.distanseDataGridViewTextBoxColumn.Name = "distanseDataGridViewTextBoxColumn";
            this.distanseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // webServiceNameDataGridViewTextBoxColumn1
            // 
            this.webServiceNameDataGridViewTextBoxColumn1.DataPropertyName = "WebServiceName";
            this.webServiceNameDataGridViewTextBoxColumn1.HeaderText = "نام وب سرویس";
            this.webServiceNameDataGridViewTextBoxColumn1.Name = "webServiceNameDataGridViewTextBoxColumn1";
            this.webServiceNameDataGridViewTextBoxColumn1.ReadOnly = true;
            this.webServiceNameDataGridViewTextBoxColumn1.Width = 300;
            // 
            // pointDataGridViewTextBoxColumn1
            // 
            this.pointDataGridViewTextBoxColumn1.DataPropertyName = "Point";
            this.pointDataGridViewTextBoxColumn1.HeaderText = "امتیاز";
            this.pointDataGridViewTextBoxColumn1.Name = "pointDataGridViewTextBoxColumn1";
            this.pointDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // distanseDataGridViewTextBoxColumn1
            // 
            this.distanseDataGridViewTextBoxColumn1.DataPropertyName = "Distanse";
            this.distanseDataGridViewTextBoxColumn1.HeaderText = "فاصله";
            this.distanseDataGridViewTextBoxColumn1.Name = "distanseDataGridViewTextBoxColumn1";
            this.distanseDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // keywordDataGridViewTextBoxColumn
            // 
            this.keywordDataGridViewTextBoxColumn.DataPropertyName = "Keyword";
            this.keywordDataGridViewTextBoxColumn.HeaderText = "Keyword";
            this.keywordDataGridViewTextBoxColumn.Name = "keywordDataGridViewTextBoxColumn";
            this.keywordDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // availablityDataGridViewTextBoxColumn
            // 
            this.availablityDataGridViewTextBoxColumn.DataPropertyName = "Availablity";
            this.availablityDataGridViewTextBoxColumn.HeaderText = "Availablity";
            this.availablityDataGridViewTextBoxColumn.Name = "availablityDataGridViewTextBoxColumn";
            this.availablityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // throghputDataGridViewTextBoxColumn
            // 
            this.throghputDataGridViewTextBoxColumn.DataPropertyName = "Throghput";
            this.throghputDataGridViewTextBoxColumn.HeaderText = "Throghput";
            this.throghputDataGridViewTextBoxColumn.Name = "throghputDataGridViewTextBoxColumn";
            this.throghputDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // reliablityDataGridViewTextBoxColumn
            // 
            this.reliablityDataGridViewTextBoxColumn.DataPropertyName = "Reliablity";
            this.reliablityDataGridViewTextBoxColumn.HeaderText = "Reliablity";
            this.reliablityDataGridViewTextBoxColumn.Name = "reliablityDataGridViewTextBoxColumn";
            this.reliablityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // latencyDataGridViewTextBoxColumn
            // 
            this.latencyDataGridViewTextBoxColumn.DataPropertyName = "Latency";
            this.latencyDataGridViewTextBoxColumn.HeaderText = "Latency";
            this.latencyDataGridViewTextBoxColumn.Name = "latencyDataGridViewTextBoxColumn";
            this.latencyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // privacyDataGridViewTextBoxColumn
            // 
            this.privacyDataGridViewTextBoxColumn.DataPropertyName = "Privacy";
            this.privacyDataGridViewTextBoxColumn.HeaderText = "Privacy";
            this.privacyDataGridViewTextBoxColumn.Name = "privacyDataGridViewTextBoxColumn";
            this.privacyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // responseTimeDataGridViewTextBoxColumn
            // 
            this.responseTimeDataGridViewTextBoxColumn.DataPropertyName = "ResponseTime";
            this.responseTimeDataGridViewTextBoxColumn.HeaderText = "ResponseTime";
            this.responseTimeDataGridViewTextBoxColumn.Name = "responseTimeDataGridViewTextBoxColumn";
            this.responseTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // longitudeDataGridViewTextBoxColumn
            // 
            this.longitudeDataGridViewTextBoxColumn.DataPropertyName = "Longitude";
            this.longitudeDataGridViewTextBoxColumn.HeaderText = "Longitude";
            this.longitudeDataGridViewTextBoxColumn.Name = "longitudeDataGridViewTextBoxColumn";
            this.longitudeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // latitudeDataGridViewTextBoxColumn
            // 
            this.latitudeDataGridViewTextBoxColumn.DataPropertyName = "Latitude";
            this.latitudeDataGridViewTextBoxColumn.HeaderText = "Latitude";
            this.latitudeDataGridViewTextBoxColumn.Name = "latitudeDataGridViewTextBoxColumn";
            this.latitudeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sMSDataGridViewCheckBoxColumn
            // 
            this.sMSDataGridViewCheckBoxColumn.DataPropertyName = "SMS";
            this.sMSDataGridViewCheckBoxColumn.HeaderText = "SMS";
            this.sMSDataGridViewCheckBoxColumn.Name = "sMSDataGridViewCheckBoxColumn";
            this.sMSDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // eMailDataGridViewCheckBoxColumn
            // 
            this.eMailDataGridViewCheckBoxColumn.DataPropertyName = "EMail";
            this.eMailDataGridViewCheckBoxColumn.HeaderText = "EMail";
            this.eMailDataGridViewCheckBoxColumn.Name = "eMailDataGridViewCheckBoxColumn";
            this.eMailDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // iMDataGridViewCheckBoxColumn
            // 
            this.iMDataGridViewCheckBoxColumn.DataPropertyName = "IM";
            this.iMDataGridViewCheckBoxColumn.HeaderText = "IM";
            this.iMDataGridViewCheckBoxColumn.Name = "iMDataGridViewCheckBoxColumn";
            this.iMDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // deviceDataGridViewTextBoxColumn
            // 
            this.deviceDataGridViewTextBoxColumn.DataPropertyName = "Device";
            this.deviceDataGridViewTextBoxColumn.HeaderText = "Device";
            this.deviceDataGridViewTextBoxColumn.Name = "deviceDataGridViewTextBoxColumn";
            this.deviceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // webServiceBindingSource
            // 
            this.webServiceBindingSource.DataSource = typeof(exceltest.WebService);
            // 
            // ShowResault
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(860, 474);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "ShowResault";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.Text = "نمایش نتیجه محاسبات";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ShowResault_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.webServiceBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn webServiceNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pointDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn distanseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn webServiceNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pointDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn distanseDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn keywordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn availablityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn throghputDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reliablityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn latencyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn privacyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn responseTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn longitudeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn latitudeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn sMSDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn eMailDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn iMDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deviceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource webServiceBindingSource;
    }
}