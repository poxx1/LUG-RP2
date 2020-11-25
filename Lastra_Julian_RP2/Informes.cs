using BLL_Negocio;
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
    public partial class Informes : Form
    {
        public Informes()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
        public BLL_informes exec;

        private void button1_Click(object sender, EventArgs e)
        {
            //Informe 1
            exec = new BLL_informes();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = exec.Listar1();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Informe 2
            exec = new BLL_informes();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = exec.Listar2();
        }
    }
}
