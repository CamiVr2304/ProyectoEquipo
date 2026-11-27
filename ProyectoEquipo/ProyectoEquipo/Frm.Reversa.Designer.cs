/*
 * Creado por SharpDevelop.
 * Usuario: alber
 * Fecha: 26/11/2026
 * Hora: 06:54 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace ProyectoEquipo
{
	partial class Frm_Reversa
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
			this.btnInvertir = new System.Windows.Forms.Button();
			this.lblResultado = new System.Windows.Forms.Label();
			this.txtResultado = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblTitulo
			// 
			this.lblTitulo.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.ForeColor = System.Drawing.Color.White;
			this.lblTitulo.Location = new System.Drawing.Point(26, 11);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(203, 24);
			this.lblTitulo.TabIndex = 0;
			this.lblTitulo.Text = "PALABRA AL REVÉS";
			// 
			// lblPalabra
			// 
			this.lblPalabra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPalabra.Location = new System.Drawing.Point(12, 60);
			this.lblPalabra.Name = "lblPalabra";
			this.lblPalabra.Size = new System.Drawing.Size(142, 23);
			this.lblPalabra.TabIndex = 1;
			this.lblPalabra.Text = "Escribe una palabra:";
			// 
			// txtPalabra
			// 
			this.txtPalabra.Location = new System.Drawing.Point(160, 60);
			this.txtPalabra.Name = "txtPalabra";
			this.txtPalabra.Size = new System.Drawing.Size(163, 20);
			this.txtPalabra.TabIndex = 2;
			this.txtPalabra.TextChanged += new System.EventHandler(this.TxtPalabraTextChanged);
			// 
			// btnInvertir
			// 
			this.btnInvertir.Location = new System.Drawing.Point(7, 3);
			this.btnInvertir.Name = "btnInvertir";
			this.btnInvertir.Size = new System.Drawing.Size(75, 29);
			this.btnInvertir.TabIndex = 3;
			this.btnInvertir.Text = "Invertir";
			this.btnInvertir.UseVisualStyleBackColor = true;
			this.btnInvertir.Click += new System.EventHandler(this.BtnInvertirClick);
			// 
			// lblResultado
			// 
			this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblResultado.Location = new System.Drawing.Point(169, 99);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Size = new System.Drawing.Size(100, 23);
			this.lblResultado.TabIndex = 4;
			this.lblResultado.Text = "Resultado:";
			// 
			// txtResultado
			// 
			this.txtResultado.Location = new System.Drawing.Point(160, 116);
			this.txtResultado.Name = "txtResultado";
			this.txtResultado.Size = new System.Drawing.Size(134, 20);
			this.txtResultado.TabIndex = 5;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Navy;
			this.panel1.Controls.Add(this.lblTitulo);
			this.panel1.Location = new System.Drawing.Point(40, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(242, 35);
			this.panel1.TabIndex = 6;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Navy;
			this.panel2.Controls.Add(this.btnInvertir);
			this.panel2.Location = new System.Drawing.Point(49, 108);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(86, 35);
			this.panel2.TabIndex = 7;
			this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel2Paint);
			// 
			// Frm_Reversa
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.ClientSize = new System.Drawing.Size(353, 168);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.txtResultado);
			this.Controls.Add(this.lblResultado);
			this.Controls.Add(this.txtPalabra);
			this.Controls.Add(this.lblPalabra);
			this.Name = "Frm_Reversa";
			this.Text = "Frm_Reversa";
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox txtResultado;
		private System.Windows.Forms.Label lblResultado;
		private System.Windows.Forms.Button btnInvertir;
		private System.Windows.Forms.TextBox txtPalabra;
		private System.Windows.Forms.Label lblPalabra;
		private System.Windows.Forms.Label lblTitulo;
	}
}
