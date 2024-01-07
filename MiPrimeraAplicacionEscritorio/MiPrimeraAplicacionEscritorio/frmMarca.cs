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
 public partial class Form1 : Form
 {
  public Form1()
  {
   InitializeComponent();
  }

  private void Form1_Load(object sender, EventArgs e)
  {
   listar();
   dgvMarcas.Columns[0].Width = 50;
   dgvMarcas.Columns[2].Width = 250;
  }

  private void listar()
  {
   BDPasajeEntities oBDPasajeEntities = new BDPasajeEntities();

   var consulta = (from marca in oBDPasajeEntities.Marca
                   where marca.BHABILITADO == 1
                   select new
                   {
                    marca.IIDMARCA,
                    marca.NOMBRE,
                    marca.DESCRIPCION
                   }).ToList();

   dgvMarcas.DataSource = consulta;
  }

  private void btnBuscar_Click(object sender, EventArgs e)
  {
   BDPasajeEntities oBDPasajeEntities = new BDPasajeEntities();

   var consulta = (from marca in oBDPasajeEntities.Marca
                   where marca.BHABILITADO == 1 &&
                   marca.NOMBRE.Contains(txtNombre.Text)
                   select new
                   {
                    marca.IIDMARCA,
                    marca.NOMBRE,
                    marca.DESCRIPCION
                   }).ToList();

   dgvMarcas.DataSource = consulta;
  }

  private void btnLimpiar_Click(object sender, EventArgs e)
  {
   listar();
   txtNombre.Text = "";
  }
 }
}
