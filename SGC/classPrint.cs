using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace SGC
{
	internal class classPrint
	{
		public static string label;

		public static int fonte;

		public void printdocument(string paperType, int A, int L, string dados, int tfonte)
		{
			label = dados;
			fonte = tfonte;
			try
			{
				PrintDocument pd = new PrintDocument();
				pd.DefaultPageSettings.PaperSize = new PaperSize(paperType, A, L);
				pd.PrintPage += pd_PrintPage;
				pd.Print();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro ao imprimir o documento", ex.ToString());
			}
		}

		private void pd_PrintPage(object sender, PrintPageEventArgs ev)
		{
			ev.Graphics.DrawString(label, new Font("Tahoma", fonte, FontStyle.Regular), Brushes.Black, 0f, 0f);
			ev.Graphics.MeasureString(label, new Font("Tahoma", fonte, FontStyle.Regular), ev.MarginBounds.Size);
		}
	}
}
