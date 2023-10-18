/*
 * Criado por SharpDevelop.
 * Usuário: RM20232930056
 * Data: 29/05/2023
 * Hora: 19:31
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace proj_inter
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
		void Label1Click(object sender, EventArgs e)
		{
	
		}
		void Label2Click(object sender, EventArgs e)
		{
	
		}
		void Timer1Tick(object sender, EventArgs e)
		{
			if (progressBar1.Value < 100)
			{
				progressBar1.Value =  progressBar1.Value +2;
			} else {
				timer1.Enabled = false;
				this.Visible = false;
				Login Login = new Login(); // chamar a tela de login
				Login.ShowDialog();
			
			}
		}
			
	}
}
