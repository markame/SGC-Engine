using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace SGC
{
	public class FormPrintSemelhanca : Form
	{
		private int t = 0;

		private string dadoscartorio;

		private string Nfirma;

		private dados d = new dados();

		private static string label;

		private string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

		private IContainer components = null;

		private Panel panel1;

		private Label label1;

		private TextBox txFirm;

		private Label label3;

		private Label label2;

		private Button button4;

		private Button button3;

		private TextBox TB_TAB;

		private TextBox tb_cod;

		private Button button2;

		private TextBox tx_firm2;

		private Button button1;

		private TextBox tbquanti;

		private Label label4;

		public FormPrintSemelhanca()
		{
			InitializeComponent();
			dados d = new dados();
			txFirm.Text = d.Getfirma1();
			tx_firm2.Text = d.Getfirma2();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Close();
			FormBusca3 bfirma = new FormBusca3();
			bfirma.ShowDialog();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Close();
			FormBFirma2 busca2 = new FormBFirma2();
			busca2.ShowDialog();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			string mes = null;
			path += "\\label.zin";
			dadoscartorio = getDados();
			DateTime now = DateTime.Now;
			switch (now.Month)
			{
			case 1:
				mes = "JANEIRO";
				break;
			case 2:
				mes = "FEVEREIRO";
				break;
			case 3:
				mes = "MARÇO";
				break;
			case 4:
				mes = "ABRIL";
				break;
			case 5:
				mes = "MAIO";
				break;
			case 6:
				mes = "JUNHO";
				break;
			case 7:
				mes = "JULHO";
				break;
			case 8:
				mes = "AGOSTO";
				break;
			case 9:
				mes = "SETEMBRO";
				break;
			case 10:
				mes = "OUTUBRO";
				break;
			case 11:
				mes = "NOVEMBRO";
				break;
			case 12:
				mes = "DEZEMBRO";
				break;
			}
			dados busca = new dados();
			string pessoa = txFirm.Text;
			string pessoa2 = tx_firm2.Text;
			if (string.IsNullOrEmpty(tx_firm2.Text))
			{
				if (txFirm.Text.Length <= 23)
				{
					label = dadoscartorio + '\n' + "RECONHEÇO POR SEMELHANÇA A FIRMA DE. " + txFirm.Text + " e,\nDOU FÉ.\n\t\tCAXIAS(MA), " + now.Day + " de " + mes + " de " + now.Year + "\n\t\t\t__________________________________\n\t\t\t" + TB_TAB.Text + "\nValor da Autenticação R$  4,20    " + busca.Getfuncao() + "    \tValor do FERC R$ 0,10";
				}
				else if (pessoa.Length < 25)
				{
					string nome = pessoa;
					label = dadoscartorio + '\n' + "RECONHEÇO POR SEMELHANÇA A FIRMA DE. " + nome + "\ne, DOU FÉ.\n\t\tCAXIAS(MA), " + now.Day + " de " + mes + " de " + now.Year + "\n\t\t\t__________________________________\n\t\t\t" + TB_TAB.Text + "\nValor da Autenticação R$  4,20    " + busca.Getfuncao() + "    \tValor do FERC R$ 0,10";
				}
				else
				{
					string nome2 = pessoa.Substring(0, 25);
					string nome3 = pessoa.Substring(25);
					label = dadoscartorio + '\n' + "RECONHEÇO POR SEMELHANÇA A FIRMA DE. " + nome2 + "\n" + nome3 + " e, DOU FÉ.\n\t\tCAXIAS(MA), " + now.Day + " de " + mes + " de " + now.Year + "\n\t\t\t__________________________________\n\t\t\t" + TB_TAB.Text + "\nValor da Autenticação R$  4,20    " + busca.Getfuncao() + "    \tValor do FERC R$ 0,10";
				}
			}
			else if (txFirm.Text.Length <= 23)
			{
				label = dadoscartorio + '\n' + "RECONHEÇO POR SEMELHANÇA A FIRMA DE, " + txFirm.Text + "\ne " + tx_firm2.Text + " e, DOU FÉ.\n\t\tCAXIAS(MA), " + now.Day + " de " + mes + " de " + now.Year + "\n\t\t__________________________________\n\t\t" + TB_TAB.Text + "\nValor da Autenticação R$  4,20    " + busca.Getfuncao() + "    \tValor do FERC R$ 0,10";
			}
			else
			{
				string nome4 = pessoa.Substring(0, 25);
				string nome5 = pessoa.Substring(25);
				label = dadoscartorio + '\n' + "RECONHEÇO POR SEMELHANÇA A FIRMA DE, " + nome4 + "\n" + nome5 + " e " + tx_firm2.Text + " e, DOU FÉ.\n\t\tCAXIAS(MA), " + now.Day + " de " + mes + " de " + now.Year + "\n\t\t__________________________________\n\t\t" + TB_TAB.Text + "\nValor da Autenticação R$  4,20    " + busca.Getfuncao() + "    \tValor do FERC R$ 0,10";
			}
			int quant = ((!string.IsNullOrEmpty(tbquanti.Text)) ? int.Parse(tbquanti.Text) : 0);
			if (quant == 0)
			{
				classPrint print = new classPrint();
				print.printdocument("Label", 480, 151, label, 8);
				return;
			}
			for (int i = 0; i < quant; i++)
			{
				classPrint print2 = new classPrint();
				print2.printdocument("Label", 480, 151, label, 8);
			}
		}

		private void textBox4_TextChanged(object sender, EventArgs e)
		{
			TB_TAB.Text = d.Gettabeliao();
		}

		private string getDados()
		{
			string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\regex.zin";
			string[] lines = File.ReadAllLines(path);
			dadoscartorio = lines[0];
			dadoscartorio = dadoscartorio + "\n" + lines[1];
			return dadoscartorio;
		}

		private void tb_cod_TextChanged(object sender, EventArgs e)
		{
			string queryAT = "SELECT * FROM usuario WHERE id_Usuario='" + tb_cod.Text + "'";
			d.Tabeliao(queryAT);
		}

		private void label2_Click(object sender, EventArgs e)
		{
		}

		private void tx_firm2_TextChanged(object sender, EventArgs e)
		{
		}

		private void label4_Click(object sender, EventArgs e)
		{
		}

		private void tbquanti_TextChanged(object sender, EventArgs e)
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
			button4 = new System.Windows.Forms.Button();
			button3 = new System.Windows.Forms.Button();
			TB_TAB = new System.Windows.Forms.TextBox();
			tb_cod = new System.Windows.Forms.TextBox();
			button2 = new System.Windows.Forms.Button();
			tx_firm2 = new System.Windows.Forms.TextBox();
			button1 = new System.Windows.Forms.Button();
			txFirm = new System.Windows.Forms.TextBox();
			label3 = new System.Windows.Forms.Label();
			label2 = new System.Windows.Forms.Label();
			label1 = new System.Windows.Forms.Label();
			tbquanti = new System.Windows.Forms.TextBox();
			label4 = new System.Windows.Forms.Label();
			panel1.SuspendLayout();
			SuspendLayout();
			panel1.Controls.Add(tbquanti);
			panel1.Controls.Add(label4);
			panel1.Controls.Add(button4);
			panel1.Controls.Add(button3);
			panel1.Controls.Add(TB_TAB);
			panel1.Controls.Add(tb_cod);
			panel1.Controls.Add(button2);
			panel1.Controls.Add(tx_firm2);
			panel1.Controls.Add(button1);
			panel1.Controls.Add(txFirm);
			panel1.Controls.Add(label3);
			panel1.Controls.Add(label2);
			panel1.Controls.Add(label1);
			panel1.Location = new System.Drawing.Point(12, 12);
			panel1.Name = "panel1";
			panel1.Size = new System.Drawing.Size(633, 185);
			panel1.TabIndex = 0;
			button4.Location = new System.Drawing.Point(438, 144);
			button4.Name = "button4";
			button4.Size = new System.Drawing.Size(75, 23);
			button4.TabIndex = 10;
			button4.Text = "Cancelar";
			button4.UseVisualStyleBackColor = true;
			button3.Location = new System.Drawing.Point(519, 144);
			button3.Name = "button3";
			button3.Size = new System.Drawing.Size(75, 23);
			button3.TabIndex = 9;
			button3.Text = "Imprimir";
			button3.UseVisualStyleBackColor = true;
			button3.Click += new System.EventHandler(button3_Click);
			TB_TAB.Location = new System.Drawing.Point(117, 114);
			TB_TAB.Name = "TB_TAB";
			TB_TAB.Size = new System.Drawing.Size(396, 20);
			TB_TAB.TabIndex = 8;
			TB_TAB.TextChanged += new System.EventHandler(textBox4_TextChanged);
			tb_cod.Location = new System.Drawing.Point(61, 114);
			tb_cod.Name = "tb_cod";
			tb_cod.Size = new System.Drawing.Size(50, 20);
			tb_cod.TabIndex = 7;
			tb_cod.TextChanged += new System.EventHandler(tb_cod_TextChanged);
			button2.Location = new System.Drawing.Point(519, 67);
			button2.Name = "button2";
			button2.Size = new System.Drawing.Size(75, 23);
			button2.TabIndex = 6;
			button2.Text = "Buscar";
			button2.UseVisualStyleBackColor = true;
			button2.Click += new System.EventHandler(button2_Click);
			tx_firm2.Enabled = false;
			tx_firm2.ForeColor = System.Drawing.SystemColors.WindowText;
			tx_firm2.Location = new System.Drawing.Point(61, 69);
			tx_firm2.Name = "tx_firm2";
			tx_firm2.Size = new System.Drawing.Size(452, 20);
			tx_firm2.TabIndex = 5;
			tx_firm2.TextChanged += new System.EventHandler(tx_firm2_TextChanged);
			button1.Location = new System.Drawing.Point(519, 24);
			button1.Name = "button1";
			button1.Size = new System.Drawing.Size(75, 23);
			button1.TabIndex = 4;
			button1.Text = "Buscar";
			button1.UseVisualStyleBackColor = true;
			button1.Click += new System.EventHandler(button1_Click);
			txFirm.Enabled = false;
			txFirm.Location = new System.Drawing.Point(61, 26);
			txFirm.Name = "txFirm";
			txFirm.Size = new System.Drawing.Size(452, 20);
			txFirm.TabIndex = 3;
			label3.AutoSize = true;
			label3.Location = new System.Drawing.Point(4, 117);
			label3.Name = "label3";
			label3.Size = new System.Drawing.Size(51, 13);
			label3.TabIndex = 2;
			label3.Text = "Tabelião:";
			label2.AutoSize = true;
			label2.Location = new System.Drawing.Point(4, 72);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(44, 13);
			label2.TabIndex = 1;
			label2.Text = "Firma 2:";
			label2.Click += new System.EventHandler(label2_Click);
			label1.AutoSize = true;
			label1.Location = new System.Drawing.Point(4, 29);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(44, 13);
			label1.TabIndex = 0;
			label1.Text = "Firma 1:";
			tbquanti.Location = new System.Drawing.Point(61, 146);
			tbquanti.Name = "tbquanti";
			tbquanti.Size = new System.Drawing.Size(59, 20);
			tbquanti.TabIndex = 13;
			tbquanti.TextChanged += new System.EventHandler(tbquanti_TextChanged);
			label4.AutoSize = true;
			label4.Location = new System.Drawing.Point(4, 149);
			label4.Name = "label4";
			label4.Size = new System.Drawing.Size(30, 13);
			label4.TabIndex = 12;
			label4.Text = "Vias:";
			label4.Click += new System.EventHandler(label4_Click);
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.MaximizeBox = false;
			base.ClientSize = new System.Drawing.Size(657, 209);
			base.Controls.Add(panel1);
			ForeColor = System.Drawing.SystemColors.ControlText;
			base.MinimizeBox = false;
			base.Name = "FormPrintSemelhanca";
			base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			Text = "Firma por Semelhança";
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			ResumeLayout(false);
		}
	}
}
