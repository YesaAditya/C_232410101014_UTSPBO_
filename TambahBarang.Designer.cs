﻿namespace C_232410101014_UTSPBO_
{
    partial class TambahBarang
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(203, 109);
            label1.Name = "label1";
            label1.Size = new Size(117, 25);
            label1.TabIndex = 0;
            label1.Text = "NamaBArang";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(203, 178);
            label2.Name = "label2";
            label2.Size = new Size(78, 25);
            label2.TabIndex = 1;
            label2.Text = "Kategori";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(203, 249);
            label3.Name = "label3";
            label3.Size = new Size(67, 25);
            label3.TabIndex = 2;
            label3.Text = "Jumlah";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(203, 309);
            label4.Name = "label4";
            label4.Size = new Size(60, 25);
            label4.TabIndex = 3;
            label4.Text = "Harga";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(388, 109);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(228, 31);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(388, 178);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(228, 31);
            textBox2.TabIndex = 5;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(388, 249);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(228, 31);
            textBox3.TabIndex = 6;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(388, 309);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(228, 31);
            textBox4.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(504, 370);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 8;
            button1.Text = "Simpan";
            button1.UseVisualStyleBackColor = true;
            // 
            // TambahBarang
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "TambahBarang";
            Text = "TambahBarang";
            Load += TambahBarang_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button1;
    }
}