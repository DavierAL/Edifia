namespace Edifia_GUI
{
    partial class frmMantenimiento
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
            btnRegistrar = new Button();
            cboActividad = new ComboBox();
            cboResponsable = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            lblUser = new Label();
            label1 = new Label();
            label2 = new Label();
            cboEdificio = new ComboBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.FromArgb(10, 132, 255);
            btnRegistrar.FlatStyle = FlatStyle.Popup;
            btnRegistrar.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrar.ForeColor = Color.FromArgb(242, 242, 247);
            btnRegistrar.Location = new Point(481, 339);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(150, 30);
            btnRegistrar.TabIndex = 8;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            // 
            // cboActividad
            // 
            cboActividad.FormattingEnabled = true;
            cboActividad.Location = new Point(226, 117);
            cboActividad.Name = "cboActividad";
            cboActividad.Size = new Size(240, 23);
            cboActividad.TabIndex = 9;
            // 
            // cboResponsable
            // 
            cboResponsable.FormattingEnabled = true;
            cboResponsable.Location = new Point(226, 52);
            cboResponsable.Name = "cboResponsable";
            cboResponsable.Size = new Size(240, 23);
            cboResponsable.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(226, 187);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(207, 23);
            dateTimePicker1.TabIndex = 11;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUser.ForeColor = Color.FromArgb(242, 242, 247);
            lblUser.Location = new Point(51, 118);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(111, 19);
            lblUser.TabIndex = 12;
            lblUser.Text = "Responsable:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(242, 242, 247);
            label1.Location = new Point(51, 53);
            label1.Name = "label1";
            label1.Size = new Size(149, 19);
            label1.TabIndex = 13;
            label1.Text = "Tipo de actividad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(242, 242, 247);
            label2.Location = new Point(51, 190);
            label2.Name = "label2";
            label2.Size = new Size(168, 19);
            label2.TabIndex = 14;
            label2.Text = "Fecha programada:";
            // 
            // cboEdificio
            // 
            cboEdificio.FormattingEnabled = true;
            cboEdificio.Location = new Point(226, 249);
            cboEdificio.Name = "cboEdificio";
            cboEdificio.Size = new Size(240, 23);
            cboEdificio.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(242, 242, 247);
            label3.Location = new Point(51, 253);
            label3.Name = "label3";
            label3.Size = new Size(68, 19);
            label3.TabIndex = 16;
            label3.Text = "Edificio:";
            // 
            // frmMantenimiento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 44, 46);
            ClientSize = new Size(669, 410);
            Controls.Add(label3);
            Controls.Add(cboEdificio);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblUser);
            Controls.Add(dateTimePicker1);
            Controls.Add(cboResponsable);
            Controls.Add(cboActividad);
            Controls.Add(btnRegistrar);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmMantenimiento";
            Text = "frmMantenimiento";
            Load += frmMantenimiento_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnRegistrar;
        private ComboBox cboActividad;
        private ComboBox cboResponsable;
        private DateTimePicker dateTimePicker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label lblUser;
        private Label label1;
        private Label label2;
        private ComboBox cboEdificio;
        private Label label3;
    }
}