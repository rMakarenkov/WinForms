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
	public partial class Form2 : Form1
	{
		public Form2()
		{
			InitializeComponent();
		}

		public void GetColorForm2Method()
		{
			this.BackColor = Color.Red;
			this.Text = "Установили новое имя формы = Red";
		}
	}
}
