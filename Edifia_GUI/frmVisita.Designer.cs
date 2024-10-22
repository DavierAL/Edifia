namespace Edifia_GUI
{
    partial class frmVisita
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
            cbbox2 = new ComboBox();
            label1 = new Label();
            dtpFecIni = new DateTimePicker();
            label2 = new Label();
            dtpFecFin = new DateTimePicker();
            lblA = new Label();
            cbbox1 = new ComboBox();
            lblPro = new Label();
            btnRegistrar = new Button();
            textBox1 = new TextBox();
            lblApe = new Label();
            lblNom = new Label();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // cbbox2
            // 
            cbbox2.FormattingEnabled = true;
            cbbox2.Location = new Point(320, 188);
            cbbox2.Name = "cbbox2";
            cbbox2.Size = new Size(180, 28);
            cbbox2.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(99, 248);
            label1.Name = "label1";
            label1.Size = new Size(171, 20);
            label1.TabIndex = 8;
            label1.Text = "Fecha y hora de entrada:";
            // 
            // dtpFecIni
            // 
            dtpFecIni.Location = new Point(320, 248);
            dtpFecIni.Name = "dtpFecIni";
            dtpFecIni.Size = new Size(250, 27);
            dtpFecIni.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(99, 308);
            label2.Name = "label2";
            label2.Size = new Size(159, 20);
            label2.TabIndex = 10;
            label2.Text = "Fecha y hora de salida:";
            // 
            // dtpFecFin
            // 
            dtpFecFin.Location = new Point(320, 308);
            dtpFecFin.Name = "dtpFecFin";
            dtpFecFin.Size = new Size(250, 27);
            dtpFecFin.TabIndex = 11;
            // 
            // lblA
            // 
            lblA.AutoSize = true;
            lblA.Location = new Point(99, 196);
            lblA.Name = "lblA";
            lblA.Size = new Size(92, 20);
            lblA.TabIndex = 6;
            lblA.Text = "Area común:";
            // 
            // cbbox1
            // 
            cbbox1.FormattingEnabled = true;
            cbbox1.Location = new Point(320, 135);
            cbbox1.Name = "cbbox1";
            cbbox1.Size = new Size(180, 28);
            cbbox1.TabIndex = 5;
            // 
            // lblPro
            // 
            lblPro.AutoSize = true;
            lblPro.Location = new Point(99, 143);
            lblPro.Name = "lblPro";
            lblPro.Size = new Size(76, 20);
            lblPro.TabIndex = 4;
            lblPro.Text = "Propósito:";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(596, 359);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(132, 38);
            btnRegistrar.TabIndex = 12;
            btnRegistrar.Text = "Registrar Visita";
            btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(320, 77);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(180, 27);
            textBox1.TabIndex = 3;
            // 
            // lblApe
            // 
            lblApe.AutoSize = true;
            lblApe.Location = new Point(99, 84);
            lblApe.Name = "lblApe";
            lblApe.Size = new Size(69, 20);
            lblApe.TabIndex = 2;
            lblApe.Text = "Apellido:";
            // 
            // lblNom
            // 
            lblNom.AutoSize = true;
            lblNom.Location = new Point(99, 35);
            lblNom.Name = "lblNom";
            lblNom.Size = new Size(67, 20);
            lblNom.TabIndex = 0;
            lblNom.Text = "Nombre:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(320, 28);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(180, 27);
            textBox2.TabIndex = 1;
            // 
            // frmVisita
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(btnRegistrar);
            Controls.Add(dtpFecFin);
            Controls.Add(lblNom);
            Controls.Add(lblApe);
            Controls.Add(lblPro);
            Controls.Add(lblA);
            Controls.Add(label2);
            Controls.Add(dtpFecIni);
            Controls.Add(label1);
            Controls.Add(cbbox1);
            Controls.Add(cbbox2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmVisita";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Formulario de Visita";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbbox2;
        private Label label1;
        private DateTimePicker dtpFecIni;
        private Label label2;
        private DateTimePicker dtpFecFin;
        private Label lblA;
        private ComboBox cbbox1;
        private Label lblPro;
        private Button btnRegistrar;
        private TextBox textBox1;
        private Label lblApe;
        private Label lblNom;
        private TextBox textBox2;
    }
}