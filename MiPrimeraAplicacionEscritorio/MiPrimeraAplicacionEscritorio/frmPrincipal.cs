using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiPrimeraAplicacionEscritorio
{
 public partial class frmPrincipal : Form
 {
  public frmPrincipal()
  {
   InitializeComponent();
  }

  private void itemMarca_Click(object sender, EventArgs e)
  {
   Form1 oFrmMarca = new Form1();
   oFrmMarca.ShowDialog();
  }

  private void itemEmpleado_Click(object sender, EventArgs e)
  {
   frmEmpleado oFrmEmpleado = new frmEmpleado();

   oFrmEmpleado.ShowDialog();
  }

  private void itemCliente_Click(object sender, EventArgs e)
  {
   frmCliente ofrmCliente = new frmCliente();

   ofrmCliente.ShowDialog();
  }

  private void tipoDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
  {
   frmTipoUsuario ofrmTipoUsuario = new frmTipoUsuario();

   ofrmTipoUsuario.ShowDialog();
  }

  private void busToolStripMenuItem_Click(object sender, EventArgs e)
  {
   frmBus ofrmBus = new frmBus();

   ofrmBus.ShowDialog();
  }

  private void viajeToolStripMenuItem_Click(object sender, EventArgs e)
  {
   frmViaje ofrmViaje = new frmViaje();

   ofrmViaje.ShowDialog();
  }
 }
}
