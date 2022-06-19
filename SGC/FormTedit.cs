using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SGC
{
	public class FormTedit : Form
	{
		private IContainer components = null;

		private Label label3;

		private Label label1;

		private Button btn_cancel;

		private Button btn_save;

		private RichTextBox rt_observacao;

		private TextBox tb_senha;

		private TextBox tb_usuario;

		private TextBox tb_email;

		private TextBox tb_nome;

		private Label label8;

		private DateTimePicker ms_data;

		private TextBox tb_funcao;

		private TextBox tb_cod;

		private GroupBox groupBox1;

		private Label label2;

		private Label label7;

		private Label label6;

		private Label label5;

		private GroupBox groupBox2;

		private Label label4;

		private Panel panel1;

		public FormTedit()
		{
			InitializeComponent();
			iniciaedit();
		}

		private void FormTedit_Load(object sender, EventArgs e)
		{
		}

		private void iniciaedit()
		{
			edittab editdados = new edittab();
			tb_cod.Text = editdados.GetCodigo();
			tb_funcao.Text = editdados.Getfuncao();
			tb_nome.Text = editdados.GetNome();
			tb_usuario.Text = editdados.GetUser();
			rt_observacao.Text = editdados.Getobser();
		}

		private void btn_save_Click(object sender, EventArgs e)
		{
			conect_querygeneric openconector = new conect_querygeneric();
			openconector.DAO();
			string codigo = tb_cod.Text;
			string funcao = tb_funcao.Text;
			string data_entrada = ms_data.Text;
			string nome = tb_nome.Text;
			string usuario = tb_usuario.Text;
			string email = tb_email.Text;
			string senha = tb_senha.Text;
			string obser = rt_observacao.Text;
			if (funcao == "" || data_entrada == "" || nome == "" || usuario == "" || email == "" || email == "" || senha == "")
			{
				MessageBox.Show("Nenhum campo pode ficar vazio");
				return;
			}
			string queryInsere = "UPDATE usuario SET nome='" + nome + "',funcao='" + funcao + "',data='" + data_entrada + "',email='" + email + "',usuario='" + usuario + "',senha='" + senha + "',observacao='" + obser + "'WHERE id_Usuario='" + codigo + "'";
			string querySelect = "SELECT * FROM usuario WHERE usuario='" + usuario + "'";
			openconector.UPDATEGENERIC(queryInsere);
			Close();
		}

		private void btn_cancel_Click(object sender, EventArgs e)
		{
			Close();
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
			label3 = new System.Windows.Forms.Label();
			label1 = new System.Windows.Forms.Label();
			btn_cancel = new System.Windows.Forms.Button();
			btn_save = new System.Windows.Forms.Button();
			rt_observacao = new System.Windows.Forms.RichTextBox();
			tb_senha = new System.Windows.Forms.TextBox();
			tb_usuario = new System.Windows.Forms.TextBox();
			tb_email = new System.Windows.Forms.TextBox();
			tb_nome = new System.Windows.Forms.TextBox();
			label8 = new System.Windows.Forms.Label();
			ms_data = new System.Windows.Forms.DateTimePicker();
			tb_funcao = new System.Windows.Forms.TextBox();
			tb_cod = new System.Windows.Forms.TextBox();
			groupBox1 = new System.Windows.Forms.GroupBox();
			label2 = new System.Windows.Forms.Label();
			label7 = new System.Windows.Forms.Label();
			label6 = new System.Windows.Forms.Label();
			label5 = new System.Windows.Forms.Label();
			groupBox2 = new System.Windows.Forms.GroupBox();
			label4 = new System.Windows.Forms.Label();
			panel1 = new System.Windows.Forms.Panel();
			groupBox1.SuspendLayout();
			groupBox2.SuspendLayout();
			panel1.SuspendLayout();
			SuspendLayout();
			label3.AutoSize = true;
			label3.Location = new System.Drawing.Point(379, 34);
			label3.Name = "label3";
			label3.Size = new System.Drawing.Size(88, 13);
			label3.TabIndex = 2;
			label3.Text = "Data de Entrada:";
			label1.AutoSize = true;
			label1.Location = new System.Drawing.Point(6, 34);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(43, 13);
			label1.TabIndex = 0;
			label1.Text = "Código:";
			btn_cancel.Location = new System.Drawing.Point(374, 243);
			btn_cancel.Name = "btn_cancel";
			btn_cancel.Size = new System.Drawing.Size(93, 33);
			btn_cancel.TabIndex = 14;
			btn_cancel.Text = "Cancelar";
			btn_cancel.UseVisualStyleBackColor = true;
			btn_cancel.Click += new System.EventHandler(btn_cancel_Click);
			btn_save.Location = new System.Drawing.Point(481, 243);
			btn_save.Name = "btn_save";
			btn_save.Size = new System.Drawing.Size(93, 33);
			btn_save.TabIndex = 13;
			btn_save.Text = "Salvar";
			btn_save.UseVisualStyleBackColor = true;
			btn_save.Click += new System.EventHandler(btn_save_Click);
			rt_observacao.Location = new System.Drawing.Point(6, 124);
			rt_observacao.Name = "rt_observacao";
			rt_observacao.Size = new System.Drawing.Size(568, 96);
			rt_observacao.TabIndex = 12;
			rt_observacao.Text = "";
			tb_senha.Location = new System.Drawing.Point(382, 68);
			tb_senha.Name = "tb_senha";
			tb_senha.Size = new System.Drawing.Size(192, 20);
			tb_senha.TabIndex = 11;
			tb_senha.UseSystemPasswordChar = true;
			tb_usuario.Location = new System.Drawing.Point(382, 30);
			tb_usuario.Name = "tb_usuario";
			tb_usuario.Size = new System.Drawing.Size(192, 20);
			tb_usuario.TabIndex = 10;
			tb_email.Location = new System.Drawing.Point(50, 68);
			tb_email.Name = "tb_email";
			tb_email.Size = new System.Drawing.Size(274, 20);
			tb_email.TabIndex = 9;
			tb_nome.Location = new System.Drawing.Point(50, 30);
			tb_nome.Name = "tb_nome";
			tb_nome.Size = new System.Drawing.Size(274, 20);
			tb_nome.TabIndex = 6;
			label8.AutoSize = true;
			label8.Location = new System.Drawing.Point(6, 99);
			label8.Name = "label8";
			label8.Size = new System.Drawing.Size(73, 13);
			label8.TabIndex = 7;
			label8.Text = "Observações:";
			ms_data.Enabled = false;
			ms_data.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			ms_data.Location = new System.Drawing.Point(473, 31);
			ms_data.Name = "ms_data";
			ms_data.Size = new System.Drawing.Size(101, 20);
			ms_data.TabIndex = 6;
			tb_funcao.Location = new System.Drawing.Point(250, 31);
			tb_funcao.Name = "tb_funcao";
			tb_funcao.Size = new System.Drawing.Size(121, 20);
			tb_funcao.TabIndex = 4;
			tb_cod.Enabled = false;
			tb_cod.Location = new System.Drawing.Point(56, 31);
			tb_cod.Name = "tb_cod";
			tb_cod.Size = new System.Drawing.Size(129, 20);
			tb_cod.TabIndex = 3;
			groupBox1.Controls.Add(ms_data);
			groupBox1.Controls.Add(tb_funcao);
			groupBox1.Controls.Add(tb_cod);
			groupBox1.Controls.Add(label3);
			groupBox1.Controls.Add(label2);
			groupBox1.Controls.Add(label1);
			groupBox1.Location = new System.Drawing.Point(3, 3);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new System.Drawing.Size(594, 88);
			groupBox1.TabIndex = 0;
			groupBox1.TabStop = false;
			groupBox1.Text = "Dados Gerais";
			label2.AutoSize = true;
			label2.Location = new System.Drawing.Point(191, 34);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(51, 13);
			label2.TabIndex = 1;
			label2.Text = "Funções:";
			label7.AutoSize = true;
			label7.Location = new System.Drawing.Point(330, 71);
			label7.Name = "label7";
			label7.Size = new System.Drawing.Size(41, 13);
			label7.TabIndex = 6;
			label7.Text = "Senha:";
			label6.AutoSize = true;
			label6.Location = new System.Drawing.Point(330, 33);
			label6.Name = "label6";
			label6.Size = new System.Drawing.Size(46, 13);
			label6.TabIndex = 5;
			label6.Text = "Usuário:";
			label5.AutoSize = true;
			label5.Location = new System.Drawing.Point(6, 71);
			label5.Name = "label5";
			label5.Size = new System.Drawing.Size(35, 13);
			label5.TabIndex = 4;
			label5.Text = "Email:";
			groupBox2.Controls.Add(btn_cancel);
			groupBox2.Controls.Add(btn_save);
			groupBox2.Controls.Add(rt_observacao);
			groupBox2.Controls.Add(tb_senha);
			groupBox2.Controls.Add(tb_usuario);
			groupBox2.Controls.Add(tb_email);
			groupBox2.Controls.Add(tb_nome);
			groupBox2.Controls.Add(label8);
			groupBox2.Controls.Add(label7);
			groupBox2.Controls.Add(label6);
			groupBox2.Controls.Add(label5);
			groupBox2.Controls.Add(label4);
			groupBox2.Location = new System.Drawing.Point(3, 97);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new System.Drawing.Size(594, 282);
			groupBox2.TabIndex = 3;
			groupBox2.TabStop = false;
			label4.AutoSize = true;
			label4.Location = new System.Drawing.Point(6, 33);
			label4.Name = "label4";
			label4.Size = new System.Drawing.Size(38, 13);
			label4.TabIndex = 3;
			label4.Text = "Nome:";
			panel1.Controls.Add(groupBox2);
			panel1.Controls.Add(groupBox1);
			panel1.Location = new System.Drawing.Point(12, 12);
			panel1.Name = "panel1";
			panel1.Size = new System.Drawing.Size(600, 382);
			panel1.TabIndex = 1;
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.MaximizeBox = false;
			base.ClientSize = new System.Drawing.Size(624, 402);
			base.Controls.Add(panel1);
			base.MinimizeBox = false;
			base.Name = "FormTedit";
			base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			Text = "Editar Tabelião";
			base.Load += new System.EventHandler(FormTedit_Load);
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			groupBox2.ResumeLayout(false);
			groupBox2.PerformLayout();
			panel1.ResumeLayout(false);
			ResumeLayout(false);
		}
	}
}
