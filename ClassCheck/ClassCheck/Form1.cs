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
			Console.WriteLine("�������� ������� Fruit");
			viewFruit = "�����";
			color = "�� ���������";
		}

		public void Print()
		{
			Console.WriteLine($"��� ������ - {viewFruit},���� - {color}");
		}
	}

	class Apple : Fruit
	{
		public Apple()
		{
			Console.WriteLine("�������� ������� ������");
			viewFruit = "������";
			color = "�������";
		}
	}

	class Banana : Fruit
	{
		public Banana()
		{
			Console.WriteLine("�������� ������� �����");
			viewFruit = "�����";
			color = "������";
		}
	}
}