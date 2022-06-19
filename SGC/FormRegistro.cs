using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace SGC
{
	public class FormRegistro : Form
	{
		private string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

		private IContainer components = null;

		private Panel panel1;

		private Button button2;

		private Button button1;

		private TextBox tbSenha;

		private TextBox tbEndereco;

		private TextBox tbNomeC;

		private Label label3;

		private Label label2;

		private TextBox txtBack;

		private Label label4;

		private Label label1;

		public FormRegistro()
		{
			InitializeComponent();
		}

		private void tbNomeC_TextChanged(object sender, EventArgs e)
		{
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Dispose();
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		private void GravaRegistro()
		{
			string nomeCartorio = tbNomeC.Text;
			string endereco = tbEndereco.Text;
			string[] newRegistro = new string[2] { nomeCartorio, endereco };
			if (verifica())
			{
				File.WriteAllLines(path, newRegistro);
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			string senhageral = "0000";
			string senha = tbSenha.Text;
			if (senhageral.Equals(senha))
			{
				GravaRegistro();
				try
				{
					MessageBox.Show("Novo Registro Cadastrado com sucesso", "Registro completo");
					tbNomeC.Clear();
					tbEndereco.Clear();
				}
				catch
				{
					MessageBox.Show("Erro ao criar o registro", "Erro");
				}
			}
		}

		private bool verifica()
		{
			path += "\\regex.zin";
			if (File.Exists(path))
			{
				return true;
			}
			DialogResult result3 = MessageBox.Show("O Arquivo de configurações não foi encontrado deseja criar um novo ?", "Arquivo não encontrado", MessageBoxButtons.YesNo);
			if (result3 == DialogResult.Yes)
			{
				FileInfo aFile = new FileInfo(path);
				aFile.Create();
				return true;
			}
			return true;
		}

		private void FormRegistro_Load(object sender, EventArgs e)
		{
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SGC.FormRegistro));
			panel1 = new System.Windows.Forms.Panel();
			button2 = new System.Windows.Forms.Button();
			button1 = new System.Windows.Forms.Button();
			tbSenha = new System.Windows.Forms.TextBox();
			tbEndereco = new System.Windows.Forms.TextBox();
			tbNomeC = new System.Windows.Forms.TextBox();
			label3 = new System.Windows.Forms.Label();
			label2 = new System.Windows.Forms.Label();
			label1 = new System.Windows.Forms.Label();
			label4 = new System.Windows.Forms.Label();
			txtBack = new System.Windows.Forms.TextBox();
			panel1.SuspendLayout();
			SuspendLayout();
			panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			panel1.Controls.Add(txtBack);
			panel1.Controls.Add(label4);
			panel1.Controls.Add(button2);
			panel1.Controls.Add(button1);
			panel1.Controls.Add(tbSenha);
			panel1.Controls.Add(tbEndereco);
			panel1.Controls.Add(tbNomeC);
			panel1.Controls.Add(label3);
			panel1.Controls.Add(label2);
			panel1.Controls.Add(label1);
			panel1.Location = new System.Drawing.Point(12, 12);
			panel1.Name = "panel1";
			panel1.Size = new System.Drawing.Size(410, 272);
			panel1.TabIndex = 0;
			panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
			button2.Location = new System.Drawing.Point(223, 230);
			button2.Name = "button2";
			button2.Size = new System.Drawing.Size(80, 31);
			button2.TabIndex = 7;
			button2.Text = "Salvar";
			button2.UseVisualStyleBackColor = true;
			button2.Click += new System.EventHandler(button2_Click);
			button1.Location = new System.Drawing.Point(119, 230);
			button1.Name = "button1";
			button1.Size = new System.Drawing.Size(80, 31);
			button1.TabIndex = 6;
			button1.Text = "Cancelar";
			button1.UseVisualStyleBackColor = true;
			button1.Click += new System.EventHandler(button1_Click);
			tbSenha.Location = new System.Drawing.Point(119, 194);
			tbSenha.Name = "tbSenha";
			tbSenha.Size = new System.Drawing.Size(184, 20);
			tbSenha.TabIndex = 5;
			tbSenha.UseSystemPasswordChar = true;
			tbEndereco.Location = new System.Drawing.Point(101, 111);
			tbEndereco.Name = "tbEndereco";
			tbEndereco.Size = new System.Drawing.Size(292, 20);
			tbEndereco.TabIndex = 4;
			tbNomeC.Location = new System.Drawing.Point(101, 47);
			tbNomeC.Name = "tbNomeC";
			tbNomeC.Size = new System.Drawing.Size(292, 20);
			tbNomeC.TabIndex = 3;
			tbNomeC.TextChanged += new System.EventHandler(tbNomeC_TextChanged);
			label3.AutoSize = true;
			label3.Location = new System.Drawing.Point(159, 174);
			label3.Name = "label3";
			label3.Size = new System.Drawing.Size(98, 13);
			label3.TabIndex = 2;
			label3.Text = "Senha de Controle:";
			label2.AutoSize = true;
			label2.Location = new System.Drawing.Point(39, 114);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(56, 13);
			label2.TabIndex = 1;
			label2.Text = "Endereço:";
			label1.AutoSize = true;
			label1.Location = new System.Drawing.Point(3, 50);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(92, 13);
			label1.TabIndex = 0;
			label1.Text = "Nome do Cartório:";
			label4.AutoSize = true;
			label4.Location = new System.Drawing.Point(4, 140);
			label4.Name = "label4";
			label4.Size = new System.Drawing.Size(91, 13);
			label4.TabIndex = 8;
			label4.Text = "Local do Backup:";
			label4.Click += new System.EventHandler(label4_Click);
			txtBack.Location = new System.Drawing.Point(101, 137);
			txtBack.Name = "txtBack";
			txtBack.Size = new System.Drawing.Size(292, 20);
			txtBack.TabIndex = 9;
			base.ClientSize = new System.Drawing.Size(434, 296);
			base.Controls.Add(panel1);
			base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "FormRegistro";
			base.ShowInTaskbar = false;
			base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			Text = "Registro";
			base.Load += new System.EventHandler(FormRegistro_Load);
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			ResumeLayout(false);
		}

		private void label4_Click(object sender, EventArgs e)
		{
		}
	}
}
