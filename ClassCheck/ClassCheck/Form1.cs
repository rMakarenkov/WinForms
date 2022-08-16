using System.Windows.Forms;

namespace ClassCheck
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Apple newApple = new Apple();
			newApple.Print();
			Banana newBanana = new Banana();
			newBanana.Print();
		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
	class Fruit
	{
		public string viewFruit;
		public string color;
		public Fruit()
		{
			Console.WriteLine("Создание объекта Fruit");
			viewFruit = "Фрукт";
			color = "Не определен";
		}

		public void Print()
		{
			Console.WriteLine($"Вид фрукта - {viewFruit},Цвет - {color}");
		}
	}

	class Apple : Fruit
	{
		public Apple()
		{
			Console.WriteLine("Создание объекта Яблоко");
			viewFruit = "Яблоко";
			color = "Зеленый";
		}
	}

	class Banana : Fruit
	{
		public Banana()
		{
			Console.WriteLine("Создание объекта Банан");
			viewFruit = "Банан";
			color = "Желтый";
		}
	}
}