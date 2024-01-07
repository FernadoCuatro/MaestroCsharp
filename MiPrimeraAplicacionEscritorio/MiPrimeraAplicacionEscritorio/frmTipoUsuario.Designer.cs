namespace MiPrimeraAplicacionEscritorio
{
 partial class frmTipoUsuario
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
   this.dgvUsuarios = new System.Windows.Forms.DataGridView();
   this.label1 = new System.Windows.Forms.Label();
   this.txtNombreTipoUsuario = new System.Windows.Forms.TextBox();
   ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
   this.SuspendLayout();
   // 
   // dgvUsuarios
   // 
   this.dgvUsuarios.AllowUserToAddRows = false;
   this.dgvUsuarios.BackgroundColor = System.Drawing.SystemColors.Control;
   this.dgvUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
   this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
   this.dgvUsuarios.Location = new System.Drawing.Point(79, 68);
   this.dgvUsuarios.Name = "dgvUsuarios";
   this.dgvUsuarios.ReadOnly = true;
   this.dgvUsuarios.RowHeadersVisible = false;
   this.dgvUsuarios.Size = new System.Drawing.Size(307, 245);
   this.dgvUsuarios.TabIndex = 0;
   // 
   // label1
   // 
   this.label1.AutoSize = true;
   this.label1.Location = new System.Drawing.Point(38, 34);
   this.label1.Name = "label1";
   this.label1.Size = new System.Drawing.Size(175, 13);
   this.label1.TabIndex = 1;
   this.label1.Text = "Ingrese nombre del tipo de usuario: ";
   // 
   // txtNombreTipoUsuario
   // 
   this.txtNombreTipoUsuario.Location = new System.Drawing.Point(219, 31);
   this.txtNombreTipoUsuario.Name = "txtNombreTipoUsuario";
   this.txtNombreTipoUsuario.Size = new System.Drawing.Size(207, 20);
   this.txtNombreTipoUsuario.TabIndex = 2;
   this.txtNombreTipoUsuario.TextChanged += new System.EventHandler(this.filtrar);
   // 
   // frmTipoUsuario
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.ClientSize = new System.Drawing.Size(459, 349);
   this.Controls.Add(this.txtNombreTipoUsuario);
   this.Controls.Add(this.label1);
   this.Controls.Add(this.dgvUsuarios);
   this.Name = "frmTipoUsuario";
   this.Text = "frmTipoUsuario";
   this.Load += new System.EventHandler(this.frmTipoUsuario_Load);
   ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
   this.ResumeLayout(false);
   this.PerformLayout();

  }

  #endregion

  private System.Windows.Forms.DataGridView dgvUsuarios;
  private System.Windows.Forms.Label label1;
  private System.Windows.Forms.TextBox txtNombreTipoUsuario;
 }
}