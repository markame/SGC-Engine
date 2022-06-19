using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SGC
{
	public class OutraFManu : Form
	{
		private conect_querygeneric openconector = new conect_querygeneric();

		public string id;

		public string nome;

		public string aut;

		public string reno;

		public string reco;

		public string limi;

		public string venci;

		public string cart;

		public string cida;

		public string uf;

		public string seque;

		private IContainer components = null;

		private DataGridView dgOfirma;

		private Panel panel1;

		private GroupBox groupBox1;

		private ComboBox cbWhere;

		private Button button1;

		private TextBox tbBusca;

		private Button bnteditar;

		private Button bntexcluir;

		public OutraFManu()
		{
			InitializeComponent();
			Plista();
		}

		public void Plista()
		{
			conect_querygeneric selectuser = new conect_querygeneric();
			selectuser.DAO();
			string query = "SELECT id_outra_firma as 'Codigo', nome as 'Nome', autografo as 'Autografo', dataReno as 'Data de Renovacao', reconhecida as 'Data de Reconhecimento', limite as 'Data Limite', vencimento as 'Vencimento', cartorio as 'Cartorio', cidade as 'Cidade', UF as 'UF', sequencia as 'Sequencia' FROM outra_firma ";
			try
			{
				DataTable dtfIRMA = new DataTable();
				selectuser.SELECTGENERIC(query).Fill(dtfIRMA);
				dgOfirma.DataSource = dtfIRMA;
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
			string query = "SELECT id_outra_firma as 'Codigo', nome as 'Nome', autografo as 'Autografo', dataReno as 'Data de Renovacao', reconhecida as 'Data de Reconhecimento', limite as 'Data Limite', vencimento as 'Vencimento', cartorio as 'Cartorio', cidade as 'Cidade', UF as 'UF', sequencia as 'Sequencia' FROM outra_firma  WHERE " + where + " = '" + find + "'";
			try
			{
				DataTable dtfIRMA = new DataTable();
				selectuser.SELECTGENERIC(query).Fill(dtfIRMA);
				dgOfirma.DataSource = dtfIRMA;
			}
			catch (MySqlException)
			{
				MessageBox.Show("Erro ao carregar os dados da tabela usuario", "ERRO");
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Blista(cbWhere.Text, tbBusca.Text);
		}

		private void dgOfirma_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				DataGridViewRow row = dgOfirma.Rows[e.RowIndex];
				id = row.Cells["Codigo"].Value.ToString();
				nome = row.Cells["Nome"].Value.ToString();
				aut = row.Cells["Autografo"].Value.ToString();
				reno = row.Cells["Data de Renovacao"].Value.ToString();
				reco = row.Cells["Data de Reconhecimento"].Value.ToString();
				limi = row.Cells["Data Limite"].Value.ToString();
				venci = row.Cells["Vencimento"].Value.ToString();
				cart = row.Cells["Cartorio"].Value.ToString();
				cida = row.Cells["Cidade"].Value.ToString();
				uf = row.Cells["UF"].Value.ToString();
				seque = row.Cells["Sequencia"].Value.ToString();
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
			dgOfirma = new System.Windows.Forms.DataGridView();
			panel1 = new System.Windows.Forms.Panel();
			groupBox1 = new System.Windows.Forms.GroupBox();
			cbWhere = new System.Windows.Forms.ComboBox();
			button1 = new System.Windows.Forms.Button();
			tbBusca = new System.Windows.Forms.TextBox();
			bnteditar = new System.Windows.Forms.Button();
			bntexcluir = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)dgOfirma).BeginInit();
			panel1.SuspendLayout();
			groupBox1.SuspendLayout();
			SuspendLayout();
			dgOfirma.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
			dgOfirma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgOfirma.Location = new System.Drawing.Point(9, 47);
			dgOfirma.Name = "dgOfirma";
			dgOfirma.Size = new System.Drawing.Size(600, 263);
			dgOfirma.TabIndex = 0;
			dgOfirma.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(dgOfirma_CellContentClick);
			panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			panel1.Controls.Add(groupBox1);
			panel1.Controls.Add(bnteditar);
			panel1.Controls.Add(bntexcluir);
			panel1.Controls.Add(dgOfirma);
			panel1.Location = new System.Drawing.Point(3, 6);
			panel1.Name = "panel1";
			panel1.Size = new System.Drawing.Size(618, 387);
			panel1.TabIndex = 2;
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
			button1.Click += new System.EventHandler(button1_Click);
			tbBusca.Location = new System.Drawing.Point(6, 16);
			tbBusca.Name = "tbBusca";
			tbBusca.Size = new System.Drawing.Size(414, 20);
			tbBusca.TabIndex = 0;
			bnteditar.Location = new System.Drawing.Point(435, 328);
			bnteditar.Name = "bnteditar";
			bnteditar.Size = new System.Drawing.Size(84, 34);
			bnteditar.TabIndex = 2;
			bnteditar.Text = "Editar";
			bnteditar.UseVisualStyleBackColor = true;
			bntexcluir.Location = new System.Drawing.Point(525, 328);
			bntexcluir.Name = "bntexcluir";
			bntexcluir.Size = new System.Drawing.Size(84, 34);
			bntexcluir.TabIndex = 1;
			bntexcluir.Text = "Excluir";
			bntexcluir.UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.MaximizeBox = false;
			base.ClientSize = new System.Drawing.Size(624, 398);
			base.Controls.Add(panel1);
			base.MinimizeBox = false;
			base.Name = "OutraFManu";
			base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			Text = "Manutenção de Outras Firmas";
			((System.ComponentModel.ISupportInitialize)dgOfirma).EndInit();
			panel1.ResumeLayout(false);
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			ResumeLayout(false);
		}
	}
}
