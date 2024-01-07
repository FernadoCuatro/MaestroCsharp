using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiPrimeraAplicacionEscritorio.Models;

namespace MiPrimeraAplicacionEscritorio
{
 public partial class frmTipoUsuario : Form
 {
  public frmTipoUsuario()
  {
   InitializeComponent();
  }

  private void listrar()
  {
   BDPasajeEntities db = new BDPasajeEntities();

   var consulta = (from usuario in db.TipoUsuario
                   where usuario.BHABILITADO == 1 
                   select new
                   {
                    usuario.IIDTIPOUSUARIO,
                    usuario.NOMBRE,
                    usuario.DESCRIPCION
                   }).ToList();

   dgvUsuarios.DataSource = consulta;
  }

  private void filtrar(object sender, EventArgs e)
  {
   BDPasajeEntities db = new BDPasajeEntities();

   var consulta = (from usuario in db.TipoUsuario
                   where usuario.BHABILITADO == 1 &&
                   usuario.NOMBRE.Contains(txtNombreTipoUsuario.Text)
                   select new
                   {
                    usuario.IIDTIPOUSUARIO,
                    usuario.NOMBRE,
                    usuario.DESCRIPCION
                   }).ToList();

   dgvUsuarios.DataSource = consulta;
  }

  private void frmTipoUsuario_Load(object sender, EventArgs e)
  {
   listrar();
  }
 }
}
