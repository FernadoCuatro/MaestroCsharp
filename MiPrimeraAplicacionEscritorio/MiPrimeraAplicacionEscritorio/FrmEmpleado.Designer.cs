namespace MiPrimeraAplicacionEscritorio
{
 partial class frmEmpleado
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
   this.dgvDatos = new System.Windows.Forms.DataGridView();
   this.label1 = new System.Windows.Forms.Label();
   this.txtNombreCompleto = new System.Windows.Forms.TextBox();
   this.btnBuscar = new System.Windows.Forms.Button();
   this.btnLimpiar = new System.Windows.Forms.Button();
   ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
   this.SuspendLayout();
   // 
   // dgvDatos
   // 
   this.dgvDatos.AllowUserToResizeColumns = false;
   this.dgvDatos.AllowUserToResizeRows = false;
   this.dgvDatos.BackgroundColor = System.Drawing.SystemColors.Control;
   this.dgvDatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
   this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
   this.dgvDatos.Location = new System.Drawing.Point(70, 62);
   this.dgvDatos.Name = "dgvDatos";
   this.dgvDatos.ReadOnly = true;
   this.dgvDatos.RowHeadersVisible = false;
   this.dgvDatos.Size = new System.Drawing.Size(483, 177);
   this.dgvDatos.TabIndex = 0;
   // 
   // label1
   // 
   this.label1.AutoSize = true;
   this.label1.Location = new System.Drawing.Point(13, 28);
   this.label1.Name = "label1";
   this.label1.Size = new System.Drawing.Size(132, 13);
   this.label1.TabIndex = 1;
   this.label1.Text = "Ingrese nombre completo: ";
   // 
   // txtNombreCompleto
   // 
   this.txtNombreCompleto.Location = new System.Drawing.Point(142, 25);
   this.txtNombreCompleto.Name = "txtNombreCompleto";
   this.txtNombreCompleto.Size = new System.Drawing.Size(264, 20);
   this.txtNombreCompleto.TabIndex = 2;
   // 
   // btnBuscar
   // 
   this.btnBuscar.Location = new System.Drawing.Point(421, 23);
   this.btnBuscar.Name = "btnBuscar";
   this.btnBuscar.Size = new System.Drawing.Size(75, 23);
   this.btnBuscar.TabIndex = 3;
   this.btnBuscar.Text = "Buscar";
   this.btnBuscar.UseVisualStyleBackColor = true;
   this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
   // 
   // btnLimpiar
   // 
   this.btnLimpiar.Location = new System.Drawing.Point(502, 23);
   this.btnLimpiar.Name = "btnLimpiar";
   this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
   this.btnLimpiar.TabIndex = 4;
   this.btnLimpiar.Text = "Limpiar";
   this.btnLimpiar.UseVisualStyleBackColor = true;
   this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
   // 
   // frmEmpleado
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.ClientSize = new System.Drawing.Size(603, 261);
   this.Controls.Add(this.btnLimpiar);
   this.Controls.Add(this.btnBuscar);
   this.Controls.Add(this.txtNombreCompleto);
   this.Controls.Add(this.label1);
   this.Controls.Add(this.dgvDatos);
   this.Name = "frmEmpleado";
   this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
   this.Text = "Form2";
   this.Load += new System.EventHandler(this.Form2_Load);
   ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
   this.ResumeLayout(false);
   this.PerformLayout();

  }

  #endregion

  private System.Windows.Forms.DataGridView dgvDatos;
  private System.Windows.Forms.Label label1;
  private System.Windows.Forms.TextBox txtNombreCompleto;
  private System.Windows.Forms.Button btnBuscar;
  private System.Windows.Forms.Button btnLimpiar;
 }
}