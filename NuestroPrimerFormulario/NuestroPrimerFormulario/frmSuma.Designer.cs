namespace NuestroPrimerFormulario
{
 partial class frmSuma
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
   this.label2 = new System.Windows.Forms.Label();
   this.label3 = new System.Windows.Forms.Label();
   this.txtNumero1 = new System.Windows.Forms.NumericUpDown();
   this.txtNumero2 = new System.Windows.Forms.NumericUpDown();
   this.txtNumero3 = new System.Windows.Forms.NumericUpDown();
   this.btnCalcular = new System.Windows.Forms.Button();
   this.btnLimpiar = new System.Windows.Forms.Button();
   this.lblRespuesta = new System.Windows.Forms.Label();
   ((System.ComponentModel.ISupportInitialize)(this.txtNumero1)).BeginInit();
   ((System.ComponentModel.ISupportInitialize)(this.txtNumero2)).BeginInit();
   ((System.ComponentModel.ISupportInitialize)(this.txtNumero3)).BeginInit();
   this.SuspendLayout();
   // 
   // label1
   // 
   this.label1.AutoSize = true;
   this.label1.Location = new System.Drawing.Point(27, 29);
   this.label1.Name = "label1";
   this.label1.Size = new System.Drawing.Size(92, 13);
   this.label1.TabIndex = 0;
   this.label1.Text = "Ingrese numero 1:";
   // 
   // label2
   // 
   this.label2.AutoSize = true;
   this.label2.Location = new System.Drawing.Point(27, 66);
   this.label2.Name = "label2";
   this.label2.Size = new System.Drawing.Size(92, 13);
   this.label2.TabIndex = 0;
   this.label2.Text = "Ingrese numero 2:";
   // 
   // label3
   // 
   this.label3.AutoSize = true;
   this.label3.Location = new System.Drawing.Point(27, 98);
   this.label3.Name = "label3";
   this.label3.Size = new System.Drawing.Size(92, 13);
   this.label3.TabIndex = 0;
   this.label3.Text = "Ingrese numero 3:";
   // 
   // txtNumero1
   // 
   this.txtNumero1.Location = new System.Drawing.Point(135, 22);
   this.txtNumero1.Name = "txtNumero1";
   this.txtNumero1.Size = new System.Drawing.Size(120, 20);
   this.txtNumero1.TabIndex = 1;
   // 
   // txtNumero2
   // 
   this.txtNumero2.Location = new System.Drawing.Point(135, 59);
   this.txtNumero2.Name = "txtNumero2";
   this.txtNumero2.Size = new System.Drawing.Size(120, 20);
   this.txtNumero2.TabIndex = 1;
   // 
   // txtNumero3
   // 
   this.txtNumero3.Location = new System.Drawing.Point(135, 96);
   this.txtNumero3.Name = "txtNumero3";
   this.txtNumero3.Size = new System.Drawing.Size(120, 20);
   this.txtNumero3.TabIndex = 1;
   // 
   // btnCalcular
   // 
   this.btnCalcular.Location = new System.Drawing.Point(30, 134);
   this.btnCalcular.Name = "btnCalcular";
   this.btnCalcular.Size = new System.Drawing.Size(75, 23);
   this.btnCalcular.TabIndex = 2;
   this.btnCalcular.Text = "Calcular";
   this.btnCalcular.UseVisualStyleBackColor = true;
   this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
   // 
   // btnLimpiar
   // 
   this.btnLimpiar.Location = new System.Drawing.Point(180, 134);
   this.btnLimpiar.Name = "btnLimpiar";
   this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
   this.btnLimpiar.TabIndex = 2;
   this.btnLimpiar.Text = "Limpiar";
   this.btnLimpiar.UseVisualStyleBackColor = true;
   this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
   // 
   // lblRespuesta
   // 
   this.lblRespuesta.AutoSize = true;
   this.lblRespuesta.Location = new System.Drawing.Point(30, 182);
   this.lblRespuesta.Name = "lblRespuesta";
   this.lblRespuesta.Size = new System.Drawing.Size(0, 13);
   this.lblRespuesta.TabIndex = 3;
   // 
   // frmSuma
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.ClientSize = new System.Drawing.Size(284, 261);
   this.Controls.Add(this.lblRespuesta);
   this.Controls.Add(this.btnLimpiar);
   this.Controls.Add(this.btnCalcular);
   this.Controls.Add(this.txtNumero3);
   this.Controls.Add(this.txtNumero2);
   this.Controls.Add(this.txtNumero1);
   this.Controls.Add(this.label3);
   this.Controls.Add(this.label2);
   this.Controls.Add(this.label1);
   this.Name = "frmSuma";
   this.Text = "frmSuma";
   ((System.ComponentModel.ISupportInitialize)(this.txtNumero1)).EndInit();
   ((System.ComponentModel.ISupportInitialize)(this.txtNumero2)).EndInit();
   ((System.ComponentModel.ISupportInitialize)(this.txtNumero3)).EndInit();
   this.ResumeLayout(false);
   this.PerformLayout();

  }

  #endregion

  private System.Windows.Forms.Label label1;
  private System.Windows.Forms.Label label2;
  private System.Windows.Forms.Label label3;
  private System.Windows.Forms.NumericUpDown txtNumero1;
  private System.Windows.Forms.NumericUpDown txtNumero2;
  private System.Windows.Forms.NumericUpDown txtNumero3;
  private System.Windows.Forms.Button btnCalcular;
  private System.Windows.Forms.Button btnLimpiar;
  private System.Windows.Forms.Label lblRespuesta;
 }
}