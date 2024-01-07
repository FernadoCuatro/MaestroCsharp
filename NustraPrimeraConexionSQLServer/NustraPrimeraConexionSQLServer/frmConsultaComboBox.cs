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
 public partial class frmConsultaComboBox : Form
 {
  public frmConsultaComboBox()
  {
   InitializeComponent();
  }

  private void categoriesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
  {
   this.Validate();
   this.categoriesBindingSource.EndEdit();
   this.tableAdapterManager.UpdateAll(this.northwindDataSet);

  }

  private void frmConsultaComboBox_Load(object sender, EventArgs e)
  {
   // TODO: esta línea de código carga datos en la tabla 'northwindDataSet.Products' Puede moverla o quitarla según sea necesario.
   this.productsTableAdapter.Fill(this.northwindDataSet.Products);
   // TODO: esta línea de código carga datos en la tabla 'northwindDataSet.Categories' Puede moverla o quitarla según sea necesario.
   this.categoriesTableAdapter.Fill(this.northwindDataSet.Categories);

  }

  private void txtConsultar_Click(object sender, EventArgs e)
  {
   this.productsTableAdapter.FiltroCategoriaProducto
    (
    this.northwindDataSet.Products,
    Convert.ToInt32(cboCategorias.SelectedValue.ToString())
    );
  }
 }
}
