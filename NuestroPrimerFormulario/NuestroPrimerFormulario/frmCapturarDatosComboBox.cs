using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NuestroPrimerFormulario
{
 public partial class frmCapturarDatosComboBox : Form
 {
  public frmCapturarDatosComboBox()
  {
   InitializeComponent();
  }

  private void btnMostrar_Click(object sender, EventArgs e)
  {
   string dia = cboDias.Text;
   if (!dia.Equals("-- Seleccione --"))
   {
    lblRespuesta.Text = "El dia seleccionado es: " + dia;
   }
   else
   {
    lblRespuesta.Text = "";
   }

  }

  private void btnLimpiar_Click(object sender, EventArgs e)
  {
   cboDias.Text = "-- Seleccione --";
   lblRespuesta.Text = "";
  }
 }
}
