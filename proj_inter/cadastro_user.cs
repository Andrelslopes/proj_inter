/*
 * Criado por SharpDevelop.
 * Usuário: RM20232930056
 * Data: 05/06/2023
 * Hora: 19:55
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;


namespace proj_inter
{
	/// <summary>
	/// Description of cadastro_user.
	/// </summary>
	public partial class cadastro_user : Form
	{
		
		string nome, email, usuario, telefone;
		int senha;
		
		public cadastro_user()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Cadastro_userLoad(object sender, EventArgs e)
		{
	
		}
		void Label7Click(object sender, EventArgs e)
		{
	
		}
		void Button1Click(object sender, EventArgs e)
		{
			
			//método irá atribuir o os valores das textbox para as variaveis
			//e posteriormente inserir o texto dentro do arquivo .txt
			nome = textBox1.Text;
			email = textBox2.Text;
			telefone = textBox3.Text;
			usuario = textBox4.Text;
			
			//senha = int.Parse(textBox5.Text);
			//if (senha != int) {
			//	MessageBox.Show("Favor digitar uma sequencia de numeros");
			//}
			//irá criar um um arquivo .txt no local indicado.
			StreamWriter x = new StreamWriter (@"U:\ETEC\PA - Programação e Algoritmos\doc\"+usuario+".txt");
			MessageBox.Show("Seu Cadastro foi Realizado com Sucesso");
			
			//gravar as informações digitadas pelo usuário no form dentro do arquivo txt
			x.WriteLine(nome);
			x.WriteLine(email);
			x.WriteLine(telefone);
			x.WriteLine(usuario);
			x.WriteLine(senha);
			x.Close();
		}
		void Button2Click(object sender, EventArgs e)
		{
			this.Visible = false;
			Login Login = new Login();
			Login.ShowDialog();
		}
	}
}
