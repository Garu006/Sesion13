using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Registro.models;
namespace Registro
{
    public partial class Form1 : Form
    {
        List<Persona> persons;
       public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Persona person = new Persona();
            person.FirstName = tbNombres.Text;
            person.LastName = tbApellidos.Text;
            person.Birthdate = dtpFechaNac.Value;
            persons.Add(person);
            ShowPerson();
        }

        private void ShowPerson()
        {
            dgvPersona.DataSource = null;
            dgvPersona.DataSource = persons;
        }

        private void Cleartb()
        {
            tbNombres.Clear();
            tbApellidos.Clear();
            dtpFechaNac.Value = DateTime.Now;
            tbNombres.Focus();
        }
    }
}
