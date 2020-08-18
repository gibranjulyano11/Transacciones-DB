using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transacciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ConexionPgsql conectandoseBD = new ConexionPgsql();

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = conectandoseBD.Consultar();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                conectandoseBD.Transferir(textBox1.Text, textBox2.Text, Convert.ToInt32(textBox3.Text));
            }
            catch (Exception)
            {
                MessageBox.Show("Debe ingresar los datos correctamente.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
