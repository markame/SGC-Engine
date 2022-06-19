namespace SGC
{
	internal class dadosscanner
	{
		public static string local;

		public string SetScanner(string localimg)
		{
			local = localimg;
			return local;
		}

		public string GetScanner()
		{
			return local;
		}
	}
}
