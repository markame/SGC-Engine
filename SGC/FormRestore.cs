using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SGC
{
	public class FormRestore : Form
	{
		private IContainer components = null;

		private Panel panel1;

		private Button button2;

		private Button btlocal;

		private Label label1;

		private TextBox textBox1;

		private OpenFileDialog openFileDialog1;

		public FormRestore()
		{
			InitializeComponent();
		}

		private void btlocal_Click(object sender, EventArgs e)
		{
			DialogResult result = openFileDialog1.ShowDialog();
			if (result == DialogResult.OK)
			{
			}
			Console.WriteLine(result);
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
			textBox1 = new System.Windows.Forms.TextBox();
			label1 = new System.Windows.Forms.Label();
			btlocal = new System.Windows.Forms.Button();
			button2 = new System.Windows.Forms.Button();
			openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			panel1.SuspendLayout();
			SuspendLayout();
			panel1.Controls.Add(button2);
			panel1.Controls.Add(btlocal);
			panel1.Controls.Add(label1);
			panel1.Controls.Add(textBox1);
			panel1.Location = new System.Drawing.Point(12, 12);
			panel1.Name = "panel1";
			panel1.Size = new System.Drawing.Size(450, 124);
			panel1.TabIndex = 0;
			textBox1.Location = new System.Drawing.Point(66, 31);
			textBox1.Name = "textBox1";
			textBox1.Size = new System.Drawing.Size(294, 20);
			textBox1.TabIndex = 1;
			label1.AutoSize = true;
			label1.Location = new System.Drawing.Point(24, 34);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(36, 13);
			label1.TabIndex = 2;
			label1.Text = "Local:";
			btlocal.Location = new System.Drawing.Point(366, 29);
			btlocal.Name = "btlocal";
			btlocal.Size = new System.Drawing.Size(75, 23);
			btlocal.TabIndex = 3;
			btlocal.Text = "...";
			btlocal.UseVisualStyleBackColor = true;
			btlocal.Click += new System.EventHandler(btlocal_Click);
			button2.Location = new System.Drawing.Point(194, 85);
			button2.Name = "button2";
			button2.Size = new System.Drawing.Size(75, 23);
			button2.TabIndex = 4;
			button2.Text = "RESTORE";
			button2.UseVisualStyleBackColor = true;
			openFileDialog1.FileName = "openFileDialog1";
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(474, 143);
			base.Controls.Add(panel1);
			base.Name = "FormRestore";
			Text = "FormRestore";
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			ResumeLayout(false);
		}
	}
}
