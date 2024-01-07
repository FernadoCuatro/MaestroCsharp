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
 public partial class frmSuma : Form
 {
  public frmSuma()
  {
   InitializeComponent();
  }

  private void btnCalcular_Click(object sender, EventArgs e)
  {
   decimal num1 = txtNumero1.Value, num2 = txtNumero2.Value, num3 = txtNumero3.Value;

   if (num1 != 0 || num2 != 0 || num3 != 0)
   {
    int sumaTotal = Convert.ToInt32(num1 + num2 + num3);

    lblRespuesta.Text = "La suma es " + sumaTotal;
   }

   if (num1 == 0 || num2 == 0 | num3 == 0)
   {
    MessageBox.Show("Los numeros no pueden ser cero [0]", "Alerta");
    return;
   }

  }

  private void btnLimpiar_Click(object sender, EventArgs e)
  {
   txtNumero1.Value = 0;
   txtNumero2.Value = 0;
   txtNumero3.Value = 0;

   lblRespuesta.Text = "";
  }
 }
}
