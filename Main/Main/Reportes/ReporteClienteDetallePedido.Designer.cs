﻿namespace Main.Reportes
{
    partial class ReporteClienteDetallePedido
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
            this.DataSetDetalleClientePedido = new Main.Reportes.DataSetDetalleClientePedido();
            this.DetallePedidoClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DetallePedidoClienteTableAdapter = new Main.Reportes.DataSetDetalleClientePedidoTableAdapters.DetallePedidoClienteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetDetalleClientePedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetallePedidoClienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet2";
            reportDataSource1.Value = this.DetallePedidoClienteBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Main.Reportes.ReporteClienteDetallePedido.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSetDetalleClientePedido
            // 
            this.DataSetDetalleClientePedido.DataSetName = "DataSetDetalleClientePedido";
            this.DataSetDetalleClientePedido.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DetallePedidoClienteBindingSource
            // 
            this.DetallePedidoClienteBindingSource.DataMember = "DetallePedidoCliente";
            this.DetallePedidoClienteBindingSource.DataSource = this.DataSetDetalleClientePedido;
            // 
            // DetallePedidoClienteTableAdapter
            // 
            this.DetallePedidoClienteTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteClienteDetallePedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteClienteDetallePedido";
            this.Text = "ReporteClienteDetallePedido";
            this.Load += new System.EventHandler(this.ReporteClienteDetallePedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetDetalleClientePedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetallePedidoClienteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DetallePedidoClienteBindingSource;
        private DataSetDetalleClientePedido DataSetDetalleClientePedido;
        private DataSetDetalleClientePedidoTableAdapters.DetallePedidoClienteTableAdapter DetallePedidoClienteTableAdapter;
    }
}