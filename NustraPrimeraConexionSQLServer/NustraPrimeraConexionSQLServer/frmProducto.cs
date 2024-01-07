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
 public partial class frmProducto : Form
 {
  public frmProducto()
  {
   InitializeComponent();
  }

  private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
  {
   this.Validate();
   this.productsBindingSource.EndEdit();
   this.tableAdapterManager.UpdateAll(this.northwindDataSet);

  }

  private void frmProducto_Load(object sender, EventArgs e)
  {
   // TODO: esta línea de código carga datos en la tabla 'northwindDataSet.Products' Puede moverla o quitarla según sea necesario.

   listar();
  }

  private void listar()
  {
   this.productsTableAdapter.Fill(this.northwindDataSet.Products);
  }

  private void btnBuscar_Click(object sender, EventArgs e)
  {
   this.productsTableAdapter.FiltradoSensitivo(
    this.northwindDataSet.Products,
    Convert.ToString(txtNombre.Text)
    );

  }

  private void btnLimpiar_Click(object sender, EventArgs e)
  {
   listar();
   txtNombre.Text = "";
  }
 }
}
