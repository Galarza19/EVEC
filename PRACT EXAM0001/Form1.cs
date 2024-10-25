using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRACT_EXAM0001
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Vectores v1, v2, v3;

        private void cargarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            v2.cargar(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text));
        }

        private void cargarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            v3.cargar(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text));
        }

        private void descargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox4.Text = v1.Descargar();
        }

        private void descargarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox5.Text = v2.Descargar();
        }

        private void descargarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            textBox6.Text = v3.Descargar();
        }

        private void ejercicio6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v1.ElimPrim();
            textBox7.Text = v1.Descargar();
        }

        private void eleYFrecToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v1.EleyFrec(v2, v3);
            textBox5.Text = v2.Descargar();
            textBox6.Text = v3.Descargar();
        }

        private void cargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v1.cargar(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            v1 = new Vectores();
            v2 = new Vectores();
            v3 = new Vectores();
        }
    }
}
