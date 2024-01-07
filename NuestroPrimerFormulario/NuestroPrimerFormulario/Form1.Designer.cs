namespace NuestroPrimerFormulario
{
 partial class frmPrimerFormulario
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
   System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrimerFormulario));
   this.label1 = new System.Windows.Forms.Label();
   this.lblImagen = new System.Windows.Forms.Label();
   this.txtnumero1 = new System.Windows.Forms.TextBox();
   this.button1 = new System.Windows.Forms.Button();
   this.comboBox1 = new System.Windows.Forms.ComboBox();
   this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
   this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
   ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
   this.SuspendLayout();
   // 
   // label1
   // 
   this.label1.Location = new System.Drawing.Point(79, 31);
   this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
   this.label1.Name = "label1";
   this.label1.Size = new System.Drawing.Size(221, 31);
   this.label1.TabIndex = 0;
   this.label1.Text = "Ingrese numero 1:";
   this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
   // 
   // lblImagen
   // 
   this.lblImagen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
   this.lblImagen.Image = ((System.Drawing.Image)(resources.GetObject("lblImagen.Image")));
   this.lblImagen.Location = new System.Drawing.Point(68, 71);
   this.lblImagen.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
   this.lblImagen.Name = "lblImagen";
   this.lblImagen.Size = new System.Drawing.Size(246, 256);
   this.lblImagen.TabIndex = 0;
   this.lblImagen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
   this.lblImagen.Click += new System.EventHandler(this.label2_Click);
   // 
   // txtnumero1
   // 
   this.txtnumero1.Location = new System.Drawing.Point(329, 31);
   this.txtnumero1.MaxLength = 10;
   this.txtnumero1.Name = "txtnumero1";
   this.txtnumero1.Size = new System.Drawing.Size(233, 29);
   this.txtnumero1.TabIndex = 1;
   this.txtnumero1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
   // 
   // button1
   // 
   this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
   this.button1.Location = new System.Drawing.Point(242, 367);
   this.button1.Name = "button1";
   this.button1.Size = new System.Drawing.Size(149, 32);
   this.button1.TabIndex = 2;
   this.button1.Text = "Guardar Info";
   this.button1.UseVisualStyleBackColor = true;
   // 
   // comboBox1
   // 
   this.comboBox1.FormattingEnabled = true;
   this.comboBox1.Items.AddRange(new object[] {
            "Lunes",
            "Martes",
            "Miercoles",
            "Jueves",
            "VIernes",
            "Sabado"});
   this.comboBox1.Location = new System.Drawing.Point(384, 84);
   this.comboBox1.Name = "comboBox1";
   this.comboBox1.Size = new System.Drawing.Size(121, 32);
   this.comboBox1.TabIndex = 3;
   // 
   // numericUpDown1
   // 
   this.numericUpDown1.Location = new System.Drawing.Point(385, 139);
   this.numericUpDown1.Name = "numericUpDown1";
   this.numericUpDown1.Size = new System.Drawing.Size(120, 29);
   this.numericUpDown1.TabIndex = 4;
   this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
   // 
   // dateTimePicker1
   // 
   this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
   this.dateTimePicker1.Location = new System.Drawing.Point(347, 195);
   this.dateTimePicker1.MaxDate = new System.DateTime(2021, 4, 11, 19, 4, 13, 0);
   this.dateTimePicker1.MinDate = new System.DateTime(1953, 1, 1, 0, 0, 0, 0);
   this.dateTimePicker1.Name = "dateTimePicker1";
   this.dateTimePicker1.Size = new System.Drawing.Size(200, 29);
   this.dateTimePicker1.TabIndex = 5;
   this.dateTimePicker1.Value = new System.DateTime(2021, 4, 11, 0, 0, 0, 0);
   // 
   // frmPrimerFormulario
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.BackColor = System.Drawing.SystemColors.Control;
   this.ClientSize = new System.Drawing.Size(602, 411);
   this.Controls.Add(this.dateTimePicker1);
   this.Controls.Add(this.numericUpDown1);
   this.Controls.Add(this.comboBox1);
   this.Controls.Add(this.button1);
   this.Controls.Add(this.txtnumero1);
   this.Controls.Add(this.lblImagen);
   this.Controls.Add(this.label1);
   this.Cursor = System.Windows.Forms.Cursors.Default;
   this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
   this.MaximizeBox = false;
   this.MinimizeBox = false;
   this.Name = "frmPrimerFormulario";
   this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
   this.Text = "Nuestro primer formulario";
   this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
   this.Load += new System.EventHandler(this.frmPrimerFormulario_Load);
   ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
   this.ResumeLayout(false);
   this.PerformLayout();

  }

  #endregion

  private System.Windows.Forms.Label label1;
  private System.Windows.Forms.Label lblImagen;
  private System.Windows.Forms.TextBox txtnumero1;
  private System.Windows.Forms.Button button1;
  private System.Windows.Forms.ComboBox comboBox1;
  private System.Windows.Forms.NumericUpDown numericUpDown1;
  private System.Windows.Forms.DateTimePicker dateTimePicker1;
 }
}

