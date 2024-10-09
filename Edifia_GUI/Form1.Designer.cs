namespace Edifia_GUI
{
    partial class frmHome
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            menuStrip1 = new MenuStrip();
            ventanaToolStripMenuItem = new ToolStripMenuItem();
            ventana1ToolStripMenuItem = new ToolStripMenuItem();
            ventana2ToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { ventanaToolStripMenuItem });
            resources.ApplyResources(menuStrip1, "menuStrip1");
            menuStrip1.Name = "menuStrip1";
            // 
            // ventanaToolStripMenuItem
            // 
            ventanaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ventana1ToolStripMenuItem, ventana2ToolStripMenuItem });
            ventanaToolStripMenuItem.Name = "ventanaToolStripMenuItem";
            resources.ApplyResources(ventanaToolStripMenuItem, "ventanaToolStripMenuItem");
            // 
            // ventana1ToolStripMenuItem
            // 
            ventana1ToolStripMenuItem.Name = "ventana1ToolStripMenuItem";
            resources.ApplyResources(ventana1ToolStripMenuItem, "ventana1ToolStripMenuItem");
            // 
            // ventana2ToolStripMenuItem
            // 
            ventana2ToolStripMenuItem.Name = "ventana2ToolStripMenuItem";
            resources.ApplyResources(ventana2ToolStripMenuItem, "ventana2ToolStripMenuItem");
            // 
            // statusStrip1
            // 
            resources.ApplyResources(statusStrip1, "statusStrip1");
            statusStrip1.Name = "statusStrip1";
            // 
            // frmHome
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 52, 73);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmHome";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private StatusStrip statusStrip1;
        private ToolStripMenuItem ventanaToolStripMenuItem;
        private ToolStripMenuItem ventana1ToolStripMenuItem;
        private ToolStripMenuItem ventana2ToolStripMenuItem;
    }
}
