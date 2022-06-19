using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SGC
{
	public class FormIfirma : Form
	{
		private string matricula;

		private string nome;

		private string autografo;

		private string dat_reno;

		private string data_reco;

		private string dat_limi;

		private string venci;

		private string endereco;

		private string bairro;

		private string civil;

		private string cep;

		private string cidade;

		private string uf;

		private string sexo;

		private string profi;

		private string nasci;

		private string cpf;

		private string cgc;

		private string rg;

		private string cod_t;

		private string tabeliao;

		private string sequencia;

		private string obsev;

		private dados d = new dados();

		private IContainer components = null;

		private Panel panel1;

		private Label label22;

		private Label label21;

		private Label label20;

		private Label label19;

		private Label label18;

		private Label label17;

		private Label label16;

		private Label label15;

		private Label label14;

		private Label label13;

		private Label label12;

		private Label label11;

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

		private Button button2;

		private Button button1;

		private TextBox tcobse;

		private TextBox tbseq;

		private TextBox tbtabeliao;

		private TextBox tbcod;

		private MaskedTextBox mkrg;

		private MaskedTextBox mkcgc;

		private MaskedTextBox mkcpf;

		private MaskedTextBox mknasci;

		private TextBox tbprofissao;

		private ComboBox cbsexo;

		private ComboBox cbuf;

		private TextBox tbcidade;

		private MaskedTextBox mkcep;

		private ComboBox cbcivil;

		private MaskedTextBox mklimite;

		private MaskedTextBox mkdataRe;

		private MaskedTextBox mkdataR;

		private TextBox tbbairro;

		private TextBox tbebdereco;

		private TextBox tbvenci;

		private TextBox tb_nome;

		private TextBox tb_matri;

		private Label label23;

		private TextBox tbautografo;

		private Button button3;

		public FormIfirma()
		{
			InitializeComponent();
			conect_querygeneric openconector = new conect_querygeneric();
			tb_matri.Text = openconector.NumberRows("SELECT MAX(id_firma) FROM firma").ToString();
		}

		private void maskedTextBox5_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
		{
		}

		private void cbcivil_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		private void button1_Click(object sender, EventArgs e)
		{
			matricula = tb_matri.Text;
			nome = tb_nome.Text.ToUpper();
			dadosscanner ds = new dadosscanner();
			autografo = ds.GetScanner();
			autografo.Replace("\\", "\\\\");
			dat_reno = Convert.ToDateTime(mkdataR.Text).ToString("yyyy/MM/dd");
			data_reco = Convert.ToDateTime(mkdataRe.Text).ToString("yyyy/MM/dd");
			dat_limi = Convert.ToDateTime(mklimite.Text).ToString("yyyy/MM/dd");
			venci = tbvenci.Text;
			endereco = tbebdereco.Text;
			bairro = tbbairro.Text;
			uf = cbuf.Text;
			civil = cbcivil.Text;
			cep = mkcep.Text;
			cidade = tbcidade.Text;
			sexo = cbsexo.Text;
			profi = tbprofissao.Text;
			nasci = mknasci.Text;
			cpf = mkcpf.Text;
			cgc = mkcgc.Text;
			rg = mkrg.Text;
			cod_t = tbcod.Text;
			tabeliao = tbtabeliao.Text;
			sequencia = tbseq.Text;
			obsev = tcobse.Text;
			conect_querygeneric connect = new conect_querygeneric();
			connect.DAO();
			string insert = "INSERT INTO firma(id_firma, nome, autografo, d_renovacao, roconheciada, validade, dias_validade, encereco, bairro, cep, cidade, uf, sexo, civil, profissao, d_nascimento, cpf, cgc, indentidade, cod_tab, tabeliao,controle, observ) VALUES ('" + matricula + "','" + nome + "','" + autografo + "','" + dat_reno + "','" + data_reco + "','" + dat_limi + "','" + venci + "','" + endereco + "','" + bairro + "','" + cep + "','" + cidade + "','" + uf + "','" + sexo + "','" + civil + "','" + profi + "','" + nasci + "','" + cpf + "','" + cgc + "','" + rg + "','" + cod_t + "','" + tabeliao + "','" + sequencia + "','" + obsev + "')";
			connect.INSEREGENERIC(insert);
			tb_matri.Text = " ";
			tb_nome.Text = " ";
			tbautografo.Text = " ";
			mkdataR.Text = " ";
			mkdataRe.Text = " ";
			mklimite.Text = " ";
			tbvenci.Text = " ";
			tbebdereco.Text = " ";
			tbbairro.Text = " ";
			cbuf.Text = " ";
			cbcivil.Text = " ";
			mkcep.Text = " ";
			tbcidade.Text = " ";
			cbsexo.Text = " ";
			tbprofissao.Text = " ";
			mknasci.Text = " ";
			mkcpf.Text = " ";
			mkcgc.Text = " ";
			mkrg.Text = " ";
			tbcod.Text = " ";
			tbtabeliao.Text = " ";
			tbseq.Text = " ";
			tcobse.Text = " ";
		}

		private void tbvenci_TextChanged(object sender, EventArgs e)
		{
			if (!(mklimite.Text == "  /  /"))
			{
				TimeSpan final = Convert.ToDateTime(mklimite.Text).Subtract(Convert.ToDateTime(mkdataRe.Text));
				tbvenci.Text = final.TotalDays.ToString();
			}
		}

		private void tbcod_TextChanged(object sender, EventArgs e)
		{
			string queryAT = "SELECT * FROM usuario WHERE id_Usuario='" + tbcod.Text + "'";
			d.Tabeliao(queryAT);
		}

		private void mklimite_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
		{
		}

		private void tbtabeliao_TextChanged(object sender, EventArgs e)
		{
			tbtabeliao.Text = d.Gettabeliao();
		}

		private void tb_matri_TextChanged(object sender, EventArgs e)
		{
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void mkdataRe_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
		{
		}

		private void cbuf_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		private void button3_Click(object sender, EventArgs e)
		{
			FormScannerDevice scanner = new FormScannerDevice();
			scanner.ShowDialog();
		}

		private void mkdataR_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
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
			panel1 = new System.Windows.Forms.Panel();
			button3 = new System.Windows.Forms.Button();
			button2 = new System.Windows.Forms.Button();
			button1 = new System.Windows.Forms.Button();
			tcobse = new System.Windows.Forms.TextBox();
			tbseq = new System.Windows.Forms.TextBox();
			tbtabeliao = new System.Windows.Forms.TextBox();
			tbcod = new System.Windows.Forms.TextBox();
			mkrg = new System.Windows.Forms.MaskedTextBox();
			mkcgc = new System.Windows.Forms.MaskedTextBox();
			mkcpf = new System.Windows.Forms.MaskedTextBox();
			mknasci = new System.Windows.Forms.MaskedTextBox();
			tbprofissao = new System.Windows.Forms.TextBox();
			cbsexo = new System.Windows.Forms.ComboBox();
			cbuf = new System.Windows.Forms.ComboBox();
			tbcidade = new System.Windows.Forms.TextBox();
			mkcep = new System.Windows.Forms.MaskedTextBox();
			cbcivil = new System.Windows.Forms.ComboBox();
			mklimite = new System.Windows.Forms.MaskedTextBox();
			mkdataRe = new System.Windows.Forms.MaskedTextBox();
			mkdataR = new System.Windows.Forms.MaskedTextBox();
			tbbairro = new System.Windows.Forms.TextBox();
			tbebdereco = new System.Windows.Forms.TextBox();
			tbvenci = new System.Windows.Forms.TextBox();
			tbautografo = new System.Windows.Forms.TextBox();
			tb_nome = new System.Windows.Forms.TextBox();
			tb_matri = new System.Windows.Forms.TextBox();
			label23 = new System.Windows.Forms.Label();
			label22 = new System.Windows.Forms.Label();
			label21 = new System.Windows.Forms.Label();
			label20 = new System.Windows.Forms.Label();
			label19 = new System.Windows.Forms.Label();
			label18 = new System.Windows.Forms.Label();
			label17 = new System.Windows.Forms.Label();
			label16 = new System.Windows.Forms.Label();
			label15 = new System.Windows.Forms.Label();
			label14 = new System.Windows.Forms.Label();
			label13 = new System.Windows.Forms.Label();
			label12 = new System.Windows.Forms.Label();
			label11 = new System.Windows.Forms.Label();
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
			panel1.SuspendLayout();
			SuspendLayout();
			panel1.Controls.Add(button3);
			panel1.Controls.Add(button2);
			panel1.Controls.Add(button1);
			panel1.Controls.Add(tcobse);
			panel1.Controls.Add(tbseq);
			panel1.Controls.Add(tbtabeliao);
			panel1.Controls.Add(tbcod);
			panel1.Controls.Add(mkrg);
			panel1.Controls.Add(mkcgc);
			panel1.Controls.Add(mkcpf);
			panel1.Controls.Add(mknasci);
			panel1.Controls.Add(tbprofissao);
			panel1.Controls.Add(cbsexo);
			panel1.Controls.Add(cbuf);
			panel1.Controls.Add(tbcidade);
			panel1.Controls.Add(mkcep);
			panel1.Controls.Add(cbcivil);
			panel1.Controls.Add(mklimite);
			panel1.Controls.Add(mkdataRe);
			panel1.Controls.Add(mkdataR);
			panel1.Controls.Add(tbbairro);
			panel1.Controls.Add(tbebdereco);
			panel1.Controls.Add(tbvenci);
			panel1.Controls.Add(tbautografo);
			panel1.Controls.Add(tb_nome);
			panel1.Controls.Add(tb_matri);
			panel1.Controls.Add(label23);
			panel1.Controls.Add(label22);
			panel1.Controls.Add(label21);
			panel1.Controls.Add(label20);
			panel1.Controls.Add(label19);
			panel1.Controls.Add(label18);
			panel1.Controls.Add(label17);
			panel1.Controls.Add(label16);
			panel1.Controls.Add(label15);
			panel1.Controls.Add(label14);
			panel1.Controls.Add(label13);
			panel1.Controls.Add(label12);
			panel1.Controls.Add(label11);
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
			panel1.Size = new System.Drawing.Size(624, 398);
			panel1.TabIndex = 0;
			button3.Location = new System.Drawing.Point(553, 14);
			button3.Name = "button3";
			button3.Size = new System.Drawing.Size(57, 23);
			button3.TabIndex = 48;
			button3.Text = "Scanner";
			button3.UseVisualStyleBackColor = true;
			button3.Click += new System.EventHandler(button3_Click);
			button2.Location = new System.Drawing.Point(428, 344);
			button2.Name = "button2";
			button2.Size = new System.Drawing.Size(81, 40);
			button2.TabIndex = 47;
			button2.Text = "Cancelar";
			button2.UseVisualStyleBackColor = true;
			button2.Click += new System.EventHandler(button2_Click);
			button1.Location = new System.Drawing.Point(530, 344);
			button1.Name = "button1";
			button1.Size = new System.Drawing.Size(81, 40);
			button1.TabIndex = 46;
			button1.Text = "Salvar";
			button1.UseVisualStyleBackColor = true;
			button1.Click += new System.EventHandler(button1_Click);
			tcobse.Location = new System.Drawing.Point(223, 309);
			tcobse.Name = "tcobse";
			tcobse.Size = new System.Drawing.Size(387, 20);
			tcobse.TabIndex = 45;
			tbseq.Location = new System.Drawing.Point(70, 309);
			tbseq.Name = "tbseq";
			tbseq.Size = new System.Drawing.Size(103, 20);
			tbseq.TabIndex = 44;
			tbtabeliao.Location = new System.Drawing.Point(331, 267);
			tbtabeliao.Name = "tbtabeliao";
			tbtabeliao.Size = new System.Drawing.Size(279, 20);
			tbtabeliao.TabIndex = 43;
			tbtabeliao.TextChanged += new System.EventHandler(tbtabeliao_TextChanged);
			tbcod.Location = new System.Drawing.Point(228, 267);
			tbcod.Name = "tbcod";
			tbcod.Size = new System.Drawing.Size(47, 20);
			tbcod.TabIndex = 42;
			tbcod.TextChanged += new System.EventHandler(tbcod_TextChanged);
			mkrg.Location = new System.Drawing.Point(70, 267);
			mkrg.Name = "mkrg";
			mkrg.Size = new System.Drawing.Size(103, 20);
			mkrg.TabIndex = 41;
			mkcgc.Location = new System.Drawing.Point(513, 222);
			mkcgc.Name = "mkcgc";
			mkcgc.Size = new System.Drawing.Size(97, 20);
			mkcgc.TabIndex = 40;
			mkcpf.Location = new System.Drawing.Point(381, 222);
			mkcpf.Name = "mkcpf";
			mkcpf.Size = new System.Drawing.Size(88, 20);
			mkcpf.TabIndex = 39;
			mknasci.Location = new System.Drawing.Point(277, 222);
			mknasci.Mask = "00/00/0000";
			mknasci.Name = "mknasci";
			mknasci.Size = new System.Drawing.Size(68, 20);
			mknasci.TabIndex = 38;
			mknasci.ValidatingType = typeof(System.DateTime);
			mknasci.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(maskedTextBox5_MaskInputRejected);
			tbprofissao.Location = new System.Drawing.Point(70, 222);
			tbprofissao.Name = "tbprofissao";
			tbprofissao.Size = new System.Drawing.Size(103, 20);
			tbprofissao.TabIndex = 37;
			cbsexo.FormattingEnabled = true;
			cbsexo.Items.AddRange(new object[2] { "Masculino", "Feminino" });
			cbsexo.Location = new System.Drawing.Point(515, 162);
			cbsexo.Name = "cbsexo";
			cbsexo.Size = new System.Drawing.Size(95, 21);
			cbsexo.TabIndex = 36;
			cbuf.FormattingEnabled = true;
			cbuf.Items.AddRange(new object[27]
			{
				"AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA",
				"MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN",
				"RS", "RO", "RR", "SC", "SP", "SE", "TO"
			});
			cbuf.Location = new System.Drawing.Point(381, 162);
			cbuf.Name = "cbuf";
			cbuf.Size = new System.Drawing.Size(53, 21);
			cbuf.TabIndex = 35;
			cbuf.SelectedIndexChanged += new System.EventHandler(cbuf_SelectedIndexChanged);
			tbcidade.Location = new System.Drawing.Point(228, 163);
			tbcidade.Name = "tbcidade";
			tbcidade.Size = new System.Drawing.Size(117, 20);
			tbcidade.TabIndex = 34;
			mkcep.Location = new System.Drawing.Point(49, 163);
			mkcep.Mask = "00000-000";
			mkcep.Name = "mkcep";
			mkcep.Size = new System.Drawing.Size(124, 20);
			mkcep.TabIndex = 33;
			cbcivil.FormattingEnabled = true;
			cbcivil.Items.AddRange(new object[4] { "Solteiro(a)", "Casado(a)", "Divorciado(a)", "Viuvo(a)" });
			cbcivil.Location = new System.Drawing.Point(513, 110);
			cbcivil.Name = "cbcivil";
			cbcivil.Size = new System.Drawing.Size(97, 21);
			cbcivil.TabIndex = 32;
			cbcivil.SelectedIndexChanged += new System.EventHandler(cbcivil_SelectedIndexChanged);
			mklimite.Location = new System.Drawing.Point(367, 54);
			mklimite.Mask = "00/00/0000";
			mklimite.Name = "mklimite";
			mklimite.Size = new System.Drawing.Size(67, 20);
			mklimite.TabIndex = 28;
			mklimite.ValidatingType = typeof(System.DateTime);
			mklimite.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(mklimite_MaskInputRejected);
			mkdataRe.Location = new System.Drawing.Point(259, 54);
			mkdataRe.Mask = "00/00/0000";
			mkdataRe.Name = "mkdataRe";
			mkdataRe.Size = new System.Drawing.Size(59, 20);
			mkdataRe.TabIndex = 27;
			mkdataRe.ValidatingType = typeof(System.DateTime);
			mkdataRe.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(mkdataRe_MaskInputRejected);
			mkdataR.Location = new System.Drawing.Point(123, 54);
			mkdataR.Mask = "00/00/0000";
			mkdataR.Name = "mkdataR";
			mkdataR.Size = new System.Drawing.Size(50, 20);
			mkdataR.TabIndex = 26;
			mkdataR.ValidatingType = typeof(System.DateTime);
			mkdataR.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(mkdataR_MaskInputRejected);
			tbbairro.Location = new System.Drawing.Point(294, 110);
			tbbairro.Name = "tbbairro";
			tbbairro.Size = new System.Drawing.Size(140, 20);
			tbbairro.TabIndex = 31;
			tbebdereco.Location = new System.Drawing.Point(70, 110);
			tbebdereco.Name = "tbebdereco";
			tbebdereco.Size = new System.Drawing.Size(175, 20);
			tbebdereco.TabIndex = 30;
			tbvenci.Location = new System.Drawing.Point(553, 54);
			tbvenci.Name = "tbvenci";
			tbvenci.Size = new System.Drawing.Size(58, 20);
			tbvenci.TabIndex = 29;
			tbvenci.TextChanged += new System.EventHandler(tbvenci_TextChanged);
			tbautografo.Enabled = false;
			tbautografo.Location = new System.Drawing.Point(502, 16);
			tbautografo.Name = "tbautografo";
			tbautografo.Size = new System.Drawing.Size(45, 20);
			tbautografo.TabIndex = 25;
			tb_nome.Location = new System.Drawing.Point(169, 16);
			tb_nome.Name = "tb_nome";
			tb_nome.Size = new System.Drawing.Size(265, 20);
			tb_nome.TabIndex = 24;
			tb_matri.Location = new System.Drawing.Point(70, 15);
			tb_matri.Name = "tb_matri";
			tb_matri.Size = new System.Drawing.Size(49, 20);
			tb_matri.TabIndex = 23;
			tb_matri.TextChanged += new System.EventHandler(tb_matri_TextChanged);
			label23.AutoSize = true;
			label23.Location = new System.Drawing.Point(7, 312);
			label23.Name = "label23";
			label23.Size = new System.Drawing.Size(61, 13);
			label23.TabIndex = 22;
			label23.Text = "Sequencia:";
			label22.AutoSize = true;
			label22.Location = new System.Drawing.Point(179, 312);
			label22.Name = "label22";
			label22.Size = new System.Drawing.Size(38, 13);
			label22.TabIndex = 21;
			label22.Text = "Obser:";
			label21.AutoSize = true;
			label21.Location = new System.Drawing.Point(281, 270);
			label21.Name = "label21";
			label21.Size = new System.Drawing.Size(51, 13);
			label21.TabIndex = 20;
			label21.Text = "Tabelião:";
			label20.AutoSize = true;
			label20.Location = new System.Drawing.Point(179, 270);
			label20.Name = "label20";
			label20.Size = new System.Drawing.Size(49, 13);
			label20.TabIndex = 19;
			label20.Text = "COD (T):";
			label19.AutoSize = true;
			label19.Location = new System.Drawing.Point(12, 270);
			label19.Name = "label19";
			label19.Size = new System.Drawing.Size(26, 13);
			label19.TabIndex = 18;
			label19.Text = "RG:";
			label18.AutoSize = true;
			label18.Location = new System.Drawing.Point(475, 225);
			label18.Name = "label18";
			label18.Size = new System.Drawing.Size(32, 13);
			label18.TabIndex = 17;
			label18.Text = "CGC:";
			label17.AutoSize = true;
			label17.Location = new System.Drawing.Point(351, 225);
			label17.Name = "label17";
			label17.Size = new System.Drawing.Size(30, 13);
			label17.TabIndex = 16;
			label17.Text = "CPF:";
			label16.AutoSize = true;
			label16.Location = new System.Drawing.Point(179, 225);
			label16.Name = "label16";
			label16.Size = new System.Drawing.Size(92, 13);
			label16.TabIndex = 15;
			label16.Text = "Data Nascimento:";
			label15.AutoSize = true;
			label15.Location = new System.Drawing.Point(12, 225);
			label15.Name = "label15";
			label15.Size = new System.Drawing.Size(53, 13);
			label15.TabIndex = 14;
			label15.Text = "Profissão:";
			label14.AutoSize = true;
			label14.Location = new System.Drawing.Point(442, 113);
			label14.Name = "label14";
			label14.Size = new System.Drawing.Size(65, 13);
			label14.TabIndex = 13;
			label14.Text = "Estado Civil:";
			label13.AutoSize = true;
			label13.Location = new System.Drawing.Point(475, 166);
			label13.Name = "label13";
			label13.Size = new System.Drawing.Size(34, 13);
			label13.TabIndex = 12;
			label13.Text = "Sexo:";
			label12.AutoSize = true;
			label12.Location = new System.Drawing.Point(351, 166);
			label12.Name = "label12";
			label12.Size = new System.Drawing.Size(24, 13);
			label12.TabIndex = 11;
			label12.Text = "UF:";
			label11.AutoSize = true;
			label11.Location = new System.Drawing.Point(179, 166);
			label11.Name = "label11";
			label11.Size = new System.Drawing.Size(43, 13);
			label11.TabIndex = 10;
			label11.Text = "Cidade:";
			label10.AutoSize = true;
			label10.Location = new System.Drawing.Point(12, 166);
			label10.Name = "label10";
			label10.Size = new System.Drawing.Size(31, 13);
			label10.TabIndex = 9;
			label10.Text = "CEP:";
			label9.AutoSize = true;
			label9.Location = new System.Drawing.Point(251, 113);
			label9.Name = "label9";
			label9.Size = new System.Drawing.Size(37, 13);
			label9.TabIndex = 8;
			label9.Text = "Bairro:";
			label8.AutoSize = true;
			label8.Location = new System.Drawing.Point(12, 113);
			label8.Name = "label8";
			label8.Size = new System.Drawing.Size(56, 13);
			label8.TabIndex = 7;
			label8.Text = "Endereço:";
			label7.AutoSize = true;
			label7.Location = new System.Drawing.Point(442, 57);
			label7.Name = "label7";
			label7.Size = new System.Drawing.Size(105, 13);
			label7.TabIndex = 6;
			label7.Text = "Dias de Vencimento:";
			label6.AutoSize = true;
			label6.Location = new System.Drawing.Point(324, 57);
			label6.Name = "label6";
			label6.Size = new System.Drawing.Size(37, 13);
			label6.TabIndex = 5;
			label6.Text = "Limite:";
			label5.AutoSize = true;
			label5.Location = new System.Drawing.Point(179, 57);
			label5.Name = "label5";
			label5.Size = new System.Drawing.Size(74, 13);
			label5.TabIndex = 4;
			label5.Text = "Reconhecido:";
			label4.AutoSize = true;
			label4.Location = new System.Drawing.Point(10, 57);
			label4.Name = "label4";
			label4.Size = new System.Drawing.Size(107, 13);
			label4.TabIndex = 3;
			label4.Text = "Data de Renovação:";
			label3.AutoSize = true;
			label3.Location = new System.Drawing.Point(440, 19);
			label3.Name = "label3";
			label3.Size = new System.Drawing.Size(56, 13);
			label3.TabIndex = 2;
			label3.Text = "Autografo:";
			label2.AutoSize = true;
			label2.Location = new System.Drawing.Point(125, 19);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(38, 13);
			label2.TabIndex = 1;
			label2.Text = "Nome:";
			label1.AutoSize = true;
			label1.Location = new System.Drawing.Point(10, 19);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(53, 13);
			label1.TabIndex = 0;
			label1.Text = "Matricula:";
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.MaximizeBox = false;
			base.ClientSize = new System.Drawing.Size(645, 422);
			base.Controls.Add(panel1);
			base.MinimizeBox = false;
			base.Name = "FormIfirma";
			base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			Text = "FormIfirma";
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			ResumeLayout(false);
		}
	}
}
