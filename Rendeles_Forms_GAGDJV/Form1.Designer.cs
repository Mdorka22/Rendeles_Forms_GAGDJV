namespace Rendeles_Forms_GAGDJV
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ugyfelBindingSource1 = new BindingSource(components);
            ugyfelBindingSource = new BindingSource(components);
            button5 = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)ugyfelBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ugyfelBindingSource).BeginInit();
            SuspendLayout();
            // 
            // ugyfelBindingSource1
            // 
            ugyfelBindingSource1.DataSource = typeof(Models.Ugyfel);
            // 
            // button5
            // 
            button5.Location = new Point(24, 28);
            button5.Name = "button5";
            button5.Size = new Size(244, 34);
            button5.TabIndex = 5;
            button5.Text = "Termékkategóriák kezelése";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button1
            // 
            button1.Location = new Point(24, 94);
            button1.Name = "button1";
            button1.Size = new Size(244, 34);
            button1.TabIndex = 6;
            button1.Text = "UgyfelForm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(button5);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)ugyfelBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ugyfelBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private BindingSource ugyfelBindingSource;
        private Button button5;
        private BindingSource ugyfelBindingSource1;
        private Button button1;
    }
}
