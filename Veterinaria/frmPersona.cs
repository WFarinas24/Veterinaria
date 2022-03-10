using CapaNegocio;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veterinaria
{
    public partial class frmPersona : Form
    {
        public frmPersona()
        {
            InitializeComponent();
            llenarCombo();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbPersona persona = new tbPersona();
            persona.nombre = txtNombre.Text;
            persona.apellido = txtApellido.Text;
            persona.idGenero = (int)comboboxGenero.SelectedItem;

            new NPersona().guardar(persona);
        }

        public void llenarCombo()
        {
            comboboxGenero.DataSource = Enum.GetValues(typeof(Enumeradores.Enumeradores.genero));

        }

        private void comboboxGenero_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
