using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SGC
{
	public class FormBusca3 : Form
	{
		private IContainer components = null;

		private Panel panel1;

		private Label label2;

		private Button button1;

		private ComboBox cbpor;

		private TextBox txcampo;

		private Label label1;

		private DataGridView dgbuscaFirma;

		public FormBusca3()
		{
			InitializeComponent();
		}

		public void Plista(string where, string find)
		{
			conect_querygeneric selectuser = new conect_querygeneric();
			selectuser.DAO();
			string query = "SELECT id_firma, nome , autografo , d_renovacao ,roconheciada ,validade , cep , cidade , uf , sexo , civil , profissao , d_nascimento , cpf , cgc , indentidade , controle ,observ FROM firma  WHERE " + where + " LIKE  '%" + find + "%'";
			try
			{
				DataTable dtfIRMA = new DataTable();
				selectuser.SELECTGENERIC(query).Fill(dtfIRMA);
				dgbuscaFirma.DataSource = dtfIRMA;
			}
			catch (MySqlException)
			{
				MessageBox.Show("Erro ao carregar os dados da tabela usuario", "ERRO");
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Plista(cbpor.Text, txcampo.Text);
		}

		private void dgbuscaFirma_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			DataGridViewRow row = dgbuscaFirma.Rows[e.RowIndex];
			string Nfirma = row.Cells["Nome"].Value.ToString();
			dados newd = new dados();
			newd.SetFirma1(Nfirma);
			Close();
			FormPrintSemelhanca aprint = new FormPrintSemelhanca();
			aprint.ShowDialog();
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
			label2 = new System.Windows.Forms.Label();
			button1 = new System.Windows.Forms.Button();
			cbpor = new System.Windows.Forms.ComboBox();
			txcampo = new System.Windows.Forms.TextBox();
			label1 = new System.Windows.Forms.Label();
			dgbuscaFirma = new System.Windows.Forms.DataGridView();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgbuscaFirma).BeginInit();
			SuspendLayout();
			panel1.Controls.Add(label2);
			panel1.Controls.Add(button1);
			panel1.Controls.Add(cbpor);
			panel1.Controls.Add(txcampo);
			panel1.Controls.Add(label1);
			panel1.Controls.Add(dgbuscaFirma);
			panel1.Location = new System.Drawing.Point(12, 12);
			panel1.Name = "panel1";
			panel1.Size = new System.Drawing.Size(481, 245);
			panel1.TabIndex = 2;
			label2.AutoSize = true;
			label2.Location = new System.Drawing.Point(268, 17);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(26, 13);
			label2.TabIndex = 5;
			label2.Text = "Por:";
			button1.Location = new System.Drawing.Point(395, 12);
			button1.Name = "button1";
			button1.Size = new System.Drawing.Size(75, 23);
			button1.TabIndex = 4;
			button1.Text = "Buscar";
			button1.UseVisualStyleBackColor = true;
			button1.Click += new System.EventHandler(button1_Click);
			cbpor.FormattingEnabled = true;
			cbpor.Items.AddRange(new object[4] { "Nome", "CGC", "CPF", "RG" });
			cbpor.Location = new System.Drawing.Point(294, 14);
			cbpor.Name = "cbpor";
			cbpor.Size = new System.Drawing.Size(95, 21);
			cbpor.TabIndex = 3;
			txcampo.Location = new System.Drawing.Point(44, 14);
			txcampo.Name = "txcampo";
			txcampo.Size = new System.Drawing.Size(218, 20);
			txcampo.TabIndex = 2;
			label1.AutoSize = true;
			label1.Location = new System.Drawing.Point(3, 17);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(40, 13);
			label1.TabIndex = 1;
			label1.Text = "Busca:";
			dgbuscaFirma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgbuscaFirma.Location = new System.Drawing.Point(3, 55);
			dgbuscaFirma.Name = "dgbuscaFirma";
			dgbuscaFirma.Size = new System.Drawing.Size(475, 187);
			dgbuscaFirma.TabIndex = 0;
			dgbuscaFirma.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(dgbuscaFirma_CellContentClick);
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.MaximizeBox = false;
			AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
			base.ClientSize = new System.Drawing.Size(505, 269);
			base.Controls.Add(panel1);
			base.MinimizeBox = false;
			base.Name = "FormBusca3";
			base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			Text = "Busca Firma";
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dgbuscaFirma).EndInit();
			ResumeLayout(false);
		}
	}
}
