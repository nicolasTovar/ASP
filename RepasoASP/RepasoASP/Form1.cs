using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RepasoASP
{
    public partial class Form1 : Form
    {
        int resultado = +1;
        int guardar;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtMostrar.Text = "1";
        }

        private void btnIncrementar_Click(object sender, EventArgs e)
        {
            guardar = guardar + resultado;
            txtMostrar.Text = guardar.ToString();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
