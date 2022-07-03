namespace TratixPABD
{
    partial class Form9
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tratixDataSet1 = new TratixPABD.tratixDataSet1();
            this.listBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listTableAdapter = new TratixPABD.tratixDataSet1TableAdapters.listTableAdapter();
            this.tratixDataSet3 = new TratixPABD.tratixDataSet3();
            this.detailPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detailPTableAdapter = new TratixPABD.tratixDataSet3TableAdapters.detailPTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tratixDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tratixDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailPBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.detailPBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TratixPABD.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // tratixDataSet1
            // 
            this.tratixDataSet1.DataSetName = "tratixDataSet1";
            this.tratixDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listBindingSource
            // 
            this.listBindingSource.DataMember = "list";
            this.listBindingSource.DataSource = this.tratixDataSet1;
            // 
            // listTableAdapter
            // 
            this.listTableAdapter.ClearBeforeFill = true;
            // 
            // tratixDataSet3
            // 
            this.tratixDataSet3.DataSetName = "tratixDataSet3";
            this.tratixDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // detailPBindingSource
            // 
            this.detailPBindingSource.DataMember = "detailP";
            this.detailPBindingSource.DataSource = this.tratixDataSet3;
            // 
            // detailPTableAdapter
            // 
            this.detailPTableAdapter.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightGray;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Location = new System.Drawing.Point(61, 387);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 26);
            this.button3.TabIndex = 14;
            this.button3.Text = "Kembali";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form9";
            this.Text = "Form9";
            this.Load += new System.EventHandler(this.Form9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tratixDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tratixDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailPBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private tratixDataSet1 tratixDataSet1;
        private System.Windows.Forms.BindingSource listBindingSource;
        private tratixDataSet1TableAdapters.listTableAdapter listTableAdapter;
        private tratixDataSet3 tratixDataSet3;
        private System.Windows.Forms.BindingSource detailPBindingSource;
        private tratixDataSet3TableAdapters.detailPTableAdapter detailPTableAdapter;
        private System.Windows.Forms.Button button3;
    }
}