using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NustraPrimeraConexionSQLServer
{
 public partial class FrmProductoProveedor : Form
 {
  public FrmProductoProveedor()
  {
   InitializeComponent();
  }

  private void suppliersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
  {
   this.Validate();
   this.suppliersBindingSource.EndEdit();
   this.tableAdapterManager.UpdateAll(this.northwindDataSet);

  }

  private void FrmProductoProveedor_Load(object sender, EventArgs e)
  {
   // TODO: esta línea de código carga datos en la tabla 'northwindDataSet.Suppliers' Puede moverla o quitarla según sea necesario.
   this.suppliersTableAdapter.Fill(this.northwindDataSet.Suppliers);

   limpiar();
  }

  private void limpiar()
  {
   // TODO: esta línea de código carga datos en la tabla 'northwindDataSet.Products' Puede moverla o quitarla según sea necesario.
   this.productsTableAdapter.Fill(this.northwindDataSet.Products);
  }

  private void filtrar(object sender, EventArgs e)
  {
   if (cboProveedor.Text.Equals("-- Seleccione un Proveedor --"))
   {
    errorProveedor.SetError(label1, "Seleccione un proveedor");
   }
   else
   {
    errorProveedor.Clear();
    this.productsTableAdapter.FiltradoProveedor
     (
     this.northwindDataSet.Products,
     Convert.ToInt32(cboProveedor.SelectedValue.ToString())
     );
   }
  }

  private void btnLimpiar_Click(object sender, EventArgs e)
  {
   limpiar();
   cboProveedor.Text = "-- Seleccione un Proveedor --";
  }
 }
}
