namespace Ejercicio02Directorios
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
   this.label1 = new System.Windows.Forms.Label();
   this.label2 = new System.Windows.Forms.Label();
   this.btnBuscar = new System.Windows.Forms.Button();
   this.txtRuta = new System.Windows.Forms.TextBox();
   this.pbImagen = new System.Windows.Forms.PictureBox();
   this.btnMover = new System.Windows.Forms.Button();
   this.btnCopiar = new System.Windows.Forms.Button();
   ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
   this.SuspendLayout();
   // 
   // label1
   // 
   this.label1.AutoSize = true;
   this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
   this.label1.Location = new System.Drawing.Point(32, 27);
   this.label1.Name = "label1";
   this.label1.Size = new System.Drawing.Size(83, 13);
   this.label1.TabIndex = 0;
   this.label1.Text = "Ingrese Imagen:";
   // 
   // label2
   // 
   this.label2.AutoSize = true;
   this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
   this.label2.Location = new System.Drawing.Point(131, 27);
   this.label2.Name = "label2";
   this.label2.Size = new System.Drawing.Size(33, 13);
   this.label2.TabIndex = 0;
   this.label2.Text = "Ruta:";
   // 
   // btnBuscar
   // 
   this.btnBuscar.Location = new System.Drawing.Point(35, 43);
   this.btnBuscar.Name = "btnBuscar";
   this.btnBuscar.Size = new System.Drawing.Size(75, 23);
   this.btnBuscar.TabIndex = 1;
   this.btnBuscar.Text = "...";
   this.btnBuscar.UseVisualStyleBackColor = true;
   this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
   // 
   // txtRuta
   // 
   this.txtRuta.BackColor = System.Drawing.SystemColors.Info;
   this.txtRuta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
   this.txtRuta.Location = new System.Drawing.Point(134, 48);
   this.txtRuta.Name = "txtRuta";
   this.txtRuta.ReadOnly = true;
   this.txtRuta.Size = new System.Drawing.Size(287, 20);
   this.txtRuta.TabIndex = 2;
   // 
   // pbImagen
   // 
   this.pbImagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
   this.pbImagen.Location = new System.Drawing.Point(35, 91);
   this.pbImagen.Name = "pbImagen";
   this.pbImagen.Size = new System.Drawing.Size(386, 178);
   this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
   this.pbImagen.TabIndex = 3;
   this.pbImagen.TabStop = false;
   // 
   // btnMover
   // 
   this.btnMover.Location = new System.Drawing.Point(35, 287);
   this.btnMover.Name = "btnMover";
   this.btnMover.Size = new System.Drawing.Size(75, 23);
   this.btnMover.TabIndex = 4;
   this.btnMover.Text = "Mover";
   this.btnMover.UseVisualStyleBackColor = true;
   this.btnMover.Click += new System.EventHandler(this.btnMover_Click);
   // 
   // btnCopiar
   // 
   this.btnCopiar.Location = new System.Drawing.Point(134, 287);
   this.btnCopiar.Name = "btnCopiar";
   this.btnCopiar.Size = new System.Drawing.Size(75, 23);
   this.btnCopiar.TabIndex = 5;
   this.btnCopiar.Text = "Copiar";
   this.btnCopiar.UseVisualStyleBackColor = true;
   this.btnCopiar.Click += new System.EventHandler(this.btnCopiar_Click);
   // 
   // Form1
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
   this.BackColor = System.Drawing.Color.OldLace;
   this.ClientSize = new System.Drawing.Size(458, 342);
   this.Controls.Add(this.btnCopiar);
   this.Controls.Add(this.btnMover);
   this.Controls.Add(this.pbImagen);
   this.Controls.Add(this.txtRuta);
   this.Controls.Add(this.btnBuscar);
   this.Controls.Add(this.label2);
   this.Controls.Add(this.label1);
   this.ForeColor = System.Drawing.SystemColors.GrayText;
   this.Name = "Form1";
   this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
   this.Text = "Administrador de imagenes";
   ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
   this.ResumeLayout(false);
   this.PerformLayout();

  }

  #endregion

  private System.Windows.Forms.Label label1;
  private System.Windows.Forms.Label label2;
  private System.Windows.Forms.Button btnBuscar;
  private System.Windows.Forms.TextBox txtRuta;
  private System.Windows.Forms.PictureBox pbImagen;
  private System.Windows.Forms.Button btnMover;
  private System.Windows.Forms.Button btnCopiar;
 }
}

