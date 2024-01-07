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
 public partial class frmEmpleado : Form
 {
  public frmEmpleado()
  {
   InitializeComponent();
  }

  private void Form2_Load(object sender, EventArgs e)
  {
   listar();
   dgvDatos.Columns[1].Width = 150;
  }

  private void listar()
  {
   BDPasajeEntities db = new BDPasajeEntities();

   var consulta = (from dato in db.Empleado
                   where dato.BHABILITADO == 1
                   select new
                   {
                    dato.IIDEMPLEADO,
                    nombreCompleto = dato.NOMBRE + " " + dato.APPATERNO + " " + dato.APPATERNO,
                    dato.FECHACONTRATO,
                    dato.SUELDO
                   }).ToList();

   dgvDatos.DataSource = consulta;
  }

  private void btnLimpiar_Click(object sender, EventArgs e)
  {
   listar();
   txtNombreCompleto.Text = "";
  }

  private void btnBuscar_Click(object sender, EventArgs e)
  {
   BDPasajeEntities db = new BDPasajeEntities();

   var consulta = (from dato in db.Empleado
                   where dato.BHABILITADO == 1 &&
                   (dato.NOMBRE + " " + dato.APPATERNO + " " + dato.APPATERNO).Contains(txtNombreCompleto.Text)
                   select new
                   {
                    dato.IIDEMPLEADO,
                    nombreCompleto = dato.NOMBRE + " " + dato.APPATERNO + " " + dato.APPATERNO,
                    dato.FECHACONTRATO,
                    dato.SUELDO
                   }).ToList();

   dgvDatos.DataSource = consulta;
  }
 }
}
