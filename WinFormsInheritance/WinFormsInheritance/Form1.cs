﻿using System;
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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		public void GetColorForm1Method()
		{
			this.BackColor = Color.Green;
			this.Text = "Установили новое имя формы = Green";
		}

		
	}
}
