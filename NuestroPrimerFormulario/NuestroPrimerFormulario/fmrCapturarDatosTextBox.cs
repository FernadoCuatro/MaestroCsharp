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
 public partial class fmrCapturarDatosTextBox : Form
 {
  public fmrCapturarDatosTextBox()
  {
   InitializeComponent();
  }

  private void fmrCapturarDatosTextBox_Load(object sender, EventArgs e)
  {

  }

  private void btnMostrar_Click(object sender, EventArgs e)
  {
   string valor = txtValor.Text;
   lblRespuesta.Text = "Ingresado: " + valor;
  }

  private void lblRespuesta_Click(object sender, EventArgs e)
  {

  }
 }
}
