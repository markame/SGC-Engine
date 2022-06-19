using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SGC
{
	public class FormLogin : Form
	{
		private IContainer components = null;

		private Panel panel1;

		private Button bntLogin;

		private Button button1;

		private TextBox txSenha;

		private TextBox txUser;

		private Label label2;

		private Label label1;

		private Panel panel2;

		public FormLogin()
		{
			InitializeComponent();
			conect_querygeneric conect = new conect_querygeneric();
			conect.DAO();
		}

		private void bntLogin_Click(object sender, EventArgs e)
		{
			conect_querygeneric login = new conect_querygeneric();
			dados d = new dados();
			string user = txUser.Text;
			string senha = txSenha.Text;
			if (user == "" || senha == "")
			{
				MessageBox.Show("Campo Usuário ou Senha não podem ficar em branco", "Algo está faltando !");
				return;
			}
			string queryAUTH = "SELECT usuario,senha FROM usuario WHERE usuario='" + user + "' AND senha='" + senha + "'";
			string queryAT = "SELECT * FROM usuario WHERE usuario='" + user + "' AND senha='" + senha + "'";
			if (login.QUERYAUTH(queryAUTH))
			{
				d.getdata(queryAT);
				Hide();
				FormPrincipal main = new FormPrincipal();
				main.Show();
			}
			else
			{
				MessageBox.Show("Login ou Senha incorretos tente com um login valído\nSe você não tem um login entre em contato com o usuário master", "Erro ao logar");
			}
		}

		public void fechar()
		{
			Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void timerProgress_Tick(object sender, EventArgs e)
		{
		}

		private void pbCarrega_Click(object sender, EventArgs e)
		{
		}

		public void ThreadSafeClose()
		{
			if (base.InvokeRequired)
			{
				Invoke(new MethodInvoker(base.Close));
			}
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SGC.FormLogin));
			panel1 = new System.Windows.Forms.Panel();
			bntLogin = new System.Windows.Forms.Button();
			button1 = new System.Windows.Forms.Button();
			txSenha = new System.Windows.Forms.TextBox();
			txUser = new System.Windows.Forms.TextBox();
			label2 = new System.Windows.Forms.Label();
			label1 = new System.Windows.Forms.Label();
			panel2 = new System.Windows.Forms.Panel();
			panel1.SuspendLayout();
			SuspendLayout();
			panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			panel1.Controls.Add(bntLogin);
			panel1.Controls.Add(button1);
			panel1.Controls.Add(txSenha);
			panel1.Controls.Add(txUser);
			panel1.Controls.Add(label2);
			panel1.Controls.Add(label1);
			panel1.Controls.Add(panel2);
			panel1.Location = new System.Drawing.Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new System.Drawing.Size(776, 327);
			panel1.TabIndex = 0;
			bntLogin.Location = new System.Drawing.Point(629, 227);
			bntLogin.Name = "bntLogin";
			bntLogin.Size = new System.Drawing.Size(98, 35);
			bntLogin.TabIndex = 6;
			bntLogin.Text = "Login";
			bntLogin.UseVisualStyleBackColor = true;
			bntLogin.Click += new System.EventHandler(bntLogin_Click);
			button1.Location = new System.Drawing.Point(496, 227);
			button1.Name = "button1";
			button1.Size = new System.Drawing.Size(98, 35);
			button1.TabIndex = 5;
			button1.Text = "Cancelar";
			button1.UseVisualStyleBackColor = true;
			button1.Click += new System.EventHandler(button1_Click);
			txSenha.Location = new System.Drawing.Point(546, 133);
			txSenha.Name = "txSenha";
			txSenha.Size = new System.Drawing.Size(181, 20);
			txSenha.TabIndex = 4;
			txSenha.UseSystemPasswordChar = true;
			txUser.Location = new System.Drawing.Point(547, 54);
			txUser.Name = "txUser";
			txUser.Size = new System.Drawing.Size(181, 20);
			txUser.TabIndex = 3;
			label2.AutoSize = true;
			label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			label2.Location = new System.Drawing.Point(470, 128);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(70, 24);
			label2.TabIndex = 2;
			label2.Text = "Senha:";
			label1.AutoSize = true;
			label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			label1.Location = new System.Drawing.Point(461, 53);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(79, 24);
			label1.TabIndex = 1;
			label1.Text = "Usuário:";
			panel2.BackgroundImage = (System.Drawing.Image)resources.GetObject("panel2.BackgroundImage");
			panel2.Location = new System.Drawing.Point(11, 25);
			panel2.Name = "panel2";
			panel2.Size = new System.Drawing.Size(435, 271);
			panel2.TabIndex = 0;
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.MaximizeBox = false;
			BackColor = System.Drawing.SystemColors.ButtonHighlight;
			base.ClientSize = new System.Drawing.Size(775, 327);
			base.Controls.Add(panel1);
			base.MinimizeBox = false;
			base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.Name = "FormLogin";
			base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			Text = "Login";
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			ResumeLayout(false);
		}
	}
}
