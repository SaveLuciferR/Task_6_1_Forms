using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_6_1_Forms
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			textBox1.Text = "";
			textBox4.Text = "";
		}

		private void button3_Click(object sender, EventArgs e)
		{
			textBox2.Text = "";
			textBox3.Text = "";
			textBox5.Text = "";
		}

		private void button2_Click(object sender, EventArgs e)
		{
			try
			{
				textBox4.Text = "";
				int n = Convert.ToInt32(textBox1.Text);
				if (n < 1)
				{
					throw new Exception();
				}
				int[] arr = new int[n];
				int index = 0;
				Random r = new Random();

				textBox4.Text += String.Format("Элементы массива:\r\n");
				for (int i = 0; i < n; i++)
				{
					arr[i] = r.Next(-100, 100);
					textBox4.Text += String.Format("{0}\t", arr[i]);
				}

				foreach (int a in arr)
				{
					if (a % 2 != 0)
					{
						index++;
					}
				}

				textBox4.Text += String.Format("\r\nКол-во нечетных элементов: {0}", index);
			}
			catch(FormatException)
			{
				textBox4.Text = "Введите корректные данные";
			}
			catch
			{
				textBox4.Text = "Размер массива должен быть натуральным числом";
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			try
			{
				textBox5.Text = "";

				int n = Convert.ToInt32(textBox3.Text);
				int m = Convert.ToInt32(textBox2.Text);

				if (m < 1 || n < 1)
				{
					throw new Exception();
				}

				int[,] arr = new int[n, m];
				int index = 0;
				Random r = new Random();

				for (int i = 0; i < n; i++)
				{
					for (int j = 0; j < m; j++)
					{
						arr[i,j] = r.Next(-100, 100);
						textBox5.Text += String.Format("{0}\t", arr[i,j]);
						if (arr[i,j] % 2 != 0)
						{
							index++;
						}
					}
					textBox5.Text += "\r\n";
				}
				textBox5.Text += String.Format("Кол-во нечетных элеметов: {0}", index);
			}
			catch (FormatException)
			{
				textBox5.Text = "Введите корректные данные";
			}
			catch
			{
				textBox5.Text = "Размер массива должен быть натуральным числом";
			}
		}
	}
}
