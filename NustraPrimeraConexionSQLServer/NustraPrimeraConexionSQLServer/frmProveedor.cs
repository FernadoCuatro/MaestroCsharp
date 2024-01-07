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
 public partial class frmProveedor : Form
 {
  public frmProveedor()
  {
   InitializeComponent();
  }

  private void suppliersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
  {
   this.Validate();
   this.suppliersBindingSource.EndEdit();
   this.tableAdapterManager.UpdateAll(this.northwindDataSet);

  }

  private void frmProveedor_Load(object sender, EventArgs e)
  {
   // TODO: esta línea de código carga datos en la tabla 'northwindDataSet.Suppliers' Puede moverla o quitarla según sea necesario.
   this.suppliersTableAdapter.Fill(this.northwindDataSet.Suppliers);

  }

  private void Filtrar(object sender, EventArgs e)
  {
   this.suppliersTableAdapter.FiltradoSensitivo(
    this.northwindDataSet.Suppliers,
    Convert.ToString(txtNombre.Text)
    );
  }
 }
}
