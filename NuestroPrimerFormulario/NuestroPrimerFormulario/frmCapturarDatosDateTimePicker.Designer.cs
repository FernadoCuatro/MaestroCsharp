namespace NuestroPrimerFormulario
{
 partial class frmCapturarDatosDateTimePicker
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
   this.btnMostrar = new System.Windows.Forms.Button();
   this.dtpFecha = new System.Windows.Forms.DateTimePicker();
   this.lblRespuesta = new System.Windows.Forms.Label();
   this.SuspendLayout();
   // 
   // label1
   // 
   this.label1.AutoSize = true;
   this.label1.Location = new System.Drawing.Point(24, 27);
   this.label1.Name = "label1";
   this.label1.Size = new System.Drawing.Size(83, 13);
   this.label1.TabIndex = 0;
   this.label1.Text = "Inserte la fecha:";
   // 
   // btnMostrar
   // 
   this.btnMostrar.Location = new System.Drawing.Point(97, 58);
   this.btnMostrar.Name = "btnMostrar";
   this.btnMostrar.Size = new System.Drawing.Size(75, 23);
   this.btnMostrar.TabIndex = 1;
   this.btnMostrar.Text = "Mostrar";
   this.btnMostrar.UseVisualStyleBackColor = true;
   this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
   // 
   // dtpFecha
   // 
   this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
   this.dtpFecha.Location = new System.Drawing.Point(132, 27);
   this.dtpFecha.MaxDate = new System.DateTime(2022, 12, 31, 0, 0, 0, 0);
   this.dtpFecha.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
   this.dtpFecha.Name = "dtpFecha";
   this.dtpFecha.Size = new System.Drawing.Size(123, 20);
   this.dtpFecha.TabIndex = 2;
   this.dtpFecha.Value = new System.DateTime(2021, 4, 12, 18, 24, 28, 0);
   // 
   // lblRespuesta
   // 
   this.lblRespuesta.AutoSize = true;
   this.lblRespuesta.Location = new System.Drawing.Point(27, 120);
   this.lblRespuesta.Name = "lblRespuesta";
   this.lblRespuesta.Size = new System.Drawing.Size(0, 13);
   this.lblRespuesta.TabIndex = 3;
   // 
   // frmCapturarDatosDateTimePicker
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.ClientSize = new System.Drawing.Size(284, 261);
   this.Controls.Add(this.lblRespuesta);
   this.Controls.Add(this.dtpFecha);
   this.Controls.Add(this.btnMostrar);
   this.Controls.Add(this.label1);
   this.Name = "frmCapturarDatosDateTimePicker";
   this.Text = "frmCapturarDatosDateTimePicker";
   this.ResumeLayout(false);
   this.PerformLayout();

  }

  #endregion

  private System.Windows.Forms.Label label1;
  private System.Windows.Forms.Button btnMostrar;
  private System.Windows.Forms.DateTimePicker dtpFecha;
  private System.Windows.Forms.Label lblRespuesta;
 }
}