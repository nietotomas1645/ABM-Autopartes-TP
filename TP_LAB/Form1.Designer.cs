namespace TP_LAB
{
    partial class frmConsultas
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultas));
            this.dgAutos = new System.Windows.Forms.DataGridView();
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
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informe1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtParametro = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnCONSULTAR = new System.Windows.Forms.Button();
            this.lblCondicion = new System.Windows.Forms.Label();
            this.txtCondicion = new System.Windows.Forms.TextBox();
            this.txtConsulta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblQueConsulta = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.informe2VehículosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgAutos)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgAutos
            // 
            this.dgAutos.AllowUserToAddRows = false;
            this.dgAutos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgAutos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgAutos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgAutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgAutos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgAutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgAutos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgAutos.Location = new System.Drawing.Point(15, 129);
            this.dgAutos.Name = "dgAutos";
            this.dgAutos.ReadOnly = true;
            this.dgAutos.Size = new System.Drawing.Size(800, 301);
            this.dgAutos.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verToolStripMenuItem,
            this.insertarToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(829, 24);
            this.menuStrip1.TabIndex = 15;
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
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.verToolStripMenuItem.Text = "Ver Tabla";
            // 
            // vehiculosToolStripMenuItem
            // 
            this.vehiculosToolStripMenuItem.Name = "vehiculosToolStripMenuItem";
            this.vehiculosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.vehiculosToolStripMenuItem.Text = "Vehiculos";
            this.vehiculosToolStripMenuItem.Click += new System.EventHandler(this.vehiculosToolStripMenuItem_Click);
            // 
            // autopartesToolStripMenuItem
            // 
            this.autopartesToolStripMenuItem.Name = "autopartesToolStripMenuItem";
            this.autopartesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.autopartesToolStripMenuItem.Text = "Autopartes";
            this.autopartesToolStripMenuItem.Click += new System.EventHandler(this.autopartesToolStripMenuItem_Click);
            // 
            // autoPlanToolStripMenuItem
            // 
            this.autoPlanToolStripMenuItem.Name = "autoPlanToolStripMenuItem";
            this.autoPlanToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.autoPlanToolStripMenuItem.Text = "Auto Plan";
            this.autoPlanToolStripMenuItem.Click += new System.EventHandler(this.autoPlanToolStripMenuItem_Click);
            // 
            // ordenPedidoToolStripMenuItem
            // 
            this.ordenPedidoToolStripMenuItem.Name = "ordenPedidoToolStripMenuItem";
            this.ordenPedidoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ordenPedidoToolStripMenuItem.Text = "Orden Pedido";
            this.ordenPedidoToolStripMenuItem.Click += new System.EventHandler(this.ordenPedidoToolStripMenuItem_Click);
            // 
            // facturasToolStripMenuItem
            // 
            this.facturasToolStripMenuItem.Name = "facturasToolStripMenuItem";
            this.facturasToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.facturasToolStripMenuItem.Text = "Facturas";
            this.facturasToolStripMenuItem.Click += new System.EventHandler(this.facturasToolStripMenuItem_Click);
            // 
            // detalleFacturaToolStripMenuItem
            // 
            this.detalleFacturaToolStripMenuItem.Name = "detalleFacturaToolStripMenuItem";
            this.detalleFacturaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.detalleFacturaToolStripMenuItem.Text = "Detalle Factura";
            this.detalleFacturaToolStripMenuItem.Click += new System.EventHandler(this.detalleFacturaToolStripMenuItem_Click);
            // 
            // vendedoresToolStripMenuItem
            // 
            this.vendedoresToolStripMenuItem.Name = "vendedoresToolStripMenuItem";
            this.vendedoresToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.vendedoresToolStripMenuItem.Text = "Vendedores";
            this.vendedoresToolStripMenuItem.Click += new System.EventHandler(this.vendedoresToolStripMenuItem_Click);
            // 
            // formasPagoToolStripMenuItem
            // 
            this.formasPagoToolStripMenuItem.Name = "formasPagoToolStripMenuItem";
            this.formasPagoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.formasPagoToolStripMenuItem.Text = "Formas Pago";
            this.formasPagoToolStripMenuItem.Click += new System.EventHandler(this.formasPagoToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // tiposClienteToolStripMenuItem
            // 
            this.tiposClienteToolStripMenuItem.Name = "tiposClienteToolStripMenuItem";
            this.tiposClienteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tiposClienteToolStripMenuItem.Text = "Tipos Cliente";
            this.tiposClienteToolStripMenuItem.Click += new System.EventHandler(this.tiposClienteToolStripMenuItem_Click);
            // 
            // barriosToolStripMenuItem
            // 
            this.barriosToolStripMenuItem.Name = "barriosToolStripMenuItem";
            this.barriosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.barriosToolStripMenuItem.Text = "Barrios";
            this.barriosToolStripMenuItem.Click += new System.EventHandler(this.barriosToolStripMenuItem_Click);
            // 
            // localidadesToolStripMenuItem
            // 
            this.localidadesToolStripMenuItem.Name = "localidadesToolStripMenuItem";
            this.localidadesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.localidadesToolStripMenuItem.Text = "Localidades";
            this.localidadesToolStripMenuItem.Click += new System.EventHandler(this.localidadesToolStripMenuItem_Click);
            // 
            // provinciasToolStripMenuItem
            // 
            this.provinciasToolStripMenuItem.Name = "provinciasToolStripMenuItem";
            this.provinciasToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.provinciasToolStripMenuItem.Text = "Provincias";
            this.provinciasToolStripMenuItem.Click += new System.EventHandler(this.provinciasToolStripMenuItem_Click);
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
            this.insertarToolStripMenuItem.Name = "insertarToolStripMenuItem";
            this.insertarToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.insertarToolStripMenuItem.Text = "Ver Consulta";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.nuevoToolStripMenuItem.Text = "Consulta 1 : Vehículos";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // consulta2ToolStripMenuItem
            // 
            this.consulta2ToolStripMenuItem.Name = "consulta2ToolStripMenuItem";
            this.consulta2ToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.consulta2ToolStripMenuItem.Text = "Consulta 2 : Autopartes";
            this.consulta2ToolStripMenuItem.Click += new System.EventHandler(this.consulta2ToolStripMenuItem_Click);
            // 
            // consulta3ToolStripMenuItem
            // 
            this.consulta3ToolStripMenuItem.Name = "consulta3ToolStripMenuItem";
            this.consulta3ToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.consulta3ToolStripMenuItem.Text = "Consulta 3 : Este Año";
            this.consulta3ToolStripMenuItem.Click += new System.EventHandler(this.consulta3ToolStripMenuItem_Click);
            // 
            // consulta4ToolStripMenuItem
            // 
            this.consulta4ToolStripMenuItem.Name = "consulta4ToolStripMenuItem";
            this.consulta4ToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.consulta4ToolStripMenuItem.Text = "Consulta 4 : Nros Facturas";
            this.consulta4ToolStripMenuItem.Click += new System.EventHandler(this.consulta4ToolStripMenuItem_Click);
            // 
            // consulta5ToolStripMenuItem
            // 
            this.consulta5ToolStripMenuItem.Name = "consulta5ToolStripMenuItem";
            this.consulta5ToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.consulta5ToolStripMenuItem.Text = "Consulta 5: Max y Min";
            this.consulta5ToolStripMenuItem.Click += new System.EventHandler(this.consulta5ToolStripMenuItem_Click);
            // 
            // consulta6ToolStripMenuItem
            // 
            this.consulta6ToolStripMenuItem.Name = "consulta6ToolStripMenuItem";
            this.consulta6ToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.consulta6ToolStripMenuItem.Text = "Consulta 6 : Clientes/Vendedores";
            this.consulta6ToolStripMenuItem.Click += new System.EventHandler(this.consulta6ToolStripMenuItem_Click);
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
            this.nuevaAutoparteToolStripMenuItem.Click += new System.EventHandler(this.nuevaAutoparteToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informe1ToolStripMenuItem,
            this.informe2VehículosToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // informe1ToolStripMenuItem
            // 
            this.informe1ToolStripMenuItem.Name = "informe1ToolStripMenuItem";
            this.informe1ToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.informe1ToolStripMenuItem.Text = "Informe 1 : Clientes";
            this.informe1ToolStripMenuItem.Click += new System.EventHandler(this.informe1ToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.ayudaToolStripMenuItem.Text = "Acerca de...";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.acercaDeToolStripMenuItem.Text = "Quiénes somos?";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // txtParametro
            // 
            this.txtParametro.Enabled = false;
            this.txtParametro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParametro.Location = new System.Drawing.Point(326, 486);
            this.txtParametro.Name = "txtParametro";
            this.txtParametro.Size = new System.Drawing.Size(126, 26);
            this.txtParametro.TabIndex = 16;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Arial", 12F);
            this.lblNombre.Location = new System.Drawing.Point(230, 491);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(90, 18);
            this.lblNombre.TabIndex = 17;
            this.lblNombre.Text = "Parámetro: ";
            // 
            // btnCONSULTAR
            // 
            this.btnCONSULTAR.Location = new System.Drawing.Point(715, 486);
            this.btnCONSULTAR.Name = "btnCONSULTAR";
            this.btnCONSULTAR.Size = new System.Drawing.Size(99, 26);
            this.btnCONSULTAR.TabIndex = 18;
            this.btnCONSULTAR.Text = "CONSULTAR";
            this.btnCONSULTAR.UseVisualStyleBackColor = true;
            this.btnCONSULTAR.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblCondicion
            // 
            this.lblCondicion.AutoSize = true;
            this.lblCondicion.Font = new System.Drawing.Font("Arial", 12F);
            this.lblCondicion.Location = new System.Drawing.Point(469, 491);
            this.lblCondicion.Name = "lblCondicion";
            this.lblCondicion.Size = new System.Drawing.Size(83, 18);
            this.lblCondicion.TabIndex = 19;
            this.lblCondicion.Text = "Condición:";
            // 
            // txtCondicion
            // 
            this.txtCondicion.Enabled = false;
            this.txtCondicion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCondicion.Location = new System.Drawing.Point(558, 486);
            this.txtCondicion.Name = "txtCondicion";
            this.txtCondicion.Size = new System.Drawing.Size(134, 26);
            this.txtCondicion.TabIndex = 20;
            // 
            // txtConsulta
            // 
            this.txtConsulta.Enabled = false;
            this.txtConsulta.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsulta.Location = new System.Drawing.Point(91, 486);
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(120, 26);
            this.txtConsulta.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F);
            this.label1.Location = new System.Drawing.Point(12, 490);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 18);
            this.label1.TabIndex = 22;
            this.label1.Text = "Consulta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Imprint MT Shadow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 25);
            this.label2.TabIndex = 24;
            this.label2.Text = "FABRICA AUTOMOTRIZ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Checked = false;
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(712, 27);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(103, 20);
            this.dateTimePicker1.TabIndex = 25;
            this.dateTimePicker1.TabStop = false;
            // 
            // lblQueConsulta
            // 
            this.lblQueConsulta.AutoSize = true;
            this.lblQueConsulta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblQueConsulta.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQueConsulta.Location = new System.Drawing.Point(15, 452);
            this.lblQueConsulta.Name = "lblQueConsulta";
            this.lblQueConsulta.Size = new System.Drawing.Size(2, 19);
            this.lblQueConsulta.TabIndex = 26;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(799, 68);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // informe2VehículosToolStripMenuItem
            // 
            this.informe2VehículosToolStripMenuItem.Name = "informe2VehículosToolStripMenuItem";
            this.informe2VehículosToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.informe2VehículosToolStripMenuItem.Text = "Informe 2 : Vehículos";
            this.informe2VehículosToolStripMenuItem.Click += new System.EventHandler(this.informe2VehículosToolStripMenuItem_Click);
            // 
            // frmConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 524);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblQueConsulta);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtConsulta);
            this.Controls.Add(this.txtCondicion);
            this.Controls.Add(this.lblCondicion);
            this.Controls.Add(this.btnCONSULTAR);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtParametro);
            this.Controls.Add(this.dgAutos);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmConsultas";
            this.Text = "CONTROL COMPRA, VENTA Y STOCK";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAutos)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgAutos;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehiculosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autopartesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoPlanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordenPedidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detalleFacturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formasPagoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.TextBox txtParametro;
        private System.Windows.Forms.ToolStripMenuItem consulta2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consulta3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consulta4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consulta5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consulta6ToolStripMenuItem;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnCONSULTAR;
        private System.Windows.Forms.Label lblCondicion;
        private System.Windows.Forms.TextBox txtCondicion;
        private System.Windows.Forms.TextBox txtConsulta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblQueConsulta;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem tiposClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem barriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem provinciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoVehículoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaAutoparteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informe1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informe2VehículosToolStripMenuItem;
    }
}

