﻿namespace Edifia_GUI
{
    partial class HabitanteMan01
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
            btnAgregar = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            btnCerrar = new Button();
            label2 = new Label();
            lblRegistros = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgDatos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 18);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 0;
            label1.Text = "Buscar habitante:";
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(203, 10);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(100, 23);
            txtFiltro.TabIndex = 1;
            // 
            // dtgDatos
            // 
            dtgDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDatos.Location = new Point(12, 64);
            dtgDatos.Name = "dtgDatos";
            dtgDatos.Size = new Size(776, 284);
            dtgDatos.TabIndex = 2;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(400, 401);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(82, 37);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(499, 402);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(82, 34);
            btnActualizar.TabIndex = 4;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(599, 403);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(87, 33);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(709, 404);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(88, 34);
            btnCerrar.TabIndex = 6;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(613, 365);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 7;
            label2.Text = "Registros:";
            // 
            // lblRegistros
            // 
            lblRegistros.BorderStyle = BorderStyle.FixedSingle;
            lblRegistros.Location = new Point(677, 357);
            lblRegistros.Name = "lblRegistros";
            lblRegistros.Size = new Size(100, 23);
            lblRegistros.TabIndex = 8;
            // 
            // HabitanteMan01
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblRegistros);
            Controls.Add(label2);
            Controls.Add(btnCerrar);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnAgregar);
            Controls.Add(dtgDatos);
            Controls.Add(txtFiltro);
            Controls.Add(label1);
            Name = "HabitanteMan01";
            Text = "Mantenimiento de Habitantes";
            ((System.ComponentModel.ISupportInitialize)dtgDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFiltro;
        private DataGridView dtgDatos;
        private Button btnAgregar;
        private Button btnActualizar;
        private Button btnEliminar;
        private Button btnCerrar;
        private Label label2;
        private Label lblRegistros;
    }
}