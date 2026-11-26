/*
 * Creado por SharpDevelop.
 * Usuario: jaime
 * Fecha: 25/11/2026
 * Hora: 07:17 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace ProyectoEquipo
{
	partial class FrmMenu
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnOrdenar;
		private System.Windows.Forms.Button btnReversa;
		private System.Windows.Forms.Button btnMayorMenor;
		private System.Windows.Forms.Button btnVocales;
		private System.Windows.Forms.Button btnSalir;
		
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnOrdenar = new System.Windows.Forms.Button();
			this.btnReversa = new System.Windows.Forms.Button();
			this.btnMayorMenor = new System.Windows.Forms.Button();
			this.btnVocales = new System.Windows.Forms.Button();
			this.btnSalir = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Ravie", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(53, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(232, 34);
			this.label1.TabIndex = 0;
			this.label1.Text = "MENU PRINCIPAL";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(83, 53);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(164, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Selecciona un Programa";
			// 
			// btnOrdenar
			// 
			this.btnOrdenar.Location = new System.Drawing.Point(53, 97);
			this.btnOrdenar.Name = "btnOrdenar";
			this.btnOrdenar.Size = new System.Drawing.Size(101, 59);
			this.btnOrdenar.TabIndex = 2;
			this.btnOrdenar.Text = "ORDENAR ARREGLOS";
			this.btnOrdenar.UseVisualStyleBackColor = true;
			this.btnOrdenar.Click += new System.EventHandler(this.BtnOrdenarClick);
			// 
			// btnReversa
			// 
			this.btnReversa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnReversa.Location = new System.Drawing.Point(53, 162);
			this.btnReversa.Name = "btnReversa";
			this.btnReversa.Size = new System.Drawing.Size(101, 59);
			this.btnReversa.TabIndex = 3;
			this.btnReversa.Text = "Reversa";
			this.btnReversa.UseVisualStyleBackColor = true;
			this.btnReversa.Click += new System.EventHandler(this.BtnReversaClick);
			// 
			// btnMayorMenor
			// 
			this.btnMayorMenor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMayorMenor.Location = new System.Drawing.Point(173, 97);
			this.btnMayorMenor.Name = "btnMayorMenor";
			this.btnMayorMenor.Size = new System.Drawing.Size(101, 59);
			this.btnMayorMenor.TabIndex = 4;
			this.btnMayorMenor.Text = "Mayor,Menor y Promedio";
			this.btnMayorMenor.UseVisualStyleBackColor = true;
			this.btnMayorMenor.Click += new System.EventHandler(this.BtnMayorMenorClick);
			// 
			// btnVocales
			// 
			this.btnVocales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnVocales.Location = new System.Drawing.Point(173, 162);
			this.btnVocales.Name = "btnVocales";
			this.btnVocales.Size = new System.Drawing.Size(101, 59);
			this.btnVocales.TabIndex = 5;
			this.btnVocales.Text = "Vocales y Consonantes";
			this.btnVocales.UseVisualStyleBackColor = true;
			this.btnVocales.Click += new System.EventHandler(this.BtnVocalesClick);
			// 
			// btnSalir
			// 
			this.btnSalir.Location = new System.Drawing.Point(99, 243);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(123, 26);
			this.btnSalir.TabIndex = 6;
			this.btnSalir.Text = "Cerrar Sesion";
			this.btnSalir.UseVisualStyleBackColor = true;
			this.btnSalir.Click += new System.EventHandler(this.BtnSalirClick);
			// 
			// FrmMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(334, 312);
			this.Controls.Add(this.btnSalir);
			this.Controls.Add(this.btnVocales);
			this.Controls.Add(this.btnMayorMenor);
			this.Controls.Add(this.btnReversa);
			this.Controls.Add(this.btnOrdenar);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "FrmMenu";
			this.Text = "FrmMenu";
			this.ResumeLayout(false);

		}
	}
}
