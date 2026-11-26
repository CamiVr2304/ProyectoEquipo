/*
 * Creado por SharpDevelop.
 * Usuario: jaime
 * Fecha: 25/11/2026
 * Hora: 06:56 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoEquipo
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
		void BtnEntrarClick(object sender, EventArgs e)
		{
			 if (txtUsuario.Text == "" || txtContraseña.Text == "")
    {
        MessageBox.Show("Escribe tu usuario y contraseña");
    }
    else
    {
        MessageBox.Show("Bienvenido " + txtUsuario.Text);
    }
}
		void BtnSalirClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
}
		}

