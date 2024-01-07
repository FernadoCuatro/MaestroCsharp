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
 public partial class frmCliente : Form
 {
  public frmCliente()
  {
   InitializeComponent();
  }

  private void Form3_Load(object sender, EventArgs e)
  {
   BDPasajeEntities db = new BDPasajeEntities();

   var consulta = (from cliente in db.Cliente
                   join Sexo in db.Sexo
                   on cliente.IIDSEXO equals Sexo.IIDSEXO
                   where cliente.BHABILITADO == 1
                   select new
                   {
                    cliente.IIDCLIENTE,
                    NombreCompleto = cliente.NOMBRE+" "+ cliente.APPATERNO+" "+ cliente.APMATERNO,
                    cliente.EMAIL,
                    Sexo.NOMBRE
                   }).ToList();

   dgvCliente.DataSource = consulta;
  }

  private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
  {

  }

  private void filtrar(object sender, EventArgs e)
  {

   BDPasajeEntities db = new BDPasajeEntities();

   var consulta = (from cliente in db.Cliente
                   join Sexo in db.Sexo
                   on cliente.IIDSEXO equals Sexo.IIDSEXO
                   where cliente.BHABILITADO == 1 &&
                   (cliente.NOMBRE + " " + cliente.APPATERNO + " " + cliente.APMATERNO).Contains(txtBuscar.Text)
                   select new
                   {
                    cliente.IIDCLIENTE,
                    NombreCompleto = cliente.NOMBRE + " " + cliente.APPATERNO + " " + cliente.APMATERNO,
                    cliente.EMAIL,
                    Sexo.NOMBRE
                   }).ToList();

   dgvCliente.DataSource = consulta;
  }
 }
}
