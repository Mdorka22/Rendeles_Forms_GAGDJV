namespace Rendeles_Forms_GAGDJV
{
    partial class TermekKategoriaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            treeViewKategoriak = new TreeView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            átnevezésToolStripMenuItem = new ToolStripMenuItem();
            újFőkategóriaToolStripMenuItem = new ToolStripMenuItem();
            újAlkategóraToolStripMenuItem = new ToolStripMenuItem();
            törlésToolStripMenuItem = new ToolStripMenuItem();
            frissítésToolStripMenuItem = new ToolStripMenuItem();
            txtNev = new TextBox();
            txtLeiras = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            dataGridView1 = new DataGridView();
            button5 = new Button();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // treeViewKategoriak
            // 
            treeViewKategoriak.ContextMenuStrip = contextMenuStrip1;
            treeViewKategoriak.LabelEdit = true;
            treeViewKategoriak.Location = new Point(33, 25);
            treeViewKategoriak.Margin = new Padding(2, 2, 2, 2);
            treeViewKategoriak.Name = "treeViewKategoriak";
            treeViewKategoriak.Size = new Size(129, 164);
            treeViewKategoriak.TabIndex = 0;
            treeViewKategoriak.AfterLabelEdit += treeViewKategoriak_AfterLabelEdit;
            treeViewKategoriak.AfterSelect += treeViewKategoriak_AfterSelect;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { átnevezésToolStripMenuItem, újFőkategóriaToolStripMenuItem, újAlkategóraToolStripMenuItem, törlésToolStripMenuItem, frissítésToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(149, 114);
            // 
            // átnevezésToolStripMenuItem
            // 
            átnevezésToolStripMenuItem.Name = "átnevezésToolStripMenuItem";
            átnevezésToolStripMenuItem.Size = new Size(148, 22);
            átnevezésToolStripMenuItem.Text = "Átnevezés";
            átnevezésToolStripMenuItem.Click += átnevezésToolStripMenuItem_Click;
            // 
            // újFőkategóriaToolStripMenuItem
            // 
            újFőkategóriaToolStripMenuItem.Name = "újFőkategóriaToolStripMenuItem";
            újFőkategóriaToolStripMenuItem.Size = new Size(148, 22);
            újFőkategóriaToolStripMenuItem.Text = "Új főkategória";
            újFőkategóriaToolStripMenuItem.Click += újFőkategóriaToolStripMenuItem_Click;
            // 
            // újAlkategóraToolStripMenuItem
            // 
            újAlkategóraToolStripMenuItem.Name = "újAlkategóraToolStripMenuItem";
            újAlkategóraToolStripMenuItem.Size = new Size(148, 22);
            újAlkategóraToolStripMenuItem.Text = "Új alkategóra";
            újAlkategóraToolStripMenuItem.Click += újAlkategóraToolStripMenuItem_Click;
            // 
            // törlésToolStripMenuItem
            // 
            törlésToolStripMenuItem.Name = "törlésToolStripMenuItem";
            törlésToolStripMenuItem.Size = new Size(148, 22);
            törlésToolStripMenuItem.Text = "Törlés";
            törlésToolStripMenuItem.Click += törlésToolStripMenuItem_Click;
            // 
            // frissítésToolStripMenuItem
            // 
            frissítésToolStripMenuItem.Name = "frissítésToolStripMenuItem";
            frissítésToolStripMenuItem.Size = new Size(148, 22);
            frissítésToolStripMenuItem.Text = "Frissítés";
            frissítésToolStripMenuItem.Click += frissítésToolStripMenuItem_Click;
            // 
            // txtNev
            // 
            txtNev.Location = new Point(216, 25);
            txtNev.Margin = new Padding(2, 2, 2, 2);
            txtNev.Name = "txtNev";
            txtNev.Size = new Size(318, 23);
            txtNev.TabIndex = 1;
            // 
            // txtLeiras
            // 
            txtLeiras.Location = new Point(217, 62);
            txtLeiras.Margin = new Padding(2, 2, 2, 2);
            txtLeiras.Multiline = true;
            txtLeiras.Name = "txtLeiras";
            txtLeiras.Size = new Size(318, 142);
            txtLeiras.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(206, 215);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(78, 20);
            button1.TabIndex = 3;
            button1.Text = "Új testvér kat.";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(288, 215);
            button2.Margin = new Padding(2, 2, 2, 2);
            button2.Name = "button2";
            button2.Size = new Size(78, 20);
            button2.TabIndex = 4;
            button2.Text = "Új gyermek kat.";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(371, 215);
            button3.Margin = new Padding(2, 2, 2, 2);
            button3.Name = "button3";
            button3.Size = new Size(78, 20);
            button3.TabIndex = 5;
            button3.Text = "Mentés";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(455, 215);
            button4.Margin = new Padding(2, 2, 2, 2);
            button4.Name = "button4";
            button4.Size = new Size(78, 20);
            button4.TabIndex = 6;
            button4.Text = "Törlés";
            button4.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(20, 197);
            dataGridView1.Margin = new Padding(2, 2, 2, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(161, 65);
            dataGridView1.TabIndex = 7;
            // 
            // button5
            // 
            button5.Location = new Point(218, 255);
            button5.Name = "button5";
            button5.Size = new Size(138, 23);
            button5.TabIndex = 8;
            button5.Text = "XML mentése";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // TermekKategoriaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(613, 342);
            Controls.Add(button5);
            Controls.Add(dataGridView1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtLeiras);
            Controls.Add(txtNev);
            Controls.Add(treeViewKategoriak);
            Margin = new Padding(2, 2, 2, 2);
            Name = "TermekKategoriaForm";
            Text = "TermekKategoriaForm";
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView treeViewKategoriak;
        private TextBox txtNev;
        private TextBox txtLeiras;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem átnevezésToolStripMenuItem;
        private ToolStripMenuItem újFőkategóriaToolStripMenuItem;
        private ToolStripMenuItem újAlkategóraToolStripMenuItem;
        private ToolStripMenuItem törlésToolStripMenuItem;
        private ToolStripMenuItem frissítésToolStripMenuItem;
        private DataGridView dataGridView1;
        private Button button5;
    }
}