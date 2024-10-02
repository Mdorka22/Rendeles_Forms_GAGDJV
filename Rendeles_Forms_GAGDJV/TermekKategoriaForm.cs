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
using System.Xml.Linq;

namespace Rendeles_Forms_GAGDJV
{
    public partial class TermekKategoriaForm : Form
    {
        RendelesDbContext _context = new RendelesDbContext();
        public TermekKategoriaForm()
        {
            InitializeComponent();
            LoadKategoriak();
        }
        private void LoadKategoriak()
        {
            try
            {
                // Az összes kategória lekérdezése az adatbázisból
                var kategoriak = (from k in _context.TermekKategoria
                                  select k).ToList();

                // TreeView tartalmának törlése
                treeViewKategoriak.Nodes.Clear();

                // Főkategóriák hozzáadása a TreeView-hoz
                var fokategoriak = from k in kategoriak
                                   where k.SzuloKategoriaId == null
                                   select k;

                foreach (var kategoria in fokategoriak)
                {
                    var node = CreateTreeNode(kategoria, kategoriak);
                    treeViewKategoriak.Nodes.Add(node);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Hiba történt a kategóriák betöltése során");
            }

        }
        private TreeNode CreateTreeNode(TermekKategoria kategoria, List<TermekKategoria> osszeKategoria)
        {
            // TreeNode létrehozása az aktuális kategóriához
            var node = new TreeNode(kategoria.Nev) { Tag = kategoria };

            // Alkategóriák keresése és hozzáadása
            var alkategoriak = from k in osszeKategoria
                               where k.SzuloKategoriaId == kategoria.KategoriaId
                               select k;

            foreach (var gyerekKategoria in alkategoriak)
            {
                node.Nodes.Add(CreateTreeNode(gyerekKategoria, osszeKategoria));
            }

            return node;
        }

        private void átnevezésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeViewKategoriak.SelectedNode != null)
            {
                treeViewKategoriak.SelectedNode.BeginEdit();
            }

        }

        private void treeViewKategoriak_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            if (e.Label != null && !string.IsNullOrEmpty(e.Label))
            {
                try
                {
                    TermekKategoria termekKategoria = (TermekKategoria)e.Node.Tag;
                    termekKategoria.Nev = e.Label;
                    _context.SaveChanges();
                }
                catch (Exception)
                {

                    MessageBox.Show("Hiba történt az átnevezés során");
                }

            }
        }

        private void frissítésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadKategoriak();
        }

        private void újFőkategóriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                TermekKategoria termekKategoria = new TermekKategoria();
                termekKategoria.Nev = " Új kategória";
                termekKategoria.SzuloKategoriaId = null;
                _context.TermekKategoria.Add(termekKategoria);
                _context.SaveChanges();

                TreeNode node = new TreeNode(termekKategoria.Nev);
                node.Tag = termekKategoria;
                treeViewKategoriak.Nodes.Add(node);
                treeViewKategoriak.SelectedNode = node;
            }
            catch (Exception)
            {

                MessageBox.Show("Hiba történt az új főkategória hozzáadása közben");
            }



        }

        private void újAlkategóraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                TermekKategoria termekKategoria = new TermekKategoria();
                termekKategoria.Nev = "Új kategória";
                termekKategoria.SzuloKategoriaId = ((TermekKategoria)treeViewKategoriak.SelectedNode.Tag).KategoriaId;
                _context.TermekKategoria.Add(termekKategoria);
                _context.SaveChanges();

                TreeNode node = new TreeNode(termekKategoria.Nev);
                node.Tag = termekKategoria;
                treeViewKategoriak.SelectedNode.Nodes.Add(node);

                treeViewKategoriak.SelectedNode = node;
            }
            catch (Exception)
            {

                MessageBox.Show("Hiba történt az új alkategória hozzáadása közben");
            }



        }

        private void törlésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeViewKategoriak.SelectedNode.Nodes.Count == 0)
            {
                try
                {
                    TermekKategoria kategoria = (TermekKategoria)treeViewKategoriak.SelectedNode.Tag;
                    _context.TermekKategoria.Remove(kategoria);
                    _context.SaveChanges();

                    treeViewKategoriak.SelectedNode.Remove();
                }
                catch (Exception)
                {

                    MessageBox.Show("Hiba történt a kategória törlése közben");
                }


            }
            else
            {
                MessageBox.Show("Nem törölhető kategória, mert van alkategóriája");
            }


        }
        private void treeViewKategoriak_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                treeViewKategoriak.SelectedNode = e.Node;
                contextMenuStrip1.Show(treeViewKategoriak, e.Location);
            }
        }

        private void treeViewKategoriak_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                if (e.Node != null)
                {
                    var kivalasztottTermekKategoria = (TermekKategoria)e.Node.Tag;
                    var termekek = from k in _context.Termek
                                   where k.KategoriaId == kivalasztottTermekKategoria.KategoriaId
                                   select k;
                    dataGridView1.DataSource = termekek.ToList();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hiba történt az adatok betöltése során" + ex.Message);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            XDocument xdoc = new XDocument();

            XDeclaration xdecl = new XDeclaration("1.0", "utf-8", "yes");
            xdoc.Declaration = xdecl;

            XElement root = new XElement("gyökér");
            xdoc.Add(root);

            //LINQ
            //Foreach
            //new XELEMENT
            //attrib
            //root.Add(xx)
            var kat = (from k in _context.TermekKategoria
                              select k).ToList();
            var fokategoriak = from k in kat
                               where k.SzuloKategoriaId == null
                               select k;

            foreach (var f in fokategoriak)
            {

                XElement node = new XElement("kategoria");
                node.SetAttributeValue("nev", f.Nev);
                node.SetAttributeValue("id", f.KategoriaId);
                var alkategoriak = from k in kat
                                   where k.SzuloKategoriaId == f.KategoriaId
                                   select k;
                foreach(var al in alkategoriak)
                {
                    XElement alKat = new XElement("alkategoria");
                    alKat.SetAttributeValue("nev", al.Nev);
                    alKat.SetAttributeValue("id", al.KategoriaId);
                    node.Add(alKat);
                }

                root.Add(node); 
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                   
                    xdoc.Save(saveFileDialog.FileName);
                    MessageBox.Show("Sikeres mentés");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hiba a fájl mentése közben: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }
    }
}
