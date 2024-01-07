using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClaseDataGridView
{
 public partial class Form2 : Form
 {
  public Form2()
  {
   InitializeComponent();
  }

  private void Form2_Load(object sender, EventArgs e)
  {
   List<Empleado> ListaEmpleado = new List<Empleado>
   {
    new Empleado {nombreEmpleado="Pedro", sueldoEmpleado=250.34, trabajoMesEmpleado=25 },
    new Empleado {nombreEmpleado="Julio", sueldoEmpleado=630.34, trabajoMesEmpleado=15 },
    new Empleado {nombreEmpleado="Beto", sueldoEmpleado=810.34, trabajoMesEmpleado=5 }
   };

   dgvEmpleado.DataSource = ListaEmpleado;

   dgvEmpleado.Columns[0].HeaderText = "Nombre del empleado";
   dgvEmpleado.Columns[1].HeaderText = "Ganancia Mensual";
   dgvEmpleado.Columns[2].HeaderText = "Dias de trabajo";

   dgvEmpleado.Columns[0].Width = 150;
   dgvEmpleado.Columns[1].Width = 140;
   dgvEmpleado.Columns[2].Width = 50;
  }
 }
}
