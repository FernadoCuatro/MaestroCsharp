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
 public partial class frmCapturarDatosNumericUpDown : Form
 {
  public frmCapturarDatosNumericUpDown()
  {
   InitializeComponent();
  }

  private void btnMostrar_Click(object sender, EventArgs e)
  {
   decimal valor = txtValor.Value;
   lblRespuesta.Text = "El numero es " + valor;
  }

  private void btnLimpiar_Click(object sender, EventArgs e)
  {
   lblRespuesta.Text = "";
   txtValor.Value = 0;
  }
 }
}
