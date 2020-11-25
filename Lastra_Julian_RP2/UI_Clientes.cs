using BE_Propiedades;
using BLL_Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lastra_Julian_RP2
{
    public partial class UI_Clientes : Form
    {
        public UI_Clientes()
        {
            InitializeComponent();
            Loade();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool a = Validate();
            if (a)
            {
                Assing();
                exec = new BLL_Clientes();
                exec.Insert(cliente);
                Loade();
            }
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

        public void Loade()
        {
            exec = new BLL_Clientes();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = exec.Listar(); 
        }

        private void UI_Clientes_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Update
            bool a = Validate();
            if (a)
            {
                Assing();
                exec = new BLL_Clientes();
                exec.Update(cliente);
                Loade();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Delte
            bool a = Validate();
            if (a)
            {
                Assing();
                exec = new BLL_Clientes();
                exec.Delete(cliente);
                Loade();
            }
        }

        //PASAR AL BLL.
        public bool Validate()
        {
            bool d1;
            bool ok = false;

            //1.Nombre
            if (textBox2.Text.Length > 0)
            {
                d1 = Regex.IsMatch(textBox2.Text, "^([a-zA-Z]+$)");
                if (d1)
                    ok = true;

                else
                  ok = false;
                
            }

            //2.Apellido
            if (textBox4.Text.Length > 0)
            {
                d1 = Regex.IsMatch(textBox3.Text, "^([a-zA-Z]+$)");
                if (d1)
                    ok = true;

                else
                    ok = false;

            }

            //3.Fecha Nacimiento
            d1 = Regex.IsMatch(textBox4.Text, "^([0][1-9]|[12][0-9]|3[01])(\\/|-)([0][1-9]|[1][0-2])\\2(\\d{4})$");
            if (d1)
                ok = true;

            else
           ok = false;

            //4.Clase 
            if (textBox4.Text.Length > 0)
            {
                d1 = Regex.IsMatch(textBox3.Text, "^([a-zA-Z]+$)");
                if (d1)
                    ok = true;

                else
                    ok = false;

            }

            //5.Costo
            d1 = Regex.IsMatch(textBox7.Text, "^([0-9]+$)");
            if (d1)
                ok = true;

            else
                ok = false;

            //6.DNI
            d1 = Regex.IsMatch(textBox1.Text, "^([0-9]+$)");
            if (d1)
                ok = true;

            else
                ok = false;

            //7.Correo


            //Return
            return ok;
        }
    }
}
