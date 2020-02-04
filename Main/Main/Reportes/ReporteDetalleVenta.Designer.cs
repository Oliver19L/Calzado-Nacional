namespace Main.Reportes
{
    partial class ReporteDetalleVenta
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSet = new Main.Reportes.DataSet();
            this.ListaDetalleVentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ListaDetalleVentaTableAdapter = new Main.Reportes.DataSetTableAdapters.ListaDetalleVentaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListaDetalleVentaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ListaDetalleVentaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Main.Reportes.ListaDetalleVenta.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(826, 293);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSet
            // 
            this.DataSet.DataSetName = "DataSet";
            this.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ListaDetalleVentaBindingSource
            // 
            this.ListaDetalleVentaBindingSource.DataMember = "ListaDetalleVenta";
            this.ListaDetalleVentaBindingSource.DataSource = this.DataSet;
            // 
            // ListaDetalleVentaTableAdapter
            // 
            this.ListaDetalleVentaTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteDetalleVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 293);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteDetalleVenta";
            this.Text = "ReporteDetalleVenta";
            this.Load += new System.EventHandler(this.ReporteDetalleVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListaDetalleVentaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ListaDetalleVentaBindingSource;
        private DataSet DataSet;
        private DataSetTableAdapters.ListaDetalleVentaTableAdapter ListaDetalleVentaTableAdapter;
    }
}