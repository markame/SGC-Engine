using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using ScanImage;

namespace SGC
{
	public class FormScannerDevice : Form
	{
		private OpenFileDialog dlg = new OpenFileDialog();

		private IContainer components = null;

		private Button button1;

		private PictureBox pic_scan;

		private Panel panel1;

		private ListBox lbDevices;

		public FormScannerDevice()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				List<string> devices = WIAScanner.GetDevices();
				foreach (string device in devices)
				{
					lbDevices.Items.Add(device);
				}
				if (lbDevices.Items.Count == 0)
				{
					MessageBox.Show("Dispositivo de Scanner não foi encontrado");
					Close();
				}
				else
				{
					lbDevices.SelectedIndex = 0;
				}
				List<Image> images = WIAScanner.Scan((string)lbDevices.SelectedItem);
				foreach (Image image in images)
				{
					pic_scan.Image = image;
					pic_scan.Show();
					pic_scan.SizeMode = PictureBoxSizeMode.StretchImage;
					string path = "C:\\\\Assinaturas\\\\";
					path = path + DateTime.Now.ToString("yyyy-MM-dd HHmmss") + ".jpeg";
					image.Save(path, ImageFormat.Jpeg);
					dadosscanner ds = new dadosscanner();
					ds.SetScanner(path);
				}
			}
			catch (Exception exc)
			{
				MessageBox.Show(exc.Message);
			}
		}

		private void Home_SizeChanged(object sender, EventArgs e)
		{
			int pheight = base.Size.Height - 153;
			pic_scan.Size = new Size(pheight - 150, pheight);
		}

		private void button2_Click(object sender, EventArgs e)
		{
		}

		private void pic_scan_Click(object sender, EventArgs e)
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
			button1 = new System.Windows.Forms.Button();
			pic_scan = new System.Windows.Forms.PictureBox();
			panel1 = new System.Windows.Forms.Panel();
			lbDevices = new System.Windows.Forms.ListBox();
			((System.ComponentModel.ISupportInitialize)pic_scan).BeginInit();
			panel1.SuspendLayout();
			SuspendLayout();
			button1.Location = new System.Drawing.Point(26, 30);
			button1.Name = "button1";
			button1.Size = new System.Drawing.Size(75, 23);
			button1.TabIndex = 0;
			button1.Text = "Scannear";
			button1.UseVisualStyleBackColor = true;
			button1.Click += new System.EventHandler(button1_Click);
			pic_scan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			pic_scan.Location = new System.Drawing.Point(219, 3);
			pic_scan.Name = "pic_scan";
			pic_scan.Size = new System.Drawing.Size(439, 577);
			pic_scan.TabIndex = 1;
			pic_scan.TabStop = false;
			pic_scan.Click += new System.EventHandler(pic_scan_Click);
			panel1.Controls.Add(lbDevices);
			panel1.Controls.Add(pic_scan);
			panel1.Location = new System.Drawing.Point(12, 12);
			panel1.Name = "panel1";
			panel1.Size = new System.Drawing.Size(661, 595);
			panel1.TabIndex = 2;
			lbDevices.FormattingEnabled = true;
			lbDevices.Location = new System.Drawing.Point(14, 47);
			lbDevices.Name = "lbDevices";
			lbDevices.Size = new System.Drawing.Size(120, 30);
			lbDevices.TabIndex = 6;
			lbDevices.Visible = false;
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.MaximizeBox = false;
			base.ClientSize = new System.Drawing.Size(685, 619);
			base.Controls.Add(button1);
			base.Controls.Add(panel1);
			base.MinimizeBox = false;
			base.Name = "FormScannerDevice";
			base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			Text = "Scanner";
			((System.ComponentModel.ISupportInitialize)pic_scan).EndInit();
			panel1.ResumeLayout(false);
			ResumeLayout(false);
		}
	}
}
