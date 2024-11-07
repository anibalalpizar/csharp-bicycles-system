namespace ProyectoProgramadolll.UI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mantenimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoProductoServicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoVendedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoBicicletaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoTiendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderDeTrabajoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientosToolStripMenuItem,
            this.procesosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(2366, 55);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mantenimientosToolStripMenuItem
            // 
            this.mantenimientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoClienteToolStripMenuItem,
            this.mantenimientoProductoServicioToolStripMenuItem,
            this.mantenimientoVendedorToolStripMenuItem,
            this.mantenimientoBicicletaToolStripMenuItem,
            this.mantenimientoTiendaToolStripMenuItem});
            this.mantenimientosToolStripMenuItem.Name = "mantenimientosToolStripMenuItem";
            this.mantenimientosToolStripMenuItem.Size = new System.Drawing.Size(130, 24);
            this.mantenimientosToolStripMenuItem.Text = "Mantenimientos";
            // 
            // mantenimientoClienteToolStripMenuItem
            // 
            this.mantenimientoClienteToolStripMenuItem.Name = "mantenimientoClienteToolStripMenuItem";
            this.mantenimientoClienteToolStripMenuItem.Size = new System.Drawing.Size(323, 26);
            this.mantenimientoClienteToolStripMenuItem.Text = "Mantenimiento Cliente";
            this.mantenimientoClienteToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoClienteToolStripMenuItem_Click);
            // 
            // mantenimientoProductoServicioToolStripMenuItem
            // 
            this.mantenimientoProductoServicioToolStripMenuItem.Name = "mantenimientoProductoServicioToolStripMenuItem";
            this.mantenimientoProductoServicioToolStripMenuItem.Size = new System.Drawing.Size(323, 26);
            this.mantenimientoProductoServicioToolStripMenuItem.Text = "Mantenimiento Producto / Servicio";
            this.mantenimientoProductoServicioToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoProductoServicioToolStripMenuItem_Click);
            // 
            // mantenimientoVendedorToolStripMenuItem
            // 
            this.mantenimientoVendedorToolStripMenuItem.Name = "mantenimientoVendedorToolStripMenuItem";
            this.mantenimientoVendedorToolStripMenuItem.Size = new System.Drawing.Size(323, 26);
            this.mantenimientoVendedorToolStripMenuItem.Text = "Mantenimiento Vendedor";
            this.mantenimientoVendedorToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoVendedorToolStripMenuItem_Click);
            // 
            // mantenimientoBicicletaToolStripMenuItem
            // 
            this.mantenimientoBicicletaToolStripMenuItem.Name = "mantenimientoBicicletaToolStripMenuItem";
            this.mantenimientoBicicletaToolStripMenuItem.Size = new System.Drawing.Size(323, 26);
            this.mantenimientoBicicletaToolStripMenuItem.Text = "Mantenimiento Bicicleta";
            this.mantenimientoBicicletaToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoBicicletaToolStripMenuItem_Click);
            // 
            // mantenimientoTiendaToolStripMenuItem
            // 
            this.mantenimientoTiendaToolStripMenuItem.Name = "mantenimientoTiendaToolStripMenuItem";
            this.mantenimientoTiendaToolStripMenuItem.Size = new System.Drawing.Size(323, 26);
            this.mantenimientoTiendaToolStripMenuItem.Text = "Mantenimiento Tienda";
            this.mantenimientoTiendaToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoTiendaToolStripMenuItem_Click);
            // 
            // procesosToolStripMenuItem
            // 
            this.procesosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.orderDeTrabajoToolStripMenuItem,
            this.facturacionToolStripMenuItem});
            this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            this.procesosToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.procesosToolStripMenuItem.Text = "Procesos";
            // 
            // orderDeTrabajoToolStripMenuItem
            // 
            this.orderDeTrabajoToolStripMenuItem.Name = "orderDeTrabajoToolStripMenuItem";
            this.orderDeTrabajoToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.orderDeTrabajoToolStripMenuItem.Text = "Order de Trabajo";
            this.orderDeTrabajoToolStripMenuItem.Click += new System.EventHandler(this.orderDeTrabajoToolStripMenuItem_Click);
            // 
            // facturacionToolStripMenuItem
            // 
            this.facturacionToolStripMenuItem.Name = "facturacionToolStripMenuItem";
            this.facturacionToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.facturacionToolStripMenuItem.Text = "Facturacion";
            this.facturacionToolStripMenuItem.Click += new System.EventHandler(this.facturacionToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "cicloRuso.png");
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoProgramadolll.Properties.Resources.cicloRuso;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1435, 1097);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Ciclo Ruso";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mantenimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoProductoServicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoVendedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoBicicletaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoTiendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderDeTrabajoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturacionToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ImageList imageList1;
    }
}