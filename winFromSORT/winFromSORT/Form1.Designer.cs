namespace winFromSORT
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
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.button3 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(522, 38);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(261, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "Сформировать массив";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(522, 102);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(261, 23);
			this.button2.TabIndex = 1;
			this.button2.Text = "Сортировка массива";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(12, 12);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(1224, 20);
			this.textBox1.TabIndex = 2;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(63, 192);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(100, 20);
			this.textBox2.TabIndex = 3;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(169, 190);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(191, 23);
			this.button3.TabIndex = 4;
			this.button3.Text = "Поиск индекса элемента";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(60, 176);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(95, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "Введите элемент";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(12, 76);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(1224, 20);
			this.textBox3.TabIndex = 6;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1289, 602);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox3;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
	}
}

