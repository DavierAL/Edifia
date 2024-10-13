namespace Edifia_GUI
{
    partial class UsuarioMan03
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
            txtNombre = new TextBox();
            label2 = new Label();
            txtApellido = new TextBox();
            label3 = new Label();
            btnGrabar = new Button();
            btnCancelar = new Button();
            cbbPersonaId = new ComboBox();
            label4 = new Label();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 28);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 0;
            label1.Text = "Usuario:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(147, 25);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 83);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 0;
            label2.Text = "Password:";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(147, 75);
            txtApellido.Name = "txtApellido";
            txtApellido.PasswordChar = '*';
            txtApellido.Size = new Size(100, 23);
            txtApellido.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(68, 138);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 0;
            label3.Text = "Persona id: ";
            // 
            // btnGrabar
            // 
            btnGrabar.Location = new Point(235, 282);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(75, 23);
            btnGrabar.TabIndex = 3;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(316, 282);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // cbbPersonaId
            // 
            cbbPersonaId.FormattingEnabled = true;
            cbbPersonaId.Location = new Point(147, 135);
            cbbPersonaId.Name = "cbbPersonaId";
            cbbPersonaId.Size = new Size(49, 23);
            cbbPersonaId.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(68, 194);
            label4.Name = "label4";
            label4.Size = new Size(82, 15);
            label4.TabIndex = 0;
            label4.Text = "Nivel usuario: ";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(147, 191);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(49, 23);
            comboBox1.TabIndex = 4;
            // 
            // UsuarioMan02
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(455, 317);
            Controls.Add(comboBox1);
            Controls.Add(cbbPersonaId);
            Controls.Add(btnCancelar);
            Controls.Add(btnGrabar);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "UsuarioMan02";
            Text = "Nuevo usuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private Label label2;
        private TextBox txtApellido;
        private Label label3;
        private Button btnGrabar;
        private Button btnCancelar;
        private ComboBox cbbPersonaId;
        private Label label4;
        private ComboBox comboBox1;
    }
}