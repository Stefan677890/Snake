namespace Snake
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
			Timer = new System.Windows.Forms.Timer(components);
			Main_menu = new Button();
			try_again = new Button();
			button3 = new Button();
			button1 = new Button();
			button4 = new Button();
			button6 = new Button();
			textBox1 = new TextBox();
			label1 = new Label();
			button5 = new Button();
			SuspendLayout();
			// 
			// Timer
			// 
			Timer.Enabled = true;
			Timer.Interval = 10;
			Timer.Tick += Tick;
			// 
			// Main_menu
			// 
			Main_menu.Location = new Point(294, 344);
			Main_menu.Name = "Main_menu";
			Main_menu.Size = new Size(76, 23);
			Main_menu.TabIndex = 0;
			Main_menu.Text = "Main menu";
			Main_menu.UseVisualStyleBackColor = true;
			Main_menu.Click += button2_Click;
			// 
			// try_again
			// 
			try_again.Location = new Point(402, 344);
			try_again.Name = "try_again";
			try_again.Size = new Size(79, 23);
			try_again.TabIndex = 1;
			try_again.Text = "try again";
			try_again.UseVisualStyleBackColor = true;
			try_again.Click += button3_Click;
			// 
			// button3
			// 
			button3.BackColor = Color.Transparent;
			button3.Cursor = Cursors.Help;
			button3.FlatAppearance.BorderSize = 0;
			button3.FlatAppearance.MouseDownBackColor = Color.Transparent;
			button3.FlatAppearance.MouseOverBackColor = Color.Transparent;
			button3.FlatStyle = FlatStyle.Flat;
			button3.Location = new Point(229, 73);
			button3.Name = "button3";
			button3.Size = new Size(30, 23);
			button3.TabIndex = 3;
			button3.UseVisualStyleBackColor = false;
			button3.Click += button3_Click_1;
			// 
			// button1
			// 
			button1.BackColor = Color.Transparent;
			button1.Cursor = Cursors.Help;
			button1.FlatAppearance.BorderSize = 0;
			button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
			button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
			button1.FlatStyle = FlatStyle.Flat;
			button1.ForeColor = SystemColors.ControlText;
			button1.Location = new Point(522, 73);
			button1.Name = "button1";
			button1.Size = new Size(37, 23);
			button1.TabIndex = 4;
			button1.UseVisualStyleBackColor = false;
			button1.Click += button1_Click;
			// 
			// button4
			// 
			button4.BackColor = Color.Transparent;
			button4.Cursor = Cursors.Help;
			button4.FlatAppearance.BorderSize = 0;
			button4.FlatAppearance.MouseDownBackColor = Color.Transparent;
			button4.FlatAppearance.MouseOverBackColor = Color.Transparent;
			button4.FlatStyle = FlatStyle.Flat;
			button4.Location = new Point(668, 49);
			button4.Name = "button4";
			button4.Size = new Size(43, 34);
			button4.TabIndex = 5;
			button4.UseVisualStyleBackColor = false;
			button4.Click += button4_Click;
			// 
			// button6
			// 
			button6.Location = new Point(484, 23);
			button6.Name = "button6";
			button6.Size = new Size(89, 44);
			button6.TabIndex = 8;
			button6.Text = "Spawn golden apple";
			button6.UseVisualStyleBackColor = true;
			button6.Click += button6_Click;
			// 
			// textBox1
			// 
			textBox1.Location = new Point(193, 26);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(100, 23);
			textBox1.TabIndex = 9;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.BackColor = Color.White;
			label1.Location = new Point(116, 34);
			label1.Name = "label1";
			label1.Size = new Size(71, 15);
			label1.TabIndex = 11;
			label1.Text = "enter speed:";
			// 
			// button5
			// 
			button5.Location = new Point(193, 51);
			button5.Name = "button5";
			button5.Size = new Size(100, 45);
			button5.TabIndex = 12;
			button5.Text = "activate the change";
			button5.UseVisualStyleBackColor = true;
			button5.Click += button5_Click;
			// 
			// Form2
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ControlText;
			BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
			BackgroundImageLayout = ImageLayout.Stretch;
			ClientSize = new Size(784, 561);
			Controls.Add(button5);
			Controls.Add(label1);
			Controls.Add(textBox1);
			Controls.Add(button6);
			Controls.Add(button4);
			Controls.Add(button1);
			Controls.Add(button3);
			Controls.Add(try_again);
			Controls.Add(Main_menu);
			Icon = (Icon)resources.GetObject("$this.Icon");
			MaximumSize = new Size(800, 600);
			MinimumSize = new Size(800, 600);
			Name = "Form2";
			Text = "Board";
			Load += Form2_Load;
			Paint += Form2_Paint;
			KeyDown += Form2_KeyDown;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private System.Windows.Forms.Timer Timer;
        private Button button1;
        private Button Main_menu;
        private Button try_again;
		private Button button3;
		private Button button4;
		private Button button6;
		private TextBox textBox1;
		private Label label1;
		private Button button5;
	}
}