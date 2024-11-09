namespace ProyectoProgramadolll.UI
{
    partial class MantenimientoTienda
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
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.txtImpuestoVenta = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblImpuestoVenta = new System.Windows.Forms.Label();
            this.txtCedulaJuridica = new System.Windows.Forms.TextBox();
            this.txtNumeroTelefonico = new System.Windows.Forms.TextBox();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.cedulaJuridica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImpuestoVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(160, 27);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(56, 28);
            this.btnEliminar.TabIndex = 41;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(35, 27);
            this.btnCrear.Margin = new System.Windows.Forms.Padding(2);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(56, 28);
            this.btnCrear.TabIndex = 39;
            this.btnCrear.Text = "Guardar";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // txtImpuestoVenta
            // 
            this.txtImpuestoVenta.Location = new System.Drawing.Point(847, 235);
            this.txtImpuestoVenta.Margin = new System.Windows.Forms.Padding(2);
            this.txtImpuestoVenta.Name = "txtImpuestoVenta";
            this.txtImpuestoVenta.Size = new System.Drawing.Size(160, 20);
            this.txtImpuestoVenta.TabIndex = 88;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(847, 201);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(2);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(160, 20);
            this.txtDireccion.TabIndex = 87;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(741, 201);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 86;
            this.label3.Text = "Direccion";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(741, 181);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 13);
            this.label8.TabIndex = 84;
            this.label8.Text = "Numero Telefonico";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(847, 154);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(160, 20);
            this.txtNombre.TabIndex = 83;
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(741, 154);
            this.Nombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(44, 13);
            this.Nombre.TabIndex = 82;
            this.Nombre.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(741, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 80;
            this.label2.Text = "Cedula Juridica";
            // 
            // lblImpuestoVenta
            // 
            this.lblImpuestoVenta.AutoSize = true;
            this.lblImpuestoVenta.Location = new System.Drawing.Point(741, 235);
            this.lblImpuestoVenta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblImpuestoVenta.Name = "lblImpuestoVenta";
            this.lblImpuestoVenta.Size = new System.Drawing.Size(96, 13);
            this.lblImpuestoVenta.TabIndex = 89;
            this.lblImpuestoVenta.Text = "Impuesto de Venta";
            this.lblImpuestoVenta.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtCedulaJuridica
            // 
            this.txtCedulaJuridica.Location = new System.Drawing.Point(847, 125);
            this.txtCedulaJuridica.Margin = new System.Windows.Forms.Padding(2);
            this.txtCedulaJuridica.Name = "txtCedulaJuridica";
            this.txtCedulaJuridica.Size = new System.Drawing.Size(160, 20);
            this.txtCedulaJuridica.TabIndex = 90;
            // 
            // txtNumeroTelefonico
            // 
            this.txtNumeroTelefonico.Location = new System.Drawing.Point(847, 178);
            this.txtNumeroTelefonico.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumeroTelefonico.Name = "txtNumeroTelefonico";
            this.txtNumeroTelefonico.Size = new System.Drawing.Size(160, 20);
            this.txtNumeroTelefonico.TabIndex = 91;
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cedulaJuridica,
            this.dataGridViewTextBoxColumn1,
            this.Telefono,
            this.Direccion,
            this.ImpuestoVenta});
            this.dgvDatos.Location = new System.Drawing.Point(36, 84);
            this.dgvDatos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.RowHeadersWidth = 51;
            this.dgvDatos.RowTemplate.Height = 24;
            this.dgvDatos.Size = new System.Drawing.Size(654, 298);
            this.dgvDatos.TabIndex = 92;
            // 
            // cedulaJuridica
            // 
            this.cedulaJuridica.DataPropertyName = "CedulaJuridica";
            this.cedulaJuridica.HeaderText = "Cedula Juridica";
            this.cedulaJuridica.MinimumWidth = 6;
            this.cedulaJuridica.Name = "cedulaJuridica";
            this.cedulaJuridica.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // Telefono
            // 
            this.Telefono.DataPropertyName = "Telefono";
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.MinimumWidth = 6;
            this.Telefono.Name = "Telefono";
            this.Telefono.Width = 125;
            // 
            // Direccion
            // 
            this.Direccion.DataPropertyName = "Direccion";
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.MinimumWidth = 6;
            this.Direccion.Name = "Direccion";
            this.Direccion.Width = 125;
            // 
            // ImpuestoVenta
            // 
            this.ImpuestoVenta.DataPropertyName = "ImpuestoVenta";
            this.ImpuestoVenta.HeaderText = "Impuesto de Venta";
            this.ImpuestoVenta.Name = "ImpuestoVenta";
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(100, 27);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(56, 28);
            this.btnEditar.TabIndex = 93;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(220, 27);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(63, 28);
            this.btnCancelar.TabIndex = 94;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // MantenimientoTienda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 664);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.txtNumeroTelefonico);
            this.Controls.Add(this.txtCedulaJuridica);
            this.Controls.Add(this.lblImpuestoVenta);
            this.Controls.Add(this.txtImpuestoVenta);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnCrear);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MantenimientoTienda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MantenimientoTienda";
            this.Load += new System.EventHandler(this.MantenimientoTienda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.TextBox txtImpuestoVenta;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label lblImpuestoVenta;
        private System.Windows.Forms.TextBox txtCedulaJuridica;
        private System.Windows.Forms.TextBox txtNumeroTelefonico;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedulaJuridica;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImpuestoVenta;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCancelar;
    }
}