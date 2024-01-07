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
 public partial class frmDemostracion : Form
 {
  public frmDemostracion()
  {
   InitializeComponent();
  }

  private void categoriesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
  {
   this.Validate();
   this.categoriesBindingSource.EndEdit();
   this.tableAdapterManager.UpdateAll(this.northwindDataSet);

  }

  private void frmDemostracion_Load(object sender, EventArgs e)
  {
   // TODO: esta línea de código carga datos en la tabla 'northwindDataSet.Categories' Puede moverla o quitarla según sea necesario.
   this.categoriesTableAdapter.Fill(this.northwindDataSet.Categories);

  }
 }
}
