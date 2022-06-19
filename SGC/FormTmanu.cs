using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SGC
{
	public class FormTmanu : Form
	{
		public string id_User;

		public string n_User;

		public string f_User;

		public string u_User;

		public string o_User;

		private IContainer components = null;

		private DataGridView dgUser;

		private Panel panel1;

		private Button bnteditar;

		private Button bntexcluir;

		private GroupBox groupBox1;

		private Button button1;

		private TextBox tbManu;

		private ComboBox comboBox1;

		public FormTmanu()
		{
			InitializeComponent();
			Plista();
		}

		public void Plista()
		{
			conect_querygeneric selectuser = new conect_querygeneric();
			selectuser.DAO();
			string query = "SELECT id_Usuario as 'Codigo',nome as'Nome',funcao as'Funcao',usuario as 'Usuario',observacao as 'Observacao' FROM usuario";
			try
			{
				DataTable dtUser = new DataTable();
				selectuser.SELECTGENERIC(query).Fill(dtUser);
				dgUser.DataSource = dtUser;
			}
			catch (MySqlException)
			{
				MessageBox.Show("Erro ao carregar os dados da tabela usuario", "ERRO");
			}
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		}

		private void dgUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				DataGridViewRow row = dgUser.Rows[e.RowIndex];
				id_User = row.Cells["Codigo"].Value.ToString();
				n_User = row.Cells["Nome"].Value.ToString();
				f_User = row.Cells["Funcao"].Value.ToString();
				u_User = row.Cells["Usuario"].Value.ToString();
				o_User = row.Cells["Observacao"].Value.ToString();
			}
		}

		private void bnteditar_Click(object sender, EventArgs e)
		{
			edittab edit = new edittab();
			edit.Setcodigo(id_User, f_User, n_User, u_User, o_User);
			FormTedit editT = new FormTedit();
			editT.ShowDialog();
		}

		private void bntexcluir_Click(object sender, EventArgs e)
		{
			conect_querygeneric c = new conect_querygeneric();
			string queryDelete = "DELETE FROM usuario WHERE id_Usuario='" + id_User + "'";
			if (c.DELETEGENERIC(queryDelete))
			{
				Close();
				FormTmanu tmanu = new FormTmanu();
				tmanu.ShowDialog();
			}
		}

		private void tbManu_TextChanged(object sender, EventArgs e)
		{
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{
		}

		private void button1_Click(object sender, EventArgs e)
		{
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		private void FormTmanu_Load(object sender, EventArgs e)
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
			dgUser = new System.Windows.Forms.DataGridView();
			panel1 = new System.Windows.Forms.Panel();
			groupBox1 = new System.Windows.Forms.GroupBox();
			comboBox1 = new System.Windows.Forms.ComboBox();
			button1 = new System.Windows.Forms.Button();
			tbManu = new System.Windows.Forms.TextBox();
			bnteditar = new System.Windows.Forms.Button();
			bntexcluir = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)dgUser).BeginInit();
			panel1.SuspendLayout();
			groupBox1.SuspendLayout();
			SuspendLayout();
			dgUser.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
			dgUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgUser.Location = new System.Drawing.Point(9, 47);
			dgUser.Name = "dgUser";
			dgUser.Size = new System.Drawing.Size(600, 263);
			dgUser.TabIndex = 0;
			dgUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(dgUser_CellContentClick);
			panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			panel1.Controls.Add(groupBox1);
			panel1.Controls.Add(bnteditar);
			panel1.Controls.Add(bntexcluir);
			panel1.Controls.Add(dgUser);
			panel1.Location = new System.Drawing.Point(2, 3);
			panel1.Name = "panel1";
			panel1.Size = new System.Drawing.Size(618, 387);
			panel1.TabIndex = 1;
			panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
			groupBox1.Controls.Add(comboBox1);
			groupBox1.Controls.Add(button1);
			groupBox1.Controls.Add(tbManu);
			groupBox1.Location = new System.Drawing.Point(9, -1);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new System.Drawing.Size(600, 42);
			groupBox1.TabIndex = 3;
			groupBox1.TabStop = false;
			groupBox1.Text = "Busca";
			groupBox1.Enter += new System.EventHandler(groupBox1_Enter);
			comboBox1.FormattingEnabled = true;
			comboBox1.Location = new System.Drawing.Point(426, 16);
			comboBox1.Name = "comboBox1";
			comboBox1.Size = new System.Drawing.Size(84, 21);
			comboBox1.TabIndex = 4;
			comboBox1.SelectedIndexChanged += new System.EventHandler(comboBox1_SelectedIndexChanged);
			button1.Location = new System.Drawing.Point(516, 14);
			button1.Name = "button1";
			button1.Size = new System.Drawing.Size(75, 23);
			button1.TabIndex = 1;
			button1.Text = "Pesquisar";
			button1.UseVisualStyleBackColor = true;
			button1.Click += new System.EventHandler(button1_Click);
			tbManu.Location = new System.Drawing.Point(6, 16);
			tbManu.Name = "tbManu";
			tbManu.Size = new System.Drawing.Size(414, 20);
			tbManu.TabIndex = 0;
			tbManu.TextChanged += new System.EventHandler(tbManu_TextChanged);
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
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.MaximizeBox = false;
			base.ClientSize = new System.Drawing.Size(624, 402);
			base.Controls.Add(panel1);
			base.MinimizeBox = false;
			base.Name = "FormTmanu";
			base.ShowInTaskbar = false;
			base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			Text = "Tabelião>Manutenção";
			base.Load += new System.EventHandler(FormTmanu_Load);
			((System.ComponentModel.ISupportInitialize)dgUser).EndInit();
			panel1.ResumeLayout(false);
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			ResumeLayout(false);
		}
	}
}
