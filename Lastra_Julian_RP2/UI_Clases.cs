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
    public partial class UI_Clases : Form
    {
        public UI_Clases()
        {
            InitializeComponent();
            Loade();
        //    listBox1.DataSource = x.Read();
        //    listBox1.DisplayMember = "Profesor";
        }

        private void UI_Clases_Load(object sender, EventArgs e)
        {

        }

        public Clase clase;
        public BLL_Clase bc;

        public void Assing()
        {
            clase = new Clase();

            clase.Descripcion = textBox1.Text;
            //clase.Profesor.DNI = Int32.Parse(textBox2.Text);
            clase.Turno = textBox3.Text;
            clase.Dia = textBox4.Text;
            clase.Cantidad = Int32.Parse(textBox5.Text);
            //clase.Profesor.DNI = Int32.Parse(comboBox1.SelectedItem.ToString());
        }
        public void Loade()
        {
            bc = new BLL_Clase();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = bc.Listar();
            var a = bc.Listar();
            foreach (var item in a)
            {
                comboBox1.Items.Add(item.Profesor);
            }

            comboBox1.DisplayMember = "DNI";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //Inser
            Assing();
            bc = new BLL_Clase();
            bc.Insert(clase);

            //Inserto en el XML Tambien.
            x.Write(clase.Descripcion,textBox2.Text,clase.Dia,clase.Turno);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //update
            Assing();
            bc = new BLL_Clase();
            bc.Update(clase);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Delete
            Assing();
            bc = new BLL_Clase();
            bc.Delete(clase);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        public XML x = new XML();

        private void button5_Click(object sender, EventArgs e)
        {
            //x.Write();
            x.Create("","","","");
        }
    }
}
