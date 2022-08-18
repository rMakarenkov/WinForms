using System.Windows.Forms;

namespace ClassCheck
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			Auto aute1 = new Auto();

			listBox1.Items.Add(aute1.GetColor());
			listBox1.Items.Add(aute1.MyType);

			aute1.SetColor("Black");
			aute1.MyType = "Car";

			listBox1.Items.Add(aute1.GetColor());
			listBox1.Items.Add(aute1.MyType);
			listBox1.Items.Add(aute1.Wheels);
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
		protected string viewFruit;
		protected string color;
		
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

	class Auto
	{
		private string _color;
		private string _type;
		private int wheels;
		public int wheels2;
		protected int wheels3;
		internal int wheels4;

		public Auto()
		{
			_color = "White";
			_type = "SportCar";


		}

		public void SetColor(string value)
		{
			if (string.IsNullOrEmpty(value))
			{
				return;
			}

			_color = value;
		}

		public string GetColor()
		{
			return _color;
		}

		public string MyType
		{
			get
			{
				return _type;
			}
			set
			{
				_type = value;
			}
		}


		public int Wheels
		{
			get
			{
				return wheels;
			}
			set
			{
				if (value <= 0)
				{
					return;
				}

				wheels = value;
			}
		}
	}
}