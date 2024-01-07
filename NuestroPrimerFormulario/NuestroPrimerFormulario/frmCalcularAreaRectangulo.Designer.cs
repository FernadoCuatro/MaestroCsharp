namespace NuestroPrimerFormulario
{
 partial class frmCalcularAreaRectangulo
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
   this.txtBase = new System.Windows.Forms.NumericUpDown();
   this.txtAltura = new System.Windows.Forms.NumericUpDown();
   this.btnCalcular = new System.Windows.Forms.Button();
   this.btnLimpiar = new System.Windows.Forms.Button();
   this.label3 = new System.Windows.Forms.Label();
   this.lblRespuesta = new System.Windows.Forms.Label();
   this.label4 = new System.Windows.Forms.Label();
   this.txtRespuesta = new System.Windows.Forms.TextBox();
   ((System.ComponentModel.ISupportInitialize)(this.txtBase)).BeginInit();
   ((System.ComponentModel.ISupportInitialize)(this.txtAltura)).BeginInit();
   this.SuspendLayout();
   // 
   // label1
   // 
   this.label1.AutoSize = true;
   this.label1.Location = new System.Drawing.Point(13, 20);
   this.label1.Name = "label1";
   this.label1.Size = new System.Drawing.Size(71, 13);
   this.label1.TabIndex = 0;
   this.label1.Text = "Ingrese base:";
   // 
   // label2
   // 
   this.label2.AutoSize = true;
   this.label2.Location = new System.Drawing.Point(13, 52);
   this.label2.Name = "label2";
   this.label2.Size = new System.Drawing.Size(74, 13);
   this.label2.TabIndex = 0;
   this.label2.Text = "Ingrese altura:";
   // 
   // txtBase
   // 
   this.txtBase.Location = new System.Drawing.Point(116, 13);
   this.txtBase.Name = "txtBase";
   this.txtBase.Size = new System.Drawing.Size(120, 20);
   this.txtBase.TabIndex = 1;
   // 
   // txtAltura
   // 
   this.txtAltura.Location = new System.Drawing.Point(116, 45);
   this.txtAltura.Name = "txtAltura";
   this.txtAltura.Size = new System.Drawing.Size(120, 20);
   this.txtAltura.TabIndex = 1;
   // 
   // btnCalcular
   // 
   this.btnCalcular.Location = new System.Drawing.Point(34, 87);
   this.btnCalcular.Name = "btnCalcular";
   this.btnCalcular.Size = new System.Drawing.Size(75, 23);
   this.btnCalcular.TabIndex = 2;
   this.btnCalcular.Text = "Calcular";
   this.btnCalcular.UseVisualStyleBackColor = true;
   this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
   // 
   // btnLimpiar
   // 
   this.btnLimpiar.Location = new System.Drawing.Point(161, 87);
   this.btnLimpiar.Name = "btnLimpiar";
   this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
   this.btnLimpiar.TabIndex = 2;
   this.btnLimpiar.Text = "Limpiar";
   this.btnLimpiar.UseVisualStyleBackColor = true;
   this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
   // 
   // label3
   // 
   this.label3.AutoSize = true;
   this.label3.Location = new System.Drawing.Point(16, 142);
   this.label3.Name = "label3";
   this.label3.Size = new System.Drawing.Size(0, 13);
   this.label3.TabIndex = 3;
   // 
   // lblRespuesta
   // 
   this.lblRespuesta.AutoSize = true;
   this.lblRespuesta.Location = new System.Drawing.Point(16, 141);
   this.lblRespuesta.Name = "lblRespuesta";
   this.lblRespuesta.Size = new System.Drawing.Size(0, 13);
   this.lblRespuesta.TabIndex = 4;
   // 
   // label4
   // 
   this.label4.AutoSize = true;
   this.label4.Location = new System.Drawing.Point(31, 211);
   this.label4.Name = "label4";
   this.label4.Size = new System.Drawing.Size(85, 13);
   this.label4.TabIndex = 5;
   this.label4.Text = "La respuesta es:";
   // 
   // txtRespuesta
   // 
   this.txtRespuesta.Location = new System.Drawing.Point(136, 204);
   this.txtRespuesta.Name = "txtRespuesta";
   this.txtRespuesta.ReadOnly = true;
   this.txtRespuesta.Size = new System.Drawing.Size(100, 20);
   this.txtRespuesta.TabIndex = 6;
   this.txtRespuesta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
   // 
   // frmCalcularAreaRectangulo
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.ClientSize = new System.Drawing.Size(284, 261);
   this.Controls.Add(this.txtRespuesta);
   this.Controls.Add(this.label4);
   this.Controls.Add(this.lblRespuesta);
   this.Controls.Add(this.label3);
   this.Controls.Add(this.btnLimpiar);
   this.Controls.Add(this.btnCalcular);
   this.Controls.Add(this.txtAltura);
   this.Controls.Add(this.txtBase);
   this.Controls.Add(this.label2);
   this.Controls.Add(this.label1);
   this.Name = "frmCalcularAreaRectangulo";
   this.Text = "frmCalcularAreaRectangulo";
   ((System.ComponentModel.ISupportInitialize)(this.txtBase)).EndInit();
   ((System.ComponentModel.ISupportInitialize)(this.txtAltura)).EndInit();
   this.ResumeLayout(false);
   this.PerformLayout();

  }

  #endregion

  private System.Windows.Forms.Label label1;
  private System.Windows.Forms.Label label2;
  private System.Windows.Forms.NumericUpDown txtBase;
  private System.Windows.Forms.NumericUpDown txtAltura;
  private System.Windows.Forms.Button btnCalcular;
  private System.Windows.Forms.Button btnLimpiar;
  private System.Windows.Forms.Label label3;
  private System.Windows.Forms.Label lblRespuesta;
  private System.Windows.Forms.Label label4;
  private System.Windows.Forms.TextBox txtRespuesta;
 }
}