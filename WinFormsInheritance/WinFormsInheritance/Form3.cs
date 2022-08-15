using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsInheritance
{
	public partial class Form3 : Form2
	{
		public Form3()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			GetColorForm1Method();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			GetColorForm2Method();
		}
	}

}
