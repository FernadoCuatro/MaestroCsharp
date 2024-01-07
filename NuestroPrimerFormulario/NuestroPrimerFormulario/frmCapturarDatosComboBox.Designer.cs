namespace NuestroPrimerFormulario
{
 partial class frmCapturarDatosComboBox
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
   this.label1 = new System.Windows.Forms.Label();
   this.cboDias = new System.Windows.Forms.ComboBox();
   this.btnMostrar = new System.Windows.Forms.Button();
   this.lblRespuesta = new System.Windows.Forms.Label();
   this.btnLimpiar = new System.Windows.Forms.Button();
   this.SuspendLayout();
   // 
   // label1
   // 
   this.label1.AutoSize = true;
   this.label1.Location = new System.Drawing.Point(60, 37);
   this.label1.Name = "label1";
   this.label1.Size = new System.Drawing.Size(31, 13);
   this.label1.TabIndex = 0;
   this.label1.Text = "Valor";
   // 
   // cboDias
   // 
   this.cboDias.FormattingEnabled = true;
   this.cboDias.Items.AddRange(new object[] {
            "Lunes",
            "Martes",
            "Miercoles",
            "Jueves",
            "Viernes",
            "Sabado",
            "Domingo"});
   this.cboDias.Location = new System.Drawing.Point(120, 29);
   this.cboDias.Name = "cboDias";
   this.cboDias.Size = new System.Drawing.Size(121, 21);
   this.cboDias.TabIndex = 1;
   this.cboDias.Text = "-- Seleccione --";
   // 
   // btnMostrar
   // 
   this.btnMostrar.Location = new System.Drawing.Point(63, 72);
   this.btnMostrar.Name = "btnMostrar";
   this.btnMostrar.Size = new System.Drawing.Size(75, 23);
   this.btnMostrar.TabIndex = 2;
   this.btnMostrar.Text = "Mostrar";
   this.btnMostrar.UseVisualStyleBackColor = true;
   this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
   // 
   // lblRespuesta
   // 
   this.lblRespuesta.AutoSize = true;
   this.lblRespuesta.Location = new System.Drawing.Point(63, 129);
   this.lblRespuesta.Name = "lblRespuesta";
   this.lblRespuesta.Size = new System.Drawing.Size(0, 13);
   this.lblRespuesta.TabIndex = 3;
   // 
   // btnLimpiar
   // 
   this.btnLimpiar.Location = new System.Drawing.Point(158, 72);
   this.btnLimpiar.Name = "btnLimpiar";
   this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
   this.btnLimpiar.TabIndex = 4;
   this.btnLimpiar.Text = "Limpiar";
   this.btnLimpiar.UseVisualStyleBackColor = true;
   this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
   // 
   // frmCapturarDatosComboBox
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.ClientSize = new System.Drawing.Size(284, 261);
   this.Controls.Add(this.btnLimpiar);
   this.Controls.Add(this.lblRespuesta);
   this.Controls.Add(this.btnMostrar);
   this.Controls.Add(this.cboDias);
   this.Controls.Add(this.label1);
   this.Name = "frmCapturarDatosComboBox";
   this.Text = "frmCapturarDatosComboBox";
   this.ResumeLayout(false);
   this.PerformLayout();

  }

  #endregion

  private System.Windows.Forms.Label label1;
  private System.Windows.Forms.ComboBox cboDias;
  private System.Windows.Forms.Button btnMostrar;
  private System.Windows.Forms.Label lblRespuesta;
  private System.Windows.Forms.Button btnLimpiar;
 }
}