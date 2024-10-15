using Microsoft.EntityFrameworkCore;
using Rendeles_Forms_GAGDJV.Data;
using Rendeles_Forms_GAGDJV.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rendeles_Forms_GAGDJV
{
    public partial class UgyfelSzerkesztesForm : Form
    {
        public Ugyfel SzerkesztettÜgyfél { get; set; }
        private RendelesDbContext _context;


        public UgyfelSzerkesztesForm(Ugyfel ugyfel = null)
        {
            InitializeComponent();
            this.SzerkesztettÜgyfél = ugyfel ?? new Ugyfel();
            ugyfelBindingSource.DataSource = SzerkesztettÜgyfél;
            _context = new RendelesDbContext();



        }



        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            Regex rgxNev = new Regex(@"^[\p{L} .'-]+$");

            if (!rgxNev.IsMatch(textBox1.Text))
            {
                errorProvider1.SetError(textBox1, "A név csak kis- és nagybetűket jeleníthet meg.");
                e.Cancel = true;
            }
            else
            {
                //Ha nincs hiba, eltüntetjük a hibaüzenetet
                errorProvider1.SetError(textBox1, "");
            }
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            Regex rgxEmail = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.IgnoreCase);

            if (!rgxEmail.IsMatch(textBox2.Text))
            {
                // Hiba megjelenítése, ha az email cím nem érvényes
                errorProvider1.SetError(textBox2, "Érvényes email címet adjon meg.");
                e.Cancel = true;  // Megakadályozza a fókuszváltást
            }
            else
            {
                // Ha nincs hiba, eltüntetjük a hibaüzenetet
                errorProvider1.SetError(textBox2, "");
            }
        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            Regex rgxTelefon = new Regex(@"^\+36(?:20|30|31|50|70)(\d{7})$");

            if (!rgxTelefon.IsMatch(textBox3.Text))
            {
                // Hiba megjelenítése, ha a telefonszám nem érvényes
                errorProvider1.SetError(textBox3, "Érvényes magyar mobilszámot adjon meg. Formátum: +36 XX XXXXXX.");
                e.Cancel = true;  // Megakadályozza a fókuszváltást
            }
            else
            {
                // Ha nincs hiba, eltüntetjük a hibaüzenetet
                errorProvider1.SetError(textBox3, "");
                e.Cancel = false;
            }
        }

        private void UgyfelSzerkesztesForm_Load(object sender, EventArgs e)
        {
            var cimLista = _context.Cim.ToList(); // _context az adatbázis kontextus

            // ComboBox feltöltése címadatokkal
            comboBox1.DataSource = cimLista;
            comboBox1.DisplayMember = "Utca";  // A cím neve, amit a felhasználó látni fog
            comboBox1.ValueMember = "CimId"; // A kiválasztott cím ID-ja
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                comboBox1.Enabled = true;
                textBox4.Enabled = false;
                textBox5.Enabled = false;
                textBox6.Enabled = false;
                textBox7.Enabled = false;
                textBox8.Enabled = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox4.Enabled = true;
            textBox5.Enabled = true;
            textBox6.Enabled = true;
            textBox7.Enabled = true;
            textBox8.Enabled = true;
            comboBox1.Enabled = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Kérjük, javítsa a hibás mezőket!");
                return;
            }

            try
            {
                if (radioButton2.Checked) // Ellenőrizzük, hogy az "Új cím" van-e kiválasztva
                {
                    // Új cím létrehozása
                    var ujCim = new Cim
                    {
                        Utca = textBox4.Text,
                        Hazszam = textBox5.Text,
                        Varos = textBox6.Text,
                        Iranyitoszam = textBox7.Text,
                        Orszag = textBox8.Text
                    };

                    // Cím mentése az adatbázisba
                    _context.Cim.Add(ujCim); // Hozzáadjuk az új címet az adatbázishoz
                    _context.SaveChanges(); // Mentés

                    // Az új cím ID-ját hozzárendelheted az ügyfélhez
                    SzerkesztettÜgyfél.LakcimId = ujCim.CimId; // Használj LakcimId-t a CimId helyett
                }
                else if (radioButton1.Checked) // Ha meglévő cím van kiválasztva
                {
                    // A kiválasztott cím ID-jának lekérdezése
                    SzerkesztettÜgyfél.LakcimId = (int)comboBox1.SelectedValue; // A ComboBox választott értéke
                }

                // Az ügyfél adatok mentése
                ugyfelBindingSource.EndEdit();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hiba történt a mentés során: {ex.Message}");
            }
        }

        private void textBox4_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox4.Text))
            {
                errorProvider1.SetError(textBox4, "Az utca mező nem lehet üres.");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(textBox4, "");
            }
        }

        private void textBox5_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox5.Text))
            {
                errorProvider1.SetError(textBox5, "A házszám mező nem lehet üres.");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(textBox5, "");
            }
        }

        private void textBox6_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox6.Text))
            {
                errorProvider1.SetError(textBox6, "A város mező nem lehet üres.");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(textBox6, "");
            }
        }

        private void textBox7_Validating(object sender, CancelEventArgs e)
        {
            Regex rgxIranyitoszam = new Regex(@"^\d{4}$"); // Irányítószám formátuma (4 számjegy)

            if (!rgxIranyitoszam.IsMatch(textBox7.Text))
            {
                errorProvider1.SetError(textBox7, "Érvényes irányítószámot adjon meg (4 számjegy).");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(textBox7, "");
            }
        }

        private void textBox8_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox8.Text))
            {
                errorProvider1.SetError(textBox8, "Az ország mező nem lehet üres.");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(textBox8, "");
            }
        }
    }
}
