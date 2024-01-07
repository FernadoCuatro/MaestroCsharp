using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox
{
 public partial class Form1 : Form
 {
  public Form1()
  {
   InitializeComponent();
  }

  private void Form1_Load(object sender, EventArgs e)
  {
   cboPersona.Text = "--Seleccione--";

   List<Persona> listaPersona = new List<Persona>();
   listaPersona.Add(new Persona { idPersona = 1, nombrePersona = "Luis" });
   listaPersona.Add(new Persona { idPersona = 2, nombrePersona = "Pedro" });
   listaPersona.Add(new Persona { idPersona = 3, nombrePersona = "Jorge" });

   cboPersona.DataSource = listaPersona;
   cboPersona.DisplayMember = "nombrePersona";
   cboPersona.ValueMember = "idPersona";
  }

  private void btnMostrar_Click(object sender, EventArgs e)
  {
   string nombrePersona = cboPersona.Text;
   MessageBox.Show(nombrePersona);
  }

  private void btnValue_Click(object sender, EventArgs e)
  {
   string idPersona = cboPersona.SelectedValue.ToString();
   MessageBox.Show(idPersona);
  }

  private void btnMostrarValores_Click(object sender, EventArgs e)
  {
   Persona Opersona = (Persona)cboPersona.SelectedItem;
   MessageBox.Show("ID: " + Opersona.idPersona + "\nNombre: " + Opersona.nombrePersona );
  }
 }
}
