/*
 * Creado por SharpDevelop.
 * Usuario: alber
 * Fecha: 26/11/2026
 * Hora: 06:54 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoEquipo
{
	/// <summary>
	/// Description of Frm_Reversa.
	/// </summary>
	public partial class Frm_Reversa : Form
	{
		public Frm_Reversa()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Panel2Paint(object sender, PaintEventArgs e)
		{
			
		}
		
		void TxtPalabraTextChanged(object sender, EventArgs e)
		{
			
		}
		
		void BtnInvertirClick(object sender, EventArgs e)
		{
			if(txtPalabra.Text=="")
			{
				MessageBox.Show("Escribe una palabra");
			}
			else
			{
				string palabra=txtPalabra.Text;
				string resultado="";
				
				for(int i=palabra.Length - 1; i>=0; i--)
				{
					resultado=resultado+palabra[i];
				}
				
				txtResultado.Text=resultado;
				
				
			}
		}
	}
}
