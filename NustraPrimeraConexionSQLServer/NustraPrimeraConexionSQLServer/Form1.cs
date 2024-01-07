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
 public partial class Form1 : Form
 {
  public Form1()
  {
   InitializeComponent();
  }

  private void categoriesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
  {
   this.Validate();
   this.categoriesBindingSource.EndEdit();
   this.tableAdapterManager.UpdateAll(this.northwindDataSet);

  }

  private void Form1_Load(object sender, EventArgs e)
  {
   // TODO: esta línea de código carga datos en la tabla 'northwindDataSet.Categories' Puede moverla o quitarla según sea necesario.
   listar();
  }

  private void listar()
  {
   this.categoriesTableAdapter.Fill(this.northwindDataSet.Categories);
  }

  private void btnBuscar_Click(object sender, EventArgs e)
  {
   int idCategoria = Convert.ToInt32(txtIdCategoria.Text);

   this.categoriesTableAdapter.FiltrarPorIdCategoria(
    this.northwindDataSet.Categories, idCategoria
    );

  }

  private void btnLimpiar_Click(object sender, EventArgs e)
  {
   listar();
   txtIdCategoria.Text = "";
  }

  private void btnCancelar_Click(object sender, EventArgs e)
  {
   limpiarEnvio();
  }

  private void limpiarEnvio()
  {
   txtNombre.Text = "";
   txtDescripcion.Text = "";
   errorDatos.Clear();
  }

  private void btnGuardar_Click(object sender, EventArgs e)
  {

   if (txtNombre.Text.Equals("") || txtDescripcion.Text.Equals(""))
   {
    errorDatos.SetError(btnGuardar, "Inserte datos correspondientes");
   }
   else
   {
    errorDatos.Clear();
   this.categoriesTableAdapter.InsertarCategoria
    (
    Convert.ToString(txtNombre.Text),
    Convert.ToString(txtDescripcion.Text)
    );

    listar();
    MessageBox.Show("Se guardaron los datos", "Exito");
    limpiarEnvio();
   }

  }
 }
}
