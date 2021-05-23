
namespace CRUD_TAREA5
{
    partial class REPORTVIEWER
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
            this.BDProductosCrudDataSet = new CRUD_TAREA5.BDProductosCrudDataSet();
            this.tablaProductosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tablaProductosTableAdapter = new CRUD_TAREA5.BDProductosCrudDataSetTableAdapters.tablaProductosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.BDProductosCrudDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaProductosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetDetalle";
            reportDataSource1.Value = this.tablaProductosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CRUD_TAREA5.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(574, 525);
            this.reportViewer1.TabIndex = 0;
            // 
            // BDProductosCrudDataSet
            // 
            this.BDProductosCrudDataSet.DataSetName = "BDProductosCrudDataSet";
            this.BDProductosCrudDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tablaProductosBindingSource
            // 
            this.tablaProductosBindingSource.DataMember = "tablaProductos";
            this.tablaProductosBindingSource.DataSource = this.BDProductosCrudDataSet;
            // 
            // tablaProductosTableAdapter
            // 
            this.tablaProductosTableAdapter.ClearBeforeFill = true;
            // 
            // REPORTVIEWER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 525);
            this.Controls.Add(this.reportViewer1);
            this.Name = "REPORTVIEWER";
            this.Text = "REPORTVIEWER";
            this.Load += new System.EventHandler(this.REPORTVIEWER_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BDProductosCrudDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaProductosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tablaProductosBindingSource;
        private BDProductosCrudDataSet BDProductosCrudDataSet;
        private BDProductosCrudDataSetTableAdapters.tablaProductosTableAdapter tablaProductosTableAdapter;
    }
}