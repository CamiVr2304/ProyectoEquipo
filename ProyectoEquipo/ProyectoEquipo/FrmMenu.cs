/*
 * Creado por SharpDevelop.
 * Usuario: jaime
 * Fecha: 25/11/2026
 * Hora: 07:17 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoEquipo
{
	/// <summary>
	/// Description of FrmMenu.
	/// </summary>
	public partial class FrmMenu : Form
	{
		public FrmMenu()
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
			  MessageBox.Show("Programa de ordenar arreglos");
		}
		void BtnMayorMenorClick(object sender, EventArgs e)
		{
			 MessageBox.Show("Programa de mayor, menor y promedio");
		}
		void BtnReversaClick(object sender, EventArgs e)
		{
			 MessageBox.Show("Programa de palabra al reves");
		}
		void BtnVocalesClick(object sender, EventArgs e)
		{
			MessageBox.Show("Programa de vocales y consonantes");
		}
		void BtnSalirClick(object sender, EventArgs e)
		{
			FrmLogin login = new FrmLogin();
    		login.Show();
    		this.Close();
		}
	}
}
