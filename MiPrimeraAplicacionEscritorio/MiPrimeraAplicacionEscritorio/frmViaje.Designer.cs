namespace MiPrimeraAplicacionEscritorio
{
 partial class frmViaje
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
   this.dgbViajes = new System.Windows.Forms.DataGridView();
   ((System.ComponentModel.ISupportInitialize)(this.dgbViajes)).BeginInit();
   this.SuspendLayout();
   // 
   // dgbViajes
   // 
   this.dgbViajes.AllowUserToAddRows = false;
   this.dgbViajes.AllowUserToResizeColumns = false;
   this.dgbViajes.AllowUserToResizeRows = false;
   this.dgbViajes.BackgroundColor = System.Drawing.SystemColors.Control;
   this.dgbViajes.BorderStyle = System.Windows.Forms.BorderStyle.None;
   this.dgbViajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
   this.dgbViajes.Location = new System.Drawing.Point(12, 22);
   this.dgbViajes.Name = "dgbViajes";
   this.dgbViajes.ReadOnly = true;
   this.dgbViajes.RowHeadersVisible = false;
   this.dgbViajes.Size = new System.Drawing.Size(506, 150);
   this.dgbViajes.TabIndex = 0;
   // 
   // frmViaje
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.ClientSize = new System.Drawing.Size(530, 191);
   this.Controls.Add(this.dgbViajes);
   this.Name = "frmViaje";
   this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
   this.Text = "frmViaje";
   this.Load += new System.EventHandler(this.frmViaje_Load);
   ((System.ComponentModel.ISupportInitialize)(this.dgbViajes)).EndInit();
   this.ResumeLayout(false);

  }

  #endregion

  private System.Windows.Forms.DataGridView dgbViajes;
 }
}