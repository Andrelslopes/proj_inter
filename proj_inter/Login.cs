/*
 * Criado por SharpDevelop.
 * Usuário: RM20232930056
 * Data: 29/05/2023
 * Hora: 20:27
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace proj_inter
{
	/// <summary>
	/// Description of Login.
	/// </summary>
	public partial class Login : Form
	{
		int contador = 5;
		public Login()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Button1Click(object sender, EventArgs e)
		{
			contador -= 1;
						
			if (contador <= 0)
			{
				MessageBox.Show("Usuário ou Senha Inválidos" , "Acesso Negado!");
				this.Close();// depois que aparecer a mensagem irá fechar.
				
			} else {
				if(textBox1.Text == "andre" && textBox2.Text == "341918"){ // o que for definido em cada textbox será validado nos campo login e senha
					//MainForm Mainform = new MainForm();
					MessageBox.Show("Acesso confirmado!\n ");
					
					this.Visible = false;
					Cadastro Cadastro = new Cadastro();
					Cadastro.ShowDialog();
					this.Hide();
					this.Close();
				} else {
					MessageBox.Show(" Usuário ou Senha invalidos \n" + "Errou - restam " + contador + " tentativas");
				}
				
			}
		}
		
		void Label1Click(object sender, EventArgs e)
		{
			
		}
		void TextBox1TextChanged(object sender, EventArgs e)
		{
			
		}
		void Label2Click(object sender, EventArgs e)
		{
			
		}
		void TextBox2TextChanged(object sender, EventArgs e)
		{
			
		}
		void Button3Click(object sender, EventArgs e)
		{
			cadastro_user cadastro_user = new cadastro_user();
			cadastro_user.ShowDialog();
			this.Hide();
			this.Close();
			
		}
	}
}
