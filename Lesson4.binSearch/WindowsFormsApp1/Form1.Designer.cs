namespace WindowsFormsApp1
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.ButtonAddSort = new System.Windows.Forms.Button();
			this.textBoxViewArray = new System.Windows.Forms.TextBox();
			this.textBoxViewSortArray = new System.Windows.Forms.TextBox();
			this.buttonSearchElement = new System.Windows.Forms.Button();
			this.textBoxEditElement = new System.Windows.Forms.TextBox();
			this.buttonPrevLessonSearch = new System.Windows.Forms.Button();
			this.textBoxNumber1 = new System.Windows.Forms.TextBox();
			this.textBoxNumber2 = new System.Windows.Forms.TextBox();
			this.textBoxSwap1 = new System.Windows.Forms.TextBox();
			this.textBoxSwap2 = new System.Windows.Forms.TextBox();
			this.buttonSwapMethod1 = new System.Windows.Forms.Button();
			this.buttonSwapMethod2 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// ButtonAddSort
			// 
			this.ButtonAddSort.Location = new System.Drawing.Point(418, 144);
			this.ButtonAddSort.Name = "ButtonAddSort";
			this.ButtonAddSort.Size = new System.Drawing.Size(174, 55);
			this.ButtonAddSort.TabIndex = 0;
			this.ButtonAddSort.Text = "Добавление и сортировка массива";
			this.ButtonAddSort.UseVisualStyleBackColor = true;
			this.ButtonAddSort.Click += new System.EventHandler(this.ButtonAddSort_Click);
			// 
			// textBoxViewArray
			// 
			this.textBoxViewArray.Location = new System.Drawing.Point(19, 36);
			this.textBoxViewArray.Multiline = true;
			this.textBoxViewArray.Name = "textBoxViewArray";
			this.textBoxViewArray.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.textBoxViewArray.Size = new System.Drawing.Size(1000, 102);
			this.textBoxViewArray.TabIndex = 1;
			// 
			// textBoxViewSortArray
			// 
			this.textBoxViewSortArray.Location = new System.Drawing.Point(19, 205);
			this.textBoxViewSortArray.Multiline = true;
			this.textBoxViewSortArray.Name = "textBoxViewSortArray";
			this.textBoxViewSortArray.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.textBoxViewSortArray.Size = new System.Drawing.Size(1000, 102);
			this.textBoxViewSortArray.TabIndex = 2;
			// 
			// buttonSearchElement
			// 
			this.buttonSearchElement.Location = new System.Drawing.Point(12, 399);
			this.buttonSearchElement.Name = "buttonSearchElement";
			this.buttonSearchElement.Size = new System.Drawing.Size(175, 55);
			this.buttonSearchElement.TabIndex = 3;
			this.buttonSearchElement.Text = "Поиск позиции элемента в массиве (бинарный)";
			this.buttonSearchElement.UseVisualStyleBackColor = true;
			this.buttonSearchElement.Click += new System.EventHandler(this.buttonSearchElement_Click);
			// 
			// textBoxEditElement
			// 
			this.textBoxEditElement.Location = new System.Drawing.Point(12, 365);
			this.textBoxEditElement.Name = "textBoxEditElement";
			this.textBoxEditElement.Size = new System.Drawing.Size(175, 20);
			this.textBoxEditElement.TabIndex = 4;
			// 
			// buttonPrevLessonSearch
			// 
			this.buttonPrevLessonSearch.Location = new System.Drawing.Point(12, 460);
			this.buttonPrevLessonSearch.Name = "buttonPrevLessonSearch";
			this.buttonPrevLessonSearch.Size = new System.Drawing.Size(175, 55);
			this.buttonPrevLessonSearch.TabIndex = 5;
			this.buttonPrevLessonSearch.Text = "Поиск обычным перебором";
			this.buttonPrevLessonSearch.UseVisualStyleBackColor = true;
			this.buttonPrevLessonSearch.Click += new System.EventHandler(this.buttonPrevLessonSearch_Click);
			// 
			// textBoxNumber1
			// 
			this.textBoxNumber1.Location = new System.Drawing.Point(450, 365);
			this.textBoxNumber1.Name = "textBoxNumber1";
			this.textBoxNumber1.Size = new System.Drawing.Size(175, 20);
			this.textBoxNumber1.TabIndex = 6;
			// 
			// textBoxNumber2
			// 
			this.textBoxNumber2.Location = new System.Drawing.Point(450, 406);
			this.textBoxNumber2.Name = "textBoxNumber2";
			this.textBoxNumber2.Size = new System.Drawing.Size(175, 20);
			this.textBoxNumber2.TabIndex = 7;
			// 
			// textBoxSwap1
			// 
			this.textBoxSwap1.Location = new System.Drawing.Point(747, 379);
			this.textBoxSwap1.Name = "textBoxSwap1";
			this.textBoxSwap1.Size = new System.Drawing.Size(138, 20);
			this.textBoxSwap1.TabIndex = 8;
			// 
			// textBoxSwap2
			// 
			this.textBoxSwap2.Location = new System.Drawing.Point(747, 478);
			this.textBoxSwap2.Name = "textBoxSwap2";
			this.textBoxSwap2.Size = new System.Drawing.Size(138, 20);
			this.textBoxSwap2.TabIndex = 9;
			// 
			// buttonSwapMethod1
			// 
			this.buttonSwapMethod1.Location = new System.Drawing.Point(747, 332);
			this.buttonSwapMethod1.Name = "buttonSwapMethod1";
			this.buttonSwapMethod1.Size = new System.Drawing.Size(138, 41);
			this.buttonSwapMethod1.TabIndex = 10;
			this.buttonSwapMethod1.Text = "Swap #1";
			this.buttonSwapMethod1.UseVisualStyleBackColor = true;
			this.buttonSwapMethod1.Click += new System.EventHandler(this.buttonSwapMethod1_Click);
			// 
			// buttonSwapMethod2
			// 
			this.buttonSwapMethod2.Location = new System.Drawing.Point(747, 431);
			this.buttonSwapMethod2.Name = "buttonSwapMethod2";
			this.buttonSwapMethod2.Size = new System.Drawing.Size(138, 41);
			this.buttonSwapMethod2.TabIndex = 11;
			this.buttonSwapMethod2.Text = "Swap #2";
			this.buttonSwapMethod2.UseVisualStyleBackColor = true;
			this.buttonSwapMethod2.Click += new System.EventHandler(this.buttonSwapMethod2_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(422, 368);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(22, 13);
			this.label1.TabIndex = 12;
			this.label1.Text = "a =";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(422, 409);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(22, 13);
			this.label2.TabIndex = 13;
			this.label2.Text = "b =";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1030, 531);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonSwapMethod2);
			this.Controls.Add(this.buttonSwapMethod1);
			this.Controls.Add(this.textBoxSwap2);
			this.Controls.Add(this.textBoxSwap1);
			this.Controls.Add(this.textBoxNumber2);
			this.Controls.Add(this.textBoxNumber1);
			this.Controls.Add(this.buttonPrevLessonSearch);
			this.Controls.Add(this.textBoxEditElement);
			this.Controls.Add(this.buttonSearchElement);
			this.Controls.Add(this.textBoxViewSortArray);
			this.Controls.Add(this.textBoxViewArray);
			this.Controls.Add(this.ButtonAddSort);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button ButtonAddSort;
		private System.Windows.Forms.TextBox textBoxViewArray;
		private System.Windows.Forms.TextBox textBoxViewSortArray;
		private System.Windows.Forms.Button buttonSearchElement;
		private System.Windows.Forms.TextBox textBoxEditElement;
		private System.Windows.Forms.Button buttonPrevLessonSearch;
		private System.Windows.Forms.TextBox textBoxNumber1;
		private System.Windows.Forms.TextBox textBoxNumber2;
		private System.Windows.Forms.TextBox textBoxSwap1;
		private System.Windows.Forms.TextBox textBoxSwap2;
		private System.Windows.Forms.Button buttonSwapMethod1;
		private System.Windows.Forms.Button buttonSwapMethod2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
	}
}

