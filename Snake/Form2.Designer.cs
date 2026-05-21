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
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(784, 561);
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
        }

        #endregion

        private System.Windows.Forms.Timer Timer;
        private Button button1;
        private Button Main_menu;
        private Button try_again;
    }
}