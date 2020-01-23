using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _Rosto;


namespace POO
{
    public partial class Form1 : Form
    {

        public Rosto MeuRosto { get; set; }

        public Form1()
        {
            InitializeComponent();

            MeuRosto = new Rosto();

            MeuRosto.Sorrir();

            Ajustar();
        }

        public void Ajustar()
        {
            button1.Text = MeuRosto.OlhoDireito.Estado;
            button2.Text = MeuRosto.OlhoEsquerdo.Estado;
            button4.Text = MeuRosto.Estado;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSorrir_Click(object sender, EventArgs e)
        {
            MeuRosto.Sorrir();

            Ajustar();
        }

        private void btnChorar_Click(object sender, EventArgs e)
        {
            MeuRosto.Chorar();

            Ajustar();
        }

        private void btnDesconfiar_Click(object sender, EventArgs e)
        {
            MeuRosto.Desconfiar();

            Ajustar();
        }
    }
}
