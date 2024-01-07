namespace MiPrimeraAplicacionEscritorio
{
 partial class frmBus
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
   this.dgbBus = new System.Windows.Forms.DataGridView();
   this.label1 = new System.Windows.Forms.Label();
   this.cboTipoBus = new System.Windows.Forms.ComboBox();
   this.btnBuscar = new System.Windows.Forms.Button();
   this.btnLimpiar = new System.Windows.Forms.Button();
   ((System.ComponentModel.ISupportInitialize)(this.dgbBus)).BeginInit();
   this.SuspendLayout();
   // 
   // dgbBus
   // 
   this.dgbBus.AllowUserToAddRows = false;
   this.dgbBus.AllowUserToResizeColumns = false;
   this.dgbBus.AllowUserToResizeRows = false;
   this.dgbBus.BackgroundColor = System.Drawing.SystemColors.Control;
   this.dgbBus.BorderStyle = System.Windows.Forms.BorderStyle.None;
   this.dgbBus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
   this.dgbBus.Location = new System.Drawing.Point(35, 79);
   this.dgbBus.Name = "dgbBus";
   this.dgbBus.ReadOnly = true;
   this.dgbBus.RowHeadersVisible = false;
   this.dgbBus.Size = new System.Drawing.Size(416, 150);
   this.dgbBus.TabIndex = 0;
   // 
   // label1
   // 
   this.label1.AutoSize = true;
   this.label1.Location = new System.Drawing.Point(32, 50);
   this.label1.Name = "label1";
   this.label1.Size = new System.Drawing.Size(132, 13);
   this.label1.TabIndex = 1;
   this.label1.Text = "Seleccione el tipo de bus: ";
   // 
   // cboTipoBus
   // 
   this.cboTipoBus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
   this.cboTipoBus.FormattingEnabled = true;
   this.cboTipoBus.Location = new System.Drawing.Point(173, 42);
   this.cboTipoBus.Name = "cboTipoBus";
   this.cboTipoBus.Size = new System.Drawing.Size(178, 21);
   this.cboTipoBus.TabIndex = 2;
   // 
   // btnBuscar
   // 
   this.btnBuscar.Location = new System.Drawing.Point(376, 45);
   this.btnBuscar.Name = "btnBuscar";
   this.btnBuscar.Size = new System.Drawing.Size(75, 23);
   this.btnBuscar.TabIndex = 3;
   this.btnBuscar.Text = "Buscar";
   this.btnBuscar.UseVisualStyleBackColor = true;
   this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
   // 
   // btnLimpiar
   // 
   this.btnLimpiar.BackColor = System.Drawing.SystemColors.AppWorkspace;
   this.btnLimpiar.Location = new System.Drawing.Point(376, 12);
   this.btnLimpiar.Name = "btnLimpiar";
   this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
   this.btnLimpiar.TabIndex = 4;
   this.btnLimpiar.Text = "Limpiar";
   this.btnLimpiar.UseVisualStyleBackColor = false;
   this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
   // 
   // frmBus
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.ClientSize = new System.Drawing.Size(483, 261);
   this.Controls.Add(this.btnLimpiar);
   this.Controls.Add(this.btnBuscar);
   this.Controls.Add(this.cboTipoBus);
   this.Controls.Add(this.label1);
   this.Controls.Add(this.dgbBus);
   this.Name = "frmBus";
   this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
   this.Text = "frmBus";
   this.Load += new System.EventHandler(this.frmBus_Load);
   ((System.ComponentModel.ISupportInitialize)(this.dgbBus)).EndInit();
   this.ResumeLayout(false);
   this.PerformLayout();

  }

  #endregion

  private System.Windows.Forms.DataGridView dgbBus;
  private System.Windows.Forms.Label label1;
  private System.Windows.Forms.ComboBox cboTipoBus;
  private System.Windows.Forms.Button btnBuscar;
  private System.Windows.Forms.Button btnLimpiar;
 }
}