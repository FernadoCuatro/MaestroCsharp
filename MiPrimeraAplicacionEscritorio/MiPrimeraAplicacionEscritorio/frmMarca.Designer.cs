﻿namespace MiPrimeraAplicacionEscritorio
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
   this.dgvMarcas = new System.Windows.Forms.DataGridView();
   this.label1 = new System.Windows.Forms.Label();
   this.txtNombre = new System.Windows.Forms.TextBox();
   this.btnBuscar = new System.Windows.Forms.Button();
   this.btnLimpiar = new System.Windows.Forms.Button();
   ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).BeginInit();
   this.SuspendLayout();
   // 
   // dgvMarcas
   // 
   this.dgvMarcas.AllowUserToAddRows = false;
   this.dgvMarcas.AllowUserToResizeColumns = false;
   this.dgvMarcas.AllowUserToResizeRows = false;
   this.dgvMarcas.BackgroundColor = System.Drawing.SystemColors.Control;
   this.dgvMarcas.BorderStyle = System.Windows.Forms.BorderStyle.None;
   this.dgvMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
   this.dgvMarcas.Location = new System.Drawing.Point(45, 78);
   this.dgvMarcas.Name = "dgvMarcas";
   this.dgvMarcas.RowHeadersVisible = false;
   this.dgvMarcas.Size = new System.Drawing.Size(413, 256);
   this.dgvMarcas.TabIndex = 0;
   // 
   // label1
   // 
   this.label1.AutoSize = true;
   this.label1.Location = new System.Drawing.Point(29, 23);
   this.label1.Name = "label1";
   this.label1.Size = new System.Drawing.Size(152, 13);
   this.label1.TabIndex = 1;
   this.label1.Text = "Ingrese el nombre de la marca:";
   // 
   // txtNombre
   // 
   this.txtNombre.Location = new System.Drawing.Point(32, 39);
   this.txtNombre.Name = "txtNombre";
   this.txtNombre.Size = new System.Drawing.Size(279, 20);
   this.txtNombre.TabIndex = 2;
   // 
   // btnBuscar
   // 
   this.btnBuscar.Location = new System.Drawing.Point(317, 39);
   this.btnBuscar.Name = "btnBuscar";
   this.btnBuscar.Size = new System.Drawing.Size(75, 23);
   this.btnBuscar.TabIndex = 3;
   this.btnBuscar.Text = "Buscar";
   this.btnBuscar.UseVisualStyleBackColor = true;
   this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
   // 
   // btnLimpiar
   // 
   this.btnLimpiar.Location = new System.Drawing.Point(398, 39);
   this.btnLimpiar.Name = "btnLimpiar";
   this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
   this.btnLimpiar.TabIndex = 4;
   this.btnLimpiar.Text = "Limpiar";
   this.btnLimpiar.UseVisualStyleBackColor = true;
   this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
   // 
   // Form1
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.ClientSize = new System.Drawing.Size(496, 391);
   this.Controls.Add(this.btnLimpiar);
   this.Controls.Add(this.btnBuscar);
   this.Controls.Add(this.txtNombre);
   this.Controls.Add(this.label1);
   this.Controls.Add(this.dgvMarcas);
   this.Name = "Form1";
   this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
   this.Text = "Form1";
   this.Load += new System.EventHandler(this.Form1_Load);
   ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).EndInit();
   this.ResumeLayout(false);
   this.PerformLayout();

  }

  #endregion

  private System.Windows.Forms.DataGridView dgvMarcas;
  private System.Windows.Forms.Label label1;
  private System.Windows.Forms.TextBox txtNombre;
  private System.Windows.Forms.Button btnBuscar;
  private System.Windows.Forms.Button btnLimpiar;
 }
}

