using BE_Propiedades;
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
    public partial class UI_Clientes : Form
    {
        public UI_Clientes()
        {
            InitializeComponent();
            Load();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Assing();
            exec = new BLL_Clientes();
            exec.Insert(cliente);
        }

        public Cliente cliente;
        public BLL_Clientes exec;

        public void Assing()
        {
            cliente = new Cliente();

            cliente.DNI = Int32.Parse(textBox1.Text);
            cliente.Nombre = textBox2.Text;
            cliente.Apellido = textBox3.Text;
            cliente.FechaNac = Convert.ToDateTime(textBox4.Text); 
            cliente.Correo = textBox5.Text;
            cliente.Clases = 1;//Int32.Parse(textBox6.Text);
            cliente.Costo = Int32.Parse(textBox7.Text);
        }

        public void Load()
        {
            exec = new BLL_Clientes();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = exec.Listar(); 
        }
    }
}
