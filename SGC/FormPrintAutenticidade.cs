using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace SGC
{
	public class FormPrintAutenticidade : Form
	{
		private int t = 0;

		private string dadoscartorio;

		private string Nfirma;

		private dados d = new dados();

		private static string label;

		private string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

		private IContainer components = null;

		private Panel panel1;

		private Button button3;

		private Button button2;

		private TextBox tb_cod;

		private TextBox TB_TAB;

		private Label label1;

		private Button button1;

		private TextBox txFirm;

		private Label Firma;

		private GroupBox groupBox1;

		private PrintDialog printDialog1;

		private PrintDocument printDocument1;

		private Button button4;

		private TextBox tx_firm2;

		private Label label2;

		private TextBox tbquanti;

		private Label label3;

		public FormPrintAutenticidade()
		{
			InitializeComponent();
			dados d = new dados();
			txFirm.Text = d.Getfirma1();
			tx_firm2.Text = d.Getfirma2();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Close();
			FormBfirma bfirma = new FormBfirma();
			bfirma.ShowDialog();
		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{
		}

		private void txFirm_TextChanged(object sender, EventArgs e)
		{
		}

		private void FormPrintAutenticidade_Load(object sender, EventArgs e)
		{
		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{
			TB_TAB.Text = d.Gettabeliao();
		}

		private void tb_cod_TextChanged(object sender, EventArgs e)
		{
			string queryAT = "SELECT * FROM usuario WHERE id_Usuario='" + tb_cod.Text + "'";
			d.Tabeliao(queryAT);
		}

		private string getDados()
		{
			string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\regex.zin";
			string[] lines = File.ReadAllLines(path);
			dadoscartorio = lines[0];
			dadoscartorio = dadoscartorio + "\n" + lines[1];
			return dadoscartorio;
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
					label = dadoscartorio + '\n' + "RECONHEÇO POR AUTENTICIDADE A FIRMA DE. " + txFirm.Text + " e,\nDOU FÉ.\n\t\tCAXIAS(MA), " + now.Day + " de " + mes + " de " + now.Year + "\n\t\t\t__________________________________\n\t\t\t" + TB_TAB.Text + "\nValor da Autenticação R$  4,20    " + busca.Getfuncao() + "    \tValor do FERC R$ 0,10";
				}
				else if (pessoa.Length < 25)
				{
					string nome = pessoa;
					label = dadoscartorio + '\n' + "RECONHEÇO POR AUTENTICIDADE A FIRMA DE. " + nome + "\ne, DOU FÉ.\n\t\tCAXIAS(MA), " + now.Day + " de " + mes + " de " + now.Year + "\n\t\t\t__________________________________\n\t\t\t" + TB_TAB.Text + "\nValor da Autenticação R$  4,20    " + busca.Getfuncao() + "    \tValor do FERC R$ 0,10";
				}
				else
				{
					string nome2 = pessoa.Substring(0, 25);
					string nome3 = pessoa.Substring(25);
					label = dadoscartorio + '\n' + "RECONHEÇO POR AUTENTICIDADE A FIRMA DE. " + nome2 + "\n" + nome3 + " e, DOU FÉ.\n\t\tCAXIAS(MA), " + now.Day + " de " + mes + " de " + now.Year + "\n\t\t\t__________________________________\n\t\t\t" + TB_TAB.Text + "\nValor da Autenticação R$  4,20    " + busca.Getfuncao() + "    \tValor do FERC R$ 0,10";
				}
			}
			else if (txFirm.Text.Length <= 23)
			{
				label = dadoscartorio + '\n' + "RECONHEÇO POR AUTENTICIDADE A FIRMA DE, " + txFirm.Text + "\ne " + tx_firm2.Text + " e, DOU FÉ.\n\t\tCAXIAS(MA), " + now.Day + " de " + mes + " de " + now.Year + "\n\t\t__________________________________\n\t\t" + TB_TAB.Text + "\nValor da Autenticação R$  4,20    " + busca.Getfuncao() + "    \tValor do FERC R$ 0,10";
			}
			else
			{
				string nome4 = pessoa.Substring(0, 25);
				string nome5 = pessoa.Substring(25);
				label = dadoscartorio + '\n' + "RECONHEÇO POR AUTENTICIDADE A FIRMA DE, " + nome4 + "\n" + nome5 + " e " + tx_firm2.Text + " e, DOU FÉ.\n\t\tCAXIAS(MA), " + now.Day + " de " + mes + " de " + now.Year + "\n\t\t__________________________________\n\t\t" + TB_TAB.Text + "\nValor da Autenticação R$  4,20    " + busca.Getfuncao() + "    \tValor do FERC R$ 0,10";
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

		private void button4_Click(object sender, EventArgs e)
		{
			Busca4 b4 = new Busca4();
			b4.ShowDialog();
			Close();
		}

		private void tx_firm2_TextChanged(object sender, EventArgs e)
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
			tb_cod = new System.Windows.Forms.TextBox();
			TB_TAB = new System.Windows.Forms.TextBox();
			label1 = new System.Windows.Forms.Label();
			button1 = new System.Windows.Forms.Button();
			txFirm = new System.Windows.Forms.TextBox();
			Firma = new System.Windows.Forms.Label();
			groupBox1 = new System.Windows.Forms.GroupBox();
			printDialog1 = new System.Windows.Forms.PrintDialog();
			printDocument1 = new System.Drawing.Printing.PrintDocument();
			button4 = new System.Windows.Forms.Button();
			tx_firm2 = new System.Windows.Forms.TextBox();
			label2 = new System.Windows.Forms.Label();
			tbquanti = new System.Windows.Forms.TextBox();
			label3 = new System.Windows.Forms.Label();
			panel1.SuspendLayout();
			groupBox1.SuspendLayout();
			SuspendLayout();
			panel1.Controls.Add(button3);
			panel1.Controls.Add(button2);
			panel1.Controls.Add(tb_cod);
			panel1.Controls.Add(TB_TAB);
			panel1.Controls.Add(label1);
			panel1.Controls.Add(button1);
			panel1.Controls.Add(txFirm);
			panel1.Controls.Add(groupBox1);
			panel1.Location = new System.Drawing.Point(12, 12);
			panel1.Name = "panel1";
			panel1.Size = new System.Drawing.Size(633, 185);
			panel1.TabIndex = 0;
			button3.Location = new System.Drawing.Point(498, 148);
			button3.Name = "button3";
			button3.Size = new System.Drawing.Size(75, 23);
			button3.TabIndex = 7;
			button3.Text = "Imprimir";
			button3.UseVisualStyleBackColor = true;
			button3.Click += new System.EventHandler(button3_Click);
			button2.Location = new System.Drawing.Point(417, 148);
			button2.Name = "button2";
			button2.Size = new System.Drawing.Size(75, 23);
			button2.TabIndex = 8;
			button2.Text = "Cancelar";
			button2.UseVisualStyleBackColor = true;
			tb_cod.Location = new System.Drawing.Point(82, 100);
			tb_cod.Name = "tb_cod";
			tb_cod.Size = new System.Drawing.Size(59, 20);
			tb_cod.TabIndex = 5;
			tb_cod.TextChanged += new System.EventHandler(tb_cod_TextChanged);
			TB_TAB.Location = new System.Drawing.Point(147, 100);
			TB_TAB.Name = "TB_TAB";
			TB_TAB.Size = new System.Drawing.Size(345, 20);
			TB_TAB.TabIndex = 6;
			TB_TAB.TextChanged += new System.EventHandler(textBox2_TextChanged);
			label1.AutoSize = true;
			label1.Location = new System.Drawing.Point(25, 103);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(51, 13);
			label1.TabIndex = 3;
			label1.Text = "Tabelião:";
			button1.Location = new System.Drawing.Point(498, 39);
			button1.Name = "button1";
			button1.Size = new System.Drawing.Size(75, 23);
			button1.TabIndex = 2;
			button1.Text = "Buscar";
			button1.UseVisualStyleBackColor = true;
			button1.Click += new System.EventHandler(button1_Click);
			txFirm.Enabled = false;
			txFirm.Location = new System.Drawing.Point(82, 41);
			txFirm.Name = "txFirm";
			txFirm.Size = new System.Drawing.Size(410, 20);
			txFirm.TabIndex = 1;
			txFirm.TextChanged += new System.EventHandler(txFirm_TextChanged);
			Firma.AutoSize = true;
			Firma.Location = new System.Drawing.Point(22, 41);
			Firma.Name = "Firma";
			Firma.Size = new System.Drawing.Size(54, 13);
			Firma.TabIndex = 0;
			Firma.Text = "Pessoa 1:";
			groupBox1.Controls.Add(tbquanti);
			groupBox1.Controls.Add(label3);
			groupBox1.Controls.Add(button4);
			groupBox1.Controls.Add(tx_firm2);
			groupBox1.Controls.Add(label2);
			groupBox1.Controls.Add(Firma);
			groupBox1.Location = new System.Drawing.Point(3, 3);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new System.Drawing.Size(627, 179);
			groupBox1.TabIndex = 8;
			groupBox1.TabStop = false;
			groupBox1.Text = "Imprimir etiqueta";
			groupBox1.Enter += new System.EventHandler(groupBox1_Enter);
			printDialog1.UseEXDialog = true;
			button4.Location = new System.Drawing.Point(495, 66);
			button4.Name = "button4";
			button4.Size = new System.Drawing.Size(75, 23);
			button4.TabIndex = 9;
			button4.Text = "Buscar";
			button4.UseVisualStyleBackColor = true;
			button4.Click += new System.EventHandler(button4_Click);
			tx_firm2.Enabled = false;
			tx_firm2.ForeColor = System.Drawing.SystemColors.WindowText;
			tx_firm2.Location = new System.Drawing.Point(79, 68);
			tx_firm2.Name = "tx_firm2";
			tx_firm2.Size = new System.Drawing.Size(410, 20);
			tx_firm2.TabIndex = 8;
			tx_firm2.TextChanged += new System.EventHandler(tx_firm2_TextChanged);
			label2.AutoSize = true;
			label2.Location = new System.Drawing.Point(22, 71);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(54, 13);
			label2.TabIndex = 7;
			label2.Text = "Pessoa 2:";
			tbquanti.Location = new System.Drawing.Point(79, 126);
			tbquanti.Name = "tbquanti";
			tbquanti.Size = new System.Drawing.Size(59, 20);
			tbquanti.TabIndex = 11;
			label3.AutoSize = true;
			label3.Location = new System.Drawing.Point(22, 129);
			label3.Name = "label3";
			label3.Size = new System.Drawing.Size(30, 13);
			label3.TabIndex = 10;
			label3.Text = "Vias:";
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.MaximizeBox = false;
			base.ClientSize = new System.Drawing.Size(657, 209);
			base.Controls.Add(panel1);
			base.MinimizeBox = false;
			base.Name = "FormPrintAutenticidade";
			base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			Text = "Etiqueta por Autenticidade";
			base.Load += new System.EventHandler(FormPrintAutenticidade_Load);
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			ResumeLayout(false);
		}
	}
}
