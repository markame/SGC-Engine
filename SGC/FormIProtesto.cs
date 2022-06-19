using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SGC
{
	public class FormIProtesto : Form
	{
		private conect_querygeneric connect = new conect_querygeneric();

		private string livro;

		private string folha;

		private string data_registro;

		private string cgc;

		private string cpf;

		private string rg;

		private string valor;

		private string nome_sacado;

		private string baixa;

		private string movimento;

		private string nome;

		private string obeser;

		private IContainer components = null;

		private Panel panel1;

		private Button button2;

		private Button button1;

		private TextBox tb_obser;

		private TextBox tb_apresent;

		private MaskedTextBox mkMovimento;

		private MaskedTextBox mkdata;

		private TextBox tbvalor;

		private MaskedTextBox mkidentidade;

		private MaskedTextBox mkcpf;

		private MaskedTextBox mkcgc;

		private TextBox tb_folha;

		private TextBox tb_livro;

		private Label label10;

		private Label label9;

		private Label label8;

		private Label label7;

		private Label label6;

		private Label label5;

		private Label label4;

		private Label label3;

		private Label label2;

		private Label label1;

		private TextBox tb_sacado;

		private Label label12;

		private MaskedTextBox mkregistro;

		private Label label11;

		public FormIProtesto()
		{
			InitializeComponent();
		}

		private void mkcpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
		{
		}

		private void button1_Click(object sender, EventArgs e)
		{
			livro = tb_livro.Text;
			folha = tb_folha.Text;
			data_registro = mkregistro.Text;
			cgc = mkcgc.Text;
			cpf = mkcpf.Text;
			rg = mkidentidade.Text;
			valor = tbvalor.Text;
			nome_sacado = tb_sacado.Text;
			baixa = mkdata.Text;
			movimento = mkMovimento.Text;
			nome = tb_apresent.Text;
			obeser = tb_obser.Text;
			if (string.IsNullOrWhiteSpace(livro))
			{
				MessageBox.Show("Erro com ao inserir o registro!", "Erro");
				return;
			}
			string insert = "INSERT INTO protesto (livro, folha,data_regist, cgc, cpf, indentidade, valor_sacado,nome_sacado, data_baixa, data_movimento, nome_apresentante, obs) VALUES ('" + livro + "','" + folha + "','" + data_registro + "','" + cgc + "','" + cpf + "','" + rg + "','" + valor + "','" + nome_sacado + "','" + baixa + "','" + movimento + "','" + nome + "','" + obeser + "')";
			connect.DAO();
			connect.INSEREGENERIC(insert);
			tb_livro.Text = "";
			tb_folha.Text = "";
			mkcgc.Text = "";
			mkcpf.Text = "";
			mkidentidade.Text = "";
			mkcpf.Text = "";
			tbvalor.Text = "";
			mkdata.Text = "";
			mkMovimento.Text = "";
			tb_apresent.Text = "";
			tb_obser.Text = "";
		}

		private void button2_Click(object sender, EventArgs e)
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
			panel1 = new System.Windows.Forms.Panel();
			button2 = new System.Windows.Forms.Button();
			button1 = new System.Windows.Forms.Button();
			tb_obser = new System.Windows.Forms.TextBox();
			tb_apresent = new System.Windows.Forms.TextBox();
			mkMovimento = new System.Windows.Forms.MaskedTextBox();
			mkdata = new System.Windows.Forms.MaskedTextBox();
			tbvalor = new System.Windows.Forms.TextBox();
			mkidentidade = new System.Windows.Forms.MaskedTextBox();
			mkcpf = new System.Windows.Forms.MaskedTextBox();
			mkcgc = new System.Windows.Forms.MaskedTextBox();
			tb_folha = new System.Windows.Forms.TextBox();
			tb_livro = new System.Windows.Forms.TextBox();
			label10 = new System.Windows.Forms.Label();
			label9 = new System.Windows.Forms.Label();
			label8 = new System.Windows.Forms.Label();
			label7 = new System.Windows.Forms.Label();
			label6 = new System.Windows.Forms.Label();
			label5 = new System.Windows.Forms.Label();
			label4 = new System.Windows.Forms.Label();
			label3 = new System.Windows.Forms.Label();
			label2 = new System.Windows.Forms.Label();
			label1 = new System.Windows.Forms.Label();
			label11 = new System.Windows.Forms.Label();
			mkregistro = new System.Windows.Forms.MaskedTextBox();
			tb_sacado = new System.Windows.Forms.TextBox();
			label12 = new System.Windows.Forms.Label();
			panel1.SuspendLayout();
			SuspendLayout();
			panel1.Controls.Add(tb_sacado);
			panel1.Controls.Add(label12);
			panel1.Controls.Add(mkregistro);
			panel1.Controls.Add(label11);
			panel1.Controls.Add(button2);
			panel1.Controls.Add(button1);
			panel1.Controls.Add(tb_obser);
			panel1.Controls.Add(tb_apresent);
			panel1.Controls.Add(mkMovimento);
			panel1.Controls.Add(mkdata);
			panel1.Controls.Add(tbvalor);
			panel1.Controls.Add(mkidentidade);
			panel1.Controls.Add(mkcpf);
			panel1.Controls.Add(mkcgc);
			panel1.Controls.Add(tb_folha);
			panel1.Controls.Add(tb_livro);
			panel1.Controls.Add(label10);
			panel1.Controls.Add(label9);
			panel1.Controls.Add(label8);
			panel1.Controls.Add(label7);
			panel1.Controls.Add(label6);
			panel1.Controls.Add(label5);
			panel1.Controls.Add(label4);
			panel1.Controls.Add(label3);
			panel1.Controls.Add(label2);
			panel1.Controls.Add(label1);
			panel1.Location = new System.Drawing.Point(12, 12);
			panel1.Name = "panel1";
			panel1.Size = new System.Drawing.Size(592, 292);
			panel1.TabIndex = 0;
			button2.Location = new System.Drawing.Point(397, 261);
			button2.Name = "button2";
			button2.Size = new System.Drawing.Size(75, 23);
			button2.TabIndex = 20;
			button2.Text = "Cancelar";
			button2.UseVisualStyleBackColor = true;
			button2.Click += new System.EventHandler(button2_Click);
			button1.Location = new System.Drawing.Point(496, 261);
			button1.Name = "button1";
			button1.Size = new System.Drawing.Size(75, 23);
			button1.TabIndex = 1;
			button1.Text = "Salvar";
			button1.UseVisualStyleBackColor = true;
			button1.Click += new System.EventHandler(button1_Click);
			tb_obser.Location = new System.Drawing.Point(128, 223);
			tb_obser.Name = "tb_obser";
			tb_obser.Size = new System.Drawing.Size(443, 20);
			tb_obser.TabIndex = 19;
			tb_apresent.Location = new System.Drawing.Point(128, 185);
			tb_apresent.Name = "tb_apresent";
			tb_apresent.Size = new System.Drawing.Size(443, 20);
			tb_apresent.TabIndex = 18;
			mkMovimento.Location = new System.Drawing.Point(281, 148);
			mkMovimento.Mask = "00/00/0000";
			mkMovimento.Name = "mkMovimento";
			mkMovimento.Size = new System.Drawing.Size(83, 20);
			mkMovimento.TabIndex = 17;
			mkMovimento.ValidatingType = typeof(System.DateTime);
			mkdata.Location = new System.Drawing.Point(86, 148);
			mkdata.Mask = "00/00/0000";
			mkdata.Name = "mkdata";
			mkdata.Size = new System.Drawing.Size(83, 20);
			mkdata.TabIndex = 16;
			mkdata.ValidatingType = typeof(System.DateTime);
			tbvalor.Location = new System.Drawing.Point(451, 79);
			tbvalor.Name = "tbvalor";
			tbvalor.Size = new System.Drawing.Size(120, 20);
			tbvalor.TabIndex = 15;
			mkidentidade.Location = new System.Drawing.Point(247, 79);
			mkidentidade.Mask = "000000000000-0";
			mkidentidade.Name = "mkidentidade";
			mkidentidade.Size = new System.Drawing.Size(100, 20);
			mkidentidade.TabIndex = 14;
			mkcpf.Location = new System.Drawing.Point(44, 79);
			mkcpf.Mask = "000.000.000-00";
			mkcpf.Name = "mkcpf";
			mkcpf.Size = new System.Drawing.Size(100, 20);
			mkcpf.TabIndex = 13;
			mkcpf.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(mkcpf_MaskInputRejected);
			mkcgc.Location = new System.Drawing.Point(42, 53);
			mkcgc.Mask = "00.000.000/0000-00";
			mkcgc.Name = "mkcgc";
			mkcgc.Size = new System.Drawing.Size(163, 20);
			mkcgc.TabIndex = 12;
			tb_folha.Location = new System.Drawing.Point(217, 24);
			tb_folha.Name = "tb_folha";
			tb_folha.Size = new System.Drawing.Size(100, 20);
			tb_folha.TabIndex = 11;
			tb_livro.Location = new System.Drawing.Point(44, 24);
			tb_livro.Name = "tb_livro";
			tb_livro.Size = new System.Drawing.Size(100, 20);
			tb_livro.TabIndex = 10;
			label10.AutoSize = true;
			label10.Location = new System.Drawing.Point(3, 226);
			label10.Name = "label10";
			label10.Size = new System.Drawing.Size(68, 13);
			label10.TabIndex = 9;
			label10.Text = "Observação:";
			label9.AutoSize = true;
			label9.Location = new System.Drawing.Point(3, 188);
			label9.Name = "label9";
			label9.Size = new System.Drawing.Size(119, 13);
			label9.TabIndex = 8;
			label9.Text = "Nome do Apresentante:";
			label8.AutoSize = true;
			label8.Location = new System.Drawing.Point(175, 151);
			label8.Name = "label8";
			label8.Size = new System.Drawing.Size(103, 13);
			label8.TabIndex = 7;
			label8.Text = "Data de Movimento:";
			label7.AutoSize = true;
			label7.Location = new System.Drawing.Point(3, 151);
			label7.Name = "label7";
			label7.Size = new System.Drawing.Size(77, 13);
			label7.TabIndex = 6;
			label7.Text = "Data da Baixa:";
			label6.AutoSize = true;
			label6.Location = new System.Drawing.Point(370, 82);
			label6.Name = "label6";
			label6.Size = new System.Drawing.Size(75, 13);
			label6.TabIndex = 5;
			label6.Text = "Valor do saco:";
			label5.AutoSize = true;
			label5.Location = new System.Drawing.Point(175, 82);
			label5.Name = "label5";
			label5.Size = new System.Drawing.Size(66, 13);
			label5.TabIndex = 4;
			label5.Text = "Indentidade:";
			label4.AutoSize = true;
			label4.Location = new System.Drawing.Point(3, 82);
			label4.Name = "label4";
			label4.Size = new System.Drawing.Size(30, 13);
			label4.TabIndex = 3;
			label4.Text = "CPF:";
			label3.AutoSize = true;
			label3.Location = new System.Drawing.Point(4, 56);
			label3.Name = "label3";
			label3.Size = new System.Drawing.Size(32, 13);
			label3.TabIndex = 2;
			label3.Text = "CGC:";
			label2.AutoSize = true;
			label2.Location = new System.Drawing.Point(175, 27);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(36, 13);
			label2.TabIndex = 1;
			label2.Text = "Folha:";
			label1.AutoSize = true;
			label1.Location = new System.Drawing.Point(3, 27);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(33, 13);
			label1.TabIndex = 0;
			label1.Text = "Livro:";
			label11.AutoSize = true;
			label11.Location = new System.Drawing.Point(354, 27);
			label11.Name = "label11";
			label11.Size = new System.Drawing.Size(90, 13);
			label11.TabIndex = 21;
			label11.Text = "Data do Registro:";
			mkregistro.Location = new System.Drawing.Point(451, 24);
			mkregistro.Mask = "00/00/0000";
			mkregistro.Name = "mkregistro";
			mkregistro.Size = new System.Drawing.Size(83, 20);
			mkregistro.TabIndex = 12;
			mkregistro.ValidatingType = typeof(System.DateTime);
			tb_sacado.Location = new System.Drawing.Point(128, 116);
			tb_sacado.Name = "tb_sacado";
			tb_sacado.Size = new System.Drawing.Size(443, 20);
			tb_sacado.TabIndex = 23;
			label12.AutoSize = true;
			label12.Location = new System.Drawing.Point(3, 119);
			label12.Name = "label12";
			label12.Size = new System.Drawing.Size(93, 13);
			label12.TabIndex = 22;
			label12.Text = "Nome do Sacado:";
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.MaximizeBox = false;
			base.ClientSize = new System.Drawing.Size(616, 317);
			base.Controls.Add(panel1);
			base.MinimizeBox = false;
			base.Name = "FormIProtesto";
			base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			Text = "Novo Protesto";
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			ResumeLayout(false);
		}
	}
}
