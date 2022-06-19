using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SGC
{
	public class FormIOutraFirma : Form
	{
		private IContainer components = null;

		private Panel panel1;

		private TextBox textBox1;

		private Label label11;

		private Label label10;

		private Label label9;

		private Label label8;

		private Label label7;

		private Label label6;

		private Label label5;

		private Label label4;

		private Label label3;

		private Label label2;

		private Label label1;

		private ComboBox comboBox1;

		private TextBox textBox6;

		private TextBox textBox5;

		private TextBox textBox4;

		private MaskedTextBox maskedTextBox3;

		private MaskedTextBox maskedTextBox2;

		private MaskedTextBox maskedTextBox1;

		private TextBox textBox3;

		private TextBox textBox2;

		private Button button2;

		private Button button1;

		private TextBox textBox7;

		public FormIOutraFirma()
		{
			InitializeComponent();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Close();
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
			label1 = new System.Windows.Forms.Label();
			label2 = new System.Windows.Forms.Label();
			label3 = new System.Windows.Forms.Label();
			label4 = new System.Windows.Forms.Label();
			label5 = new System.Windows.Forms.Label();
			label6 = new System.Windows.Forms.Label();
			label7 = new System.Windows.Forms.Label();
			label8 = new System.Windows.Forms.Label();
			label9 = new System.Windows.Forms.Label();
			label10 = new System.Windows.Forms.Label();
			label11 = new System.Windows.Forms.Label();
			textBox1 = new System.Windows.Forms.TextBox();
			textBox2 = new System.Windows.Forms.TextBox();
			textBox3 = new System.Windows.Forms.TextBox();
			maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
			maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
			maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
			textBox4 = new System.Windows.Forms.TextBox();
			textBox5 = new System.Windows.Forms.TextBox();
			textBox6 = new System.Windows.Forms.TextBox();
			comboBox1 = new System.Windows.Forms.ComboBox();
			textBox7 = new System.Windows.Forms.TextBox();
			button1 = new System.Windows.Forms.Button();
			button2 = new System.Windows.Forms.Button();
			panel1.SuspendLayout();
			SuspendLayout();
			panel1.Controls.Add(button2);
			panel1.Controls.Add(button1);
			panel1.Controls.Add(textBox7);
			panel1.Controls.Add(comboBox1);
			panel1.Controls.Add(textBox6);
			panel1.Controls.Add(textBox5);
			panel1.Controls.Add(textBox4);
			panel1.Controls.Add(maskedTextBox3);
			panel1.Controls.Add(maskedTextBox2);
			panel1.Controls.Add(maskedTextBox1);
			panel1.Controls.Add(textBox3);
			panel1.Controls.Add(textBox2);
			panel1.Controls.Add(textBox1);
			panel1.Controls.Add(label11);
			panel1.Controls.Add(label10);
			panel1.Controls.Add(label9);
			panel1.Controls.Add(label8);
			panel1.Controls.Add(label7);
			panel1.Controls.Add(label6);
			panel1.Controls.Add(label5);
			panel1.Controls.Add(label4);
			panel1.Controls.Add(label3);
			panel1.Controls.Add(label2);
			panel1.Controls.Add(label1);
			panel1.Location = new System.Drawing.Point(12, 12);
			panel1.Name = "panel1";
			panel1.Size = new System.Drawing.Size(594, 333);
			panel1.TabIndex = 0;
			label1.AutoSize = true;
			label1.Location = new System.Drawing.Point(14, 34);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(53, 13);
			label1.TabIndex = 0;
			label1.Text = "Matricula:";
			label2.AutoSize = true;
			label2.Location = new System.Drawing.Point(201, 34);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(38, 13);
			label2.TabIndex = 1;
			label2.Text = "Nome:";
			label3.AutoSize = true;
			label3.Location = new System.Drawing.Point(459, 34);
			label3.Name = "label3";
			label3.Size = new System.Drawing.Size(56, 13);
			label3.TabIndex = 2;
			label3.Text = "Autografo:";
			label4.AutoSize = true;
			label4.Location = new System.Drawing.Point(14, 97);
			label4.Name = "label4";
			label4.Size = new System.Drawing.Size(92, 13);
			label4.TabIndex = 3;
			label4.Text = "Data Renovação:";
			label5.AutoSize = true;
			label5.Location = new System.Drawing.Point(186, 97);
			label5.Name = "label5";
			label5.Size = new System.Drawing.Size(100, 13);
			label5.TabIndex = 4;
			label5.Text = "Data Reconhecida:";
			label6.AutoSize = true;
			label6.Location = new System.Drawing.Point(366, 97);
			label6.Name = "label6";
			label6.Size = new System.Drawing.Size(37, 13);
			label6.TabIndex = 5;
			label6.Text = "Limite:";
			label7.AutoSize = true;
			label7.Location = new System.Drawing.Point(476, 97);
			label7.Name = "label7";
			label7.Size = new System.Drawing.Size(51, 13);
			label7.TabIndex = 6;
			label7.Text = "Validade:";
			label8.AutoSize = true;
			label8.Location = new System.Drawing.Point(14, 166);
			label8.Name = "label8";
			label8.Size = new System.Drawing.Size(46, 13);
			label8.TabIndex = 7;
			label8.Text = "Cartorio:";
			label9.AutoSize = true;
			label9.Location = new System.Drawing.Point(298, 166);
			label9.Name = "label9";
			label9.Size = new System.Drawing.Size(43, 13);
			label9.TabIndex = 8;
			label9.Text = "Cidade:";
			label10.AutoSize = true;
			label10.Location = new System.Drawing.Point(453, 166);
			label10.Name = "label10";
			label10.Size = new System.Drawing.Size(24, 13);
			label10.TabIndex = 9;
			label10.Text = "UF:";
			label11.AutoSize = true;
			label11.Location = new System.Drawing.Point(14, 234);
			label11.Name = "label11";
			label11.Size = new System.Drawing.Size(49, 13);
			label11.TabIndex = 10;
			label11.Text = "Controle:";
			textBox1.Location = new System.Drawing.Point(73, 31);
			textBox1.Name = "textBox1";
			textBox1.Size = new System.Drawing.Size(100, 20);
			textBox1.TabIndex = 11;
			textBox2.Location = new System.Drawing.Point(245, 31);
			textBox2.Name = "textBox2";
			textBox2.Size = new System.Drawing.Size(208, 20);
			textBox2.TabIndex = 12;
			textBox3.Location = new System.Drawing.Point(521, 31);
			textBox3.Name = "textBox3";
			textBox3.Size = new System.Drawing.Size(53, 20);
			textBox3.TabIndex = 13;
			maskedTextBox1.Location = new System.Drawing.Point(112, 94);
			maskedTextBox1.Mask = "00/00/0000";
			maskedTextBox1.Name = "maskedTextBox1";
			maskedTextBox1.Size = new System.Drawing.Size(68, 20);
			maskedTextBox1.TabIndex = 14;
			maskedTextBox1.ValidatingType = typeof(System.DateTime);
			maskedTextBox2.Location = new System.Drawing.Point(292, 94);
			maskedTextBox2.Mask = "00/00/0000";
			maskedTextBox2.Name = "maskedTextBox2";
			maskedTextBox2.Size = new System.Drawing.Size(68, 20);
			maskedTextBox2.TabIndex = 15;
			maskedTextBox2.ValidatingType = typeof(System.DateTime);
			maskedTextBox3.Location = new System.Drawing.Point(402, 94);
			maskedTextBox3.Mask = "00/00/0000";
			maskedTextBox3.Name = "maskedTextBox3";
			maskedTextBox3.Size = new System.Drawing.Size(68, 20);
			maskedTextBox3.TabIndex = 16;
			maskedTextBox3.ValidatingType = typeof(System.DateTime);
			textBox4.Location = new System.Drawing.Point(533, 94);
			textBox4.Name = "textBox4";
			textBox4.Size = new System.Drawing.Size(53, 20);
			textBox4.TabIndex = 17;
			textBox5.Location = new System.Drawing.Point(66, 163);
			textBox5.Name = "textBox5";
			textBox5.Size = new System.Drawing.Size(226, 20);
			textBox5.TabIndex = 18;
			textBox6.Location = new System.Drawing.Point(347, 163);
			textBox6.Name = "textBox6";
			textBox6.Size = new System.Drawing.Size(100, 20);
			textBox6.TabIndex = 19;
			comboBox1.FormattingEnabled = true;
			comboBox1.Items.AddRange(new object[27]
			{
				"AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA",
				"MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN",
				"RS", "RO", "RR", "SC", "SP", "SE", "TO"
			});
			comboBox1.Location = new System.Drawing.Point(484, 163);
			comboBox1.Name = "comboBox1";
			comboBox1.Size = new System.Drawing.Size(57, 21);
			comboBox1.TabIndex = 20;
			textBox7.Location = new System.Drawing.Point(66, 231);
			textBox7.Name = "textBox7";
			textBox7.Size = new System.Drawing.Size(107, 20);
			textBox7.TabIndex = 21;
			button1.Location = new System.Drawing.Point(494, 278);
			button1.Name = "button1";
			button1.Size = new System.Drawing.Size(80, 35);
			button1.TabIndex = 22;
			button1.Text = "Salvar";
			button1.UseVisualStyleBackColor = true;
			button2.Location = new System.Drawing.Point(390, 278);
			button2.Name = "button2";
			button2.Size = new System.Drawing.Size(80, 35);
			button2.TabIndex = 23;
			button2.Text = "Cancelar";
			button2.UseVisualStyleBackColor = true;
			button2.Click += new System.EventHandler(button2_Click);
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.MaximizeBox = false;
			base.ClientSize = new System.Drawing.Size(621, 359);
			base.Controls.Add(panel1);
			base.MinimizeBox = false;
			base.Name = "FormIOutraFirma";
			base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			Text = "Outras Firmas";
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			ResumeLayout(false);
		}
	}
}
