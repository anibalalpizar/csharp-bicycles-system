﻿namespace ProyectoProgramadolll.UI
{
    partial class MantenimientoClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantenimientoClientes));
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.TipoIdentificacionDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Identificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefonos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbDistrito = new System.Windows.Forms.ComboBox();
            this.cmbCanton = new System.Windows.Forms.ComboBox();
            this.cmbProvincia = new System.Windows.Forms.ComboBox();
            this.txtCorreoElectronico = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rdbMasculino = new System.Windows.Forms.RadioButton();
            this.rdbFemenino = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAnnadirTelefono = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbEstado = new System.Windows.Forms.GroupBox();
            this.rdbNoActivo = new System.Windows.Forms.RadioButton();
            this.rdbActivo = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.txtContrasegna = new System.Windows.Forms.TextBox();
            this.lblContrasegna = new System.Windows.Forms.Label();
            this.lstTelefonos = new System.Windows.Forms.ListView();
            this.btnEditarTelefono = new System.Windows.Forms.Button();
            this.btnEliminarTelefono = new System.Windows.Forms.Button();
            this.lblTipoIdentificacion = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.lblTelefonos = new System.Windows.Forms.Label();
            this.txtNumeroTelefonico = new System.Windows.Forms.TextBox();
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblCliente = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.panel1.SuspendLayout();
            this.gbEstado.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDatos
            // 
            this.dgvDatos.BackgroundColor = System.Drawing.Color.OldLace;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TipoIdentificacionDescripcion,
            this.Identificacion,
            this.colNombre,
            this.Sexo,
            this.Correo,
            this.Direccion,
            this.Telefonos});
            this.dgvDatos.Location = new System.Drawing.Point(18, 371);
            this.dgvDatos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDatos.MultiSelect = false;
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.RowHeadersWidth = 51;
            this.dgvDatos.RowTemplate.Height = 24;
            this.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatos.Size = new System.Drawing.Size(852, 256);
            this.dgvDatos.TabIndex = 18;
            // 
            // TipoIdentificacionDescripcion
            // 
            this.TipoIdentificacionDescripcion.DataPropertyName = "TipoIdentificacionDescripcion";
            this.TipoIdentificacionDescripcion.HeaderText = "Tipo de Identificacion";
            this.TipoIdentificacionDescripcion.Name = "TipoIdentificacionDescripcion";
            // 
            // Identificacion
            // 
            this.Identificacion.DataPropertyName = "Identificacion";
            this.Identificacion.HeaderText = "Identificacion";
            this.Identificacion.Name = "Identificacion";
            // 
            // colNombre
            // 
            this.colNombre.DataPropertyName = "Nombre";
            this.colNombre.HeaderText = "Nombre Completo";
            this.colNombre.MinimumWidth = 6;
            this.colNombre.Name = "colNombre";
            this.colNombre.Width = 125;
            // 
            // Sexo
            // 
            this.Sexo.DataPropertyName = "Genero";
            this.Sexo.HeaderText = "Sexo";
            this.Sexo.Name = "Sexo";
            // 
            // Correo
            // 
            this.Correo.DataPropertyName = "CorreoElectronico";
            this.Correo.HeaderText = "Correo Electronico";
            this.Correo.Name = "Correo";
            // 
            // Direccion
            // 
            this.Direccion.DataPropertyName = "DireccionCompleta";
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.Name = "Direccion";
            // 
            // Telefonos
            // 
            this.Telefonos.DataPropertyName = "Telefonos";
            this.Telefonos.HeaderText = "Telefonos";
            this.Telefonos.Name = "Telefonos";
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.Location = new System.Drawing.Point(110, 11);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(86, 41);
            this.btnEditar.TabIndex = 36;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(200, 11);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(89, 41);
            this.btnEliminar.TabIndex = 35;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCrear.Image = ((System.Drawing.Image)(resources.GetObject("btnCrear.Image")));
            this.btnCrear.Location = new System.Drawing.Point(18, 10);
            this.btnCrear.Margin = new System.Windows.Forms.Padding(2);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(88, 42);
            this.btnCrear.TabIndex = 33;
            this.btnCrear.Text = "Guardar";
            this.btnCrear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCrear.UseVisualStyleBackColor = false;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 241);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 73;
            this.label6.Text = "Distrito";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 217);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 72;
            this.label5.Text = "Canton";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 189);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 71;
            this.label4.Text = "Provincia";
            // 
            // cmbDistrito
            // 
            this.cmbDistrito.BackColor = System.Drawing.Color.Wheat;
            this.cmbDistrito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDistrito.Enabled = false;
            this.cmbDistrito.FormattingEnabled = true;
            this.cmbDistrito.Location = new System.Drawing.Point(137, 235);
            this.cmbDistrito.Margin = new System.Windows.Forms.Padding(2);
            this.cmbDistrito.Name = "cmbDistrito";
            this.cmbDistrito.Size = new System.Drawing.Size(154, 21);
            this.cmbDistrito.TabIndex = 70;
            // 
            // cmbCanton
            // 
            this.cmbCanton.BackColor = System.Drawing.Color.Wheat;
            this.cmbCanton.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCanton.Enabled = false;
            this.cmbCanton.FormattingEnabled = true;
            this.cmbCanton.Location = new System.Drawing.Point(137, 211);
            this.cmbCanton.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCanton.Name = "cmbCanton";
            this.cmbCanton.Size = new System.Drawing.Size(154, 21);
            this.cmbCanton.TabIndex = 69;
            this.cmbCanton.SelectedIndexChanged += new System.EventHandler(this.cmbCanton_SelectedIndexChanged);
            // 
            // cmbProvincia
            // 
            this.cmbProvincia.BackColor = System.Drawing.Color.Wheat;
            this.cmbProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProvincia.FormattingEnabled = true;
            this.cmbProvincia.Location = new System.Drawing.Point(137, 186);
            this.cmbProvincia.Margin = new System.Windows.Forms.Padding(2);
            this.cmbProvincia.Name = "cmbProvincia";
            this.cmbProvincia.Size = new System.Drawing.Size(154, 21);
            this.cmbProvincia.TabIndex = 68;
            this.cmbProvincia.SelectedIndexChanged += new System.EventHandler(this.cmbProvincia_SelectedIndexChanged);
            // 
            // txtCorreoElectronico
            // 
            this.txtCorreoElectronico.Location = new System.Drawing.Point(137, 147);
            this.txtCorreoElectronico.Margin = new System.Windows.Forms.Padding(2);
            this.txtCorreoElectronico.Name = "txtCorreoElectronico";
            this.txtCorreoElectronico.Size = new System.Drawing.Size(160, 20);
            this.txtCorreoElectronico.TabIndex = 67;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 147);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 66;
            this.label3.Text = "Correo Electronico";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // rdbMasculino
            // 
            this.rdbMasculino.AutoSize = true;
            this.rdbMasculino.Location = new System.Drawing.Point(224, 114);
            this.rdbMasculino.Margin = new System.Windows.Forms.Padding(2);
            this.rdbMasculino.Name = "rdbMasculino";
            this.rdbMasculino.Size = new System.Drawing.Size(73, 17);
            this.rdbMasculino.TabIndex = 65;
            this.rdbMasculino.TabStop = true;
            this.rdbMasculino.Text = "Masculino";
            this.rdbMasculino.UseVisualStyleBackColor = true;
            // 
            // rdbFemenino
            // 
            this.rdbFemenino.AutoSize = true;
            this.rdbFemenino.Location = new System.Drawing.Point(137, 112);
            this.rdbFemenino.Margin = new System.Windows.Forms.Padding(2);
            this.rdbFemenino.Name = "rdbFemenino";
            this.rdbFemenino.Size = new System.Drawing.Size(71, 17);
            this.rdbFemenino.TabIndex = 64;
            this.rdbFemenino.TabStop = true;
            this.rdbFemenino.Text = "Femenino";
            this.rdbFemenino.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 114);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 63;
            this.label1.Text = "Sexo";
            // 
            // btnAnnadirTelefono
            // 
            this.btnAnnadirTelefono.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAnnadirTelefono.Location = new System.Drawing.Point(718, 152);
            this.btnAnnadirTelefono.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnnadirTelefono.Name = "btnAnnadirTelefono";
            this.btnAnnadirTelefono.Size = new System.Drawing.Size(56, 31);
            this.btnAnnadirTelefono.TabIndex = 62;
            this.btnAnnadirTelefono.Text = "Añadir";
            this.btnAnnadirTelefono.UseVisualStyleBackColor = false;
            this.btnAnnadirTelefono.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(512, 20);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(160, 20);
            this.txtNombre.TabIndex = 61;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBuscar.Location = new System.Drawing.Point(312, 68);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(56, 22);
            this.btnBuscar.TabIndex = 60;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 58;
            this.label2.Text = "Ingrese su Cedula";
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(411, 25);
            this.Nombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(44, 13);
            this.Nombre.TabIndex = 57;
            this.Nombre.Text = "Nombre";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gbEstado);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtContrasegna);
            this.panel1.Controls.Add(this.lblContrasegna);
            this.panel1.Controls.Add(this.lstTelefonos);
            this.panel1.Controls.Add(this.btnEditarTelefono);
            this.panel1.Controls.Add(this.btnEliminarTelefono);
            this.panel1.Controls.Add(this.lblTipoIdentificacion);
            this.panel1.Controls.Add(this.cmbTipo);
            this.panel1.Controls.Add(this.lblTelefonos);
            this.panel1.Controls.Add(this.txtNumeroTelefonico);
            this.panel1.Controls.Add(this.txtIdentificacion);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cmbDistrito);
            this.panel1.Controls.Add(this.cmbCanton);
            this.panel1.Controls.Add(this.cmbProvincia);
            this.panel1.Controls.Add(this.txtCorreoElectronico);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.rdbMasculino);
            this.panel1.Controls.Add(this.rdbFemenino);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnAnnadirTelefono);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Nombre);
            this.panel1.Location = new System.Drawing.Point(18, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(852, 297);
            this.panel1.TabIndex = 76;
            // 
            // gbEstado
            // 
            this.gbEstado.Controls.Add(this.rdbNoActivo);
            this.gbEstado.Controls.Add(this.rdbActivo);
            this.gbEstado.Location = new System.Drawing.Point(512, 102);
            this.gbEstado.Name = "gbEstado";
            this.gbEstado.Size = new System.Drawing.Size(187, 48);
            this.gbEstado.TabIndex = 102;
            this.gbEstado.TabStop = false;
            // 
            // rdbNoActivo
            // 
            this.rdbNoActivo.AutoSize = true;
            this.rdbNoActivo.Checked = true;
            this.rdbNoActivo.Location = new System.Drawing.Point(98, 19);
            this.rdbNoActivo.Name = "rdbNoActivo";
            this.rdbNoActivo.Size = new System.Drawing.Size(71, 17);
            this.rdbNoActivo.TabIndex = 100;
            this.rdbNoActivo.TabStop = true;
            this.rdbNoActivo.Text = "No activo";
            this.rdbNoActivo.UseVisualStyleBackColor = true;
            // 
            // rdbActivo
            // 
            this.rdbActivo.AutoSize = true;
            this.rdbActivo.Location = new System.Drawing.Point(22, 19);
            this.rdbActivo.Name = "rdbActivo";
            this.rdbActivo.Size = new System.Drawing.Size(55, 17);
            this.rdbActivo.TabIndex = 101;
            this.rdbActivo.Text = "Activo";
            this.rdbActivo.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(411, 116);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 99;
            this.label7.Text = "Estado";
            // 
            // txtContrasegna
            // 
            this.txtContrasegna.Location = new System.Drawing.Point(512, 73);
            this.txtContrasegna.Margin = new System.Windows.Forms.Padding(2);
            this.txtContrasegna.Name = "txtContrasegna";
            this.txtContrasegna.Size = new System.Drawing.Size(160, 20);
            this.txtContrasegna.TabIndex = 84;
            // 
            // lblContrasegna
            // 
            this.lblContrasegna.AutoSize = true;
            this.lblContrasegna.Location = new System.Drawing.Point(411, 73);
            this.lblContrasegna.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContrasegna.Name = "lblContrasegna";
            this.lblContrasegna.Size = new System.Drawing.Size(64, 13);
            this.lblContrasegna.TabIndex = 83;
            this.lblContrasegna.Text = "Contraseña:";
            // 
            // lstTelefonos
            // 
            this.lstTelefonos.HideSelection = false;
            this.lstTelefonos.Location = new System.Drawing.Point(512, 186);
            this.lstTelefonos.Margin = new System.Windows.Forms.Padding(10);
            this.lstTelefonos.Name = "lstTelefonos";
            this.lstTelefonos.Size = new System.Drawing.Size(185, 97);
            this.lstTelefonos.TabIndex = 82;
            this.lstTelefonos.UseCompatibleStateImageBehavior = false;
            this.lstTelefonos.SelectedIndexChanged += new System.EventHandler(this.lstTelefonos_SelectedIndexChanged_1);
            // 
            // btnEditarTelefono
            // 
            this.btnEditarTelefono.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEditarTelefono.Location = new System.Drawing.Point(718, 206);
            this.btnEditarTelefono.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditarTelefono.Name = "btnEditarTelefono";
            this.btnEditarTelefono.Size = new System.Drawing.Size(56, 31);
            this.btnEditarTelefono.TabIndex = 81;
            this.btnEditarTelefono.Text = "Editar";
            this.btnEditarTelefono.UseVisualStyleBackColor = false;
            this.btnEditarTelefono.Click += new System.EventHandler(this.btnEditarTelefono_Click);
            // 
            // btnEliminarTelefono
            // 
            this.btnEliminarTelefono.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminarTelefono.Location = new System.Drawing.Point(718, 252);
            this.btnEliminarTelefono.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarTelefono.Name = "btnEliminarTelefono";
            this.btnEliminarTelefono.Size = new System.Drawing.Size(56, 31);
            this.btnEliminarTelefono.TabIndex = 80;
            this.btnEliminarTelefono.Text = "Eliminar";
            this.btnEliminarTelefono.UseVisualStyleBackColor = false;
            this.btnEliminarTelefono.Click += new System.EventHandler(this.btnEliminarTelefono_Click);
            // 
            // lblTipoIdentificacion
            // 
            this.lblTipoIdentificacion.AllowDrop = true;
            this.lblTipoIdentificacion.AutoSize = true;
            this.lblTipoIdentificacion.Location = new System.Drawing.Point(20, 30);
            this.lblTipoIdentificacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipoIdentificacion.Name = "lblTipoIdentificacion";
            this.lblTipoIdentificacion.Size = new System.Drawing.Size(112, 13);
            this.lblTipoIdentificacion.TabIndex = 79;
            this.lblTipoIdentificacion.Text = "Tipo de Identificacion:";
            this.lblTipoIdentificacion.Click += new System.EventHandler(this.lblTipoIdentificacion_Click);
            // 
            // cmbTipo
            // 
            this.cmbTipo.BackColor = System.Drawing.Color.Wheat;
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(137, 22);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(160, 21);
            this.cmbTipo.TabIndex = 78;
            this.cmbTipo.SelectedIndexChanged += new System.EventHandler(this.cmbTipo_SelectedIndexChanged);
            // 
            // lblTelefonos
            // 
            this.lblTelefonos.AutoSize = true;
            this.lblTelefonos.Location = new System.Drawing.Point(411, 158);
            this.lblTelefonos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTelefonos.Name = "lblTelefonos";
            this.lblTelefonos.Size = new System.Drawing.Size(54, 13);
            this.lblTelefonos.TabIndex = 78;
            this.lblTelefonos.Text = "Telefonos";
            // 
            // txtNumeroTelefonico
            // 
            this.txtNumeroTelefonico.Location = new System.Drawing.Point(512, 155);
            this.txtNumeroTelefonico.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumeroTelefonico.Name = "txtNumeroTelefonico";
            this.txtNumeroTelefonico.Size = new System.Drawing.Size(185, 20);
            this.txtNumeroTelefonico.TabIndex = 77;
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.Location = new System.Drawing.Point(137, 70);
            this.txtIdentificacion.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(160, 20);
            this.txtIdentificacion.TabIndex = 76;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(293, 11);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(93, 41);
            this.btnCancelar.TabIndex = 77;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblCliente
            // 
            this.lblCliente.AllowDrop = true;
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(4, -1);
            this.lblCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(10, 13);
            this.lblCliente.TabIndex = 83;
            this.lblCliente.Text = "-";
            this.lblCliente.Visible = false;
            // 
            // MantenimientoClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(896, 643);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.dgvDatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimizeBox = false;
            this.Name = "MantenimientoClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento de Clientes";
            this.Load += new System.EventHandler(this.MantenimientoClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbEstado.ResumeLayout(false);
            this.gbEstado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbDistrito;
        private System.Windows.Forms.ComboBox cmbCanton;
        private System.Windows.Forms.ComboBox cmbProvincia;
        private System.Windows.Forms.TextBox txtCorreoElectronico;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdbMasculino;
        private System.Windows.Forms.RadioButton rdbFemenino;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAnnadirTelefono;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtIdentificacion;
        private System.Windows.Forms.TextBox txtNumeroTelefonico;
        private System.Windows.Forms.Label lblTelefonos;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label lblTipoIdentificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoIdentificacionDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Identificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefonos;
        private System.Windows.Forms.Button btnEditarTelefono;
        private System.Windows.Forms.Button btnEliminarTelefono;
        private System.Windows.Forms.ListView lstTelefonos;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox txtContrasegna;
        private System.Windows.Forms.Label lblContrasegna;
        private System.Windows.Forms.RadioButton rdbNoActivo;
        private System.Windows.Forms.RadioButton rdbActivo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gbEstado;
    }
}