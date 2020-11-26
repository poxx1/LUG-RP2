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
    public partial class UI_Profesores : Form
    {
        public UI_Profesores()
        {
            InitializeComponent();
            Loade();
        }

        public Profesor p;
        public BLL_Profes ex;

        public void Loade()
        {
            ex = new BLL_Profes();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ex.Listar();
        }
        public void Assing()
        {
             p = new Profesor();

             p.Nombre = textBox2.Text;
             p.DNI = Int32.Parse(textBox1.Text);
             p.Apellido = textBox3.Text;

        }
        private void UI_Profesores_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ins
            Assing();
            ex = new BLL_Profes();
            ex.Insert(p);
            Loade();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //upd
            Assing();
            ex = new BLL_Profes();
            ex.Update(p);
            Loade();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //delete
            Assing();
            ex = new BLL_Profes();
            ex.Delete(p);
            Loade();
        }
    }
}
