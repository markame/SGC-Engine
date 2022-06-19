namespace SGC
{
	internal class ClassEditProtesto
	{
		private static string codigo;

		private static string livro;

		private static string folha;

		private static string datreg;

		private static string cgc;

		private static string cpf;

		private static string rg;

		private static string valor;

		private static string nomesaca;

		private static string baixa;

		private static string movimento;

		private static string nome;

		private static string obeser;

		public void setDados(string scodigo, string slivro, string sdatreg, string sfolha, string scgc, string scpf, string srg, string svalor, string snomesaca, string sbaixa, string smovimento, string snome, string sobeser)
		{
			codigo = scodigo;
			livro = slivro;
			datreg = sdatreg;
			folha = sfolha;
			cgc = scgc;
			cpf = scpf;
			rg = srg;
			valor = svalor;
			nomesaca = snomesaca;
			baixa = sbaixa;
			movimento = smovimento;
			nome = snome;
			obeser = sobeser;
		}

		public string getCodigo()
		{
			return codigo;
		}

		public string getLivro()
		{
			return livro;
		}

		public string getFolha()
		{
			return folha;
		}

		public string getDatReg()
		{
			return datreg;
		}

		public string getCgc()
		{
			return cgc;
		}

		public string getCPF()
		{
			return cpf;
		}

		public string getRg()
		{
			return rg;
		}

		public string getSacado()
		{
			return valor;
		}

		public string getNomeSaca()
		{
			return nomesaca;
		}

		public string getBaixa()
		{
			return baixa;
		}

		public string getMovimento()
		{
			return movimento;
		}

		public string getNome()
		{
			return nome;
		}

		public string getObser()
		{
			return obeser;
		}
	}
}
