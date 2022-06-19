using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SGC
{
	public class FormPrincipal : Form
	{
		private string dadoscartorio;

		private dados d = new dados();

		public string Codigo;

		public string Nome;

		public string Autografo;

		public string DatadeRenovacao;

		public string DatadeReconhecimento;

		public string endereco;

		public string bairro;

		public string PeriododeValidade;

		public string CEP;

		public string Cidade;

		public string UF;

		public string Sexo;

		public string EstadoCivil;

		public string Profissao;

		public string DatadeNascimento;

		public string CPF;

		public string CGC;

		public string RG;

		public string Controle;

		public string Observacao;

		public string tabeliao;

		private IContainer components = null;

		private Panel panel1;

		private MenuStrip menuStrip1;

		private ToolStripMenuItem cADASTROToolStripMenuItem;

		private ToolStripMenuItem tABLIÃOToolStripMenuItem;

		private ToolStripMenuItem iNCLUIRToolStripMenuItem;

		private ToolStripMenuItem mANUTENÇÃOToolStripMenuItem;

		private ToolStripMenuItem pROTESTOSToolStripMenuItem;

		private ToolStripMenuItem iNCLUSÃOToolStripMenuItem;

		private ToolStripMenuItem mANUTENÇÃOToolStripMenuItem1;

		private ToolStripMenuItem fIRMASToolStripMenuItem;

		private ToolStripMenuItem iNCLUSÃOToolStripMenuItem1;

		private ToolStripMenuItem mANUTENCAOToolStripMenuItem;

		private ToolStripMenuItem oUTRASFIRMASToolStripMenuItem;

		private ToolStripMenuItem iNCLUSÃOToolStripMenuItem2;

		private ToolStripMenuItem mANUTENÇÃOToolStripMenuItem2;

		private ToolStripMenuItem sCANNERToolStripMenuItem;

		private ToolStripMenuItem rELATORIOSToolStripMenuItem;

		private ToolStripMenuItem aPOIOCONFIGURAToolStripMenuItem;

		private ToolStripMenuItem sOBREToolStripMenuItem;

		private GroupBox groupBox2;

		private GroupBox groupBox1;

		private ToolStrip toolStrip1;

		private ToolStripButton toolStripButton1;

		private ToolStripSeparator toolStripSeparator1;

		private DataGridView dgfirma;

		private ToolStripButton toolStripButton2;

		private ToolStripButton toolStripButton3;

		private Label label1;

		private Label label2;

		private Label lbfuncao;

		private Label lbHora;

		private Label lbusuario;

		private Label lbcartorio;

		private Label label4;

		private Label label3;

		private ToolStripMenuItem aJUDAToolStripMenuItem;

		private ToolStripSeparator toolStripSeparator2;

		private ToolStripMenuItem sepaToolStripMenuItem;

		private Timer timer1;

		private ToolStripMenuItem etiquetaFirrmaAUTENTICIDADEToolStripMenuItem;

		private ToolStripMenuItem etiquetaFirmaSEMELHANÇAToolStripMenuItem;

		private ToolStripMenuItem sAIRToolStripMenuItem;

		private ToolStripMenuItem bACKUPToolStripMenuItem;

		private ToolStripMenuItem aUTENTICAÇÃODEFIRMAToolStripMenuItem;

		public FormPrincipal()
		{
			InitializeComponent();
			closeLogin();
			timer1.Start();
			lbcartorio.Text = getDados();
			FormLogin closeform = new FormLogin();
			closeform.ThreadSafeClose();
			dados busca = new dados();
			lbusuario.Text = busca.GetnomeU();
			lbfuncao.Text = busca.Getfuncao();
			Plista();
		}

		private void cADASTROToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		private void tABLIÃOToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		private void iNCLUIRToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FormTinclui incluitabeliao = new FormTinclui();
			incluitabeliao.ShowDialog();
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{
			conect_querygeneric openconector = new conect_querygeneric();
			openconector.DAO();
		}

		private void mANUTENÇÃOToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FormTmanu mostratabeliao = new FormTmanu();
			mostratabeliao.ShowDialog();
		}

		private void sOBREToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FormSobre sobre = new FormSobre();
			sobre.ShowDialog();
		}

		private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
		}

		private void closeLogin()
		{
			FormLogin login = new FormLogin();
			login.fechar();
		}

		private void label1_Click(object sender, EventArgs e)
		{
		}

		private void label6_Click(object sender, EventArgs e)
		{
		}

		private void groupBox2_Enter(object sender, EventArgs e)
		{
		}

		private void aPOIOCONFIGURAToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		private void sepaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FormRegistro registro = new FormRegistro();
			registro.ShowDialog();
		}

		private string getDados()
		{
			string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\regex.zin";
			string[] lines = File.ReadAllLines(path);
			dadoscartorio = lines[0];
			dadoscartorio = dadoscartorio + "\n" + lines[1];
			return dadoscartorio;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			DateTime dateTime = DateTime.Now;
			lbHora.Text = dateTime.ToString();
		}

		private void iNCLUSÃOToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			FormIfirma novaFirma = new FormIfirma();
			novaFirma.ShowDialog();
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				DataGridViewRow row = dgfirma.Rows[e.RowIndex];
				Codigo = row.Cells["Codigo"].Value.ToString();
				Nome = row.Cells["Nome"].Value.ToString();
				Autografo = row.Cells["Autografo"].Value.ToString();
				DatadeRenovacao = row.Cells["Data de Renovacao"].Value.ToString();
				DatadeReconhecimento = row.Cells["Data de Reconhecimento"].Value.ToString();
				PeriododeValidade = row.Cells["Periodo de Validade"].Value.ToString();
				endereco = row.Cells["Endereco"].Value.ToString();
				bairro = row.Cells["Bairro"].Value.ToString();
				CEP = row.Cells["CEP"].Value.ToString();
				Cidade = row.Cells["Cidade"].Value.ToString();
				UF = row.Cells["UF"].Value.ToString();
				Sexo = row.Cells["Sexo"].Value.ToString();
				EstadoCivil = row.Cells["Estado Civil"].Value.ToString();
				Profissao = row.Cells["Profissao"].Value.ToString();
				DatadeNascimento = row.Cells["Data de Nascimento"].Value.ToString();
				CPF = row.Cells["CPF"].Value.ToString();
				CGC = row.Cells["C.G.C"].Value.ToString();
				tabeliao = row.Cells["Tabeliao"].Value.ToString();
				RG = row.Cells["RG"].Value.ToString();
				Controle = row.Cells["Controle"].Value.ToString();
				Observacao = row.Cells["Observacao"].Value.ToString();
			}
		}

		private void etiquetaFirrmaAUTENTICIDADEToolStripMenuItem_Click(object sender, EventArgs e)
		{
			dados d = new dados();
			d.SetFirma1("");
			d.SetFirma2("");
			FormPrintAutenticidade aprint = new FormPrintAutenticidade();
			aprint.Show();
		}

		private void mANUTENCAOToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FormFmanu fm = new FormFmanu();
			fm.Show();
		}

		public void Plista()
		{
			conect_querygeneric selectuser = new conect_querygeneric();
			selectuser.DAO();
			string query = "SELECT id_firma as 'Codigo', nome as 'Nome', autografo as 'Autografo', DATE_FORMAT( d_renovacao , '%d/%m/%Y' ) as 'Data de Renovacao', DATE_FORMAT( roconheciada , '%d/%m/%Y' ) as 'Data de Reconhecimento', DATE_FORMAT( validade , '%d/%m/%Y' )   as 'Periodo de Validade', encereco as 'Endereco', bairro as 'Bairro', cep as 'CEP', cidade as 'Cidade', uf as 'UF', sexo as 'Sexo', civil as 'Estado Civil', profissao as 'Profissao', DATE_FORMAT( d_nascimento , '%d/%m/%Y' ) as 'Data de Nascimento', cpf as 'CPF', cgc as 'C.G.C', indentidade as 'RG', tabeliao as 'Tabeliao', controle as 'Controle', observ as 'Observacao' FROM firma WHERE validade  <='" + DateTime.Today.Date.ToString("yyyy/MM/dd") + "' ";
			try
			{
				DataTable dtfIRMA = new DataTable();
				selectuser.SELECTGENERIC(query).Fill(dtfIRMA);
				dgfirma.DataSource = dtfIRMA;
			}
			catch (MySqlException)
			{
				MessageBox.Show("Erro ao carregar os dados da tabela usuario", "ERRO");
			}
		}

		private void sAIRToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void toolStripButton1_Click(object sender, EventArgs e)
		{
		}

		private void toolStripButton2_Click(object sender, EventArgs e)
		{
			if (Codigo == null)
			{
				MessageBox.Show("O item da lista de Firmas vencidas não foi selecionado de forma correta ou não existe tente clicar duas vezes no nome da firma antes de executar essa operação", "Erro");
				return;
			}
			editFirma editafirma = new editFirma();
			editafirma.setFirma(Codigo, Nome, Autografo, DatadeRenovacao, DatadeReconhecimento, PeriododeValidade, CEP, Cidade, UF, Sexo, EstadoCivil, Profissao, DatadeNascimento, CPF, CGC, RG, Controle, Observacao, endereco, bairro, tabeliao);
			FormFEdit fef = new FormFEdit();
			fef.ShowDialog();
			Plista();
		}

		private void toolStripButton3_Click(object sender, EventArgs e)
		{
			if (Codigo == null)
			{
				MessageBox.Show("O item da lista de Firmas vencidas não foi selecionado de forma correta ou não existe tente clicar duas vezes no nome da firma antes de executar essa operação", "Erro");
				return;
			}
			conect_querygeneric openconector = new conect_querygeneric();
			DialogResult result = MessageBox.Show("Deseja realmente excluir esse registro", "Tem Certeza", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.Yes)
			{
				openconector.DELETEGENERIC("DELETE FROM firma WHERE id_firma = '" + Codigo + "'");
			}
			Plista();
		}

		private void etiquetaFirmaSEMELHANÇAToolStripMenuItem_Click(object sender, EventArgs e)
		{
			dados d = new dados();
			d.SetFirma1("");
			d.SetFirma2("");
			FormPrintSemelhanca semelhanca = new FormPrintSemelhanca();
			semelhanca.ShowDialog();
		}

		private void iNCLUSÃOToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FormIProtesto newProtesto = new FormIProtesto();
			newProtesto.ShowDialog();
		}

		private void mANUTENÇÃOToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			FormPedit editaProtesto = new FormPedit();
			editaProtesto.ShowDialog();
		}

		private void iNCLUSÃOToolStripMenuItem2_Click(object sender, EventArgs e)
		{
			FormIOutraFirma outra = new FormIOutraFirma();
			outra.ShowDialog();
		}

		private void sCANNERToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FormScannerDevice scan = new FormScannerDevice();
			scan.ShowDialog();
		}

		private void aUTENTICAÇÃODEFIRMAToolStripMenuItem_Click(object sender, EventArgs e)
		{
			d.SetFirma1("");
			FormAutenticacao autenticaco = new FormAutenticacao();
			autenticaco.ShowDialog();
		}

		private void mANUTENÇÃOToolStripMenuItem2_Click(object sender, EventArgs e)
		{
			OutraFManu ofmanu = new OutraFManu();
			ofmanu.ShowDialog();
		}

		private void lbfuncao_Click(object sender, EventArgs e)
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
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SGC.FormPrincipal));
			panel1 = new System.Windows.Forms.Panel();
			toolStrip1 = new System.Windows.Forms.ToolStrip();
			toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			toolStripButton2 = new System.Windows.Forms.ToolStripButton();
			toolStripButton3 = new System.Windows.Forms.ToolStripButton();
			groupBox2 = new System.Windows.Forms.GroupBox();
			lbfuncao = new System.Windows.Forms.Label();
			lbHora = new System.Windows.Forms.Label();
			lbusuario = new System.Windows.Forms.Label();
			lbcartorio = new System.Windows.Forms.Label();
			label4 = new System.Windows.Forms.Label();
			label3 = new System.Windows.Forms.Label();
			label2 = new System.Windows.Forms.Label();
			label1 = new System.Windows.Forms.Label();
			groupBox1 = new System.Windows.Forms.GroupBox();
			dgfirma = new System.Windows.Forms.DataGridView();
			menuStrip1 = new System.Windows.Forms.MenuStrip();
			cADASTROToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			tABLIÃOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			iNCLUIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			mANUTENÇÃOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			pROTESTOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			iNCLUSÃOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			mANUTENÇÃOToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			fIRMASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			iNCLUSÃOToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			mANUTENCAOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			oUTRASFIRMASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			iNCLUSÃOToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			mANUTENÇÃOToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			sAIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			sCANNERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			rELATORIOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			etiquetaFirrmaAUTENTICIDADEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			etiquetaFirmaSEMELHANÇAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			aUTENTICAÇÃODEFIRMAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			aPOIOCONFIGURAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			aJUDAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			sepaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			bACKUPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			sOBREToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			timer1 = new System.Windows.Forms.Timer(components);
			panel1.SuspendLayout();
			toolStrip1.SuspendLayout();
			groupBox2.SuspendLayout();
			groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgfirma).BeginInit();
			menuStrip1.SuspendLayout();
			SuspendLayout();
			panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			panel1.Controls.Add(toolStrip1);
			panel1.Controls.Add(groupBox2);
			panel1.Controls.Add(groupBox1);
			panel1.Controls.Add(menuStrip1);
			panel1.Location = new System.Drawing.Point(12, 12);
			panel1.Name = "panel1";
			panel1.Size = new System.Drawing.Size(760, 578);
			panel1.TabIndex = 0;
			panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
			toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[4] { toolStripButton1, toolStripSeparator1, toolStripButton2, toolStripButton3 });
			toolStrip1.Location = new System.Drawing.Point(0, 24);
			toolStrip1.Name = "toolStrip1";
			toolStrip1.Size = new System.Drawing.Size(758, 25);
			toolStrip1.TabIndex = 3;
			toolStrip1.Text = "toolStrip1";
			toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(toolStrip1_ItemClicked);
			toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			toolStripButton1.Image = (System.Drawing.Image)resources.GetObject("toolStripButton1.Image");
			toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			toolStripButton1.Name = "toolStripButton1";
			toolStripButton1.Size = new System.Drawing.Size(23, 22);
			toolStripButton1.Text = "Imprimir dados do protesto";
			toolStripButton1.ToolTipText = "Imprimir dados do Protesto";
			toolStripButton1.Click += new System.EventHandler(toolStripButton1_Click);
			toolStripSeparator1.Name = "toolStripSeparator1";
			toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			toolStripButton2.Image = (System.Drawing.Image)resources.GetObject("toolStripButton2.Image");
			toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
			toolStripButton2.Name = "toolStripButton2";
			toolStripButton2.Size = new System.Drawing.Size(23, 22);
			toolStripButton2.Text = "Abrir Protesto";
			toolStripButton2.Click += new System.EventHandler(toolStripButton2_Click);
			toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			toolStripButton3.Image = (System.Drawing.Image)resources.GetObject("toolStripButton3.Image");
			toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
			toolStripButton3.Name = "toolStripButton3";
			toolStripButton3.Size = new System.Drawing.Size(23, 22);
			toolStripButton3.Text = "Exluir Protesto";
			toolStripButton3.Click += new System.EventHandler(toolStripButton3_Click);
			groupBox2.Controls.Add(lbfuncao);
			groupBox2.Controls.Add(lbHora);
			groupBox2.Controls.Add(lbusuario);
			groupBox2.Controls.Add(lbcartorio);
			groupBox2.Controls.Add(label4);
			groupBox2.Controls.Add(label3);
			groupBox2.Controls.Add(label2);
			groupBox2.Controls.Add(label1);
			groupBox2.Location = new System.Drawing.Point(3, 437);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new System.Drawing.Size(754, 138);
			groupBox2.TabIndex = 2;
			groupBox2.TabStop = false;
			groupBox2.Text = "Dados do Utilizador";
			groupBox2.Enter += new System.EventHandler(groupBox2_Enter);
			lbfuncao.AutoSize = true;
			lbfuncao.Location = new System.Drawing.Point(576, 95);
			lbfuncao.Name = "lbfuncao";
			lbfuncao.Size = new System.Drawing.Size(25, 13);
			lbfuncao.TabIndex = 7;
			lbfuncao.Text = "------";
			lbfuncao.Click += new System.EventHandler(lbfuncao_Click);
			lbHora.AutoSize = true;
			lbHora.Location = new System.Drawing.Point(614, 44);
			lbHora.Name = "lbHora";
			lbHora.Size = new System.Drawing.Size(25, 13);
			lbHora.TabIndex = 6;
			lbHora.Text = "------";
			lbusuario.AutoSize = true;
			lbusuario.Location = new System.Drawing.Point(127, 95);
			lbusuario.Name = "lbusuario";
			lbusuario.Size = new System.Drawing.Size(22, 13);
			lbusuario.TabIndex = 5;
			lbusuario.Text = "-----";
			lbusuario.Click += new System.EventHandler(label6_Click);
			lbcartorio.AutoSize = true;
			lbcartorio.Location = new System.Drawing.Point(114, 44);
			lbcartorio.Name = "lbcartorio";
			lbcartorio.Size = new System.Drawing.Size(22, 13);
			lbcartorio.TabIndex = 4;
			lbcartorio.Text = "-----";
			label4.AutoSize = true;
			label4.Location = new System.Drawing.Point(513, 95);
			label4.Name = "label4";
			label4.Size = new System.Drawing.Size(46, 13);
			label4.TabIndex = 3;
			label4.Text = "Função:";
			label3.AutoSize = true;
			label3.Location = new System.Drawing.Point(513, 44);
			label3.Name = "label3";
			label3.Size = new System.Drawing.Size(95, 13);
			label3.TabIndex = 2;
			label3.Text = "Data e Hora Atual:";
			label2.AutoSize = true;
			label2.Location = new System.Drawing.Point(7, 95);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(114, 13);
			label2.TabIndex = 1;
			label2.Text = "Utilizador no momento:";
			label1.AutoSize = true;
			label1.Location = new System.Drawing.Point(7, 44);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(101, 13);
			label1.TabIndex = 0;
			label1.Text = "Cartório Licenciado:";
			label1.Click += new System.EventHandler(label1_Click);
			groupBox1.Controls.Add(dgfirma);
			groupBox1.Location = new System.Drawing.Point(3, 59);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new System.Drawing.Size(754, 372);
			groupBox1.TabIndex = 1;
			groupBox1.TabStop = false;
			groupBox1.Text = "Firmas Vencidas";
			dgfirma.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
			dgfirma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgfirma.Location = new System.Drawing.Point(6, 19);
			dgfirma.Name = "dgfirma";
			dgfirma.Size = new System.Drawing.Size(742, 347);
			dgfirma.TabIndex = 0;
			dgfirma.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(dataGridView1_CellContentClick);
			menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[5] { cADASTROToolStripMenuItem, sCANNERToolStripMenuItem, rELATORIOSToolStripMenuItem, aPOIOCONFIGURAToolStripMenuItem, sOBREToolStripMenuItem });
			menuStrip1.Location = new System.Drawing.Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new System.Drawing.Size(758, 24);
			menuStrip1.TabIndex = 0;
			menuStrip1.Text = "menuStrip1";
			cADASTROToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[5] { tABLIÃOToolStripMenuItem, pROTESTOSToolStripMenuItem, fIRMASToolStripMenuItem, oUTRASFIRMASToolStripMenuItem, sAIRToolStripMenuItem });
			cADASTROToolStripMenuItem.Name = "cADASTROToolStripMenuItem";
			cADASTROToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
			cADASTROToolStripMenuItem.Text = "CADASTRO";
			cADASTROToolStripMenuItem.Click += new System.EventHandler(cADASTROToolStripMenuItem_Click);
			tABLIÃOToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[2] { iNCLUIRToolStripMenuItem, mANUTENÇÃOToolStripMenuItem });
			tABLIÃOToolStripMenuItem.Name = "tABLIÃOToolStripMenuItem";
			tABLIÃOToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
			tABLIÃOToolStripMenuItem.Text = "TABELIÃO";
			tABLIÃOToolStripMenuItem.Click += new System.EventHandler(tABLIÃOToolStripMenuItem_Click);
			iNCLUIRToolStripMenuItem.Name = "iNCLUIRToolStripMenuItem";
			iNCLUIRToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
			iNCLUIRToolStripMenuItem.Text = "INCLUIR";
			iNCLUIRToolStripMenuItem.Click += new System.EventHandler(iNCLUIRToolStripMenuItem_Click);
			mANUTENÇÃOToolStripMenuItem.Name = "mANUTENÇÃOToolStripMenuItem";
			mANUTENÇÃOToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
			mANUTENÇÃOToolStripMenuItem.Text = "MANUTENÇÃO";
			mANUTENÇÃOToolStripMenuItem.Click += new System.EventHandler(mANUTENÇÃOToolStripMenuItem_Click);
			pROTESTOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[2] { iNCLUSÃOToolStripMenuItem, mANUTENÇÃOToolStripMenuItem1 });
			pROTESTOSToolStripMenuItem.Name = "pROTESTOSToolStripMenuItem";
			pROTESTOSToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
			pROTESTOSToolStripMenuItem.Text = "PROTESTOS";
			iNCLUSÃOToolStripMenuItem.Name = "iNCLUSÃOToolStripMenuItem";
			iNCLUSÃOToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
			iNCLUSÃOToolStripMenuItem.Text = "INCLUSÃO";
			iNCLUSÃOToolStripMenuItem.Click += new System.EventHandler(iNCLUSÃOToolStripMenuItem_Click);
			mANUTENÇÃOToolStripMenuItem1.Name = "mANUTENÇÃOToolStripMenuItem1";
			mANUTENÇÃOToolStripMenuItem1.Size = new System.Drawing.Size(157, 22);
			mANUTENÇÃOToolStripMenuItem1.Text = "MANUTENÇÃO";
			mANUTENÇÃOToolStripMenuItem1.Click += new System.EventHandler(mANUTENÇÃOToolStripMenuItem1_Click);
			fIRMASToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[2] { iNCLUSÃOToolStripMenuItem1, mANUTENCAOToolStripMenuItem });
			fIRMASToolStripMenuItem.Name = "fIRMASToolStripMenuItem";
			fIRMASToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
			fIRMASToolStripMenuItem.Text = "FIRMAS";
			iNCLUSÃOToolStripMenuItem1.Name = "iNCLUSÃOToolStripMenuItem1";
			iNCLUSÃOToolStripMenuItem1.Size = new System.Drawing.Size(157, 22);
			iNCLUSÃOToolStripMenuItem1.Text = "INCLUSÃO";
			iNCLUSÃOToolStripMenuItem1.Click += new System.EventHandler(iNCLUSÃOToolStripMenuItem1_Click);
			mANUTENCAOToolStripMenuItem.Name = "mANUTENCAOToolStripMenuItem";
			mANUTENCAOToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
			mANUTENCAOToolStripMenuItem.Text = "MANUTENCAO";
			mANUTENCAOToolStripMenuItem.Click += new System.EventHandler(mANUTENCAOToolStripMenuItem_Click);
			oUTRASFIRMASToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[2] { iNCLUSÃOToolStripMenuItem2, mANUTENÇÃOToolStripMenuItem2 });
			oUTRASFIRMASToolStripMenuItem.Name = "oUTRASFIRMASToolStripMenuItem";
			oUTRASFIRMASToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
			oUTRASFIRMASToolStripMenuItem.Text = "OUTRAS FIRMAS";
			iNCLUSÃOToolStripMenuItem2.Name = "iNCLUSÃOToolStripMenuItem2";
			iNCLUSÃOToolStripMenuItem2.Size = new System.Drawing.Size(157, 22);
			iNCLUSÃOToolStripMenuItem2.Text = "INCLUSÃO";
			iNCLUSÃOToolStripMenuItem2.Click += new System.EventHandler(iNCLUSÃOToolStripMenuItem2_Click);
			mANUTENÇÃOToolStripMenuItem2.Name = "mANUTENÇÃOToolStripMenuItem2";
			mANUTENÇÃOToolStripMenuItem2.Size = new System.Drawing.Size(157, 22);
			mANUTENÇÃOToolStripMenuItem2.Text = "MANUTENÇÃO";
			mANUTENÇÃOToolStripMenuItem2.Click += new System.EventHandler(mANUTENÇÃOToolStripMenuItem2_Click);
			sAIRToolStripMenuItem.Name = "sAIRToolStripMenuItem";
			sAIRToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
			sAIRToolStripMenuItem.Text = "SAIR";
			sAIRToolStripMenuItem.Click += new System.EventHandler(sAIRToolStripMenuItem_Click);
			sCANNERToolStripMenuItem.Name = "sCANNERToolStripMenuItem";
			sCANNERToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
			sCANNERToolStripMenuItem.Text = "SCANNER";
			sCANNERToolStripMenuItem.Click += new System.EventHandler(sCANNERToolStripMenuItem_Click);
			rELATORIOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[3] { etiquetaFirrmaAUTENTICIDADEToolStripMenuItem, etiquetaFirmaSEMELHANÇAToolStripMenuItem, aUTENTICAÇÃODEFIRMAToolStripMenuItem });
			rELATORIOSToolStripMenuItem.Name = "rELATORIOSToolStripMenuItem";
			rELATORIOSToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
			rELATORIOSToolStripMenuItem.Text = "RELATORIOS";
			etiquetaFirrmaAUTENTICIDADEToolStripMenuItem.Name = "etiquetaFirrmaAUTENTICIDADEToolStripMenuItem";
			etiquetaFirrmaAUTENTICIDADEToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
			etiquetaFirrmaAUTENTICIDADEToolStripMenuItem.Text = "Etiqueta Firma/AUTENTICIDADE";
			etiquetaFirrmaAUTENTICIDADEToolStripMenuItem.Click += new System.EventHandler(etiquetaFirrmaAUTENTICIDADEToolStripMenuItem_Click);
			etiquetaFirmaSEMELHANÇAToolStripMenuItem.Name = "etiquetaFirmaSEMELHANÇAToolStripMenuItem";
			etiquetaFirmaSEMELHANÇAToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
			etiquetaFirmaSEMELHANÇAToolStripMenuItem.Text = "Etiqueta Firma/SEMELHANÇA";
			etiquetaFirmaSEMELHANÇAToolStripMenuItem.Click += new System.EventHandler(etiquetaFirmaSEMELHANÇAToolStripMenuItem_Click);
			aUTENTICAÇÃODEFIRMAToolStripMenuItem.Name = "aUTENTICAÇÃODEFIRMAToolStripMenuItem";
			aUTENTICAÇÃODEFIRMAToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
			aUTENTICAÇÃODEFIRMAToolStripMenuItem.Text = "AUTENTICAÇÃO DE FIRMA";
			aUTENTICAÇÃODEFIRMAToolStripMenuItem.Click += new System.EventHandler(aUTENTICAÇÃODEFIRMAToolStripMenuItem_Click);
			aPOIOCONFIGURAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[4] { aJUDAToolStripMenuItem, toolStripSeparator2, sepaToolStripMenuItem, bACKUPToolStripMenuItem });
			aPOIOCONFIGURAToolStripMenuItem.Name = "aPOIOCONFIGURAToolStripMenuItem";
			aPOIOCONFIGURAToolStripMenuItem.Size = new System.Drawing.Size(151, 20);
			aPOIOCONFIGURAToolStripMenuItem.Text = "APOIO/CONFIGURAÇÂO";
			aPOIOCONFIGURAToolStripMenuItem.Click += new System.EventHandler(aPOIOCONFIGURAToolStripMenuItem_Click);
			aJUDAToolStripMenuItem.Name = "aJUDAToolStripMenuItem";
			aJUDAToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			aJUDAToolStripMenuItem.Text = "AJUDA";
			toolStripSeparator2.Name = "toolStripSeparator2";
			toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
			sepaToolStripMenuItem.Name = "sepaToolStripMenuItem";
			sepaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			sepaToolStripMenuItem.Text = "REGISTRO";
			sepaToolStripMenuItem.Click += new System.EventHandler(sepaToolStripMenuItem_Click);
			bACKUPToolStripMenuItem.Name = "bACKUPToolStripMenuItem";
			bACKUPToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			bACKUPToolStripMenuItem.Text = "BACKUP";
			bACKUPToolStripMenuItem.Click += new System.EventHandler(bACKUPToolStripMenuItem_Click);
			sOBREToolStripMenuItem.Name = "sOBREToolStripMenuItem";
			sOBREToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
			sOBREToolStripMenuItem.Text = "SOBRE";
			sOBREToolStripMenuItem.Click += new System.EventHandler(sOBREToolStripMenuItem_Click);
			timer1.Tick += new System.EventHandler(timer1_Tick);
			base.ClientSize = new System.Drawing.Size(784, 602);
			base.Controls.Add(panel1);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.MainMenuStrip = menuStrip1;
			base.MaximizeBox = false;
			base.Name = "FormPrincipal";
			base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			Text = "SGC- Sistema de Gerenciamento de Cartorio";
			base.Load += new System.EventHandler(Form1_Load);
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			toolStrip1.ResumeLayout(false);
			toolStrip1.PerformLayout();
			groupBox2.ResumeLayout(false);
			groupBox2.PerformLayout();
			groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dgfirma).EndInit();
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			ResumeLayout(false);
		}

		private void bACKUPToolStripMenuItem_Click(object sender, EventArgs e)
		{
			conect_querygeneric connf = new conect_querygeneric();
			string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\local.zin";
			string[] lines = File.ReadAllLines(path);
			string local = lines[0];
			string constring = connf.connf();
			constring += "charset=utf8;convertzerodatetime=true;";
			string CaminhoBackup = local + "sinesio_db" + DateTime.Today.ToString("ddMMyyyy") + ".sql";
			using (MySqlConnection conn = new MySqlConnection(constring))
			{
				using (MySqlCommand cmd = new MySqlCommand())
				{
					using (MySqlBackup mb = new MySqlBackup(cmd))
					{
						cmd.Connection = conn;
						conn.Open();
						mb.ExportToFile(CaminhoBackup);
						conn.Close();
						MessageBox.Show("Backup realizado com sucesso", "SGC", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					}
				}
			}
		}

		private void rESTOREToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}
	}
}
