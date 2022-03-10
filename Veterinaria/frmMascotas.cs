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
    public partial class frmMascotas : Form
    {
        public frmMascotas()
        {
            InitializeComponent();
        }

        private void frmMascotas_Load(object sender, EventArgs e)
        {
            //DataGridView dt = new DataGridView(); // se crea una instancia de la tabla

            comboBox1.ValueMember = "id"; // se refiere al id de la tabla
            comboBox1.DisplayMember = "nombre"; // muestra el nombre de la persona en lugar del id
            comboBox1.DataSource = new NPersona().obtener();  // se llena el combo box con datos

        }
        private void button1_Click(object sender, EventArgs e)
        {
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("Se seleccionó el Id " + comboBox1.SelectedValue);
        }
    }
}
