/*
 * Creado por SharpDevelop.
 * Usuario: CC2_PC17
 * Fecha: 26/11/2026
 * Hora: 07:31 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Mayor_Menor_y_Promedio
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void BtnCalcularClick(object sender, EventArgs e)
		{
			try 
			{
				double[] numeros = txtNumeros.Text
					.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
					.Select(n => double.Parse(n.Trim()))
					.ToArray();

				if (numeros.Length == 0)
				{
					MessageBox.Show("Por favor ingresa al menos un número.");
					return;
				}

				double mayor = numeros.Max();
				double menor = numeros.Min();
				double promedio = numeros.Average();

				lblMayor.Text = "Mayor: " + mayor;
				lblMenor.Text = "Menor: " + menor;
				lblPromedio.Text = "Promedio: " + Math.Round(promedio, 2);
			}
			catch (FormatException)
			{
				MessageBox.Show("Error: Asegúrate de escribir solo números separados por comas (Ej: 10, 5.5, 20).");
			}
	
		}

	}
}