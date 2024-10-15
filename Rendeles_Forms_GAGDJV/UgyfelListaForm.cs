using Microsoft.EntityFrameworkCore;
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


    public partial class UgyfelListaForm : Form
    {
        private RendelesDbContext _context;
        private BindingList<Ugyfel> ugyfelBindingList;
        public UgyfelListaForm()
        {
            InitializeComponent();
            _context = new RendelesDbContext();
        }

        private void UgyfelListaForm_Load(object sender, EventArgs e)
        {
            _context.Ugyfel.Load();
            ugyfelBindingList = _context.Ugyfel.Local.ToBindingList();
            ugyfelBindingSource.DataSource = ugyfelBindingList;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string filterString = textBox1.Text.ToLower();
            ugyfelBindingSource.DataSource = from u in ugyfelBindingList
                                             where u.Nev.ToLower().Contains(filterString) ||
                                             u.Email.ToLower().Contains(filterString) ||
                                             (u.Telefonszam != null && u.Telefonszam.Contains(filterString))
                                             orderby u.UgyfelId
                                             select u;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UgyfelSzerkesztesForm ujUgyfelForm = new UgyfelSzerkesztesForm();
            if (ujUgyfelForm.ShowDialog() == DialogResult.OK)
            {
                ugyfelBindingList.Add(ujUgyfelForm.SzerkesztettÜgyfél);
                Mentés();
            }
        }
        void Mentés()
        {
            try
            {
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ugyfelBindingSource.Current is Ugyfel selectedUgyfel)
            {
                // Az eredeti adatok mentése esetleges visszaállításhoz
                var eredetiUgyfel = _context.Entry(selectedUgyfel).OriginalValues.Clone();

                // Megnyitjuk a szerkesztő űrlapot, és átadjuk a kiválasztott ügyfél adatait
                using (var szerkesztesForm = new UgyfelSzerkesztesForm(selectedUgyfel))
                {
                    // Ellenőrizzük, hogy az űrlapot OK gombbal zárták-e be
                    if (szerkesztesForm.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            // Ha OK gombot nyomtak, a változtatásokat elmentjük
                            Mentés();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Hiba történt a mentés során: {ex.Message}", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        // Ha a felhasználó mégsem gombot nyom, visszaállítjuk az eredeti adatokat
                        _context.Entry(selectedUgyfel).CurrentValues.SetValues(eredetiUgyfel);
                        _context.Ugyfel.Load();
                    }
                }
            }
            else
            {
                MessageBox.Show("Kérjük, válasszon ki egy ügyfelet a szerkesztéshez.", "Nincs kiválasztott ügyfél", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Ellenőrizzük, hogy van-e kiválasztott ügyfél
            if (ugyfelBindingSource.Current is Ugyfel selectedUgyfel)
            {
                // Megerősítő üzenet megjelenítése a felhasználónak
                var confirmation = MessageBox.Show($"Biztosan törölni szeretné az ügyfelet: {selectedUgyfel.Nev}?",
                                                   "Megerősítés",
                                                   MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Warning);

                // Ha a felhasználó megerősíti a törlést
                if (confirmation == DialogResult.Yes)
                {
                    try
                    {
                        // Az ügyfél eltávolítása a BindingSource-ból
                        ugyfelBindingSource.RemoveCurrent();

                        // A változások elmentése az adatbázisban
                        Mentés();
                    }
                    catch (Exception ex)
                    {
                        // Hiba esetén értesítjük a felhasználót
                        MessageBox.Show($"Hiba történt a törlés során: {ex.Message}", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Kérjük, válasszon ki egy ügyfelet a törléshez.", "Nincs kiválasztott ügyfél", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
