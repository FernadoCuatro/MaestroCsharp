using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLaseListBox
{
 public partial class Form2 : Form
 {
  public Form2()
  {
   InitializeComponent();
  }

  private void Form2_Load(object sender, EventArgs e)
  {
   /*
   string[] cursos =
   {
    "Matematicas", "Religion", "Comunicacion", "Fisica"
   };
   */

   // Tambien se puede llenar con una lista en HD

   List<string> cursos = new List<string>
   {
    "Matematicas", "Religion", "Comunicacion", "Fisica"
   };

   lbCursos.DataSource = cursos;
  }
 }
}
