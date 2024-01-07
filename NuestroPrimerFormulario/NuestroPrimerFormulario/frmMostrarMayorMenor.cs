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
 public partial class frmMostrarMayorMenor : Form
 {
  public frmMostrarMayorMenor()
  {
   InitializeComponent();
  }

  private void btnCalcular_Click(object sender, EventArgs e)
  {
  int edad = Convert.ToInt32(txtEdad.Value);

   if (edad <= 0)
   {
    errorDatos.SetError(txtEdad, "La edad no es valida");
    return;
   }
   else
   {
    errorDatos.Clear();
   }

   if (edad >= 18)
   {
    lblMensaje.Text = "Es mayor de edad";
   }
   else
   {
    lblMensaje.Text = "Es menor de edad";
   }

  }

 }
}
