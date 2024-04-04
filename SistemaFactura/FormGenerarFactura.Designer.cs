namespace SistemaFactura
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
            tbNit = new TextBox();
            tbNombreRazon = new TextBox();
            Fecha = new DateTimePicker();
            tbMonto = new TextBox();
            tbMontoImponible = new TextBox();
            tbCodigoControl = new TextBox();
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
            label11 = new Label();
            TipoFactura = new ComboBox();
            tbNitEmisor = new TextBox();
            label12 = new Label();
            tbNumeroFactura = new TextBox();
            label13 = new Label();
            tbCodigoAutorizacion = new TextBox();
            label14 = new Label();
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
            // tbNit
            // 
            tbNit.Location = new Point(249, 102);
            tbNit.Name = "tbNit";
            tbNit.Size = new Size(143, 23);
            tbNit.TabIndex = 0;
            // 
            // tbNombreRazon
            // 
            tbNombreRazon.Location = new Point(249, 141);
            tbNombreRazon.Name = "tbNombreRazon";
            tbNombreRazon.Size = new Size(143, 23);
            tbNombreRazon.TabIndex = 1;
            // 
            // Fecha
            // 
            Fecha.Location = new Point(175, 295);
            Fecha.Name = "Fecha";
            Fecha.Size = new Size(217, 23);
            Fecha.TabIndex = 3;
            // 
            // tbMonto
            // 
            tbMonto.Location = new Point(247, 328);
            tbMonto.Name = "tbMonto";
            tbMonto.Size = new Size(143, 23);
            tbMonto.TabIndex = 4;
            // 
            // tbMontoImponible
            // 
            tbMontoImponible.Location = new Point(247, 365);
            tbMontoImponible.Name = "tbMontoImponible";
            tbMontoImponible.Size = new Size(143, 23);
            tbMontoImponible.TabIndex = 5;
            // 
            // tbCodigoControl
            // 
            tbCodigoControl.Location = new Point(247, 403);
            tbCodigoControl.Name = "tbCodigoControl";
            tbCodigoControl.Size = new Size(143, 23);
            tbCodigoControl.TabIndex = 6;
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
            label2.Size = new Size(114, 21);
            label2.TabIndex = 9;
            label2.Text = "Nombre razon:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(81, 296);
            label3.Name = "label3";
            label3.Size = new Size(53, 21);
            label3.TabIndex = 10;
            label3.Text = "Fecha:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(83, 330);
            label4.Name = "label4";
            label4.Size = new Size(59, 21);
            label4.TabIndex = 11;
            label4.Text = "Monto:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(83, 367);
            label5.Name = "label5";
            label5.Size = new Size(133, 21);
            label5.TabIndex = 12;
            label5.Text = "Monto Imponible:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(83, 405);
            label6.Name = "label6";
            label6.Size = new Size(116, 21);
            label6.TabIndex = 13;
            label6.Text = "Código control:";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 17, 61);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 11F);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(379, 523);
            button1.Name = "button1";
            button1.Size = new Size(143, 33);
            button1.TabIndex = 14;
            button1.Text = "Registrar Factura";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
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
            panel2.Location = new Point(0, 578);
            panel2.Name = "panel2";
            panel2.Size = new Size(534, 34);
            panel2.TabIndex = 19;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(4, 498);
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
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(86, 446);
            label11.Name = "label11";
            label11.Size = new Size(46, 15);
            label11.TabIndex = 22;
            label11.Text = "Factura";
            // 
            // TipoFactura
            // 
            TipoFactura.DropDownStyle = ComboBoxStyle.DropDownList;
            TipoFactura.FormattingEnabled = true;
            TipoFactura.Location = new Point(249, 443);
            TipoFactura.Name = "TipoFactura";
            TipoFactura.Size = new Size(144, 23);
            TipoFactura.TabIndex = 2;
            // 
            // tbNitEmisor
            // 
            tbNitEmisor.Location = new Point(248, 179);
            tbNitEmisor.Name = "tbNitEmisor";
            tbNitEmisor.Size = new Size(143, 23);
            tbNitEmisor.TabIndex = 1;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F);
            label12.Location = new Point(80, 181);
            label12.Name = "label12";
            label12.Size = new Size(86, 21);
            label12.TabIndex = 9;
            label12.Text = "Nit emisor:";
            // 
            // tbNumeroFactura
            // 
            tbNumeroFactura.Location = new Point(248, 218);
            tbNumeroFactura.Name = "tbNumeroFactura";
            tbNumeroFactura.Size = new Size(143, 23);
            tbNumeroFactura.TabIndex = 1;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F);
            label13.Location = new Point(80, 220);
            label13.Name = "label13";
            label13.Size = new Size(123, 21);
            label13.TabIndex = 9;
            label13.Text = "Numero factura:";
            // 
            // tbCodigoAutorizacion
            // 
            tbCodigoAutorizacion.Location = new Point(248, 256);
            tbCodigoAutorizacion.Name = "tbCodigoAutorizacion";
            tbCodigoAutorizacion.Size = new Size(143, 23);
            tbCodigoAutorizacion.TabIndex = 1;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F);
            label14.Location = new Point(80, 258);
            label14.Name = "label14";
            label14.Size = new Size(152, 21);
            label14.TabIndex = 9;
            label14.Text = "Codigo autorizacion:";
            // 
            // FormGenerarFactura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 612);
            Controls.Add(TipoFactura);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbCodigoControl);
            Controls.Add(tbMontoImponible);
            Controls.Add(tbMonto);
            Controls.Add(Fecha);
            Controls.Add(tbCodigoAutorizacion);
            Controls.Add(tbNumeroFactura);
            Controls.Add(tbNitEmisor);
            Controls.Add(tbNombreRazon);
            Controls.Add(tbNit);
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
        private TextBox tbNit;
        private Panel panel1;
        private Label label1;
        private TextBox tbCodigoControl;
        private TextBox tbMontoImponible;
        private TextBox tbMonto;
        private DateTimePicker Fecha;
        private TextBox tbNombreRazon;
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
        private Label label11;
        private ComboBox TipoFactura;
        private Label label14;
        private Label label13;
        private Label label12;
        private TextBox tbCodigoAutorizacion;
        private TextBox tbNumeroFactura;
        private TextBox tbNitEmisor;
    }
}