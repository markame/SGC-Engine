using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SGC
{
	public class FormEditaProtesto : Form
	{
		private string codigo;

		private string livro;

		private string folha;

		private string dta_reg;

		private string cgc;

		private string cpf;

		private string rg;

		private string valor;

		private string nomeSacado;

		private string baixa;

		private string movimento;

		private string nome;

		private string obeser;

		private ClassEditProtesto edita = new ClassEditProtesto();

		private IContainer components = null;

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

		private Panel panel1;

		private TextBox tb_sacado;

		private Label label12;

		private MaskedTextBox mk_reg;

		private Label label11;

		public FormEditaProtesto()
		{
			InitializeComponent();
			preencheeform();
		}

		private void FormEditaProtesto_Load(object sender, EventArgs e)
		{
		}

		public void preencheeform()
		{
			tb_livro.Text = edita.getLivro();
			tb_folha.Text = edita.getFolha();
			mk_reg.Text = Convert.ToDateTime(edita.getDatReg()).ToString("dd/MM/yyyy");
			mkcgc.Text = edita.getCgc();
			mkcpf.Text = edita.getCPF();
			mkidentidade.Text = edita.getRg();
			tbvalor.Text = edita.getSacado();
			tb_sacado.Text = edita.getNomeSaca();
			if (edita.getBaixa() == "0000-00-00")
			{
				mkdata.Text = "0000-00-00";
			}
			else
			{
				mkdata.Text = Convert.ToDateTime(edita.getBaixa()).ToString("dd/MM/yyyy");
			}
			mkMovimento.Text = Convert.ToDateTime(edita.getMovimento()).ToString("dd/MM/yyyy");
			tb_apresent.Text = edita.getNome();
			tb_obser.Text = edita.getObser();
			codigo = edita.getCodigo();
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			livro = tb_livro.Text;
			folha = tb_folha.Text;
			dta_reg = Convert.ToDateTime(mk_reg.Text).ToString("yyyy/MM/dd");
			cgc = mkcgc.Text;
			cpf = mkcpf.Text;
			rg = mkidentidade.Text;
			valor = tbvalor.Text;
			nomeSacado = tb_sacado.Text;
			baixa = Convert.ToDateTime(mkdata.Text).ToString("yyyy/MM/dd");
			movimento = Convert.ToDateTime(mkMovimento.Text).ToString("yyyy/MM/dd");
			nome = tb_apresent.Text;
			obeser = tb_obser.Text;
			string update = "UPDATE protesto SET livro='" + livro + "',folha='" + folha + "',data_regist='" + dta_reg + "'    ,cgc='" + cgc + "',cpf='" + cpf + "',indentidade='" + rg + "',valor_sacado='" + valor + "',nome_sacado='" + nomeSacado + "'  ,data_baixa='" + baixa + "',data_movimento='" + movimento + "',nome_apresentante='" + nome + "',obs='" + obeser + "' WHERE id_protesto = '" + codigo + "'";
			conect_querygeneric dao = new conect_querygeneric();
			dao.DAO();
			dao.UPDATEGENERIC(update);
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
			panel1 = new System.Windows.Forms.Panel();
			mk_reg = new System.Windows.Forms.MaskedTextBox();
			label11 = new System.Windows.Forms.Label();
			tb_sacado = new System.Windows.Forms.TextBox();
			label12 = new System.Windows.Forms.Label();
			panel1.SuspendLayout();
			SuspendLayout();
			button2.Location = new System.Drawing.Point(397, 261);
			button2.Name = "button2";
			button2.Size = new System.Drawing.Size(75, 23);
			button2.TabIndex = 23;
			button2.Text = "Cancelar";
			button2.UseVisualStyleBackColor = true;
			button2.Click += new System.EventHandler(button2_Click);
			button1.Location = new System.Drawing.Point(496, 261);
			button1.Name = "button1";
			button1.Size = new System.Drawing.Size(75, 23);
			button1.TabIndex = 22;
			button1.Text = "Salvar";
			button1.UseVisualStyleBackColor = true;
			button1.Click += new System.EventHandler(button1_Click);
			tb_obser.Location = new System.Drawing.Point(128, 224);
			tb_obser.Name = "tb_obser";
			tb_obser.Size = new System.Drawing.Size(443, 20);
			tb_obser.TabIndex = 21;
			tb_apresent.Location = new System.Drawing.Point(128, 198);
			tb_apresent.Name = "tb_apresent";
			tb_apresent.Size = new System.Drawing.Size(443, 20);
			tb_apresent.TabIndex = 20;
			mkMovimento.Location = new System.Drawing.Point(281, 130);
			mkMovimento.Mask = "00/00/0000";
			mkMovimento.Name = "mkMovimento";
			mkMovimento.Size = new System.Drawing.Size(83, 20);
			mkMovimento.TabIndex = 18;
			mkMovimento.ValidatingType = typeof(System.DateTime);
			mkdata.Location = new System.Drawing.Point(86, 130);
			mkdata.Mask = "00/00/0000";
			mkdata.Name = "mkdata";
			mkdata.Size = new System.Drawing.Size(83, 20);
			mkdata.TabIndex = 17;
			mkdata.ValidatingType = typeof(System.DateTime);
			tbvalor.Location = new System.Drawing.Point(451, 88);
			tbvalor.Name = "tbvalor";
			tbvalor.Size = new System.Drawing.Size(120, 20);
			tbvalor.TabIndex = 16;
			mkidentidade.Location = new System.Drawing.Point(247, 88);
			mkidentidade.Mask = "000000000000-0";
			mkidentidade.Name = "mkidentidade";
			mkidentidade.Size = new System.Drawing.Size(100, 20);
			mkidentidade.TabIndex = 15;
			mkcpf.Location = new System.Drawing.Point(44, 88);
			mkcpf.Mask = "000.000.000-00";
			mkcpf.Name = "mkcpf";
			mkcpf.Size = new System.Drawing.Size(100, 20);
			mkcpf.TabIndex = 14;
			mkcgc.Location = new System.Drawing.Point(44, 54);
			mkcgc.Mask = "00.000.000/0000-00";
			mkcgc.Name = "mkcgc";
			mkcgc.Size = new System.Drawing.Size(163, 20);
			mkcgc.TabIndex = 13;
			tb_folha.Location = new System.Drawing.Point(215, 23);
			tb_folha.Name = "tb_folha";
			tb_folha.Size = new System.Drawing.Size(100, 20);
			tb_folha.TabIndex = 11;
			tb_livro.Location = new System.Drawing.Point(44, 24);
			tb_livro.Name = "tb_livro";
			tb_livro.Size = new System.Drawing.Size(100, 20);
			tb_livro.TabIndex = 10;
			label10.AutoSize = true;
			label10.Location = new System.Drawing.Point(3, 227);
			label10.Name = "label10";
			label10.Size = new System.Drawing.Size(68, 13);
			label10.TabIndex = 9;
			label10.Text = "Observação:";
			label9.AutoSize = true;
			label9.Location = new System.Drawing.Point(3, 201);
			label9.Name = "label9";
			label9.Size = new System.Drawing.Size(119, 13);
			label9.TabIndex = 8;
			label9.Text = "Nome do Apresentante:";
			label8.AutoSize = true;
			label8.Location = new System.Drawing.Point(175, 133);
			label8.Name = "label8";
			label8.Size = new System.Drawing.Size(103, 13);
			label8.TabIndex = 7;
			label8.Text = "Data de Movimento:";
			label7.AutoSize = true;
			label7.Location = new System.Drawing.Point(3, 133);
			label7.Name = "label7";
			label7.Size = new System.Drawing.Size(77, 13);
			label7.TabIndex = 6;
			label7.Text = "Data da Baixa:";
			label6.AutoSize = true;
			label6.Location = new System.Drawing.Point(370, 91);
			label6.Name = "label6";
			label6.Size = new System.Drawing.Size(75, 13);
			label6.TabIndex = 5;
			label6.Text = "Valor do saco:";
			label5.AutoSize = true;
			label5.Location = new System.Drawing.Point(175, 91);
			label5.Name = "label5";
			label5.Size = new System.Drawing.Size(66, 13);
			label5.TabIndex = 4;
			label5.Text = "Indentidade:";
			label4.AutoSize = true;
			label4.Location = new System.Drawing.Point(3, 91);
			label4.Name = "label4";
			label4.Size = new System.Drawing.Size(30, 13);
			label4.TabIndex = 3;
			label4.Text = "CPF:";
			label3.AutoSize = true;
			label3.Location = new System.Drawing.Point(6, 57);
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
			panel1.Controls.Add(tb_sacado);
			panel1.Controls.Add(label12);
			panel1.Controls.Add(mk_reg);
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
			panel1.TabIndex = 1;
			panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
			mk_reg.Location = new System.Drawing.Point(439, 23);
			mk_reg.Mask = "00/00/0000";
			mk_reg.Name = "mk_reg";
			mk_reg.Size = new System.Drawing.Size(83, 20);
			mk_reg.TabIndex = 12;
			mk_reg.ValidatingType = typeof(System.DateTime);
			label11.AutoSize = true;
			label11.Location = new System.Drawing.Point(343, 27);
			label11.Name = "label11";
			label11.Size = new System.Drawing.Size(90, 13);
			label11.TabIndex = 21;
			label11.Text = "Data do Registro:";
			tb_sacado.Location = new System.Drawing.Point(128, 172);
			tb_sacado.Name = "tb_sacado";
			tb_sacado.Size = new System.Drawing.Size(443, 20);
			tb_sacado.TabIndex = 19;
			label12.AutoSize = true;
			label12.Location = new System.Drawing.Point(3, 175);
			label12.Name = "label12";
			label12.Size = new System.Drawing.Size(93, 13);
			label12.TabIndex = 22;
			label12.Text = "Nome do Sacado:";
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.MaximizeBox = false;
			base.ClientSize = new System.Drawing.Size(614, 311);
			base.Controls.Add(panel1);
			base.MinimizeBox = false;
			base.Name = "FormEditaProtesto";
			base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			Text = "FormEditaProtesto";
			base.Load += new System.EventHandler(FormEditaProtesto_Load);
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			ResumeLayout(false);
		}
	}
}
