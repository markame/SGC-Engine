namespace SGC
{
	internal class edittab
	{
		public static string codigo;

		public static string funcao;

		public static string data;

		public static string nome;

		public static string email;

		public static string usuario;

		public static string senha;

		public static string observ;

		public void Setcodigo(string c, string f, string n, string u, string o)
		{
			codigo = c;
			funcao = f;
			nome = n;
			usuario = u;
			observ = o;
		}

		public string GetCodigo()
		{
			return codigo;
		}

		public string Getfuncao()
		{
			return funcao;
		}

		public string GetNome()
		{
			return nome;
		}

		public string GetUser()
		{
			return usuario;
		}

		public string Getobser()
		{
			return observ;
		}
	}
}
