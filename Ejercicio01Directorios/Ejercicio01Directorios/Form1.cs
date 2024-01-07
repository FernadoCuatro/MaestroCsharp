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
using System.Diagnostics;

namespace Ejercicio01Directorios
{
 public partial class Buscador : Form
 {
  public Buscador()
  {
   InitializeComponent();
  }

  private void Form1_Load(object sender, EventArgs e)
  {
   List<TiposArchivos> listaArchivos = new List<TiposArchivos>
   {
    new TiposArchivos {extencion=".txt", nombreArchivo="Archivos TXT" },
    new TiposArchivos {extencion=".docx", nombreArchivo="Microsoft Word" },
    new TiposArchivos {extencion=".xlxs", nombreArchivo="Microsoft Excel" },
    new TiposArchivos {extencion=".php", nombreArchivo="Archivos PHP" },
    new TiposArchivos {extencion=".png", nombreArchivo="Imagen" }
   };

   cboArchivos.DataSource = listaArchivos;
   cboArchivos.DisplayMember = "nombreArchivo";
   cboArchivos.ValueMember = "extencion";
  }

  private void btnBuscar_Click(object sender, EventArgs e)
  {
   FolderBrowserDialog fbd = new FolderBrowserDialog();

   if (fbd.ShowDialog().Equals(DialogResult.OK))
   {
    txtRuta.Text = fbd.SelectedPath;
   }
  }

  private void btnFiltrar_Click(object sender, EventArgs e)
  {
   if (txtRuta.Text.Equals(""))
   {
    errorDatos.SetError(txtRuta, "Seleccione una ruta");
    return;
   }
   else
   {
    errorDatos.Clear();
   }

   string rutaDirectorio = txtRuta.Text;
   string extencion = cboArchivos.SelectedValue.ToString();
   lbDatos.DataSource = Directory.GetFiles(rutaDirectorio, "*" + extencion);
  }

  private void btnLimpiar_Click(object sender, EventArgs e)
  {
   lbDatos.DataSource = null;
  }

  private void mostrarArchivos(object sender, EventArgs e)
  {
   if (lbDatos.Items.Count > 0)
   {
    string itemSeleccionado = lbDatos.SelectedItem.ToString();
    Process.Start(itemSeleccionado); 
   }
  }
 }
}
