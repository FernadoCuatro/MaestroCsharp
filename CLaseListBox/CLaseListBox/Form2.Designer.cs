﻿namespace CLaseListBox
{
 partial class Form2
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
   this.lbCursos = new System.Windows.Forms.ListBox();
   this.SuspendLayout();
   // 
   // lbCursos
   // 
   this.lbCursos.FormattingEnabled = true;
   this.lbCursos.Location = new System.Drawing.Point(12, 12);
   this.lbCursos.Name = "lbCursos";
   this.lbCursos.Size = new System.Drawing.Size(260, 95);
   this.lbCursos.TabIndex = 0;
   // 
   // Form2
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.ClientSize = new System.Drawing.Size(284, 261);
   this.Controls.Add(this.lbCursos);
   this.Name = "Form2";
   this.Text = "Form2";
   this.Load += new System.EventHandler(this.Form2_Load);
   this.ResumeLayout(false);

  }

  #endregion

  private System.Windows.Forms.ListBox lbCursos;
 }
}