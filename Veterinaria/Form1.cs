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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //new frmPersona().Visible = true;
            frmPersona ventanaPersona = new frmPersona();
            ventanaPersona.Visible = true;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            new frmClientes().Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new frmMascotas().Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
