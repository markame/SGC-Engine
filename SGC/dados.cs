using MySql.Data.MySqlClient;

namespace SGC
{
	internal class dados
	{
		public static string nomeUser;

		public static string funcaoUser;

		public static string tabeliao;

		public static string firma1;

		public static string firma2;

		public static string local;

		private conect_querygeneric c = new conect_querygeneric();

		public void getdata(string query)
		{
			string conf = "server=localhost;userid=root;database=sinesio_db;Allow Zero Datetime=true;Allow Zero Datetime=true;";
			MySqlConnection conexao = new MySqlConnection(conf);
			conexao.Open();
			MySqlCommand GETDATA = new MySqlCommand(query, conexao);
			MySqlDataReader reader = GETDATA.ExecuteReader();
			while (reader.Read())
			{
				SetnomeU(reader.GetString("nome"));
				SetfuncaoU(reader.GetString("funcao"));
			}
			reader.Close();
		}

		public void Tabeliao(string query)
		{
			string conf = "server=localhost;userid=root;database=sinesio_db;";
			MySqlConnection conexao = new MySqlConnection(conf);
			conexao.Open();
			MySqlCommand GETDATA = new MySqlCommand(query, conexao);
			MySqlDataReader reader = GETDATA.ExecuteReader();
			while (reader.Read())
			{
				Settabeliao(reader.GetString("nome"));
			}
			reader.Close();
		}

		public string SetnomeU(string nome)
		{
			nomeUser = nome;
			return nomeUser;
		}

		public string SetfuncaoU(string funcao)
		{
			funcaoUser = funcao;
			return funcaoUser;
		}

		public string GetnomeU()
		{
			return nomeUser;
		}

		public string Getfuncao()
		{
			return funcaoUser;
		}

		public string Settabeliao(string funcao)
		{
			tabeliao = funcao;
			return tabeliao;
		}

		public string Gettabeliao()
		{
			return tabeliao;
		}

		public string SetFirma1(string nfirma)
		{
			firma1 = nfirma;
			return firma1;
		}

		public string Getfirma1()
		{
			return firma1;
		}

		public string SetFirma2(string nfirma2)
		{
			firma2 = nfirma2;
			return firma2;
		}

		public string Getfirma2()
		{
			return firma2;
		}

		public string SetAssinatura(string nlocal)
		{
			local = nlocal;
			return local;
		}

		public string GetAssinatura()
		{
			return local;
		}
	}
}
