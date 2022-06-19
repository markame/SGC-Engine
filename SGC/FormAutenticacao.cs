using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace SGC
{
	public class FormAutenticacao : Form
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

		private TextBox tbquanti;

		private Label label2;

		public FormAutenticacao()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Close();
			FormbuscaAutenticacao bauten = new FormbuscaAutenticacao();
			bauten.ShowDialog();
		}

		private void tb_cod_TextChanged(object sender, EventArgs e)
		{
			string queryAT = "SELECT * FROM usuario WHERE id_Usuario='" + tb_cod.Text + "'";
			d.Tabeliao(queryAT);
		}

		private void TB_TAB_TextChanged(object sender, EventArgs e)
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

		private void button3_Click(object sender, EventArgs e)
		{
			string mes = null;
			path += "\\label.zin";
			dadoscartorio = getDados();
			DateTime now = DateTime.Now;
			switch (now.Month)
			{
			case 1:
				mes = "Janeiro";
				break;
			case 2:
				mes = "Fevereiro";
				break;
			case 3:
				mes = "Março";
				break;
			case 4:
				mes = "Abril";
				break;
			case 5:
				mes = "Maio";
				break;
			case 6:
				mes = "Junho";
				break;
			case 7:
				mes = "Julho";
				break;
			case 8:
				mes = "Agosto";
				break;
			case 9:
				mes = "Setembro";
				break;
			case 10:
				mes = "Outubro";
				break;
			case 11:
				mes = "Novembro";
				break;
			case 12:
				mes = "Dezembro";
				break;
			}
			dados busca = new dados();
			label = dadoscartorio + '\n' + "De acordo com o art.7º, lei nº 8935/94 autentico está fotocópia que é  \nreprodução fiel da original. (somente está face).\n\t\tCAXIAS(MA), " + now.Day + " de " + mes + " de " + now.Year + "\n\t\t\t__________________________________\n\t\t\t" + TB_TAB.Text + "\nValor da Autenticação R$  4,20    " + busca.Getfuncao() + "    \tValor do FERC R$ 0,10";
			int quant = int.Parse(tbquanti.Text);
			for (int i = 0; i < quant; i++)
			{
				classPrint print = new classPrint();
				print.printdocument("Label", 480, 151, label, 8);
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Close();
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
			label2 = new System.Windows.Forms.Label();
			tbquanti = new System.Windows.Forms.TextBox();
			panel1.SuspendLayout();
			groupBox1.SuspendLayout();
			SuspendLayout();
			panel1.Controls.Add(button3);
			panel1.Controls.Add(button2);
			panel1.Controls.Add(groupBox1);
			panel1.Location = new System.Drawing.Point(12, 12);
			panel1.Name = "panel1";
			panel1.Size = new System.Drawing.Size(633, 185);
			panel1.TabIndex = 1;
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
			button2.Click += new System.EventHandler(button2_Click);
			tb_cod.Location = new System.Drawing.Point(79, 79);
			tb_cod.Name = "tb_cod";
			tb_cod.Size = new System.Drawing.Size(59, 20);
			tb_cod.TabIndex = 5;
			tb_cod.TextChanged += new System.EventHandler(tb_cod_TextChanged);
			TB_TAB.Location = new System.Drawing.Point(144, 79);
			TB_TAB.Name = "TB_TAB";
			TB_TAB.Size = new System.Drawing.Size(345, 20);
			TB_TAB.TabIndex = 6;
			TB_TAB.TextChanged += new System.EventHandler(TB_TAB_TextChanged);
			label1.AutoSize = true;
			label1.Location = new System.Drawing.Point(22, 82);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(51, 13);
			label1.TabIndex = 3;
			label1.Text = "Tabelião:";
			button1.Location = new System.Drawing.Point(495, 17);
			button1.Name = "button1";
			button1.Size = new System.Drawing.Size(75, 23);
			button1.TabIndex = 2;
			button1.Text = "Buscar";
			button1.UseVisualStyleBackColor = true;
			button1.Click += new System.EventHandler(button1_Click);
			txFirm.Enabled = false;
			txFirm.Location = new System.Drawing.Point(79, 19);
			txFirm.Name = "txFirm";
			txFirm.Size = new System.Drawing.Size(410, 20);
			txFirm.TabIndex = 1;
			Firma.AutoSize = true;
			Firma.Location = new System.Drawing.Point(38, 22);
			Firma.Name = "Firma";
			Firma.Size = new System.Drawing.Size(35, 13);
			Firma.TabIndex = 0;
			Firma.Text = "Firma:";
			groupBox1.Controls.Add(tbquanti);
			groupBox1.Controls.Add(label2);
			groupBox1.Controls.Add(txFirm);
			groupBox1.Controls.Add(Firma);
			groupBox1.Controls.Add(tb_cod);
			groupBox1.Controls.Add(TB_TAB);
			groupBox1.Controls.Add(button1);
			groupBox1.Controls.Add(label1);
			groupBox1.Location = new System.Drawing.Point(3, 3);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new System.Drawing.Size(627, 179);
			groupBox1.TabIndex = 8;
			groupBox1.TabStop = false;
			groupBox1.Text = "Imprimir etiqueta";
			printDialog1.UseEXDialog = true;
			label2.AutoSize = true;
			label2.Location = new System.Drawing.Point(22, 125);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(30, 13);
			label2.TabIndex = 7;
			label2.Text = "Vias:";
			tbquanti.Location = new System.Drawing.Point(79, 122);
			tbquanti.Name = "tbquanti";
			tbquanti.Size = new System.Drawing.Size(59, 20);
			tbquanti.TabIndex = 8;
			tbquanti.TextChanged += new System.EventHandler(tbquanti_TextChanged);
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.MaximizeBox = false;
			base.ClientSize = new System.Drawing.Size(657, 209);
			base.Controls.Add(panel1);
			base.MinimizeBox = false;
			base.Name = "FormAutenticacao";
			base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			Text = "FormAutenticacao";
			panel1.ResumeLayout(false);
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			ResumeLayout(false);
		}
	}
}
