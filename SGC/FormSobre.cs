using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SGC
{
	public class FormSobre : Form
	{
		private IContainer components = null;

		private Panel panel1;

		private Label label1;

		private Panel panel2;

		private Label lbSobre;

		public FormSobre()
		{
			InitializeComponent();
			Sobre();
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		private void panel2_Paint(object sender, PaintEventArgs e)
		{
		}

		private void Sobre()
		{
			string sobre = "SGC-Sistema de gerenciamento de cartórios\nSistema possui licença comercial para uso exclusivo do comprador.\nOs dados aqui inserido ficam de exclusiva responsabilidade dos usuarios cadastrados.\nNenhum dado e capturado e levado para internet ou usado por terceiros.\nDesenvolvido por Marcos Rocha.";
			lbSobre.Text = sobre;
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SGC.FormSobre));
			panel1 = new System.Windows.Forms.Panel();
			lbSobre = new System.Windows.Forms.Label();
			label1 = new System.Windows.Forms.Label();
			panel2 = new System.Windows.Forms.Panel();
			panel1.SuspendLayout();
			SuspendLayout();
			panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			panel1.Controls.Add(lbSobre);
			panel1.Controls.Add(label1);
			panel1.Controls.Add(panel2);
			panel1.Location = new System.Drawing.Point(12, 12);
			panel1.Name = "panel1";
			panel1.Size = new System.Drawing.Size(535, 415);
			panel1.TabIndex = 0;
			panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
			lbSobre.AutoSize = true;
			lbSobre.Location = new System.Drawing.Point(49, 271);
			lbSobre.Name = "lbSobre";
			lbSobre.Size = new System.Drawing.Size(35, 13);
			lbSobre.TabIndex = 2;
			lbSobre.Text = "label2";
			lbSobre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			label1.AutoSize = true;
			label1.Location = new System.Drawing.Point(46, 271);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(0, 13);
			label1.TabIndex = 1;
			panel2.BackgroundImage = (System.Drawing.Image)resources.GetObject("panel2.BackgroundImage");
			panel2.Location = new System.Drawing.Point(49, 14);
			panel2.Name = "panel2";
			panel2.Size = new System.Drawing.Size(439, 241);
			panel2.TabIndex = 0;
			panel2.Paint += new System.Windows.Forms.PaintEventHandler(panel2_Paint);
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.MaximizeBox = false;
			base.ClientSize = new System.Drawing.Size(559, 439);
			base.Controls.Add(panel1);
			base.MinimizeBox = false;
			base.Name = "FormSobre";
			base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			Text = "Sobre";
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			ResumeLayout(false);
		}
	}
}
