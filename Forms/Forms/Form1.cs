using System.Windows.Forms;

namespace Forms
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		public virtual void SetColor()
		{
			this.BackColor = Color.Red;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.SetColor();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Form2 form2 = new Form2();
			form2.SetColor();
			form2.Show();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			Form3 form3 = new Form3();
			form3.SetColor();
			form3.Show();
		}
	}

	public class Form2 : Form1
	{
		public Form2()
		{

		}

		public override void SetColor()
		{
			BackColor = Color.Green;
			Text = "Изменение цвета формы с переопределенным методом SetColor - Зеленый";
		}
	}

	public class Form3 : Form1
	{
		public Form3()
		{

		}
		public override void SetColor()
		{
			BackColor = Color.Gray;
			Text = "Изменение цвета формы с переопределенным методом SetColor - Серый";
		}

	}
}