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
 public partial class frmViaje : Form
 {
  public frmViaje()
  {
   InitializeComponent();
  }

  private void listar()
  {
   BDPasajeEntities db = new BDPasajeEntities();

   var consulta = (from viaje in db.Viaje
                   join lugar in db.Lugar
                   on viaje.IIDLUGARORIGEN equals lugar.IIDLUGAR
                   join destino in db.Lugar
                   on viaje.IIDLUGARDESTINO equals destino.IIDLUGAR
                   where viaje.BHABILITADO == 1
                   select new
                   {
                    viaje.IIDVIAJE,
                    lugar.NOMBRE,
                    Destino = destino.NOMBRE,
                    viaje.PRECIO,
                    viaje.FECHAVIAJE
                   }).ToList();

   dgbViajes.DataSource = consulta;
  }

  private void frmViaje_Load(object sender, EventArgs e)
  {
   listar();
  }
 }
}
