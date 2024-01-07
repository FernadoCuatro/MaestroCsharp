namespace ClaseDGVDataTable
{
 partial class Form1
 {
  /// <summary>
  /// Variable del diseñador necesaria.
  /// </summary>
  private System.ComponentModel.IContainer components = null;

  /// <summary>
  /// Limpiar los recursos que se estén usando.
  /// </summary>
  /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
  protected override void Dispose(bool disposing)
  {
   if (disposing && (components != null))
   {
    components.Dispose();
   }
   base.Dispose(disposing);
  }

  #region Código generado por el Diseñador de Windows Forms

  /// <summary>
  /// Método necesario para admitir el Diseñador. No se puede modificar
  /// el contenido de este método con el editor de código.
  /// </summary>
  private void InitializeComponent()
  {
   this.dgvPersonas = new System.Windows.Forms.DataGridView();
   ((System.ComponentModel.ISupportInitialize)(this.dgvPersonas)).BeginInit();
   this.SuspendLayout();
   // 
   // dgvPersonas
   // 
   this.dgvPersonas.AllowUserToAddRows = false;
   this.dgvPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
   this.dgvPersonas.Location = new System.Drawing.Point(12, 77);
   this.dgvPersonas.Name = "dgvPersonas";
   this.dgvPersonas.ReadOnly = true;
   this.dgvPersonas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
   this.dgvPersonas.Size = new System.Drawing.Size(462, 150);
   this.dgvPersonas.TabIndex = 0;
   // 
   // Form1
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.ClientSize = new System.Drawing.Size(486, 261);
   this.Controls.Add(this.dgvPersonas);
   this.Name = "Form1";
   this.Text = "Form1";
   this.Load += new System.EventHandler(this.Form1_Load);
   ((System.ComponentModel.ISupportInitialize)(this.dgvPersonas)).EndInit();
   this.ResumeLayout(false);

  }

  #endregion

  private System.Windows.Forms.DataGridView dgvPersonas;
 }
}

