namespace ProyectoProgramadolll.UI
{
    partial class Vendedor
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
            this.txtSegundoApellido = new System.Windows.Forms.TextBox();
            this.lbl2ndApellido = new System.Windows.Forms.Label();
            this.Apellido = new System.Windows.Forms.Label();
            this.btnSegundoApellido = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.ptbFotoVendedor = new System.Windows.Forms.PictureBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.ofdDialogo = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFotoVendedor)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSegundoApellido
            // 
            this.txtSegundoApellido.Location = new System.Drawing.Point(160, 109);
            this.txtSegundoApellido.Name = "txtSegundoApellido";
            this.txtSegundoApellido.Size = new System.Drawing.Size(212, 22);
            this.txtSegundoApellido.TabIndex = 64;
            this.txtSegundoApellido.Visible = false;
            // 
            // lbl2ndApellido
            // 
            this.lbl2ndApellido.AutoSize = true;
            this.lbl2ndApellido.Location = new System.Drawing.Point(19, 109);
            this.lbl2ndApellido.Name = "lbl2ndApellido";
            this.lbl2ndApellido.Size = new System.Drawing.Size(115, 16);
            this.lbl2ndApellido.TabIndex = 63;
            this.lbl2ndApellido.Text = "Segundo Apellido";
            this.lbl2ndApellido.Visible = false;
            // 
            // Apellido
            // 
            this.Apellido.AutoSize = true;
            this.Apellido.Location = new System.Drawing.Point(19, 78);
            this.Apellido.Name = "Apellido";
            this.Apellido.Size = new System.Drawing.Size(57, 16);
            this.Apellido.TabIndex = 62;
            this.Apellido.Text = "Apellido";
            // 
            // btnSegundoApellido
            // 
            this.btnSegundoApellido.Location = new System.Drawing.Point(378, 78);
            this.btnSegundoApellido.Name = "btnSegundoApellido";
            this.btnSegundoApellido.Size = new System.Drawing.Size(152, 30);
            this.btnSegundoApellido.TabIndex = 61;
            this.btnSegundoApellido.Text = "Agregar 2nd Apellido";
            this.btnSegundoApellido.UseVisualStyleBackColor = true;
            this.btnSegundoApellido.Click += new System.EventHandler(this.btnSegundoApellido_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(160, 78);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(212, 22);
            this.textBox2.TabIndex = 60;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(160, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(212, 22);
            this.textBox1.TabIndex = 59;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(297, 17);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 58;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(160, 18);
            this.maskedTextBox1.Mask = "0-0000-000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(109, 22);
            this.maskedTextBox1.TabIndex = 57;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 16);
            this.label2.TabIndex = 56;
            this.label2.Text = "Ingrese su Cedula";
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(19, 49);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(56, 16);
            this.Nombre.TabIndex = 55;
            this.Nombre.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 16);
            this.label1.TabIndex = 69;
            this.label1.Text = "Fecha de Nacimiento";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(161, 144);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(224, 22);
            this.dateTimePicker2.TabIndex = 68;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ptbFotoVendedor);
            this.groupBox1.Location = new System.Drawing.Point(26, 233);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 225);
            this.groupBox1.TabIndex = 70;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Foto del Vendedor";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(472, 410);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 42);
            this.btnGuardar.TabIndex = 71;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // ptbFotoVendedor
            // 
            this.ptbFotoVendedor.Location = new System.Drawing.Point(14, 24);
            this.ptbFotoVendedor.Name = "ptbFotoVendedor";
            this.ptbFotoVendedor.Size = new System.Drawing.Size(229, 195);
            this.ptbFotoVendedor.TabIndex = 0;
            this.ptbFotoVendedor.TabStop = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(26, 203);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(243, 24);
            this.btnAgregar.TabIndex = 72;
            this.btnAgregar.Text = "Agregar Imagen del Venedor *";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // ofdDialogo
            // 
            this.ofdDialogo.FileName = "openFileDialog1";
            // 
            // Vendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 470);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.txtSegundoApellido);
            this.Controls.Add(this.lbl2ndApellido);
            this.Controls.Add(this.Apellido);
            this.Controls.Add(this.btnSegundoApellido);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nombre);
            this.Name = "Vendedor";
            this.Text = "Vendedor";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbFotoVendedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSegundoApellido;
        private System.Windows.Forms.Label lbl2ndApellido;
        private System.Windows.Forms.Label Apellido;
        private System.Windows.Forms.Button btnSegundoApellido;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.PictureBox ptbFotoVendedor;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.OpenFileDialog ofdDialogo;
    }
}