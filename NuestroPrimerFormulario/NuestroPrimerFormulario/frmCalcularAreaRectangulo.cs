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
 public partial class frmCalcularAreaRectangulo : Form
 {
  public frmCalcularAreaRectangulo()
  {
   InitializeComponent();
  }

  private void btnCalcular_Click(object sender, EventArgs e)
  {
  decimal altura = txtAltura.Value, bse = txtBase.Value;
  decimal total = (altura * bse);
  lblRespuesta.Text = ("El area del rectangulo es: " + total);
  txtRespuesta.Text = total.ToString();
  }

  private void btnLimpiar_Click(object sender, EventArgs e)
  {
   txtAltura.Value = 0;
   txtBase.Value = 0;
   lblRespuesta.Text = "";
   txtRespuesta.Text = "";
  }

 }
}
