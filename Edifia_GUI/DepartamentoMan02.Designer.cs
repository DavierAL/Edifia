namespace Edifia_GUI
{
    partial class DepartamentoMan02
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
            txtNumero = new TextBox();
            txtPiso = new TextBox();
            btnGrabar = new Button();
            btnCancelar = new Button();
            cboEdificio = new ComboBox();
            groupBox1 = new GroupBox();
            optDeshabitado = new RadioButton();
            optHabitado = new RadioButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 31);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Numero:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 70);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 0;
            label2.Text = "Piso:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 109);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 0;
            label3.Text = "Edificio:";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(98, 31);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(121, 23);
            txtNumero.TabIndex = 1;
            // 
            // txtPiso
            // 
            txtPiso.Location = new Point(98, 66);
            txtPiso.Name = "txtPiso";
            txtPiso.Size = new Size(121, 23);
            txtPiso.TabIndex = 1;
            // 
            // btnGrabar
            // 
            btnGrabar.Location = new Point(206, 151);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(75, 23);
            btnGrabar.TabIndex = 3;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = true;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(309, 151);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // cboEdificio
            // 
            cboEdificio.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEdificio.FormattingEnabled = true;
            cboEdificio.Location = new Point(98, 101);
            cboEdificio.Name = "cboEdificio";
            cboEdificio.Size = new Size(121, 23);
            cboEdificio.TabIndex = 5;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(optDeshabitado);
            groupBox1.Controls.Add(optHabitado);
            groupBox1.Location = new Point(256, 31);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(137, 100);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Estado";
            // 
            // optDeshabitado
            // 
            optDeshabitado.AutoSize = true;
            optDeshabitado.Location = new Point(20, 62);
            optDeshabitado.Name = "optDeshabitado";
            optDeshabitado.Size = new Size(91, 19);
            optDeshabitado.TabIndex = 0;
            optDeshabitado.TabStop = true;
            optDeshabitado.Text = "Deshabitado";
            optDeshabitado.UseVisualStyleBackColor = true;
            // 
            // optHabitado
            // 
            optHabitado.AutoSize = true;
            optHabitado.Location = new Point(20, 28);
            optHabitado.Name = "optHabitado";
            optHabitado.Size = new Size(74, 19);
            optHabitado.TabIndex = 0;
            optHabitado.TabStop = true;
            optHabitado.Text = "Habitado";
            optHabitado.UseVisualStyleBackColor = true;
            // 
            // DepartamentoMan02
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(411, 197);
            Controls.Add(groupBox1);
            Controls.Add(cboEdificio);
            Controls.Add(btnCancelar);
            Controls.Add(btnGrabar);
            Controls.Add(txtPiso);
            Controls.Add(txtNumero);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DepartamentoMan02";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nuevo departamento";
            Load += DepartamentoMan02_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNumero;
        private TextBox txtPiso;
        private Button btnGrabar;
        private Button btnCancelar;
        private ComboBox cboEdificio;
        private GroupBox groupBox1;
        private RadioButton optDeshabitado;
        private RadioButton optHabitado;
    }
}