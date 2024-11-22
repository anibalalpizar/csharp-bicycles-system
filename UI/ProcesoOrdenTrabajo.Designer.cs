namespace ProyectoProgramadolll.UI
{
    partial class ProcesoOrdenTrabajo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProcesoOrdenTrabajo));
            this.dtpFinalizacion = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbBicicletas = new System.Windows.Forms.ComboBox();
            this.cmbClientes = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnlFirma = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbServicio = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ptbFotoBici = new System.Windows.Forms.PictureBox();
            this.ofdDialogo = new System.Windows.Forms.OpenFileDialog();
            this.btnAgregarDetalle = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEditarTelefono = new System.Windows.Forms.Button();
            this.btnEliminarTelefono = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lstDetalles = new System.Windows.Forms.ListBox();
            this.txaDescripcion = new System.Windows.Forms.TextBox();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colaborador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Firma = new System.Windows.Forms.DataGridViewImageColumn();
            this.FechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaFinalizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QR = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnFoto = new System.Windows.Forms.Button();
            this.lstFotografias = new System.Windows.Forms.ListBox();
            this.btnEliminarFoto = new System.Windows.Forms.Button();
            this.btnAgregarListaFotos = new System.Windows.Forms.Button();
            this.btnEliminarFirma = new System.Windows.Forms.Button();
            this.lblOrden = new System.Windows.Forms.Label();
            this.lblIdFotografia = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFotoBici)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpFinalizacion
            // 
            this.dtpFinalizacion.Location = new System.Drawing.Point(289, 177);
            this.dtpFinalizacion.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFinalizacion.Name = "dtpFinalizacion";
            this.dtpFinalizacion.Size = new System.Drawing.Size(201, 20);
            this.dtpFinalizacion.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(287, 151);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha de Finalizacion";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(286, 20);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(118, 13);
            this.lblDescripcion.TabIndex = 6;
            this.lblDescripcion.Text = "Descripción del trabajo:";
            this.lblDescripcion.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 84);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Nombre de la Bici";
            // 
            // cmbBicicletas
            // 
            this.cmbBicicletas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBicicletas.Enabled = false;
            this.cmbBicicletas.FormattingEnabled = true;
            this.cmbBicicletas.Location = new System.Drawing.Point(21, 109);
            this.cmbBicicletas.Margin = new System.Windows.Forms.Padding(2);
            this.cmbBicicletas.Name = "cmbBicicletas";
            this.cmbBicicletas.Size = new System.Drawing.Size(225, 21);
            this.cmbBicicletas.TabIndex = 8;
            // 
            // cmbClientes
            // 
            this.cmbClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClientes.FormattingEnabled = true;
            this.cmbClientes.Location = new System.Drawing.Point(21, 44);
            this.cmbClientes.Margin = new System.Windows.Forms.Padding(2);
            this.cmbClientes.Name = "cmbClientes";
            this.cmbClientes.Size = new System.Drawing.Size(225, 21);
            this.cmbClientes.TabIndex = 10;
            this.cmbClientes.SelectedIndexChanged += new System.EventHandler(this.cmbClientes_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 20);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Cliente/Dueño de la Bicicleta";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pnlFirma);
            this.groupBox1.Location = new System.Drawing.Point(700, 370);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(379, 234);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Firma del Cliente";
            // 
            // pnlFirma
            // 
            this.pnlFirma.Location = new System.Drawing.Point(22, 18);
            this.pnlFirma.Name = "pnlFirma";
            this.pnlFirma.Size = new System.Drawing.Size(337, 199);
            this.pnlFirma.TabIndex = 96;
            this.pnlFirma.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlFirma_Paint);
            this.pnlFirma.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlFirma_MouseDown);
            this.pnlFirma.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlFirma_MouseMove);
            this.pnlFirma.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlFirma_MouseUp);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 151);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Servicio-Mantenimiento Producto";
            // 
            // cmbServicio
            // 
            this.cmbServicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbServicio.FormattingEnabled = true;
            this.cmbServicio.Location = new System.Drawing.Point(21, 176);
            this.cmbServicio.Margin = new System.Windows.Forms.Padding(2);
            this.cmbServicio.Name = "cmbServicio";
            this.cmbServicio.Size = new System.Drawing.Size(225, 21);
            this.cmbServicio.TabIndex = 16;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ptbFotoBici);
            this.groupBox2.Location = new System.Drawing.Point(1029, 98);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(338, 183);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Foto de la Bicicleta (Opcional)";
            // 
            // ptbFotoBici
            // 
            this.ptbFotoBici.Location = new System.Drawing.Point(22, 20);
            this.ptbFotoBici.Margin = new System.Windows.Forms.Padding(2);
            this.ptbFotoBici.Name = "ptbFotoBici";
            this.ptbFotoBici.Size = new System.Drawing.Size(292, 144);
            this.ptbFotoBici.TabIndex = 0;
            this.ptbFotoBici.TabStop = false;
            // 
            // ofdDialogo
            // 
            this.ofdDialogo.FileName = "openFileDialog1";
            // 
            // btnAgregarDetalle
            // 
            this.btnAgregarDetalle.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgregarDetalle.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarDetalle.Image")));
            this.btnAgregarDetalle.Location = new System.Drawing.Point(519, 165);
            this.btnAgregarDetalle.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarDetalle.Name = "btnAgregarDetalle";
            this.btnAgregarDetalle.Size = new System.Drawing.Size(109, 32);
            this.btnAgregarDetalle.TabIndex = 73;
            this.btnAgregarDetalle.Text = "Agregar Servicio";
            this.btnAgregarDetalle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregarDetalle.UseVisualStyleBackColor = false;
            this.btnAgregarDetalle.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(306, 21);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(94, 45);
            this.btnCancelar.TabIndex = 93;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(213, 21);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(89, 45);
            this.btnEliminar.TabIndex = 91;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCrear.Image = ((System.Drawing.Image)(resources.GetObject("btnCrear.Image")));
            this.btnCrear.Location = new System.Drawing.Point(24, 21);
            this.btnCrear.Margin = new System.Windows.Forms.Padding(2);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(92, 45);
            this.btnCrear.TabIndex = 90;
            this.btnCrear.Text = "Guardar";
            this.btnCrear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCrear.UseVisualStyleBackColor = false;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnModificar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.Location = new System.Drawing.Point(120, 21);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(89, 45);
            this.btnModificar.TabIndex = 92;
            this.btnModificar.Text = "Editar";
            this.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnEditarTelefono);
            this.panel1.Controls.Add(this.btnEliminarTelefono);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lstDetalles);
            this.panel1.Controls.Add(this.txaDescripcion);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cmbClientes);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cmbBicicletas);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnAgregarDetalle);
            this.panel1.Controls.Add(this.cmbServicio);
            this.panel1.Controls.Add(this.lblDescripcion);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dtpFinalizacion);
            this.panel1.Location = new System.Drawing.Point(24, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(952, 252);
            this.panel1.TabIndex = 94;
            // 
            // btnEditarTelefono
            // 
            this.btnEditarTelefono.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEditarTelefono.Location = new System.Drawing.Point(837, 75);
            this.btnEditarTelefono.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditarTelefono.Name = "btnEditarTelefono";
            this.btnEditarTelefono.Size = new System.Drawing.Size(56, 31);
            this.btnEditarTelefono.TabIndex = 101;
            this.btnEditarTelefono.Text = "Editar";
            this.btnEditarTelefono.UseVisualStyleBackColor = false;
            this.btnEditarTelefono.Click += new System.EventHandler(this.btnEditarTelefono_Click);
            // 
            // btnEliminarTelefono
            // 
            this.btnEliminarTelefono.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminarTelefono.Location = new System.Drawing.Point(837, 121);
            this.btnEliminarTelefono.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarTelefono.Name = "btnEliminarTelefono";
            this.btnEliminarTelefono.Size = new System.Drawing.Size(56, 31);
            this.btnEliminarTelefono.TabIndex = 100;
            this.btnEliminarTelefono.Text = "Eliminar";
            this.btnEliminarTelefono.UseVisualStyleBackColor = false;
            this.btnEliminarTelefono.Click += new System.EventHandler(this.btnEliminarTelefono_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(673, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 98;
            this.label1.Text = "Detalle de la Orden:";
            // 
            // lstDetalles
            // 
            this.lstDetalles.FormattingEnabled = true;
            this.lstDetalles.Location = new System.Drawing.Point(676, 37);
            this.lstDetalles.Name = "lstDetalles";
            this.lstDetalles.Size = new System.Drawing.Size(142, 160);
            this.lstDetalles.TabIndex = 97;
            this.lstDetalles.SelectedIndexChanged += new System.EventHandler(this.lstDetalles_SelectedIndexChanged);
            // 
            // txaDescripcion
            // 
            this.txaDescripcion.Location = new System.Drawing.Point(289, 44);
            this.txaDescripcion.Multiline = true;
            this.txaDescripcion.Name = "txaDescripcion";
            this.txaDescripcion.Size = new System.Drawing.Size(339, 86);
            this.txaDescripcion.TabIndex = 74;
            // 
            // dgvDatos
            // 
            this.dgvDatos.BackgroundColor = System.Drawing.Color.LightCyan;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Colaborador,
            this.Firma,
            this.FechaInicio,
            this.FechaFinalizacion,
            this.QR});
            this.dgvDatos.Location = new System.Drawing.Point(24, 370);
            this.dgvDatos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.RowHeadersWidth = 51;
            this.dgvDatos.RowTemplate.Height = 24;
            this.dgvDatos.Size = new System.Drawing.Size(645, 234);
            this.dgvDatos.TabIndex = 95;
            this.dgvDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatos_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "IdOrdenTrabajo";
            this.Column1.HeaderText = "Codigo Orden";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "NombreCliente";
            this.Column2.HeaderText = "Cliente";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Colaborador
            // 
            this.Colaborador.DataPropertyName = "NombreVendedor";
            this.Colaborador.HeaderText = "Colaborador";
            this.Colaborador.Name = "Colaborador";
            // 
            // Firma
            // 
            this.Firma.DataPropertyName = "Firma";
            this.Firma.HeaderText = "Firma";
            this.Firma.Name = "Firma";
            this.Firma.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Firma.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // FechaInicio
            // 
            this.FechaInicio.DataPropertyName = "FechaInicio";
            this.FechaInicio.HeaderText = "Fecha Inicio";
            this.FechaInicio.Name = "FechaInicio";
            // 
            // FechaFinalizacion
            // 
            this.FechaFinalizacion.DataPropertyName = "FechaFinalizacion";
            this.FechaFinalizacion.HeaderText = "Fecha Finalizacion";
            this.FechaFinalizacion.Name = "FechaFinalizacion";
            // 
            // QR
            // 
            this.QR.DataPropertyName = "ImagenQROrden";
            this.QR.HeaderText = "QR";
            this.QR.Name = "QR";
            this.QR.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.QR.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btnFoto
            // 
            this.btnFoto.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFoto.Location = new System.Drawing.Point(1029, 301);
            this.btnFoto.Margin = new System.Windows.Forms.Padding(2);
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.Size = new System.Drawing.Size(94, 49);
            this.btnFoto.TabIndex = 96;
            this.btnFoto.Text = "Seleccionar Fotografia";
            this.btnFoto.UseVisualStyleBackColor = false;
            this.btnFoto.Click += new System.EventHandler(this.btnFoto_Click);
            // 
            // lstFotografias
            // 
            this.lstFotografias.FormattingEnabled = true;
            this.lstFotografias.Location = new System.Drawing.Point(1105, 375);
            this.lstFotografias.Name = "lstFotografias";
            this.lstFotografias.Size = new System.Drawing.Size(240, 212);
            this.lstFotografias.TabIndex = 97;
            this.lstFotografias.SelectedIndexChanged += new System.EventHandler(this.lstFotografias_SelectedIndexChanged);
            // 
            // btnEliminarFoto
            // 
            this.btnEliminarFoto.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminarFoto.Location = new System.Drawing.Point(1242, 301);
            this.btnEliminarFoto.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarFoto.Name = "btnEliminarFoto";
            this.btnEliminarFoto.Size = new System.Drawing.Size(112, 32);
            this.btnEliminarFoto.TabIndex = 101;
            this.btnEliminarFoto.Text = "Eliminar Fotografia";
            this.btnEliminarFoto.UseVisualStyleBackColor = false;
            this.btnEliminarFoto.Click += new System.EventHandler(this.btnEliminarFoto_Click);
            // 
            // btnAgregarListaFotos
            // 
            this.btnAgregarListaFotos.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgregarListaFotos.Location = new System.Drawing.Point(1127, 301);
            this.btnAgregarListaFotos.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarListaFotos.Name = "btnAgregarListaFotos";
            this.btnAgregarListaFotos.Size = new System.Drawing.Size(94, 49);
            this.btnAgregarListaFotos.TabIndex = 102;
            this.btnAgregarListaFotos.Text = "Agregar Foto a la Lista";
            this.btnAgregarListaFotos.UseVisualStyleBackColor = false;
            this.btnAgregarListaFotos.Click += new System.EventHandler(this.btnAgregarListaFotos_Click);
            // 
            // btnEliminarFirma
            // 
            this.btnEliminarFirma.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminarFirma.Location = new System.Drawing.Point(861, 609);
            this.btnEliminarFirma.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarFirma.Name = "btnEliminarFirma";
            this.btnEliminarFirma.Size = new System.Drawing.Size(56, 31);
            this.btnEliminarFirma.TabIndex = 103;
            this.btnEliminarFirma.Text = "Eliminar Firma";
            this.btnEliminarFirma.UseVisualStyleBackColor = false;
            this.btnEliminarFirma.Click += new System.EventHandler(this.btnEliminarFirma_Click);
            // 
            // lblOrden
            // 
            this.lblOrden.AutoSize = true;
            this.lblOrden.Enabled = false;
            this.lblOrden.Location = new System.Drawing.Point(1, -1);
            this.lblOrden.Name = "lblOrden";
            this.lblOrden.Size = new System.Drawing.Size(10, 13);
            this.lblOrden.TabIndex = 104;
            this.lblOrden.Text = "-";
            this.lblOrden.Visible = false;
            // 
            // lblIdFotografia
            // 
            this.lblIdFotografia.AutoSize = true;
            this.lblIdFotografia.Enabled = false;
            this.lblIdFotografia.Location = new System.Drawing.Point(1239, 9);
            this.lblIdFotografia.Name = "lblIdFotografia";
            this.lblIdFotografia.Size = new System.Drawing.Size(10, 13);
            this.lblIdFotografia.TabIndex = 105;
            this.lblIdFotografia.Text = "-";
            this.lblIdFotografia.Visible = false;
            // 
            // ProcesoOrdenTrabajo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1411, 651);
            this.Controls.Add(this.lblIdFotografia);
            this.Controls.Add(this.lblOrden);
            this.Controls.Add(this.btnEliminarFirma);
            this.Controls.Add(this.btnAgregarListaFotos);
            this.Controls.Add(this.btnEliminarFoto);
            this.Controls.Add(this.lstFotografias);
            this.Controls.Add(this.btnFoto);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ProcesoOrdenTrabajo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProcesoOrdenTrabajo";
            this.Load += new System.EventHandler(this.ProcesoOrdenTrabajo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbFotoBici)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpFinalizacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbBicicletas;
        private System.Windows.Forms.ComboBox cmbClientes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbServicio;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox ptbFotoBici;
        private System.Windows.Forms.OpenFileDialog ofdDialogo;
        private System.Windows.Forms.Button btnAgregarDetalle;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlFirma;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Button btnFoto;
        private System.Windows.Forms.TextBox txaDescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstDetalles;
        private System.Windows.Forms.Button btnEditarTelefono;
        private System.Windows.Forms.Button btnEliminarTelefono;
        private System.Windows.Forms.ListBox lstFotografias;
        private System.Windows.Forms.Button btnEliminarFoto;
        private System.Windows.Forms.Button btnAgregarListaFotos;
        private System.Windows.Forms.Button btnEliminarFirma;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colaborador;
        private System.Windows.Forms.DataGridViewImageColumn Firma;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaFinalizacion;
        private System.Windows.Forms.DataGridViewImageColumn QR;
        private System.Windows.Forms.Label lblOrden;
        private System.Windows.Forms.Label lblIdFotografia;
    }
}