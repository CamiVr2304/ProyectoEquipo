/*
 * Creado por SharpDevelop.
 * Usuario: CC2_PC19
 * Fecha: 26/11/2026
 * Hora: 07:19 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoEquipo
{
	/// <summary>
	/// Description of FrmOrdenar.
	/// </summary>
	public partial class FrmOrdenar : Form
	{
		public FrmOrdenar()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnOrdenarClick(object sender, EventArgs e)
		{
			
    		if (txtNumeros.Text == "")
    		{
        		MessageBox.Show("Escribe los numeros");
    		}
    		else
    		{
        		try
        		{
            		string[] datos = txtNumeros.Text.Split(',');
            		int[] numeros = new int[datos.Length];


            		for (int i = 0; i < datos.Length; i++)
            		{
                		numeros[i] = int.Parse(datos[i].Trim());
            		}


            		Array.Sort(numeros);


            		txtAscendente.Text = "";


            		for (int i = 0; i < numeros.Length; i++)
            		{
                		txtAscendente.Text += numeros[i] + " ";
            		}


            		txtDescendente.Text = "";


            		for (int i = numeros.Length - 1; i >= 0; i--)
            		{
                		txtDescendente.Text += numeros[i] + " ";
            		}
        		}
        		catch
        		{
            		MessageBox.Show("Escribe solamente numeros separados por comas");
				}
			}
		}
		
		void BtnLimpiarClick(object sender, EventArgs e)
		{
			txtNumeros.Clear();
    		txtAscendente.Clear();
    		txtDescendente.Clear();
		}
	}
}