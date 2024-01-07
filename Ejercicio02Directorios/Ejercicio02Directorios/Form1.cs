using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Ejercicio02Directorios
{
 public partial class Form1 : Form
 {
  public Form1()
  {
   InitializeComponent();
  }

  private void btnBuscar_Click(object sender, EventArgs e)
  {
   OpenFileDialog odf = new OpenFileDialog();

   odf.Filter = "Archivos de programa |*jpg;*png;*jpeg";

   if (odf.ShowDialog().Equals(DialogResult.OK))
   {
    txtRuta.Text = odf.FileName;

    byte[] img = File.ReadAllBytes(odf.FileName);

    using (MemoryStream ms = new MemoryStream(img))
    {
     pbImagen.Image = Image.FromStream(ms);
    }

   }

  }

  // qr_web.png
  private void btnMover_Click(object sender, EventArgs e)
  {
   SaveFileDialog sfd = new SaveFileDialog();
   sfd.Filter = "Archivos de programa |*jpg;*png;*jpeg";

   if (sfd.ShowDialog().Equals(DialogResult.OK))
   {
    File.Move(txtRuta.Text, sfd.FileName);
    MessageBox.Show("El proceso se realizo", "Exito");
   }

  }

  private void btnCopiar_Click(object sender, EventArgs e)
  {
   SaveFileDialog sfd = new SaveFileDialog();
   sfd.Filter = "Archivos de programa |*jpg;*png;*jpeg";

   if (sfd.ShowDialog().Equals(DialogResult.OK))
   {
    File.Copy(txtRuta.Text, sfd.FileName);
    MessageBox.Show("El proceso se realizo", "Exito");
   }

  }
 }
}
