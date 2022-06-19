using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SGC
{
	public class FormFmanu : Form
	{
		private conect_querygeneric openconector = new conect_querygeneric();

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

		private TextBox tbBusca;

		private DataGridView dgFirma;

		private Panel panel1;

		private GroupBox groupBox1;

		private ComboBox cbWhere;

		private Button button1;

		private Button bnteditar;

		private Button bntexcluir;

		private Button button2;

		public FormFmanu()
		{
			InitializeComponent();
			Plista();
		}

		public void Blista(string where, string find)
		{
			conect_querygeneric selectuser = new conect_querygeneric();
			selectuser.DAO();
			string query = "SELECT id_firma as 'Codigo', nome as 'Nome', autografo as 'Autografo',DATE_FORMAT( d_renovacao , '%d/%m/%Y' ) as 'Data de Renovacao', DATE_FORMAT( roconheciada , '%d/%m/%Y' ) as 'Data de Reconhecimento', DATE_FORMAT( validade , '%d/%m/%Y' )   as 'Periodo de Validade', encereco as 'Endereco', bairro as 'Bairro', cep as 'CEP', cidade as 'Cidade', uf as 'UF', sexo as 'Sexo', civil as 'Estado Civil', profissao as 'Profissao', d_nascimento as 'Data de Nascimento', cpf as 'CPF', cgc as 'C.G.C', indentidade as 'RG', tabeliao as 'Tabeliao', controle as 'Controle', observ as 'Observacao'  FROM firma  WHERE " + where + " LIKE  '%" + find + "%'";
			try
			{
				DataTable dtfIRMA = new DataTable();
				selectuser.SELECTGENERIC(query).Fill(dtfIRMA);
				dgFirma.DataSource = dtfIRMA;
			}
			catch (MySqlException)
			{
				MessageBox.Show("Erro ao carregar os dados da tabela usuario", "ERRO");
			}
		}

		public void Plista()
		{
			conect_querygeneric selectuser = new conect_querygeneric();
			selectuser.DAO();
			string query = "SELECT id_firma as 'Codigo', nome as 'Nome', autografo as 'Autografo', DATE_FORMAT( d_renovacao , '%d/%m/%Y' ) as 'Data de Renovacao', DATE_FORMAT( roconheciada , '%d/%m/%Y' ) as 'Data de Reconhecimento', DATE_FORMAT( validade , '%d/%m/%Y' )   as 'Periodo de Validade', encereco as 'Endereco', bairro as 'Bairro', cep as 'CEP', cidade as 'Cidade', uf as 'UF', sexo as 'Sexo', civil as 'Estado Civil', profissao as 'Profissao', d_nascimento as 'Data de Nascimento', cpf as 'CPF', cgc as 'C.G.C', indentidade as 'RG', tabeliao as 'Tabeliao', controle as 'Controle', observ as 'Observacao' FROM firma ";
			try
			{
				DataTable dtfIRMA = new DataTable();
				selectuser.SELECTGENERIC(query).Fill(dtfIRMA);
				dgFirma.DataSource = dtfIRMA;
			}
			catch (MySqlException)
			{
				MessageBox.Show("Erro ao carregar os dados da tabela usuario", "ERRO");
			}
		}

		private void dgUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				DataGridViewRow row = dgFirma.Rows[e.RowIndex];
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

		private void FormFmanu_Load(object sender, EventArgs e)
		{
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Blista(cbWhere.Text, tbBusca.Text);
		}

		private void bnteditar_Click(object sender, EventArgs e)
		{
		}

		private void bnteditar_Click_1(object sender, EventArgs e)
		{
			editFirma editafirma = new editFirma();
			editafirma.setFirma(Codigo, Nome, Autografo, DatadeRenovacao, DatadeReconhecimento, PeriododeValidade, CEP, Cidade, UF, Sexo, EstadoCivil, Profissao, DatadeNascimento, CPF, CGC, RG, Controle, Observacao, endereco, bairro, tabeliao);
			FormFEdit fef = new FormFEdit();
			fef.ShowDialog();
		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			Blista(cbWhere.Text, tbBusca.Text);
		}

		private void bntexcluir_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Deseja realmente excluir esse registro", "Tem Certeza", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.Yes)
			{
				openconector.DELETEGENERIC("DELETE FROM firma WHERE id_firma = '" + Codigo + "'");
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			dados d = new dados();
			d.SetAssinatura(Autografo);
			FormVizualizaAss va = new FormVizualizaAss();
			va.ShowDialog();
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
			tbBusca = new System.Windows.Forms.TextBox();
			dgFirma = new System.Windows.Forms.DataGridView();
			panel1 = new System.Windows.Forms.Panel();
			groupBox1 = new System.Windows.Forms.GroupBox();
			cbWhere = new System.Windows.Forms.ComboBox();
			button1 = new System.Windows.Forms.Button();
			bnteditar = new System.Windows.Forms.Button();
			bntexcluir = new System.Windows.Forms.Button();
			button2 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)dgFirma).BeginInit();
			panel1.SuspendLayout();
			groupBox1.SuspendLayout();
			SuspendLayout();
			tbBusca.Location = new System.Drawing.Point(6, 16);
			tbBusca.Name = "tbBusca";
			tbBusca.Size = new System.Drawing.Size(414, 20);
			tbBusca.TabIndex = 0;
			dgFirma.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
			dgFirma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgFirma.Location = new System.Drawing.Point(9, 47);
			dgFirma.Name = "dgFirma";
			dgFirma.Size = new System.Drawing.Size(600, 263);
			dgFirma.TabIndex = 0;
			dgFirma.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(dgUser_CellContentClick);
			panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			panel1.Controls.Add(button2);
			panel1.Controls.Add(groupBox1);
			panel1.Controls.Add(bnteditar);
			panel1.Controls.Add(bntexcluir);
			panel1.Controls.Add(dgFirma);
			panel1.Location = new System.Drawing.Point(3, 8);
			panel1.Name = "panel1";
			panel1.Size = new System.Drawing.Size(618, 387);
			panel1.TabIndex = 2;
			panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
			groupBox1.Controls.Add(cbWhere);
			groupBox1.Controls.Add(button1);
			groupBox1.Controls.Add(tbBusca);
			groupBox1.Location = new System.Drawing.Point(9, -1);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new System.Drawing.Size(600, 42);
			groupBox1.TabIndex = 3;
			groupBox1.TabStop = false;
			groupBox1.Text = "Busca";
			cbWhere.FormattingEnabled = true;
			cbWhere.Items.AddRange(new object[4] { "Nome", "CPF", "RG", "CGC" });
			cbWhere.Location = new System.Drawing.Point(426, 16);
			cbWhere.Name = "cbWhere";
			cbWhere.Size = new System.Drawing.Size(84, 21);
			cbWhere.TabIndex = 4;
			button1.Location = new System.Drawing.Point(516, 14);
			button1.Name = "button1";
			button1.Size = new System.Drawing.Size(75, 23);
			button1.TabIndex = 1;
			button1.Text = "Pesquisar";
			button1.UseVisualStyleBackColor = true;
			button1.Click += new System.EventHandler(button1_Click_1);
			bnteditar.Location = new System.Drawing.Point(435, 328);
			bnteditar.Name = "bnteditar";
			bnteditar.Size = new System.Drawing.Size(84, 34);
			bnteditar.TabIndex = 2;
			bnteditar.Text = "Editar";
			bnteditar.UseVisualStyleBackColor = true;
			bnteditar.Click += new System.EventHandler(bnteditar_Click_1);
			bntexcluir.Location = new System.Drawing.Point(525, 328);
			bntexcluir.Name = "bntexcluir";
			bntexcluir.Size = new System.Drawing.Size(84, 34);
			bntexcluir.TabIndex = 1;
			bntexcluir.Text = "Excluir";
			bntexcluir.UseVisualStyleBackColor = true;
			bntexcluir.Click += new System.EventHandler(bntexcluir_Click);
			button2.Location = new System.Drawing.Point(345, 328);
			button2.Name = "button2";
			button2.Size = new System.Drawing.Size(84, 34);
			button2.TabIndex = 4;
			button2.Text = "Ver Assinatura";
			button2.UseVisualStyleBackColor = true;
			button2.Click += new System.EventHandler(button2_Click);
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.MaximizeBox = false;
			base.ClientSize = new System.Drawing.Size(624, 402);
			base.Controls.Add(panel1);
			base.MinimizeBox = false;
			base.Name = "FormFmanu";
			base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			Text = "Manutenção de Firmas";
			base.Load += new System.EventHandler(FormFmanu_Load);
			((System.ComponentModel.ISupportInitialize)dgFirma).EndInit();
			panel1.ResumeLayout(false);
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			ResumeLayout(false);
		}
	}
}
