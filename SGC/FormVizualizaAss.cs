using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using SGC.Properties;

namespace SGC
{
	public class FormVizualizaAss : Form
	{
		private dados d = new dados();

		private IContainer components = null;

		private Panel panel1;

		private Button button1;

		private OpenFileDialog openFileDialog1;

		private PictureBox picAssinatura;

		public FormVizualizaAss()
		{
			InitializeComponent();
			loadImage();
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			loadImage();
		}

		private void Home_SizeChanged(object sender, EventArgs e)
		{
			int pheight = base.Size.Height - 153;
			picAssinatura.Size = new Size(pheight - 150, pheight);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void FormVizualizaAss_Load(object sender, EventArgs e)
		{
		}

		private void loadImage()
		{
			try
			{
				string local = d.GetAssinatura();
				picAssinatura.SizeMode = PictureBoxSizeMode.StretchImage;
				Bitmap image = new Bitmap(local);
				picAssinatura.Dock = DockStyle.Fill;
				picAssinatura.Image = image;
				picAssinatura.Show();
			}
			catch
			{
				MessageBox.Show("Não foi Possivel encontrar a Assinatura", "erro");
			}
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
			button1 = new System.Windows.Forms.Button();
			openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			picAssinatura = new System.Windows.Forms.PictureBox();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)picAssinatura).BeginInit();
			SuspendLayout();
			panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			panel1.Controls.Add(picAssinatura);
			panel1.Controls.Add(button1);
			panel1.Location = new System.Drawing.Point(12, 12);
			panel1.Name = "panel1";
			panel1.Size = new System.Drawing.Size(1035, 550);
			panel1.TabIndex = 0;
			button1.Location = new System.Drawing.Point(464, 522);
			button1.Name = "button1";
			button1.Size = new System.Drawing.Size(75, 23);
			button1.TabIndex = 1;
			button1.Text = "Sair";
			button1.UseVisualStyleBackColor = true;
			button1.Click += new System.EventHandler(button1_Click);
			openFileDialog1.FileName = "openFileDialog1";
			picAssinatura.BackgroundImage = SGC.Properties.Resources.image_not_found;
			picAssinatura.Location = new System.Drawing.Point(3, 3);
			picAssinatura.Name = "picAssinatura";
			picAssinatura.Size = new System.Drawing.Size(1027, 513);
			picAssinatura.TabIndex = 2;
			picAssinatura.TabStop = false;
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.MaximizeBox = false;
			base.ClientSize = new System.Drawing.Size(1059, 574);
			base.Controls.Add(panel1);
			base.MinimizeBox = false;
			base.Name = "FormVizualizaAss";
			base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			Text = "Vizualizador de Assinaturas";
			base.Load += new System.EventHandler(FormVizualizaAss_Load);
			panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)picAssinatura).EndInit();
			ResumeLayout(false);
		}
	}
}
