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
            UgyfelForm ugyfel=new UgyfelForm();
        }
    }
}
