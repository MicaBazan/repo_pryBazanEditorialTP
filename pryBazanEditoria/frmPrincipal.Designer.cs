
namespace pryBazanEditoria
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.msPrincipal = new System.Windows.Forms.MenuStrip();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catalogoDeLibrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.picPrincipal = new System.Windows.Forms.PictureBox();
            this.msPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // msPrincipal
            // 
            this.msPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaToolStripMenuItem});
            this.msPrincipal.Location = new System.Drawing.Point(0, 0);
            this.msPrincipal.Name = "msPrincipal";
            this.msPrincipal.Size = new System.Drawing.Size(743, 30);
            this.msPrincipal.TabIndex = 0;
            this.msPrincipal.Text = "menuStrip1";
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.catalogoDeLibrosToolStripMenuItem});
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(80, 26);
            this.consultaToolStripMenuItem.Text = "Consulta";
            // 
            // catalogoDeLibrosToolStripMenuItem
            // 
            this.catalogoDeLibrosToolStripMenuItem.Name = "catalogoDeLibrosToolStripMenuItem";
            this.catalogoDeLibrosToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.catalogoDeLibrosToolStripMenuItem.Text = "Catálogo de Libros";
            this.catalogoDeLibrosToolStripMenuItem.Click += new System.EventHandler(this.catalogoDeLibrosToolStripMenuItem_Click);
            // 
            // picPrincipal
            // 
            this.picPrincipal.Image = global::pryBazanEditoria.Properties.Resources.principal;
            this.picPrincipal.Location = new System.Drawing.Point(-29, 31);
            this.picPrincipal.Name = "picPrincipal";
            this.picPrincipal.Size = new System.Drawing.Size(800, 403);
            this.picPrincipal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPrincipal.TabIndex = 1;
            this.picPrincipal.TabStop = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 432);
            this.Controls.Add(this.picPrincipal);
            this.Controls.Add(this.msPrincipal);
            this.MainMenuStrip = this.msPrincipal;
            this.Name = "frmPrincipal";
            this.Text = "Principal";
            this.msPrincipal.ResumeLayout(false);
            this.msPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPrincipal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msPrincipal;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catalogoDeLibrosToolStripMenuItem;
        private System.Windows.Forms.PictureBox picPrincipal;
    }
}

