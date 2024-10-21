namespace Edifia_GUI
{
    partial class DepartamentoMan01
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
            txtFiltro = new TextBox();
            dtgDatos = new DataGridView();
            numero = new DataGridViewTextBoxColumn();
            piso = new DataGridViewTextBoxColumn();
            Fec_reg = new DataGridViewTextBoxColumn();
            label2 = new Label();
            btnAgregar = new Button();
            btnACtualizar = new Button();
            btnEliminar = new Button();
            btnCerrar = new Button();
            lblRegistros = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgDatos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 24);
            label1.Name = "label1";
            label1.Size = new Size(126, 15);
            label1.TabIndex = 0;
            label1.Text = "Ingrese departamento:";
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(142, 21);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(137, 23);
            txtFiltro.TabIndex = 1;
            txtFiltro.TextChanged += this.txtFiltro_TextChanged;
            // 
            // dtgDatos
            // 
            dtgDatos.AllowUserToAddRows = false;
            dtgDatos.AllowUserToDeleteRows = false;
            dtgDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDatos.Columns.AddRange(new DataGridViewColumn[] { numero, piso, Fec_reg });
            dtgDatos.Location = new Point(12, 67);
            dtgDatos.Name = "dtgDatos";
            dtgDatos.ReadOnly = true;
            dtgDatos.RowHeadersVisible = false;
            dtgDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgDatos.Size = new Size(776, 296);
            dtgDatos.TabIndex = 0;
            // 
            // numero
            // 
            numero.DataPropertyName = "numero";
            numero.HeaderText = "Numero";
            numero.Name = "numero";
            numero.ReadOnly = true;
            // 
            // piso
            // 
            piso.DataPropertyName = "piso";
            piso.HeaderText = "Piso";
            piso.Name = "piso";
            piso.ReadOnly = true;
            // 
            // Fec_reg
            // 
            Fec_reg.DataPropertyName = "Fec_reg";
            Fec_reg.HeaderText = "F.Registro";
            Fec_reg.Name = "Fec_reg";
            Fec_reg.ReadOnly = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(646, 378);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 0;
            label2.Text = "Registros:";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(399, 410);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(80, 28);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnACtualizar
            // 
            btnACtualizar.Location = new Point(491, 410);
            btnACtualizar.Name = "btnACtualizar";
            btnACtualizar.Size = new Size(80, 28);
            btnACtualizar.TabIndex = 3;
            btnACtualizar.Text = "Actualizar";
            btnACtualizar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(583, 410);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(80, 28);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(708, 410);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(80, 28);
            btnCerrar.TabIndex = 3;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            // 
            // lblRegistros
            // 
            lblRegistros.BorderStyle = BorderStyle.FixedSingle;
            lblRegistros.Location = new Point(713, 377);
            lblRegistros.Name = "lblRegistros";
            lblRegistros.Size = new Size(75, 20);
            lblRegistros.TabIndex = 0;
            // 
            // DepartamentoMan01
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCerrar);
            Controls.Add(btnEliminar);
            Controls.Add(btnACtualizar);
            Controls.Add(btnAgregar);
            Controls.Add(dtgDatos);
            Controls.Add(txtFiltro);
            Controls.Add(label2);
            Controls.Add(lblRegistros);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DepartamentoMan01";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mantenimiento de Departamentos";
            Load += DepartamentoMan01_Load;
            ((System.ComponentModel.ISupportInitialize)dtgDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFiltro;
        private DataGridView dtgDatos;
        private Label label2;
        private Button btnAgregar;
        private Button btnACtualizar;
        private Button btnEliminar;
        private Button btnCerrar;
        private Label lblRegistros;
        private DataGridViewTextBoxColumn numero;
        private DataGridViewTextBoxColumn piso;
        private DataGridViewTextBoxColumn Fec_reg;
    }
}