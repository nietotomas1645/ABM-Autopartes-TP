namespace TP_LAB
{
    partial class frmReportes2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportes2));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.FABRICA_AUTOMOTRIZDataSet = new TP_LAB.FABRICA_AUTOMOTRIZDataSet();
            this.Vehiculos_TerminadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Vehiculos_TerminadosTableAdapter = new TP_LAB.FABRICA_AUTOMOTRIZDataSetTableAdapters.Vehiculos_TerminadosTableAdapter();
            this.btnTodos = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtParam1 = new System.Windows.Forms.MaskedTextBox();
            this.txtParam2 = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.FABRICA_AUTOMOTRIZDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vehiculos_TerminadosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "dsVehiculos";
            reportDataSource1.Value = this.Vehiculos_TerminadosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TP_LAB.rptVehiculos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 37);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(761, 389);
            this.reportViewer1.TabIndex = 0;
            // 
            // FABRICA_AUTOMOTRIZDataSet
            // 
            this.FABRICA_AUTOMOTRIZDataSet.DataSetName = "FABRICA_AUTOMOTRIZDataSet";
            this.FABRICA_AUTOMOTRIZDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Vehiculos_TerminadosBindingSource
            // 
            this.Vehiculos_TerminadosBindingSource.DataMember = "Vehiculos_Terminados";
            this.Vehiculos_TerminadosBindingSource.DataSource = this.FABRICA_AUTOMOTRIZDataSet;
            // 
            // Vehiculos_TerminadosTableAdapter
            // 
            this.Vehiculos_TerminadosTableAdapter.ClearBeforeFill = true;
            // 
            // btnTodos
            // 
            this.btnTodos.Location = new System.Drawing.Point(12, 443);
            this.btnTodos.Name = "btnTodos";
            this.btnTodos.Size = new System.Drawing.Size(105, 28);
            this.btnTodos.TabIndex = 1;
            this.btnTodos.Text = "Todos";
            this.btnTodos.UseVisualStyleBackColor = true;
            this.btnTodos.Click += new System.EventHandler(this.btnTodos_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(683, 442);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(105, 28);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(335, 450);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Precios entre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(551, 450);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "y";
            // 
            // txtParam1
            // 
            this.txtParam1.Location = new System.Drawing.Point(437, 449);
            this.txtParam1.Mask = "9999999999999999999999999999999999999999999999999999999999999999999999";
            this.txtParam1.Name = "txtParam1";
            this.txtParam1.Size = new System.Drawing.Size(105, 20);
            this.txtParam1.TabIndex = 7;
            this.txtParam1.ValidatingType = typeof(int);
            // 
            // txtParam2
            // 
            this.txtParam2.Location = new System.Drawing.Point(572, 448);
            this.txtParam2.Mask = "999999999999999999999999999999999999999999999999999999999999999999999999999999999" +
    "99999";
            this.txtParam2.Name = "txtParam2";
            this.txtParam2.Size = new System.Drawing.Size(105, 20);
            this.txtParam2.TabIndex = 8;
            this.txtParam2.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Imprint MT Shadow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(249, 25);
            this.label3.TabIndex = 25;
            this.label3.Text = "FABRICA AUTOMOTRIZ";
            // 
            // frmReportes2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 486);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtParam2);
            this.Controls.Add(this.txtParam1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnTodos);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReportes2";
            this.Text = "REPORTE VEHICULOS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmReportes2_FormClosing);
            this.Load += new System.EventHandler(this.frmReportes2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FABRICA_AUTOMOTRIZDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vehiculos_TerminadosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Vehiculos_TerminadosBindingSource;
        private FABRICA_AUTOMOTRIZDataSet FABRICA_AUTOMOTRIZDataSet;
        private FABRICA_AUTOMOTRIZDataSetTableAdapters.Vehiculos_TerminadosTableAdapter Vehiculos_TerminadosTableAdapter;
        private System.Windows.Forms.Button btnTodos;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtParam1;
        private System.Windows.Forms.MaskedTextBox txtParam2;
        private System.Windows.Forms.Label label3;
    }
}