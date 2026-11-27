/*
 * Creado por SharpDevelop.
 * Usuario: Lenovo
 * Fecha: 26/11/2026
 * Hora: 09:38 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoEquipo
{
	/// <summary>
	/// Description of FrmVocales.
	/// </summary>
	public partial class FrmVocales : Form
	{
		public FrmVocales()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void TxtConsonantesTextChanged(object sender, EventArgs e)
		{
			
		}
		
		void BtnContarClick(object sender, EventArgs e)
		{
    		string palabra;
    		int vocales = 0;
    		int consonantes = 0;

    	palabra = txtPalabra.Text.ToUpper();

    		if (palabra == "")
    		{
        		MessageBox.Show("Escribe una palabra");
    		}
    		else
    		{
        		for (int i = 0; i < palabra.Length; i++)
        		{
            		if (palabra[i] == 'A' ||
                		palabra[i] == 'E' ||
                		palabra[i] == 'I' ||
                		palabra[i] == 'O' ||
                		palabra[i] == 'U')
            		{
                		vocales = vocales + 1;
            		}
            		else if (palabra[i] >= 'A' &&
                     		palabra[i] <= 'Z')
            		{
                		consonantes = consonantes + 1;
            		}
        		}

        		txtVocales.Text = vocales.ToString();
        		txtConsonantes.Text = consonantes.ToString();
    		}
		}
				
	}
}
