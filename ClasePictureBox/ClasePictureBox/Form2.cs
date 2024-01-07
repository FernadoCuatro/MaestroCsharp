﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ClasePictureBox
{
 public partial class Form2 : Form
 {
  public Form2()
  {
   InitializeComponent();
  }

  private void Form2_Load(object sender, EventArgs e)
  {
   string ruta = @"C:\Users\Fernando\Pictures\wallhaven-43qzkd.jpg";

   byte[] buffer =  File.ReadAllBytes(ruta);

   using (MemoryStream ms = new MemoryStream(buffer))
   {
    pbImagen.Image = Image.FromStream(ms);
   }

  }
 }
}
