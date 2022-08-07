using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		int[] array = new int[10000];

		private void ButtonAddSort_Click(object sender, EventArgs e)
		{
			Random rndValue = new Random();
			StringBuilder arrayBuild = new StringBuilder();

			for (int i = 0; i < array.Length; i++)
			{
				array[i] = rndValue.Next(-1000, 50000);
				arrayBuild.Append(array[i] + " ");
			}

			textBoxViewArray.Text = arrayBuild.ToString();

			Array.Sort(array);
			arrayBuild.Clear();
			
			for (int j = 0; j < array.Length; j++)
			{
				arrayBuild.Append(array[j] + " ");
			}
			textBoxViewSortArray.Text = arrayBuild.ToString();
		}

		private void buttonSearchElement_Click(object sender, EventArgs e)
		{
			int left = 0;
			int righh = array.Length - 1;
			int counter = 1;
			int searchElement = Convert.ToInt32(textBoxEditElement.Text);

			while (left <= righh)
			{
				int mid = (left + righh) / 2;

				if (searchElement == array[mid])
				{
					counter++;
					MessageBox.Show($"Поздравляем, Вы нашли искомый элемент, его позиция {mid}");
					break;
				}

				if ((left == righh) && (mid != searchElement))
				{
					MessageBox.Show("Увы, такого элемента в массиве нет!");
					break;
				}

				if (searchElement < array[mid])
				{
					counter++;
					righh = mid - 1;
				}

				else

				{
					counter++;
					left = mid + 1;
				}
			}

			this.Text = $"Количество итераций = {counter.ToString()}";
		}

		private void buttonPrevLessonSearch_Click(object sender, EventArgs e)
		{
			int element = Convert.ToInt32(textBoxEditElement.Text);
			int counter = 1;

			for (int i = 0; i < array.Length; i++)
			{

				if (array[i] == element)
				{
					MessageBox.Show($"Поздравляем, Вы нашли искомый элемент, его позиция {i}");
					this.Text = $"Количество итераций = {counter.ToString()}";
					break;
				}

				else

				{
					if ((i == array.Length - 1) & (element != array[i]))
					{
						MessageBox.Show("Увы, такого элемента в массиве нет!");
					}
				}

				counter++;
			}
		}

		private void buttonSwapMethod1_Click(object sender, EventArgs e)
		{
			int a = Convert.ToInt32(textBoxNumber1.Text);
			int b = Convert.ToInt32(textBoxNumber2.Text);

			(a, b) = (b, a);

			textBoxSwap1.Text = $"a = {a}, b = {b}"; 
		}

		private void buttonSwapMethod2_Click(object sender, EventArgs e)
		{
			int a = Convert.ToInt32(textBoxNumber1.Text);
			int b = Convert.ToInt32(textBoxNumber2.Text);

			a = a + b;
			b = a - b;
			a = a - b;
			textBoxSwap2.Text = $"a = {a}, b = {b}";
		}
	}
}
 