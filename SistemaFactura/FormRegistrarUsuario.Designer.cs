﻿namespace SistemaFactura
{
    partial class FormRegistrarUsuario
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
            label2 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            label3 = new Label();
            button2 = new Button();
            label4 = new Label();
            label5 = new Label();
            panel1 = new Panel();
            tbNit = new NumericUpDown();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbNit).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Orange;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 9);
            label2.Name = "label2";
            label2.Size = new Size(351, 15);
            label2.TabIndex = 10;
            label2.Text = "Es la primera vez que ingresas a este sistema, por favor ingresa tu:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(96, 60);
            label1.Name = "label1";
            label1.Size = new Size(170, 21);
            label1.TabIndex = 11;
            label1.Text = "Nombre / Razón Social";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(72, 84);
            textBox1.MaxLength = 50;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(221, 23);
            textBox1.TabIndex = 12;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 17, 61);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 11F);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(123, 184);
            button1.Name = "button1";
            button1.Size = new Size(143, 33);
            button1.TabIndex = 15;
            button1.Text = "Registrarse";
            button1.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 246);
            label3.Name = "label3";
            label3.Size = new Size(123, 15);
            label3.TabIndex = 16;
            label3.Text = "¿No es la primera vez?";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 17, 61);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 11F);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(123, 303);
            button2.Name = "button2";
            button2.Size = new Size(143, 33);
            button2.TabIndex = 17;
            button2.Text = "Volver atras";
            button2.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 271);
            label4.Name = "label4";
            label4.Size = new Size(153, 15);
            label4.TabIndex = 18;
            label4.Text = "Quizá te equivocaste de NIT";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(96, 119);
            label5.Name = "label5";
            label5.Size = new Size(109, 21);
            label5.TabIndex = 20;
            label5.Text = "Confirmar NIT";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Orange;
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(364, 39);
            panel1.TabIndex = 21;
            // 
            // tbNit
            // 
            tbNit.Location = new Point(72, 143);
            tbNit.Maximum = new decimal(new int[] { -727379969, 232, 0, 0 });
            tbNit.Name = "tbNit";
            tbNit.Size = new Size(221, 23);
            tbNit.TabIndex = 22;
            tbNit.ValueChanged += tbNit_ValueChanged;
            // 
            // FormRegistrarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(364, 364);
            Controls.Add(tbNit);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "FormRegistrarUsuario";
            Text = "FormRegistrarUsuario";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tbNit).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Label label3;
        private Button button2;
        private Label label4;
        private Label label5;
        private Panel panel1;
        private NumericUpDown tbNit;
    }
}