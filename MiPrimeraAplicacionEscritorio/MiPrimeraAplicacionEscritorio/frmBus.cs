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
 public partial class frmBus : Form
 {
  public frmBus()
  {
   InitializeComponent();
  }

  private void listar()
  {
   BDPasajeEntities db = new BDPasajeEntities();

   var consulta = (from bus in db.Bus
                   join Sucursal in db.Sucursal
                   on bus.IIDSUCURSAL equals Sucursal.IIDSUCURSAL
                   join TipoBus in db.TipoBus
                   on bus.IIDTIPOBUS equals TipoBus.IIDTIPOBUS
                   where bus.BHABILITADO == 1
                   select new
                   {
                    bus.IIDBUS,
                    Sucursal.NOMBRE,
                    Tipo = TipoBus.NOMBRE,
                    bus.PLACA
                   }).ToList();

   dgbBus.DataSource = consulta;

  }

  private void frmBus_Load(object sender, EventArgs e)
  {
   listar();
   llenarCombo();
  }

  private void llenarCombo()
  {
   BDPasajeEntities db = new BDPasajeEntities();

  var consulta = (from TipoBus in db.TipoBus
                  where TipoBus.BHABILITADO == 1
                  select new
                  {
                   TipoBus.IIDTIPOBUS,
                   TipoBus.NOMBRE
                  }).ToList();

  cboTipoBus.DataSource = consulta;
  cboTipoBus.DisplayMember = "NOMBRE";
  cboTipoBus.ValueMember = "IIDTIPOBUS";
  }

  private void btnBuscar_Click(object sender, EventArgs e)
  {

   BDPasajeEntities db = new BDPasajeEntities();

   var consulta = (from bus in db.Bus
                   join Sucursal in db.Sucursal
                   on bus.IIDSUCURSAL equals Sucursal.IIDSUCURSAL
                   join TipoBus in db.TipoBus
                   on bus.IIDTIPOBUS equals TipoBus.IIDTIPOBUS
                   where bus.BHABILITADO == 1 &&
                   TipoBus.IIDTIPOBUS == (int)cboTipoBus.SelectedValue
                   select new
                   {
                    bus.IIDBUS,
                    Sucursal.NOMBRE,
                    Tipo = TipoBus.NOMBRE,
                    bus.PLACA
                   }).ToList();

   dgbBus.DataSource = consulta;
  }

  private void btnLimpiar_Click(object sender, EventArgs e)
  {
   listar();
  }
 }
}
