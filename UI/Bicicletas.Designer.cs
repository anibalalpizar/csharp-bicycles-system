namespace ProyectoProgramadolll.UI
{
    partial class Bicicletas
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
            this.Apellido = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Apellido
            // 
            this.Apellido.AutoSize = true;
            this.Apellido.Location = new System.Drawing.Point(12, 79);
            this.Apellido.Name = "Apellido";
            this.Apellido.Size = new System.Drawing.Size(39, 16);
            this.Apellido.TabIndex = 72;
            this.Apellido.Text = "Color";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(153, 79);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(109, 22);
            this.textBox2.TabIndex = 71;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(153, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(109, 22);
            this.textBox1.TabIndex = 70;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(153, 17);
            this.maskedTextBox1.Mask = "BI-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(109, 22);
            this.maskedTextBox1.TabIndex = 69;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 68;
            this.label2.Text = "Numero de Serie";
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(12, 48);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(56, 20);
            this.Nombre.TabIndex = 67;
            this.Nombre.Text = "Marca";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(15, 135);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(176, 24);
            this.comboBox2.TabIndex = 74;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 16);
            this.label6.TabIndex = 73;
            this.label6.Text = "Cliente/Dueño de la Bicicleta";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(278, 135);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 42);
            this.btnGuardar.TabIndex = 75;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // Bicicletas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 204);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Apellido);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nombre);
            this.Name = "Bicicletas";
            this.Text = "Bicicletas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Apellido;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGuardar;
    }
}