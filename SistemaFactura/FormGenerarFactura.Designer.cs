﻿namespace SistemaFactura
{
    partial class FormGenerarFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGenerarFactura));
            fileSystemWatcher1 = new FileSystemWatcher();
            panel1 = new Panel();
            label9 = new Label();
            tbNitCi = new TextBox();
            tbCodigoAuto = new TextBox();
            dtpFecha = new DateTimePicker();
            tbMonto = new TextBox();
            tbMontoImponible = new TextBox();
            textBox5 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            label7 = new Label();
            label8 = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Orange;
            panel1.Controls.Add(label9);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(534, 54);
            panel1.TabIndex = 0;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Orange;
            label9.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ControlLightLight;
            label9.Location = new Point(12, 9);
            label9.Name = "label9";
            label9.Size = new Size(82, 25);
            label9.TabIndex = 20;
            label9.Text = "Factura:";
            // 
            // tbNitCi
            // 
            tbNitCi.Location = new Point(249, 102);
            tbNitCi.Name = "tbNitCi";
            tbNitCi.Size = new Size(143, 23);
            tbNitCi.TabIndex = 1;
            // 
            // tbCodigoAuto
            // 
            tbCodigoAuto.Location = new Point(249, 141);
            tbCodigoAuto.Name = "tbCodigoAuto";
            tbCodigoAuto.Size = new Size(143, 23);
            tbCodigoAuto.TabIndex = 2;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(175, 186);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(217, 23);
            dtpFecha.TabIndex = 3;
            // 
            // tbMonto
            // 
            tbMonto.Location = new Point(249, 226);
            tbMonto.Name = "tbMonto";
            tbMonto.Size = new Size(143, 23);
            tbMonto.TabIndex = 4;
            // 
            // tbMontoImponible
            // 
            tbMontoImponible.Location = new Point(249, 268);
            tbMontoImponible.Name = "tbMontoImponible";
            tbMontoImponible.Size = new Size(143, 23);
            tbMontoImponible.TabIndex = 5;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(249, 309);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(143, 23);
            textBox5.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(81, 104);
            label1.Name = "label1";
            label1.Size = new Size(57, 21);
            label1.TabIndex = 8;
            label1.Text = "NIT/CI:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(81, 143);
            label2.Name = "label2";
            label2.Size = new Size(154, 21);
            label2.TabIndex = 9;
            label2.Text = "Codigo Autorización:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(81, 188);
            label3.Name = "label3";
            label3.Size = new Size(53, 21);
            label3.TabIndex = 10;
            label3.Text = "Fecha:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(85, 228);
            label4.Name = "label4";
            label4.Size = new Size(59, 21);
            label4.TabIndex = 11;
            label4.Text = "Monto:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(85, 270);
            label5.Name = "label5";
            label5.Size = new Size(133, 21);
            label5.TabIndex = 12;
            label5.Text = "Monto Imponible:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(85, 311);
            label6.Name = "label6";
            label6.Size = new Size(154, 21);
            label6.TabIndex = 13;
            label6.Text = "Código Autorización:";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 17, 61);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 11F);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(339, 397);
            button1.Name = "button1";
            button1.Size = new Size(143, 33);
            button1.TabIndex = 14;
            button1.Text = "Registrar Factura";
            button1.UseVisualStyleBackColor = false;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(122, 5);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(143, 23);
            textBox6.TabIndex = 15;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(364, 5);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(143, 23);
            textBox7.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(35, 7);
            label7.Name = "label7";
            label7.Size = new Size(71, 21);
            label7.TabIndex = 17;
            label7.Text = "Nombre:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.ForeColor = SystemColors.ControlLightLight;
            label8.Location = new Point(301, 7);
            label8.Name = "label8";
            label8.Size = new Size(57, 21);
            label8.TabIndex = 18;
            label8.Text = "NIT/CI:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Orange;
            panel2.Controls.Add(textBox7);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(textBox6);
            panel2.Controls.Add(label7);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 477);
            panel2.Name = "panel2";
            panel2.Size = new Size(534, 34);
            panel2.TabIndex = 19;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(16, 384);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(128, 74);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = SystemColors.AppWorkspace;
            label10.Location = new Point(447, 57);
            label10.Name = "label10";
            label10.Size = new Size(75, 15);
            label10.TabIndex = 21;
            label10.Text = "JEELM©2024";
            // 
            // FormGenerarFactura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 511);
            Controls.Add(label10);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox5);
            Controls.Add(tbMontoImponible);
            Controls.Add(tbMonto);
            Controls.Add(dtpFecha);
            Controls.Add(tbCodigoAuto);
            Controls.Add(tbNitCi);
            Controls.Add(panel1);
            Name = "FormGenerarFactura";
            Text = "Generar Factura";
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FileSystemWatcher fileSystemWatcher1;
        private TextBox tbNitCi;
        private Panel panel1;
        private Label label1;
        private TextBox textBox5;
        private TextBox tbMontoImponible;
        private TextBox tbMonto;
        private DateTimePicker dtpFecha;
        private TextBox tbCodigoAuto;
        private Panel panel2;
        private TextBox textBox7;
        private Label label8;
        private TextBox textBox6;
        private Label label7;
        private Button button1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label9;
        private Label label10;
    }
}