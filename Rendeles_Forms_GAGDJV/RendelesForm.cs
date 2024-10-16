using Rendeles_Forms_GAGDJV.Data;
using Rendeles_Forms_GAGDJV.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rendeles_Forms_GAGDJV
{
    public partial class RendelesForm : Form
    {
        private readonly RendelesDbContext _context;
        public RendelesForm()
        {
            InitializeComponent();
            _context = new RendelesDbContext();
        }

        private void RendelesForm_Load(object sender, EventArgs e)
        {
            LoadUgyfelek();
            LoadCimek();
            LoadRendelesek();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            LoadUgyfelek();
        }
        private void LoadUgyfelek()
        {
            var q = from x in _context.Ugyfel
                    where x.Nev.Contains(txtSzuro.Text) || x.Email.Contains(txtSzuro.Text)
                    orderby x.Nev
                    select x;

            ugyfelBindingSource.DataSource = q.ToList();

            ugyfelBindingSource.ResetCurrentItem();
        }

        private void LoadCimek()
        {
            var q = from x in _context.Cim
                    select new CimEgybenDTO
                    {
                        CimId = x.CimId,
                        CimEgyben = $"{x.Iranyitoszam}-{x.Varos}, {x.Orszag}: {x.Utca} {x.Hazszam}"
                    };

            cimEgybenDTOBindingSource.DataSource = q.ToList();
            cimEgybenDTOBindingSource.ResetCurrentItem();


        }
        private void LoadRendelesek()
        {
            if (ugyfelBindingSource.Current == null) return;
            dataGridView1.DataSource = null;
            var rendeles = from x in _context.Rendeles
                           where x.UgyfelId == ((Ugyfel)ugyfelBindingSource.Current).UgyfelId
                           select x;
            rendelesBindingSource.DataSource = rendeles.ToList();
            lbRendeles.DataSource = rendelesBindingSource;
            if (lbRendeles.Items.Count > 0)
            {
                lbRendeles.SelectedIndex = 0;
            }
            rendelesBindingSource.ResetCurrentItem();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadRendelesek();
        }
        private void LoadRendelesTetel()
        {
            if (rendelesBindingSource.Current == null) return;

            var q = from rt in _context.RendelesTetel
                    where rt.RendelesId == ((Rendeles)rendelesBindingSource.Current).RendelesId
                    select new RendelesTetelDTO
                    {
                        TetelId = rt.TetelId,
                        TermekNev = rt.Termek.Nev,
                        Mennyiseg = rt.Mennyiseg,
                        EgysegAr = rt.EgysegAr,
                        Afa = rt.Afa,
                        NettoAr = rt.NettoAr,
                        BruttoAr = rt.BruttoAr
                    };

            dataGridView1.DataSource = q.ToList();
            // UpdateVegosszeg(); ez egyelőre maradjon kommentelve, később implementáljuk
        }

        private void lbRendeles_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadRendelesTetel();
        }
    }


}
