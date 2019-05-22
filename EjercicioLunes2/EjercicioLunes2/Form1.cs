using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioLunes2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int contador;
        private void Button1_Click(object sender, EventArgs e)
        {
            Operaciones resultado = new Operaciones();

            label1.Text = resultado.Sumar().ToString();

        }
        
        private void Button2_Click(object sender, EventArgs e)
        {
            label2.Text = contador++.ToString();
        }
    }
}
