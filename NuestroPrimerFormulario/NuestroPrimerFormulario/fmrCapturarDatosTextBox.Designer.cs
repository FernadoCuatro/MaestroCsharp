namespace NuestroPrimerFormulario
{
 partial class fmrCapturarDatosTextBox
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
   this.txtValor = new System.Windows.Forms.TextBox();
   this.btnMostrar = new System.Windows.Forms.Button();
   this.lblRespuesta = new System.Windows.Forms.Label();
   this.SuspendLayout();
   // 
   // label1
   // 
   this.label1.AutoSize = true;
   this.label1.Location = new System.Drawing.Point(44, 45);
   this.label1.Name = "label1";
   this.label1.Size = new System.Drawing.Size(82, 13);
   this.label1.TabIndex = 0;
   this.label1.Text = "Inserte el valor: ";
   // 
   // txtValor
   // 
   this.txtValor.Location = new System.Drawing.Point(148, 42);
   this.txtValor.Name = "txtValor";
   this.txtValor.Size = new System.Drawing.Size(100, 20);
   this.txtValor.TabIndex = 1;
   // 
   // btnMostrar
   // 
   this.btnMostrar.Location = new System.Drawing.Point(105, 87);
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
   this.lblRespuesta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
   this.lblRespuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.lblRespuesta.Location = new System.Drawing.Point(63, 148);
   this.lblRespuesta.Name = "lblRespuesta";
   this.lblRespuesta.Padding = new System.Windows.Forms.Padding(20);
   this.lblRespuesta.Size = new System.Drawing.Size(42, 62);
   this.lblRespuesta.TabIndex = 3;
   this.lblRespuesta.Click += new System.EventHandler(this.lblRespuesta_Click);
   // 
   // fmrCapturarDatosTextBox
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.ClientSize = new System.Drawing.Size(284, 261);
   this.Controls.Add(this.lblRespuesta);
   this.Controls.Add(this.btnMostrar);
   this.Controls.Add(this.txtValor);
   this.Controls.Add(this.label1);
   this.Name = "fmrCapturarDatosTextBox";
   this.Text = "fmrCapturarDatosTextBox";
   this.Load += new System.EventHandler(this.fmrCapturarDatosTextBox_Load);
   this.ResumeLayout(false);
   this.PerformLayout();

  }

  #endregion

  private System.Windows.Forms.Label label1;
  private System.Windows.Forms.TextBox txtValor;
  private System.Windows.Forms.Button btnMostrar;
  private System.Windows.Forms.Label lblRespuesta;
 }
}