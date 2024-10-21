namespace Edifia_GUI
{
    partial class frmEmpleado
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
            btnAgregar = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            btnCerrar = new Button();
            lblRegistros = new Label();
            dtgDatos = new DataGridView();
            txtFiltro = new TextBox();
            DNI = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            Cargo = new DataGridViewTextBoxColumn();
            Horario = new DataGridViewTextBoxColumn();
            Fecha_Inicio = new DataGridViewTextBoxColumn();
            Fecha_Fin = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dtgDatos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(242, 242, 247);
            label1.Location = new Point(69, 16);
            label1.Name = "label1";
            label1.Size = new Size(345, 23);
            label1.TabIndex = 22;
            label1.Text = "Busqueda empleado por apellido:";
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(10, 132, 255);
            btnAgregar.FlatStyle = FlatStyle.Popup;
            btnAgregar.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = Color.FromArgb(242, 242, 247);
            btnAgregar.Location = new Point(111, 545);
            btnAgregar.Margin = new Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(171, 40);
            btnAgregar.TabIndex = 17;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.FromArgb(10, 132, 255);
            btnActualizar.FlatStyle = FlatStyle.Popup;
            btnActualizar.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizar.ForeColor = Color.FromArgb(242, 242, 247);
            btnActualizar.Location = new Point(311, 545);
            btnActualizar.Margin = new Padding(3, 4, 3, 4);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(171, 40);
            btnActualizar.TabIndex = 17;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(10, 132, 255);
            btnEliminar.FlatStyle = FlatStyle.Popup;
            btnEliminar.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = Color.FromArgb(242, 242, 247);
            btnEliminar.Location = new Point(500, 545);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(171, 40);
            btnEliminar.TabIndex = 17;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += button2_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.FromArgb(10, 132, 255);
            btnCerrar.FlatStyle = FlatStyle.Popup;
            btnCerrar.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrar.ForeColor = Color.FromArgb(242, 242, 247);
            btnCerrar.Location = new Point(857, 545);
            btnCerrar.Margin = new Padding(3, 4, 3, 4);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(171, 40);
            btnCerrar.TabIndex = 17;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += button2_Click;
            // 
            // lblRegistros
            // 
            lblRegistros.BackColor = Color.FromArgb(46, 40, 44);
            lblRegistros.Location = new Point(59, 479);
            lblRegistros.Name = "lblRegistros";
            lblRegistros.Size = new Size(158, 36);
            lblRegistros.TabIndex = 27;
            // 
            // dtgDatos
            // 
            dtgDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDatos.Columns.AddRange(new DataGridViewColumn[] { DNI, Nombre, Apellido, Cargo, Horario, Fecha_Inicio, Fecha_Fin });
            dtgDatos.Location = new Point(59, 96);
            dtgDatos.Name = "dtgDatos";
            dtgDatos.ReadOnly = true;
            dtgDatos.RowHeadersWidth = 51;
            dtgDatos.Size = new Size(928, 380);
            dtgDatos.TabIndex = 28;
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(435, 16);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(275, 27);
            txtFiltro.TabIndex = 29;
            txtFiltro.TextChanged += txtFiltro_TextChanged;
            // 
            // DNI
            // 
            DNI.DataPropertyName = "DNI";
            DNI.HeaderText = "DNI";
            DNI.MinimumWidth = 6;
            DNI.Name = "DNI";
            DNI.ReadOnly = true;
            DNI.Width = 125;
            // 
            // Nombre
            // 
            Nombre.DataPropertyName = "nombre";
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Width = 125;
            // 
            // Apellido
            // 
            Apellido.DataPropertyName = "apellido";
            Apellido.HeaderText = "Apellido";
            Apellido.MinimumWidth = 6;
            Apellido.Name = "Apellido";
            Apellido.ReadOnly = true;
            Apellido.Width = 125;
            // 
            // Cargo
            // 
            Cargo.DataPropertyName = "Cargo";
            Cargo.HeaderText = "Cargo";
            Cargo.MinimumWidth = 6;
            Cargo.Name = "Cargo";
            Cargo.ReadOnly = true;
            Cargo.Width = 125;
            // 
            // Horario
            // 
            Horario.DataPropertyName = "horario";
            Horario.HeaderText = "Horario";
            Horario.MinimumWidth = 6;
            Horario.Name = "Horario";
            Horario.ReadOnly = true;
            Horario.Width = 125;
            // 
            // Fecha_Inicio
            // 
            Fecha_Inicio.DataPropertyName = "Fecha de inicio";
            Fecha_Inicio.HeaderText = "Fecha de inicio";
            Fecha_Inicio.MinimumWidth = 6;
            Fecha_Inicio.Name = "Fecha_Inicio";
            Fecha_Inicio.ReadOnly = true;
            Fecha_Inicio.Width = 125;
            // 
            // Fecha_Fin
            // 
            Fecha_Fin.DataPropertyName = "Fecha de fin";
            Fecha_Fin.HeaderText = "Fecha de fin";
            Fecha_Fin.MinimumWidth = 6;
            Fecha_Fin.Name = "Fecha_Fin";
            Fecha_Fin.ReadOnly = true;
            Fecha_Fin.Width = 125;
            // 
            // frmEmpleado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 40, 46);
            ClientSize = new Size(1093, 616);
            Controls.Add(txtFiltro);
            Controls.Add(dtgDatos);
            Controls.Add(lblRegistros);
            Controls.Add(label1);
            Controls.Add(btnCerrar);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnAgregar);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmEmpleado";
            Text = "Mantenimiento empleado";
            Load += frmEmpleado_Load;
            ((System.ComponentModel.ISupportInitialize)dtgDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button btnAgregar;
        private Button btnActualizar;
        private Button btnEliminar;
        private Button btnCerrar;
        private Label lblRegistros;
        private DataGridView dtgDatos;
        private TextBox txtFiltro;
        private DataGridViewTextBoxColumn DNI;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Cargo;
        private DataGridViewTextBoxColumn Horario;
        private DataGridViewTextBoxColumn Fecha_Inicio;
        private DataGridViewTextBoxColumn Fecha_Fin;
    }
}