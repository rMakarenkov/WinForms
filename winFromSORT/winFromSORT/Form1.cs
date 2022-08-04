using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winFromSORT
{
	public partial class Form1 : Form
	{
		int[] array = new int[50];
		Random rnd = new Random();
		int temp = 0;

		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			textBox1.Clear();
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = rnd.Next(-100, 100);
				textBox1.Text += " " + array[i];
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			int x = 0;

			for (int i = 0; i < array.Length - 1; i++)
			{
				for (int j = 0; j < array.Length - 1; j++)
				{
					if (array[j] > array[j + 1])
					{
						temp = array[j];
						array[j] = array[j + 1];
						array[j + 1] = temp;
					}

					x++;
				}
			}

			Text = x.ToString();

			textBox3.Clear();

			for (int i = 0; i < array.Length; i++)
			{
				textBox3.Text += " " + array[i];
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			int entValue = Convert.ToInt32(textBox2.Text);
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] == entValue)
				{
					MessageBox.Show($"Индекс введенного Вами числа в массиве = {i}");
					break;
				}
				else
				{
					if (i == array.Length - 1)
					{
						MessageBox.Show("Такого элемента в массиве нет");
					}
				}
			}
		}
	}
}
