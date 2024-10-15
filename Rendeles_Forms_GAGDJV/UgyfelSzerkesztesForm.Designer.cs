
namespace Rendeles_Forms_GAGDJV
{
    partial class UgyfelSzerkesztesForm
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
            textBox1 = new TextBox();
            ugyfelBindingSource = new BindingSource(components);
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            comboBox1 = new ComboBox();
            radioButton1 = new RadioButton();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            radioButton2 = new RadioButton();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)ugyfelBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.DataBindings.Add(new Binding("Text", ugyfelBindingSource, "Nev", true));
            textBox1.Location = new Point(97, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(328, 31);
            textBox1.TabIndex = 0;
            textBox1.Validating += textBox1_Validating;
            // 
            // ugyfelBindingSource
            // 
            ugyfelBindingSource.DataSource = typeof(Models.Ugyfel);
            // 
            // textBox2
            // 
            textBox2.DataBindings.Add(new Binding("Text", ugyfelBindingSource, "Email", true));
            textBox2.Location = new Point(97, 74);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(328, 31);
            textBox2.TabIndex = 1;
            textBox2.Validating += textBox2_Validating;
            // 
            // textBox3
            // 
            textBox3.DataBindings.Add(new Binding("Text", ugyfelBindingSource, "Telefonszam", true));
            textBox3.Location = new Point(97, 128);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(328, 31);
            textBox3.TabIndex = 2;
            textBox3.Validated += textBox3_Validated;
            // 
            // comboBox1
            // 
            comboBox1.DataBindings.Add(new Binding("SelectedItem", ugyfelBindingSource, "Lakcim", true));
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(101, 200);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(229, 33);
            comboBox1.TabIndex = 3;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(104, 165);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(141, 29);
            radioButton1.TabIndex = 4;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(97, 296);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(328, 31);
            textBox4.TabIndex = 5;
            textBox4.Validating += textBox4_Validating;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(97, 345);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(328, 31);
            textBox5.TabIndex = 6;
            textBox5.Validating += textBox5_Validating;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(101, 391);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(328, 31);
            textBox6.TabIndex = 7;
            textBox6.Validating += textBox6_Validating;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(104, 441);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(328, 31);
            textBox7.TabIndex = 8;
            textBox7.Validating += textBox7_Validating;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(104, 491);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(328, 31);
            textBox8.TabIndex = 9;
            textBox8.Validating += textBox8_Validating;
            // 
            // button1
            // 
            button1.Location = new Point(599, 317);
            button1.Name = "button1";
            button1.Size = new Size(209, 34);
            button1.TabIndex = 10;
            button1.Text = "Új elem hozzáadás";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(599, 372);
            button2.Name = "button2";
            button2.Size = new Size(209, 34);
            button2.TabIndex = 11;
            button2.Text = "Mégse";
            button2.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(97, 251);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(141, 29);
            radioButton2.TabIndex = 12;
            radioButton2.TabStop = true;
            radioButton2.Text = "radioButton2";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // UgyfelSzerkesztesForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(940, 565);
            Controls.Add(radioButton2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(radioButton1);
            Controls.Add(comboBox1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "UgyfelSzerkesztesForm";
            Text = "UgyfelSzerkesztesForm";
            Load += UgyfelSzerkesztesForm_Load;
            ((System.ComponentModel.ISupportInitialize)ugyfelBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void textBox3_Validated(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private ComboBox comboBox1;
        private RadioButton radioButton1;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private Button button1;
        private Button button2;
        private BindingSource ugyfelBindingSource;
        private RadioButton radioButton2;
        private ErrorProvider errorProvider1;
    }
}