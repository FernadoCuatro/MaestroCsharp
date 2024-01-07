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
 public partial class frmCalcularPrecio : Form
 {
  public frmCalcularPrecio()
  {
   InitializeComponent();
  }

  private void btnCalcular_Click(object sender, EventArgs e)
  {
   double precio = Convert.ToDouble(txtPrecio.Text);
   double descuento = precio * 0.20;
   double totalPagar = precio - descuento;

   txtPrecioReal.Text = "$"+precio.ToString();
   txtDescuento.Text = "$" + descuento.ToString();
   txtTotalPagar.Text = "$" + totalPagar.ToString();

  }

 }
}
