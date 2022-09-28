
namespace pryBazanEditoria
{
    partial class frmLibro
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
            this.txtDistribuidor = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtEditorial = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.lblCodDistribuidor = new System.Windows.Forms.Label();
            this.lblCodEditorial = new System.Windows.Forms.Label();
            this.lblCodigoLib = new System.Windows.Forms.Label();
            this.lblCodAutor = new System.Windows.Forms.Label();
            this.lblNombreLib = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDistribuidor
            // 
            this.txtDistribuidor.Location = new System.Drawing.Point(206, 176);
            this.txtDistribuidor.Name = "txtDistribuidor";
            this.txtDistribuidor.Size = new System.Drawing.Size(191, 22);
            this.txtDistribuidor.TabIndex = 30;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(206, 62);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(303, 22);
            this.txtNombre.TabIndex = 29;
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(206, 138);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(191, 22);
            this.txtAutor.TabIndex = 28;
            // 
            // txtEditorial
            // 
            this.txtEditorial.Location = new System.Drawing.Point(206, 100);
            this.txtEditorial.Name = "txtEditorial";
            this.txtEditorial.Size = new System.Drawing.Size(191, 22);
            this.txtEditorial.TabIndex = 27;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(206, 24);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 22);
            this.txtCodigo.TabIndex = 26;
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(114, 220);
            this.btnAnterior.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(77, 48);
            this.btnAnterior.TabIndex = 25;
            this.btnAnterior.Text = "<<";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(265, 220);
            this.btnSiguiente.Margin = new System.Windows.Forms.Padding(4);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(77, 48);
            this.btnSiguiente.TabIndex = 24;
            this.btnSiguiente.Text = ">>";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // lblCodDistribuidor
            // 
            this.lblCodDistribuidor.AutoSize = true;
            this.lblCodDistribuidor.Location = new System.Drawing.Point(19, 182);
            this.lblCodDistribuidor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodDistribuidor.Name = "lblCodDistribuidor";
            this.lblCodDistribuidor.Size = new System.Drawing.Size(75, 16);
            this.lblCodDistribuidor.TabIndex = 23;
            this.lblCodDistribuidor.Text = "Distribuidor";
            // 
            // lblCodEditorial
            // 
            this.lblCodEditorial.AutoSize = true;
            this.lblCodEditorial.Location = new System.Drawing.Point(19, 106);
            this.lblCodEditorial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodEditorial.Name = "lblCodEditorial";
            this.lblCodEditorial.Size = new System.Drawing.Size(56, 16);
            this.lblCodEditorial.TabIndex = 22;
            this.lblCodEditorial.Text = "Editorial";
            // 
            // lblCodigoLib
            // 
            this.lblCodigoLib.AutoSize = true;
            this.lblCodigoLib.Location = new System.Drawing.Point(19, 30);
            this.lblCodigoLib.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigoLib.Name = "lblCodigoLib";
            this.lblCodigoLib.Size = new System.Drawing.Size(51, 16);
            this.lblCodigoLib.TabIndex = 21;
            this.lblCodigoLib.Text = "Codigo";
            // 
            // lblCodAutor
            // 
            this.lblCodAutor.AutoSize = true;
            this.lblCodAutor.Location = new System.Drawing.Point(19, 144);
            this.lblCodAutor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodAutor.Name = "lblCodAutor";
            this.lblCodAutor.Size = new System.Drawing.Size(38, 16);
            this.lblCodAutor.TabIndex = 20;
            this.lblCodAutor.Text = "Autor";
            // 
            // lblNombreLib
            // 
            this.lblNombreLib.AutoSize = true;
            this.lblNombreLib.Location = new System.Drawing.Point(19, 68);
            this.lblNombreLib.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreLib.Name = "lblNombreLib";
            this.lblNombreLib.Size = new System.Drawing.Size(89, 16);
            this.lblNombreLib.TabIndex = 19;
            this.lblNombreLib.Text = "Nombre Libro";
            // 
            // frmLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 288);
            this.Controls.Add(this.txtDistribuidor);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.txtEditorial);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.lblCodDistribuidor);
            this.Controls.Add(this.lblCodEditorial);
            this.Controls.Add(this.lblCodigoLib);
            this.Controls.Add(this.lblCodAutor);
            this.Controls.Add(this.lblNombreLib);
            this.Name = "frmLibro";
            this.Text = "Libros";
            this.Load += new System.EventHandler(this.frmLibro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDistribuidor;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.TextBox txtEditorial;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Label lblCodDistribuidor;
        private System.Windows.Forms.Label lblCodEditorial;
        private System.Windows.Forms.Label lblCodigoLib;
        private System.Windows.Forms.Label lblCodAutor;
        private System.Windows.Forms.Label lblNombreLib;
    }
}