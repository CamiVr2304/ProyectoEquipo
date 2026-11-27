/*
 * Creado por SharpDevelop.
 * Usuario: CC2_PC17
 * Fecha: 26/11/2026
 * Hora: 07:31 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Mayor_Menor_y_Promedio
{
	partial class MainForm
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
			this.txtNumeros = new System.Windows.Forms.TextBox();
			this.btnCalcular = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.lblMayor = new System.Windows.Forms.Label();
			this.lblMenor = new System.Windows.Forms.Label();
			this.lblPromedio = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtNumeros
			// 
			this.txtNumeros.Location = new System.Drawing.Point(66, 42);
			this.txtNumeros.Name = "txtNumeros";
			this.txtNumeros.Size = new System.Drawing.Size(162, 20);
			this.txtNumeros.TabIndex = 0;
			// 
			// btnCalcular
			// 
			this.btnCalcular.Location = new System.Drawing.Point(109, 82);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(75, 23);
			this.btnCalcular.TabIndex = 1;
			this.btnCalcular.Text = "Calcular";
			this.btnCalcular.UseVisualStyleBackColor = true;
			this.btnCalcular.Click += new System.EventHandler(this.BtnCalcularClick);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(52, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(202, 23);
			this.label1.TabIndex = 5;
			this.label1.Text = "Ingresa números separados por coma:";
			// 
			// lblMayor
			// 
			this.lblMayor.Location = new System.Drawing.Point(66, 125);
			this.lblMayor.Name = "lblMayor";
			this.lblMayor.Size = new System.Drawing.Size(100, 23);
			this.lblMayor.TabIndex = 6;
			this.lblMayor.Text = "Mayor: ";
			// 
			// lblMenor
			// 
			this.lblMenor.Location = new System.Drawing.Point(66, 152);
			this.lblMenor.Name = "lblMenor";
			this.lblMenor.Size = new System.Drawing.Size(100, 23);
			this.lblMenor.TabIndex = 7;
			this.lblMenor.Text = "Menor:";
			// 
			// lblPromedio
			// 
			this.lblPromedio.Location = new System.Drawing.Point(66, 179);
			this.lblPromedio.Name = "lblPromedio";
			this.lblPromedio.Size = new System.Drawing.Size(100, 23);
			this.lblPromedio.TabIndex = 8;
			this.lblPromedio.Text = "Promedio:";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.lblPromedio);
			this.Controls.Add(this.lblMenor);
			this.Controls.Add(this.lblMayor);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnCalcular);
			this.Controls.Add(this.txtNumeros);
			this.Name = "MainForm";
			this.Text = "Mayor,Menor y Promedio";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label lblPromedio;
		private System.Windows.Forms.Label lblMenor;
		private System.Windows.Forms.Label lblMayor;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnCalcular;
		private System.Windows.Forms.TextBox txtNumeros;
	}
}
