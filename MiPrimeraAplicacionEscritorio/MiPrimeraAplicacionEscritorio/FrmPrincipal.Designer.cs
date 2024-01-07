namespace MiPrimeraAplicacionEscritorio
{
 partial class frmPrincipal
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
   System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
   this.menuStrip1 = new System.Windows.Forms.MenuStrip();
   this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
   this.itemMarca = new System.Windows.Forms.ToolStripMenuItem();
   this.itemEmpleado = new System.Windows.Forms.ToolStripMenuItem();
   this.itemCliente = new System.Windows.Forms.ToolStripMenuItem();
   this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
   this.pictureBox1 = new System.Windows.Forms.PictureBox();
   this.tipoDeUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
   this.busToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
   this.viajeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
   this.menuStrip1.SuspendLayout();
   ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
   this.SuspendLayout();
   // 
   // menuStrip1
   // 
   this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoToolStripMenuItem,
            this.consultasToolStripMenuItem});
   this.menuStrip1.Location = new System.Drawing.Point(0, 0);
   this.menuStrip1.Name = "menuStrip1";
   this.menuStrip1.Size = new System.Drawing.Size(284, 24);
   this.menuStrip1.TabIndex = 0;
   this.menuStrip1.Text = "menuStrip1";
   // 
   // mantenimientoToolStripMenuItem
   // 
   this.mantenimientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemMarca,
            this.itemEmpleado,
            this.itemCliente,
            this.tipoDeUsuarioToolStripMenuItem,
            this.busToolStripMenuItem,
            this.viajeToolStripMenuItem});
   this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
   this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
   this.mantenimientoToolStripMenuItem.Text = "Mantenimiento";
   // 
   // itemMarca
   // 
   this.itemMarca.Name = "itemMarca";
   this.itemMarca.Size = new System.Drawing.Size(156, 22);
   this.itemMarca.Text = "Marca";
   this.itemMarca.Click += new System.EventHandler(this.itemMarca_Click);
   // 
   // itemEmpleado
   // 
   this.itemEmpleado.Name = "itemEmpleado";
   this.itemEmpleado.Size = new System.Drawing.Size(156, 22);
   this.itemEmpleado.Text = "Empleado";
   this.itemEmpleado.Click += new System.EventHandler(this.itemEmpleado_Click);
   // 
   // itemCliente
   // 
   this.itemCliente.Name = "itemCliente";
   this.itemCliente.Size = new System.Drawing.Size(156, 22);
   this.itemCliente.Text = "Cliente";
   this.itemCliente.Click += new System.EventHandler(this.itemCliente_Click);
   // 
   // consultasToolStripMenuItem
   // 
   this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
   this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
   this.consultasToolStripMenuItem.Text = "Consultas";
   // 
   // pictureBox1
   // 
   this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
   this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
   this.pictureBox1.Location = new System.Drawing.Point(12, 38);
   this.pictureBox1.Name = "pictureBox1";
   this.pictureBox1.Size = new System.Drawing.Size(260, 195);
   this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
   this.pictureBox1.TabIndex = 1;
   this.pictureBox1.TabStop = false;
   // 
   // tipoDeUsuarioToolStripMenuItem
   // 
   this.tipoDeUsuarioToolStripMenuItem.Name = "tipoDeUsuarioToolStripMenuItem";
   this.tipoDeUsuarioToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
   this.tipoDeUsuarioToolStripMenuItem.Text = "Tipo de usuario";
   this.tipoDeUsuarioToolStripMenuItem.Click += new System.EventHandler(this.tipoDeUsuarioToolStripMenuItem_Click);
   // 
   // busToolStripMenuItem
   // 
   this.busToolStripMenuItem.Name = "busToolStripMenuItem";
   this.busToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
   this.busToolStripMenuItem.Text = "Bus";
   this.busToolStripMenuItem.Click += new System.EventHandler(this.busToolStripMenuItem_Click);
   // 
   // viajeToolStripMenuItem
   // 
   this.viajeToolStripMenuItem.Name = "viajeToolStripMenuItem";
   this.viajeToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
   this.viajeToolStripMenuItem.Text = "Viaje";
   this.viajeToolStripMenuItem.Click += new System.EventHandler(this.viajeToolStripMenuItem_Click);
   // 
   // frmPrincipal
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
   this.ClientSize = new System.Drawing.Size(284, 261);
   this.Controls.Add(this.pictureBox1);
   this.Controls.Add(this.menuStrip1);
   this.MainMenuStrip = this.menuStrip1;
   this.MaximizeBox = false;
   this.MinimizeBox = false;
   this.Name = "frmPrincipal";
   this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
   this.Text = "Principal";
   this.menuStrip1.ResumeLayout(false);
   this.menuStrip1.PerformLayout();
   ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
   this.ResumeLayout(false);
   this.PerformLayout();

  }

  #endregion

  private System.Windows.Forms.MenuStrip menuStrip1;
  private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
  private System.Windows.Forms.ToolStripMenuItem itemMarca;
  private System.Windows.Forms.ToolStripMenuItem itemEmpleado;
  private System.Windows.Forms.ToolStripMenuItem itemCliente;
  private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
  private System.Windows.Forms.PictureBox pictureBox1;
  private System.Windows.Forms.ToolStripMenuItem tipoDeUsuarioToolStripMenuItem;
  private System.Windows.Forms.ToolStripMenuItem busToolStripMenuItem;
  private System.Windows.Forms.ToolStripMenuItem viajeToolStripMenuItem;
 }
}