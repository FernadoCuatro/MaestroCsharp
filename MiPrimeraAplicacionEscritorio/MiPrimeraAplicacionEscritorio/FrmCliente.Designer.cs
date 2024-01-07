namespace MiPrimeraAplicacionEscritorio
{
 partial class frmCliente
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
   this.dgvCliente = new System.Windows.Forms.DataGridView();
   this.label1 = new System.Windows.Forms.Label();
   this.txtBuscar = new System.Windows.Forms.TextBox();
   ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
   this.SuspendLayout();
   // 
   // dgvCliente
   // 
   this.dgvCliente.AllowUserToResizeColumns = false;
   this.dgvCliente.AllowUserToResizeRows = false;
   this.dgvCliente.BackgroundColor = System.Drawing.SystemColors.Control;
   this.dgvCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
   this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
   this.dgvCliente.Location = new System.Drawing.Point(48, 75);
   this.dgvCliente.Name = "dgvCliente";
   this.dgvCliente.ReadOnly = true;
   this.dgvCliente.RowHeadersVisible = false;
   this.dgvCliente.Size = new System.Drawing.Size(421, 150);
   this.dgvCliente.TabIndex = 0;
   this.dgvCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCliente_CellContentClick);
   // 
   // label1
   // 
   this.label1.AutoSize = true;
   this.label1.Location = new System.Drawing.Point(72, 40);
   this.label1.Name = "label1";
   this.label1.Size = new System.Drawing.Size(132, 13);
   this.label1.TabIndex = 1;
   this.label1.Text = "Ingrese nombre completo: ";
   // 
   // txtBuscar
   // 
   this.txtBuscar.Location = new System.Drawing.Point(219, 37);
   this.txtBuscar.Name = "txtBuscar";
   this.txtBuscar.Size = new System.Drawing.Size(215, 20);
   this.txtBuscar.TabIndex = 2;
   this.txtBuscar.TextChanged += new System.EventHandler(this.filtrar);
   // 
   // frmCliente
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.ClientSize = new System.Drawing.Size(507, 261);
   this.Controls.Add(this.txtBuscar);
   this.Controls.Add(this.label1);
   this.Controls.Add(this.dgvCliente);
   this.Name = "frmCliente";
   this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
   this.Text = "Form3";
   this.Load += new System.EventHandler(this.Form3_Load);
   ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
   this.ResumeLayout(false);
   this.PerformLayout();

  }

  #endregion

  private System.Windows.Forms.DataGridView dgvCliente;
  private System.Windows.Forms.Label label1;
  private System.Windows.Forms.TextBox txtBuscar;
 }
}