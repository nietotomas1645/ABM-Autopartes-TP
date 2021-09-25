namespace TP_LAB
{
    partial class frmAutopartes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAutopartes));
            this.txtIdA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstAutopartes = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehiculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autopartesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoPlanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenPedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detalleFacturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formasPagoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiposClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.provinciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consulta2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consulta3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consulta4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consulta5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consulta6ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoVehículoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaAutoparteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnConfirmarAP = new System.Windows.Forms.Button();
            this.txtPrecioA = new System.Windows.Forms.TextBox();
            this.cboTipoA = new System.Windows.Forms.ComboBox();
            this.txtNombreA = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtStockMin = new System.Windows.Forms.TextBox();
            this.txtStockActual = new System.Windows.Forms.TextBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIdA
            // 
            this.txtIdA.Location = new System.Drawing.Point(104, 139);
            this.txtIdA.Name = "txtIdA";
            this.txtIdA.Size = new System.Drawing.Size(142, 20);
            this.txtIdA.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 16);
            this.label1.TabIndex = 51;
            this.label1.Text = "ID";
            // 
            // lstAutopartes
            // 
            this.lstAutopartes.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstAutopartes.FormattingEnabled = true;
            this.lstAutopartes.ItemHeight = 16;
            this.lstAutopartes.Location = new System.Drawing.Point(267, 139);
            this.lstAutopartes.Name = "lstAutopartes";
            this.lstAutopartes.Size = new System.Drawing.Size(493, 260);
            this.lstAutopartes.TabIndex = 50;
            this.lstAutopartes.SelectedIndexChanged += new System.EventHandler(this.lstAutopartes_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verToolStripMenuItem,
            this.insertarToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(772, 24);
            this.menuStrip1.TabIndex = 48;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vehiculosToolStripMenuItem,
            this.autopartesToolStripMenuItem,
            this.autoPlanToolStripMenuItem,
            this.ordenPedidoToolStripMenuItem,
            this.facturasToolStripMenuItem,
            this.detalleFacturaToolStripMenuItem,
            this.vendedoresToolStripMenuItem,
            this.formasPagoToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.tiposClienteToolStripMenuItem,
            this.barriosToolStripMenuItem,
            this.localidadesToolStripMenuItem,
            this.provinciasToolStripMenuItem});
            this.verToolStripMenuItem.Enabled = false;
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.verToolStripMenuItem.Text = "Ver Tabla";
            // 
            // vehiculosToolStripMenuItem
            // 
            this.vehiculosToolStripMenuItem.Name = "vehiculosToolStripMenuItem";
            this.vehiculosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.vehiculosToolStripMenuItem.Text = "Vehiculos";
            // 
            // autopartesToolStripMenuItem
            // 
            this.autopartesToolStripMenuItem.Name = "autopartesToolStripMenuItem";
            this.autopartesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.autopartesToolStripMenuItem.Text = "Autopartes";
            // 
            // autoPlanToolStripMenuItem
            // 
            this.autoPlanToolStripMenuItem.Name = "autoPlanToolStripMenuItem";
            this.autoPlanToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.autoPlanToolStripMenuItem.Text = "Auto Plan";
            // 
            // ordenPedidoToolStripMenuItem
            // 
            this.ordenPedidoToolStripMenuItem.Name = "ordenPedidoToolStripMenuItem";
            this.ordenPedidoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ordenPedidoToolStripMenuItem.Text = "Orden Pedido";
            // 
            // facturasToolStripMenuItem
            // 
            this.facturasToolStripMenuItem.Name = "facturasToolStripMenuItem";
            this.facturasToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.facturasToolStripMenuItem.Text = "Facturas";
            // 
            // detalleFacturaToolStripMenuItem
            // 
            this.detalleFacturaToolStripMenuItem.Name = "detalleFacturaToolStripMenuItem";
            this.detalleFacturaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.detalleFacturaToolStripMenuItem.Text = "Detalle Factura";
            // 
            // vendedoresToolStripMenuItem
            // 
            this.vendedoresToolStripMenuItem.Name = "vendedoresToolStripMenuItem";
            this.vendedoresToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.vendedoresToolStripMenuItem.Text = "Vendedores";
            // 
            // formasPagoToolStripMenuItem
            // 
            this.formasPagoToolStripMenuItem.Name = "formasPagoToolStripMenuItem";
            this.formasPagoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.formasPagoToolStripMenuItem.Text = "Formas Pago";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // tiposClienteToolStripMenuItem
            // 
            this.tiposClienteToolStripMenuItem.Name = "tiposClienteToolStripMenuItem";
            this.tiposClienteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tiposClienteToolStripMenuItem.Text = "Tipos Cliente";
            // 
            // barriosToolStripMenuItem
            // 
            this.barriosToolStripMenuItem.Name = "barriosToolStripMenuItem";
            this.barriosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.barriosToolStripMenuItem.Text = "Barrios";
            // 
            // localidadesToolStripMenuItem
            // 
            this.localidadesToolStripMenuItem.Name = "localidadesToolStripMenuItem";
            this.localidadesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.localidadesToolStripMenuItem.Text = "Localidades";
            // 
            // provinciasToolStripMenuItem
            // 
            this.provinciasToolStripMenuItem.Name = "provinciasToolStripMenuItem";
            this.provinciasToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.provinciasToolStripMenuItem.Text = "Provincias";
            // 
            // insertarToolStripMenuItem
            // 
            this.insertarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.consulta2ToolStripMenuItem,
            this.consulta3ToolStripMenuItem,
            this.consulta4ToolStripMenuItem,
            this.consulta5ToolStripMenuItem,
            this.consulta6ToolStripMenuItem});
            this.insertarToolStripMenuItem.Enabled = false;
            this.insertarToolStripMenuItem.Name = "insertarToolStripMenuItem";
            this.insertarToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.insertarToolStripMenuItem.Text = "Ver Consulta";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.nuevoToolStripMenuItem.Text = "Consulta 1 : Vehículos";
            // 
            // consulta2ToolStripMenuItem
            // 
            this.consulta2ToolStripMenuItem.Name = "consulta2ToolStripMenuItem";
            this.consulta2ToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.consulta2ToolStripMenuItem.Text = "Consulta 2 : Autopartes";
            // 
            // consulta3ToolStripMenuItem
            // 
            this.consulta3ToolStripMenuItem.Name = "consulta3ToolStripMenuItem";
            this.consulta3ToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.consulta3ToolStripMenuItem.Text = "Consulta 3 : Este Año";
            // 
            // consulta4ToolStripMenuItem
            // 
            this.consulta4ToolStripMenuItem.Name = "consulta4ToolStripMenuItem";
            this.consulta4ToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.consulta4ToolStripMenuItem.Text = "Consulta 4 : Nros Facturas";
            // 
            // consulta5ToolStripMenuItem
            // 
            this.consulta5ToolStripMenuItem.Name = "consulta5ToolStripMenuItem";
            this.consulta5ToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.consulta5ToolStripMenuItem.Text = "Consulta 5: Max y Min";
            // 
            // consulta6ToolStripMenuItem
            // 
            this.consulta6ToolStripMenuItem.Name = "consulta6ToolStripMenuItem";
            this.consulta6ToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.consulta6ToolStripMenuItem.Text = "Consulta 6 : Clientes/Vendedores";
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoVehículoToolStripMenuItem,
            this.nuevaAutoparteToolStripMenuItem});
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.editarToolStripMenuItem.Text = "Insert / Update";
            // 
            // nuevoVehículoToolStripMenuItem
            // 
            this.nuevoVehículoToolStripMenuItem.Name = "nuevoVehículoToolStripMenuItem";
            this.nuevoVehículoToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.nuevoVehículoToolStripMenuItem.Text = "Vehículos";
            this.nuevoVehículoToolStripMenuItem.Click += new System.EventHandler(this.nuevoVehículoToolStripMenuItem_Click);
            // 
            // nuevaAutoparteToolStripMenuItem
            // 
            this.nuevaAutoparteToolStripMenuItem.Name = "nuevaAutoparteToolStripMenuItem";
            this.nuevaAutoparteToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.nuevaAutoparteToolStripMenuItem.Text = "Autopartes";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.ayudaToolStripMenuItem.Text = "Acerca de...";
            this.ayudaToolStripMenuItem.Click += new System.EventHandler(this.ayudaToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.acercaDeToolStripMenuItem.Text = "Quiénes somos?";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Checked = false;
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(657, 27);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(103, 20);
            this.dateTimePicker1.TabIndex = 47;
            this.dateTimePicker1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(748, 68);
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label6.Font = new System.Drawing.Font("Imprint MT Shadow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(249, 25);
            this.label6.TabIndex = 45;
            this.label6.Text = "FABRICA AUTOMOTRIZ";
            // 
            // btnConfirmarAP
            // 
            this.btnConfirmarAP.Location = new System.Drawing.Point(624, 412);
            this.btnConfirmarAP.Name = "btnConfirmarAP";
            this.btnConfirmarAP.Size = new System.Drawing.Size(134, 32);
            this.btnConfirmarAP.TabIndex = 44;
            this.btnConfirmarAP.Text = "Confirmar";
            this.btnConfirmarAP.UseVisualStyleBackColor = true;
            this.btnConfirmarAP.Click += new System.EventHandler(this.btnConfirmarAP_Click);
            // 
            // txtPrecioA
            // 
            this.txtPrecioA.Location = new System.Drawing.Point(103, 281);
            this.txtPrecioA.Name = "txtPrecioA";
            this.txtPrecioA.Size = new System.Drawing.Size(142, 20);
            this.txtPrecioA.TabIndex = 43;
            // 
            // cboTipoA
            // 
            this.cboTipoA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoA.FormattingEnabled = true;
            this.cboTipoA.Location = new System.Drawing.Point(103, 233);
            this.cboTipoA.Name = "cboTipoA";
            this.cboTipoA.Size = new System.Drawing.Size(142, 21);
            this.cboTipoA.TabIndex = 42;
            // 
            // txtNombreA
            // 
            this.txtNombreA.Location = new System.Drawing.Point(104, 186);
            this.txtNombreA.Name = "txtNombreA";
            this.txtNombreA.Size = new System.Drawing.Size(142, 20);
            this.txtNombreA.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 16);
            this.label5.TabIndex = 40;
            this.label5.Text = "Precio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 39;
            this.label4.Text = "Tipo Autoparte";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 37;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 334);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 53;
            this.label3.Text = "Stock Mínimo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 376);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 16);
            this.label7.TabIndex = 54;
            this.label7.Text = "Stock Actual";
            // 
            // txtStockMin
            // 
            this.txtStockMin.Location = new System.Drawing.Point(103, 328);
            this.txtStockMin.Name = "txtStockMin";
            this.txtStockMin.Size = new System.Drawing.Size(142, 20);
            this.txtStockMin.TabIndex = 55;
            // 
            // txtStockActual
            // 
            this.txtStockActual.Location = new System.Drawing.Point(103, 375);
            this.txtStockActual.Name = "txtStockActual";
            this.txtStockActual.Size = new System.Drawing.Size(142, 20);
            this.txtStockActual.TabIndex = 56;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(12, 412);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(134, 32);
            this.btnNuevo.TabIndex = 57;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(165, 412);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(134, 32);
            this.btnEditar.TabIndex = 58;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(318, 412);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(134, 32);
            this.btnBorrar.TabIndex = 59;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(471, 412);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(134, 32);
            this.btnCancelar.TabIndex = 60;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmAutopartes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 456);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.txtStockActual);
            this.Controls.Add(this.txtStockMin);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIdA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstAutopartes);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnConfirmarAP);
            this.Controls.Add(this.txtPrecioA);
            this.Controls.Add(this.cboTipoA);
            this.Controls.Add(this.txtNombreA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAutopartes";
            this.Text = "AUTOPARTES: COMPRA, VENTA O STOCK";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAutopartes_FormClosing);
            this.Load += new System.EventHandler(this.frmAutopartes_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstAutopartes;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehiculosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autopartesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoPlanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordenPedidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detalleFacturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formasPagoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiposClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem barriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem provinciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consulta2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consulta3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consulta4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consulta5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consulta6ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoVehículoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaAutoparteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnConfirmarAP;
        private System.Windows.Forms.TextBox txtPrecioA;
        private System.Windows.Forms.ComboBox cboTipoA;
        private System.Windows.Forms.TextBox txtNombreA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtStockMin;
        private System.Windows.Forms.TextBox txtStockActual;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnCancelar;
    }
}