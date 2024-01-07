using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClaseDGVDataTable
{
 public partial class Form1 : Form
 {
  public Form1()
  {
   InitializeComponent();
  }

  private void Form1_Load(object sender, EventArgs e)
  {
   DataTable TablaPersona = new DataTable();

   // Hacemos las columnas
   TablaPersona.Columns.Add("Nombre", Type.GetType("System.String"));
   TablaPersona.Columns.Add("Edad", Type.GetType("System.Int32"));
   TablaPersona.Columns.Add("Sueldo", Type.GetType("System.Double"));

   // Llenando las filas
   DataRow fila1 = TablaPersona.NewRow();
   fila1[0] = "Pedro";
   fila1[1] = 25;
   fila1[2] = 149.23;
   // Agregando a la tabla
   TablaPersona.Rows.Add(fila1);

   DataRow fila2 = TablaPersona.NewRow();
   fila2[0] = "Luis";
   fila2[1] = 26;
   fila2[2] = 849.34;
   // Agregando a la tabla
   TablaPersona.Rows.Add(fila2);

   dgvPersonas.DataSource = TablaPersona;

  }
 }
}
