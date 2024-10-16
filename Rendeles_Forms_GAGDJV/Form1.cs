using Rendeles_Forms_GAGDJV.Data;
using Rendeles_Forms_GAGDJV.Models;

namespace Rendeles_Forms_GAGDJV
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();


        }



        private void button5_Click(object sender, EventArgs e)
        {
            TermekKategoriaForm termekKategoriaForm = new TermekKategoriaForm();
            termekKategoriaForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UgyfelForm ugyfel = new UgyfelForm();
            ugyfel.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UgyfelListaForm ugyfelListaForm = new UgyfelListaForm();
            ugyfelListaForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RendelesForm rendelesForm = new RendelesForm();
            rendelesForm.ShowDialog();

        }
    }
}
