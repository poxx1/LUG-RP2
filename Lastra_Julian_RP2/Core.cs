using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lastra_Julian_RP2
{
    public partial class Core : Form
    {
        public Core()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Alumno: " + Environment.NewLine + "Lastra Julian Marcos", "Recuperatorio Parcial N 2", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UI_Clientes u = new UI_Clientes();
            u.MdiParent = this;
            u.Show();
        }

        private void clasesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UI_Clases u = new UI_Clases();
            u.MdiParent = this;
            u.Show();
        }

        private void profesoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UI_Profesores u = new UI_Profesores();
            u.MdiParent = this;
            u.Show();
        }
    }
}
