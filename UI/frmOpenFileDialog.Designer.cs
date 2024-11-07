namespace Controles
{
    partial class frmOpenFileDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOpenFileDialog));
            this.ofdDialogo = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.ptbImagen = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.rtbTexto = new System.Windows.Forms.RichTextBox();
            this.btnEjecutar = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnSalir = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImagen)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.Location = new System.Drawing.Point(3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(566, 276);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnSeleccionar);
            this.tabPage1.Controls.Add(this.ptbImagen);
            this.tabPage1.ImageIndex = 0;
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(558, 233);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Imagen";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionar.Location = new System.Drawing.Point(423, 169);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(124, 47);
            this.btnSeleccionar.TabIndex = 1;
            this.btnSeleccionar.Text = "&Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // ptbImagen
            // 
            this.ptbImagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptbImagen.Location = new System.Drawing.Point(18, 17);
            this.ptbImagen.Name = "ptbImagen";
            this.ptbImagen.Size = new System.Drawing.Size(366, 199);
            this.ptbImagen.TabIndex = 0;
            this.ptbImagen.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.rtbTexto);
            this.tabPage2.Controls.Add(this.btnEjecutar);
            this.tabPage2.ImageIndex = 1;
            this.tabPage2.Location = new System.Drawing.Point(4, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(558, 233);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Abrir Archivo";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // rtbTexto
            // 
            this.rtbTexto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbTexto.Location = new System.Drawing.Point(7, 20);
            this.rtbTexto.Name = "rtbTexto";
            this.rtbTexto.Size = new System.Drawing.Size(410, 207);
            this.rtbTexto.TabIndex = 1;
            this.rtbTexto.Text = "";
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.Location = new System.Drawing.Point(426, 184);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(124, 43);
            this.btnEjecutar.TabIndex = 0;
            this.btnEjecutar.Text = "&Abrir";
            this.btnEjecutar.UseVisualStyleBackColor = true;
            this.btnEjecutar.Click += new System.EventHandler(this.btnEjecutar_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "delicious.png");
            this.imageList1.Images.SetKeyName(1, "illustration.png");
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(432, 284);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(125, 47);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmOpenFileDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 338);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmOpenFileDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OpenFileDialog";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbImagen)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofdDialogo;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.PictureBox ptbImagen;
        private System.Windows.Forms.Button btnEjecutar;
        private System.Windows.Forms.RichTextBox rtbTexto;
        private System.Windows.Forms.ImageList imageList1;
    }
}