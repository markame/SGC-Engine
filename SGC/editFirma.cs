namespace SGC
{
	internal class editFirma
	{
		public static string Codigo;

		public static string Nome;

		public static string Autografo;

		public static string DatadeRenovacao;

		public static string DatadeReconhecimento;

		public static string PeriododeValidade;

		public static string CEP;

		public static string Cidade;

		public static string UF;

		public static string Sexo;

		public static string EstadoCivil;

		public static string Profissao;

		public static string DatadeNascimento;

		public static string CPF;

		public static string CGC;

		public static string RG;

		public static string Controle;

		public static string Observacao;

		public static string endereco;

		public static string bairro;

		public static string tabeliao;

		public void setFirma(string C, string N, string A, string D, string Dreco, string P, string Cep, string Cida, string U, string S, string EC, string Prof, string DNa, string Cpf, string Ccg, string Rg, string Control, string Obse, string ender, string bair, string tab)
		{
			Codigo = C;
			Nome = N;
			Autografo = A;
			DatadeRenovacao = D;
			DatadeReconhecimento = Dreco;
			PeriododeValidade = P;
			CEP = Cep;
			Cidade = Cida;
			UF = U;
			Sexo = S;
			EstadoCivil = EC;
			Profissao = Prof;
			DatadeNascimento = DNa;
			CPF = Cpf;
			RG = Rg;
			CGC = Ccg;
			Controle = Control;
			Observacao = Obse;
			endereco = ender;
			bairro = bair;
			tabeliao = tab;
		}

		public string CODIGO()
		{
			return Codigo;
		}

		public string NOME()
		{
			return Nome;
		}

		public string AUTOGRAFO()
		{
			return Autografo;
		}

		public string RENOVACAO()
		{
			return DatadeRenovacao;
		}

		public string RECONHECIMENTO()
		{
			return DatadeReconhecimento;
		}

		public string VALIDADE()
		{
			return PeriododeValidade;
		}

		public string CEPg()
		{
			return CEP;
		}

		public string CIDADE()
		{
			return Cidade;
		}

		public string UFg()
		{
			return UF;
		}

		public string SEXO()
		{
			return Sexo;
		}

		public string ESC()
		{
			return EstadoCivil;
		}

		public string PROFI()
		{
			return Profissao;
		}

		public string DNA()
		{
			return DatadeNascimento;
		}

		public string CPFg()
		{
			return CPF;
		}

		public string CGCg()
		{
			return CGC;
		}

		public string RGg()
		{
			return RG;
		}

		public string CONTROLE()
		{
			return Controle;
		}

		public string OBSER()
		{
			return Observacao;
		}

		public string ENDERECO()
		{
			return endereco;
		}

		public string BAIR()
		{
			return bairro;
		}

		public string TAB()
		{
			return tabeliao;
		}
	}
}
