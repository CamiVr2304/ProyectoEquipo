/*
 * Creado por SharpDevelop.
 * Usuario: CC2_PC19
 * Fecha: 26/11/2026
 * Hora: 07:19 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace ProyectoEquipo
{
	partial class FrmOrdenar
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
			this.lblNumeros = new System.Windows.Forms.Label();
			this.txtNumeros = new System.Windows.Forms.TextBox();
			this.btnOrdenar = new System.Windows.Forms.Button();
			this.lblMenorMayor = new System.Windows.Forms.Label();
			this.txtAscendente = new System.Windows.Forms.TextBox();
			this.lblMayorMenor = new System.Windows.Forms.Label();
			this.txtDescendente = new System.Windows.Forms.TextBox();
			this.btnLimpiar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblTitulo
			// 
			this.lblTitulo.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.Location = new System.Drawing.Point(37, 9);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(211, 23);
			this.lblTitulo.TabIndex = 0;
			this.lblTitulo.Text = "ORDENAR ARREGLOS";
			// 
			// lblNumeros
			// 
			this.lblNumeros.Location = new System.Drawing.Point(12, 51);
			this.lblNumeros.Name = "lblNumeros";
			this.lblNumeros.Size = new System.Drawing.Size(141, 23);
			this.lblNumeros.TabIndex = 1;
			this.lblNumeros.Text = "Ingresa los numeros";
			// 
			// txtNumeros
			// 
			this.txtNumeros.Location = new System.Drawing.Point(131, 48);
			this.txtNumeros.Name = "txtNumeros";
			this.txtNumeros.Size = new System.Drawing.Size(100, 20);
			this.txtNumeros.TabIndex = 2;
			// 
			// btnOrdenar
			// 
			this.btnOrdenar.Location = new System.Drawing.Point(37, 164);
			this.btnOrdenar.Name = "btnOrdenar";
			this.btnOrdenar.Size = new System.Drawing.Size(75, 23);
			this.btnOrdenar.TabIndex = 3;
			this.btnOrdenar.Text = "Ordenar";
			this.btnOrdenar.UseVisualStyleBackColor = true;
			this.btnOrdenar.Click += new System.EventHandler(this.BtnOrdenarClick);
			// 
			// lblMenorMayor
			// 
			this.lblMenorMayor.Location = new System.Drawing.Point(13, 96);
			this.lblMenorMayor.Name = "lblMenorMayor";
			this.lblMenorMayor.Size = new System.Drawing.Size(100, 23);
			this.lblMenorMayor.TabIndex = 4;
			this.lblMenorMayor.Text = "Menor a Mayor";
			// 
			// txtAscendente
			// 
			this.txtAscendente.Location = new System.Drawing.Point(131, 93);
			this.txtAscendente.Name = "txtAscendente";
			this.txtAscendente.Size = new System.Drawing.Size(100, 20);
			this.txtAscendente.TabIndex = 5;
			// 
			// lblMayorMenor
			// 
			this.lblMayorMenor.Location = new System.Drawing.Point(13, 119);
			this.lblMayorMenor.Name = "lblMayorMenor";
			this.lblMayorMenor.Size = new System.Drawing.Size(100, 23);
			this.lblMayorMenor.TabIndex = 6;
			this.lblMayorMenor.Text = "Mayor a Menor";
			// 
			// txtDescendente
			// 
			this.txtDescendente.Location = new System.Drawing.Point(131, 119);
			this.txtDescendente.Name = "txtDescendente";
			this.txtDescendente.Size = new System.Drawing.Size(100, 20);
			this.txtDescendente.TabIndex = 7;
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.Location = new System.Drawing.Point(141, 164);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
			this.btnLimpiar.TabIndex = 8;
			this.btnLimpiar.Text = "Limpiar";
			this.btnLimpiar.UseVisualStyleBackColor = true;
			this.btnLimpiar.Click += new System.EventHandler(this.BtnLimpiarClick);
			// 
			// FrmOrdenar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.btnLimpiar);
			this.Controls.Add(this.txtDescendente);
			this.Controls.Add(this.lblMayorMenor);
			this.Controls.Add(this.txtAscendente);
			this.Controls.Add(this.lblMenorMayor);
			this.Controls.Add(this.btnOrdenar);
			this.Controls.Add(this.txtNumeros);
			this.Controls.Add(this.lblNumeros);
			this.Controls.Add(this.lblTitulo);
			this.Name = "FrmOrdenar";
			this.Text = "FrmOrdenar";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnLimpiar;
		private System.Windows.Forms.TextBox txtDescendente;
		private System.Windows.Forms.Label lblMayorMenor;
		private System.Windows.Forms.TextBox txtAscendente;
		private System.Windows.Forms.Label lblMenorMayor;
		private System.Windows.Forms.Button btnOrdenar;
		private System.Windows.Forms.TextBox txtNumeros;
		private System.Windows.Forms.Label lblNumeros;
		private System.Windows.Forms.Label lblTitulo;
	}
}
