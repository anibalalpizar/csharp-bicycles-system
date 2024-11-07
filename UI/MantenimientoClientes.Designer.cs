namespace ProyectoProgramadolll.UI
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbDistrito = new System.Windows.Forms.ComboBox();
            this.cmbCanton = new System.Windows.Forms.ComboBox();
            this.cmbProvincia = new System.Windows.Forms.ComboBox();
            this.txtCorreoElectronico = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rdbMasculino = new System.Windows.Forms.RadioButton();
            this.rbnFemenimo = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtIdCliente = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column11});
            this.dataGridView1.Location = new System.Drawing.Point(19, 70);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(909, 367);
            this.dataGridView1.TabIndex = 18;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Numero Telefonico";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Correo Electronico";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Provincia";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 125;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Cantidad de Bicicletas";
            this.Column11.MinimumWidth = 6;
            this.Column11.Name = "Column11";
            this.Column11.Width = 125;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(109, 12);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 34);
            this.btnModificar.TabIndex = 36;
            this.btnModificar.Text = "Modficar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(191, 12);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 34);
            this.btnEliminar.TabIndex = 35;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(24, 12);
            this.btnCrear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 34);
            this.btnCrear.TabIndex = 33;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(199, 130);
            this.maskedTextBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maskedTextBox2.Mask = "0000-0000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(109, 22);
            this.maskedTextBox2.TabIndex = 75;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(57, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 16);
            this.label8.TabIndex = 74;
            this.label8.Text = "Numero Telefonico";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 16);
            this.label6.TabIndex = 73;
            this.label6.Text = "Distrito";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 72;
            this.label5.Text = "Canton";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 71;
            this.label4.Text = "Provincia";
            // 
            // cmbDistrito
            // 
            this.cmbDistrito.FormattingEnabled = true;
            this.cmbDistrito.Location = new System.Drawing.Point(197, 260);
            this.cmbDistrito.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbDistrito.Name = "cmbDistrito";
            this.cmbDistrito.Size = new System.Drawing.Size(121, 24);
            this.cmbDistrito.TabIndex = 70;
            // 
            // cmbCanton
            // 
            this.cmbCanton.FormattingEnabled = true;
            this.cmbCanton.Location = new System.Drawing.Point(197, 230);
            this.cmbCanton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCanton.Name = "cmbCanton";
            this.cmbCanton.Size = new System.Drawing.Size(121, 24);
            this.cmbCanton.TabIndex = 69;
            // 
            // cmbProvincia
            // 
            this.cmbProvincia.FormattingEnabled = true;
            this.cmbProvincia.Location = new System.Drawing.Point(197, 199);
            this.cmbProvincia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbProvincia.Name = "cmbProvincia";
            this.cmbProvincia.Size = new System.Drawing.Size(121, 24);
            this.cmbProvincia.TabIndex = 68;
            // 
            // txtCorreoElectronico
            // 
            this.txtCorreoElectronico.Location = new System.Drawing.Point(197, 161);
            this.txtCorreoElectronico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCorreoElectronico.Name = "txtCorreoElectronico";
            this.txtCorreoElectronico.Size = new System.Drawing.Size(212, 22);
            this.txtCorreoElectronico.TabIndex = 67;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 16);
            this.label3.TabIndex = 66;
            this.label3.Text = "Correo Electronico";
            // 
            // rdbMasculino
            // 
            this.rdbMasculino.AutoSize = true;
            this.rdbMasculino.Location = new System.Drawing.Point(305, 95);
            this.rdbMasculino.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbMasculino.Name = "rdbMasculino";
            this.rdbMasculino.Size = new System.Drawing.Size(89, 20);
            this.rdbMasculino.TabIndex = 65;
            this.rdbMasculino.TabStop = true;
            this.rdbMasculino.Text = "Masculino";
            this.rdbMasculino.UseVisualStyleBackColor = true;
            // 
            // rbnFemenimo
            // 
            this.rbnFemenimo.AutoSize = true;
            this.rbnFemenimo.Location = new System.Drawing.Point(197, 95);
            this.rbnFemenimo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbnFemenimo.Name = "rbnFemenimo";
            this.rbnFemenimo.Size = new System.Drawing.Size(92, 20);
            this.rbnFemenimo.TabIndex = 64;
            this.rbnFemenimo.TabStop = true;
            this.rbnFemenimo.Text = "Femenima";
            this.rbnFemenimo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 63;
            this.label1.Text = "Sexo";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(351, 250);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 42);
            this.btnGuardar.TabIndex = 62;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(191, 60);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(212, 22);
            this.txtNombre.TabIndex = 61;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(328, 28);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 60;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Location = new System.Drawing.Point(191, 30);
            this.txtIdCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdCliente.Mask = "0-0000-0000";
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(109, 22);
            this.txtIdCliente.TabIndex = 59;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 16);
            this.label2.TabIndex = 58;
            this.label2.Text = "Ingrese su Cedula";
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(49, 60);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(56, 16);
            this.Nombre.TabIndex = 57;
            this.Nombre.Text = "Nombre";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.maskedTextBox2);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cmbDistrito);
            this.panel1.Controls.Add(this.cmbCanton);
            this.panel1.Controls.Add(this.cmbProvincia);
            this.panel1.Controls.Add(this.txtCorreoElectronico);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.rdbMasculino);
            this.panel1.Controls.Add(this.rbnFemenimo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.txtIdCliente);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Nombre);
            this.panel1.Location = new System.Drawing.Point(951, 70);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(445, 366);
            this.panel1.TabIndex = 76;
            // 
            // MantenimientoClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1429, 501);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MantenimientoClientes";
            this.Text = "MantenimientoClientes";
            this.Load += new System.EventHandler(this.MantenimientoClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbDistrito;
        private System.Windows.Forms.ComboBox cmbCanton;
        private System.Windows.Forms.ComboBox cmbProvincia;
        private System.Windows.Forms.TextBox txtCorreoElectronico;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdbMasculino;
        private System.Windows.Forms.RadioButton rbnFemenimo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.MaskedTextBox txtIdCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Panel panel1;
    }
}