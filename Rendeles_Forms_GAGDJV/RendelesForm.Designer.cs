namespace Rendeles_Forms_GAGDJV
{
    partial class RendelesForm
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
            listBox1 = new ListBox();
            ugyfelBindingSource = new BindingSource(components);
            listBox2 = new ListBox();
            termekBindingSource = new BindingSource(components);
            lbRendeles = new ListBox();
            rendelesBindingSource = new BindingSource(components);
            txtSzuro = new TextBox();
            dataGridView1 = new DataGridView();
            comboBox1 = new ComboBox();
            cimEgybenDTOBindingSource = new BindingSource(components);
            comboBox2 = new ComboBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)ugyfelBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)termekBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rendelesBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cimEgybenDTOBindingSource).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.DataSource = ugyfelBindingSource;
            listBox1.DisplayMember = "Nev";
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 153);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(224, 409);
            listBox1.TabIndex = 0;
            listBox1.ValueMember = "UgyfelId";
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // ugyfelBindingSource
            // 
            ugyfelBindingSource.DataSource = typeof(Models.Ugyfel);
            // 
            // listBox2
            // 
            listBox2.DataSource = termekBindingSource;
            listBox2.DisplayMember = "Nev";
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(1116, 151);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(255, 409);
            listBox2.TabIndex = 1;
            listBox2.ValueMember = "TermekId";
            // 
            // termekBindingSource
            // 
            termekBindingSource.DataSource = typeof(Models.Termek);
            // 
            // lbRendeles
            // 
            lbRendeles.DataSource = rendelesBindingSource;
            lbRendeles.DisplayMember = "RendelesDatum";
            lbRendeles.FormattingEnabled = true;
            lbRendeles.ItemHeight = 15;
            lbRendeles.Location = new Point(242, 152);
            lbRendeles.Name = "lbRendeles";
            lbRendeles.Size = new Size(255, 409);
            lbRendeles.TabIndex = 2;
            lbRendeles.ValueMember = "RendelesId";
            lbRendeles.SelectedIndexChanged += lbRendeles_SelectedIndexChanged;
            // 
            // rendelesBindingSource
            // 
            rendelesBindingSource.DataSource = typeof(Models.Rendeles);
            // 
            // txtSzuro
            // 
            txtSzuro.Location = new Point(32, 88);
            txtSzuro.Name = "txtSzuro";
            txtSzuro.Size = new Size(255, 23);
            txtSzuro.TabIndex = 3;
            txtSzuro.TextChanged += textBox1_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(503, 151);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(502, 410);
            dataGridView1.TabIndex = 4;
            // 
            // comboBox1
            // 
            comboBox1.DataSource = cimEgybenDTOBindingSource;
            comboBox1.DisplayMember = "CimEgyben";
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(331, 108);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(408, 23);
            comboBox1.TabIndex = 5;
            comboBox1.ValueMember = "CimId";
            // 
            // cimEgybenDTOBindingSource
            // 
            cimEgybenDTOBindingSource.DataSource = typeof(Models.CimEgybenDTO);
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(937, 104);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(167, 23);
            comboBox2.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(763, 108);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(138, 23);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(1018, 311);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(91, 23);
            textBox3.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(242, 576);
            button1.Name = "button1";
            button1.Size = new Size(126, 23);
            button1.TabIndex = 9;
            button1.Text = "Új rendelés";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(803, 576);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 10;
            button2.Text = "Mentés";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(897, 576);
            button3.Name = "button3";
            button3.Size = new Size(108, 23);
            button3.TabIndex = 11;
            button3.Text = "Excel export";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(1030, 364);
            button4.Name = "button4";
            button4.Size = new Size(75, 48);
            button4.TabIndex = 12;
            button4.Text = "Tétel hozzáadás";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(1029, 430);
            button5.Name = "button5";
            button5.Size = new Size(75, 48);
            button5.TabIndex = 13;
            button5.Text = "Tétel törlése";
            button5.UseVisualStyleBackColor = true;
            // 
            // RendelesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1383, 611);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(dataGridView1);
            Controls.Add(txtSzuro);
            Controls.Add(lbRendeles);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Name = "RendelesForm";
            Text = "RendelesForm";
            Load += RendelesForm_Load;
            ((System.ComponentModel.ISupportInitialize)ugyfelBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)termekBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)rendelesBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)cimEgybenDTOBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private ListBox listBox2;
        private ListBox lbRendeles;
        private TextBox txtSzuro;
        private DataGridView dataGridView1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private BindingSource ugyfelBindingSource;
        private BindingSource termekBindingSource;
        private BindingSource cimEgybenDTOBindingSource;
        private BindingSource rendelesBindingSource;
    }
}