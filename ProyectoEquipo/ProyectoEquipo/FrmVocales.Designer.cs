/*
 * Creado por SharpDevelop.
 * Usuario: Lenovo
 * Fecha: 26/11/2026
 * Hora: 09:38 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace ProyectoEquipo
{
	partial class FrmVocales
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.lblTitulo = new System.Windows.Forms.Label();
			this.lblPalabra = new System.Windows.Forms.Label();
			this.txtPalabra = new System.Windows.Forms.TextBox();
			this.btnContar = new System.Windows.Forms.Button();
			this.lblVocales = new System.Windows.Forms.Label();
			this.txtVocales = new System.Windows.Forms.TextBox();
			this.lblConsonantes = new System.Windows.Forms.Label();
			this.txtConsonantes = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// lblTitulo
			// 
			this.lblTitulo.Font = new System.Drawing.Font("Monotype Corsiva", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.Location = new System.Drawing.Point(68, 23);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(362, 43);
			this.lblTitulo.TabIndex = 0;
			this.lblTitulo.Text = "VOCALES Y CONSONANTES";
			// 
			// lblPalabra
			// 
			this.lblPalabra.Location = new System.Drawing.Point(12, 103);
			this.lblPalabra.Name = "lblPalabra";
			this.lblPalabra.Size = new System.Drawing.Size(192, 23);
			this.lblPalabra.TabIndex = 1;
			this.lblPalabra.Text = "Escribe una palabra";
			// 
			// txtPalabra
			// 
			this.txtPalabra.Location = new System.Drawing.Point(188, 100);
			this.txtPalabra.Name = "txtPalabra";
			this.txtPalabra.Size = new System.Drawing.Size(250, 26);
			this.txtPalabra.TabIndex = 2;
			// 
			// btnContar
			// 
			this.btnContar.Location = new System.Drawing.Point(166, 159);
			this.btnContar.Name = "btnContar";
			this.btnContar.Size = new System.Drawing.Size(102, 38);
			this.btnContar.TabIndex = 3;
			this.btnContar.Text = "Contar";
			this.btnContar.UseVisualStyleBackColor = true;
			this.btnContar.Click += new System.EventHandler(this.BtnContarClick);
			// 
			// lblVocales
			// 
			this.lblVocales.Location = new System.Drawing.Point(55, 201);
			this.lblVocales.Name = "lblVocales";
			this.lblVocales.Size = new System.Drawing.Size(100, 23);
			this.lblVocales.TabIndex = 4;
			this.lblVocales.Text = "Vocales";
			// 
			// txtVocales
			// 
			this.txtVocales.Location = new System.Drawing.Point(38, 227);
			this.txtVocales.Name = "txtVocales";
			this.txtVocales.ReadOnly = true;
			this.txtVocales.Size = new System.Drawing.Size(100, 26);
			this.txtVocales.TabIndex = 5;
			// 
			// lblConsonantes
			// 
			this.lblConsonantes.Location = new System.Drawing.Point(269, 201);
			this.lblConsonantes.Name = "lblConsonantes";
			this.lblConsonantes.Size = new System.Drawing.Size(100, 23);
			this.lblConsonantes.TabIndex = 6;
			this.lblConsonantes.Text = "Consonantes";
			// 
			// txtConsonantes
			// 
			this.txtConsonantes.Location = new System.Drawing.Point(269, 227);
			this.txtConsonantes.Name = "txtConsonantes";
			this.txtConsonantes.ReadOnly = true;
			this.txtConsonantes.Size = new System.Drawing.Size(100, 26);
			this.txtConsonantes.TabIndex = 7;
			this.txtConsonantes.TextChanged += new System.EventHandler(this.TxtConsonantesTextChanged);
			// 
			// FrmVocales
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(488, 394);
			this.Controls.Add(this.txtConsonantes);
			this.Controls.Add(this.lblConsonantes);
			this.Controls.Add(this.txtVocales);
			this.Controls.Add(this.lblVocales);
			this.Controls.Add(this.btnContar);
			this.Controls.Add(this.txtPalabra);
			this.Controls.Add(this.lblPalabra);
			this.Controls.Add(this.lblTitulo);
			this.Name = "FrmVocales";
			this.Text = "FrmVocales";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox txtConsonantes;
		private System.Windows.Forms.Label lblConsonantes;
		private System.Windows.Forms.TextBox txtVocales;
		private System.Windows.Forms.Label lblVocales;
		private System.Windows.Forms.Button btnContar;
		private System.Windows.Forms.TextBox txtPalabra;
		private System.Windows.Forms.Label lblPalabra;
		private System.Windows.Forms.Label lblTitulo;
	}
}
