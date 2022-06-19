using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SGC
{
	public class FormPedit : Form
	{
		private string codigo;

		private string livro;

		private string folha;

		private string registro;

		private string cgc;

		private string cpf;

		private string rg;

		private string valor;

		private string sacado;

		private string baixa;

		private string movimento;

		private string nome;

		private string obeser;

		private IContainer components = null;

		private TextBox tbBusca;

		private DataGridView dgFirma;

		private Panel panel1;

		private GroupBox groupBox1;

		private ComboBox cbWhere;

		private Button button1;

		private Button bnteditar;

		private Button bntexcluir;

		public FormPedit()
		{
			InitializeComponent();
			Plista();
		}

		private void tbBusca_TextChanged(object sender, EventArgs e)
		{
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (cbWhere.Text.Equals("Sacado"))
			{
				Blista("nome_sacado", tbBusca.Text);
			}
			else
			{
				Blista(cbWhere.Text, tbBusca.Text);
			}
		}

		public void Plista()
		{
			conect_querygeneric selectuser = new conect_querygeneric();
			selectuser.DAO();
			string query = "SELECT id_protesto as 'Codigo', livro as 'Livro', folha as 'Folha',data_regist as 'Data do Registro', cgc as 'C.G.C', cpf as 'CPF', indentidade as 'RG', valor_sacado as 'Valor Sacado',nome_apresentante as 'Nome do Apresentante', data_baixa as 'Data da Baixa', data_movimento as 'Data de Movimento', nome_sacado as 'Nome do Sacado', obs as 'Observacao' FROM protesto ORDER BY id_protesto ASC";
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

		public void Blista(string where, string find)
		{
			conect_querygeneric selectuser = new conect_querygeneric();
			selectuser.DAO();
			string query = ((!where.Equals("nome_sacado")) ? ("SELECT id_protesto as 'Codigo', livro as 'Livro', folha as 'Folha',data_regist as 'Data do Registro', cgc as 'C.G.C', cpf as 'CPF', indentidade as 'RG', valor_sacado as 'Valor Sacado',nome_apresentante as 'Nome do Apresentante', data_baixa as 'Data da Baixa', data_movimento as 'Data de Movimento', nome_sacado as 'Nome do Sacado', obs as 'Observacao' FROM protesto Where " + where + " LIKE  '%" + find + "%'") : ("SELECT nome_sacado as 'Nome do Sacado', livro as 'Livro', folha as 'Folha',data_regist as 'Data do Registro',id_protesto as 'Codigo', cgc as 'C.G.C', cpf as 'CPF', indentidade as 'RG', valor_sacado as 'Valor Sacado',nome_apresentante as 'Nome do Apresentante', data_baixa as 'Data da Baixa', data_movimento as 'Data de Movimento', nome_sacado as 'Nome do Sacado', obs as 'Observacao' FROM protesto Where " + where + " LIKE  '%" + find + "%'"));
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

		private void bntexcluir_Click(object sender, EventArgs e)
		{
			conect_querygeneric openconector = new conect_querygeneric();
			DialogResult result = MessageBox.Show("Deseja realmente excluir esse registro", "Tem Certeza", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.Yes)
			{
				openconector.DELETEGENERIC("DELETE FROM protesto WHERE id_protesto = '" + codigo + "'");
				Plista();
			}
		}

		private void dgFirma_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				DataGridViewRow row = dgFirma.Rows[e.RowIndex];
				codigo = row.Cells["Codigo"].Value.ToString();
				livro = row.Cells["Livro"].Value.ToString();
				folha = row.Cells["Folha"].Value.ToString();
				registro = row.Cells["Data do Registro"].Value.ToString();
				cgc = row.Cells["C.G.C"].Value.ToString();
				cpf = row.Cells["CPF"].Value.ToString();
				rg = row.Cells["RG"].Value.ToString();
				valor = row.Cells["Valor Sacado"].Value.ToString();
				sacado = row.Cells["Nome do Sacado"].Value.ToString();
				baixa = row.Cells["Data da Baixa"].Value.ToString();
				movimento = row.Cells["Data de Movimento"].Value.ToString();
				nome = row.Cells["Nome do Apresentante"].Value.ToString();
				obeser = row.Cells["Observacao"].Value.ToString();
			}
		}

		private void bnteditar_Click(object sender, EventArgs e)
		{
			if (codigo != null)
			{
				ClassEditProtesto edita = new ClassEditProtesto();
				edita.setDados(codigo, livro, registro, folha, cgc, cpf, rg, valor, sacado, baixa, movimento, nome, obeser);
				FormEditaProtesto EditaProtesto = new FormEditaProtesto();
				EditaProtesto.ShowDialog();
			}
			else
			{
				MessageBox.Show("Nada foi selecionado para executar o comando de Editar tente clicar duas vezes antes no item que voce deseja editar", "Erro de Operação");
			}
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
			((System.ComponentModel.ISupportInitialize)dgFirma).BeginInit();
			panel1.SuspendLayout();
			groupBox1.SuspendLayout();
			SuspendLayout();
			tbBusca.Location = new System.Drawing.Point(6, 16);
			tbBusca.Name = "tbBusca";
			tbBusca.Size = new System.Drawing.Size(414, 20);
			tbBusca.TabIndex = 0;
			tbBusca.TextChanged += new System.EventHandler(tbBusca_TextChanged);
			dgFirma.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
			dgFirma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgFirma.Location = new System.Drawing.Point(9, 47);
			dgFirma.MultiSelect = false;
			dgFirma.Name = "dgFirma";
			dgFirma.Size = new System.Drawing.Size(600, 263);
			dgFirma.TabIndex = 0;
			dgFirma.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(dgFirma_CellContentClick);
			panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			panel1.Controls.Add(groupBox1);
			panel1.Controls.Add(bnteditar);
			panel1.Controls.Add(bntexcluir);
			panel1.Controls.Add(dgFirma);
			panel1.Location = new System.Drawing.Point(3, 6);
			panel1.Name = "panel1";
			panel1.Size = new System.Drawing.Size(618, 387);
			panel1.TabIndex = 3;
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
			cbWhere.Items.AddRange(new object[5] { "Nome", "CPF", "Livro", "Folha", "Sacado" });
			cbWhere.Location = new System.Drawing.Point(426, 16);
			cbWhere.Name = "cbWhere";
			cbWhere.Size = new System.Drawing.Size(84, 21);
			cbWhere.TabIndex = 4;
			cbWhere.SelectedIndexChanged += new System.EventHandler(cbWhere_SelectedIndexChanged);
			button1.Location = new System.Drawing.Point(516, 14);
			button1.Name = "button1";
			button1.Size = new System.Drawing.Size(75, 23);
			button1.TabIndex = 1;
			button1.Text = "Pesquisar";
			button1.UseVisualStyleBackColor = true;
			button1.Click += new System.EventHandler(button1_Click);
			bnteditar.Location = new System.Drawing.Point(435, 328);
			bnteditar.Name = "bnteditar";
			bnteditar.Size = new System.Drawing.Size(84, 34);
			bnteditar.TabIndex = 2;
			bnteditar.Text = "Editar";
			bnteditar.UseVisualStyleBackColor = true;
			bnteditar.Click += new System.EventHandler(bnteditar_Click);
			bntexcluir.Location = new System.Drawing.Point(525, 328);
			bntexcluir.Name = "bntexcluir";
			bntexcluir.Size = new System.Drawing.Size(84, 34);
			bntexcluir.TabIndex = 1;
			bntexcluir.Text = "Excluir";
			bntexcluir.UseVisualStyleBackColor = true;
			bntexcluir.Click += new System.EventHandler(bntexcluir_Click);
			base.ClientSize = new System.Drawing.Size(624, 398);
			base.Controls.Add(panel1);
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "FormPedit";
			base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			Text = "Edita Protesto";
			((System.ComponentModel.ISupportInitialize)dgFirma).EndInit();
			panel1.ResumeLayout(false);
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			ResumeLayout(false);
		}

		private void cbWhere_SelectedIndexChanged(object sender, EventArgs e)
		{
		}
	}
}
