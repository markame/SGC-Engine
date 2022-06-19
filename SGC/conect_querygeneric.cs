using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SGC
{
	internal class conect_querygeneric
	{
		public static string conf = "server=localhost;Port=3302;userid=root;database=sinesio_db;";

		private MySqlConnection conexao = new MySqlConnection(conf);

		~conect_querygeneric()
		{
		}

		public string connf()
		{
			return conf;
		}

		public void DAO()
		{
			try
			{
				conexao.Open();
			}
			catch
			{
				MessageBox.Show("Erro o conectar com banco de dados tente reiniciar a maquina.\nSe não é a primeira vez que você vê essa mensagem entre em contado com o desenvolvedor.", "ERRO");
			}
		}

		public void INSEREGENERIC(string query)
		{
			MySqlCommand INSERE = new MySqlCommand(query, conexao);
			INSERE.ExecuteNonQuery();
			try
			{
				MessageBox.Show("Registro inserido com sucesso!", "Sucesso");
			}
			catch
			{
				MessageBox.Show("Algo não correu como o esperado durante a conexão com o banco.", "OPSS");
			}
		}

		public bool SELECTDUPLICATE(string query)
		{
			MySqlCommand SELECT = new MySqlCommand(query, conexao);
			SELECT.ExecuteNonQuery();
			conexao.Close();
			return true;
		}

		public MySqlDataAdapter SELECTGENERIC(string query)
		{
			MySqlCommand SELECTQUERY = new MySqlCommand(query, conexao);
			SELECTQUERY.ExecuteNonQuery();
			MySqlDataAdapter dau = new MySqlDataAdapter(SELECTQUERY);
			try
			{
				conexao.Close();
			}
			catch
			{
				MessageBox.Show("Erro ao buscar os dados no banco !\nSe essa maquina contem o servidor de dados tente reiniciar ela caso o contrario reinicei o servidorSe o erro persistir entre em contato com o desenvolvedoe", "Erro");
				conexao.Close();
			}
			return dau;
		}

		public void UPDATEGENERIC(string query)
		{
			MySqlCommand UPDATE = new MySqlCommand(query, conexao);
			UPDATE.ExecuteNonQuery();
			try
			{
				MessageBox.Show("Registro Atualizado com sucesso !", "Atualização completa.");
				conexao.Close();
			}
			catch
			{
				MessageBox.Show("Algo aconteceu e um erro foi encontrado\nTente Atualizar o registro novamente se o erro persiste entre em contato com o administrador", "Algo não aconteceu como esperado !");
				conexao.Close();
			}
		}

		public bool DELETEGENERIC(string query)
		{
			conexao.Open();
			MySqlCommand DELETE = new MySqlCommand(query, conexao);
			DELETE.ExecuteNonQuery();
			try
			{
				MessageBox.Show("Registro deletado com sucesso !", "Exclusão completa.");
				conexao.Close();
				return true;
			}
			catch
			{
				MessageBox.Show("Algo aconteceu e um erro foi encontrado\nTente deletar o registro novamente se o erro persiste entre em contato com o administrador", "Algo não aconteceu como esperado !");
				conexao.Close();
				return false;
			}
		}

		public bool QUERYAUTH(string query)
		{
			conexao.Open();
			MySqlCommand SELECTAUTH = new MySqlCommand(query, conexao);
			return SELECTAUTH.ExecuteReader().HasRows;
		}

		public int NumberRows(string query)
		{
			conexao.Open();
			MySqlCommand cmd = new MySqlCommand(query, conexao);
			return Convert.ToInt32(cmd.ExecuteScalar()) + 1;
		}
	}
}
