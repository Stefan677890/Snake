namespace Snake
{
    partial class Board
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Timer = new System.Windows.Forms.Timer(components);
            Start = new Button();
            Difficulty = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // Timer
            // 
            Timer.Interval = 80;
            // 
            // Start
            // 
            Start.Location = new Point(405, 76);
            Start.Name = "Start";
            Start.Size = new Size(75, 23);
            Start.TabIndex = 0;
            Start.Text = "Start";
            Start.UseVisualStyleBackColor = true;
            Start.Click += button1_Click;
            // 
            // Difficulty
            // 
            Difficulty.Location = new Point(408, 162);
            Difficulty.Name = "Difficulty";
            Difficulty.Size = new Size(75, 23);
            Difficulty.TabIndex = 1;
            Difficulty.Text = "Difficulty";
            Difficulty.UseVisualStyleBackColor = true;
            Difficulty.Click += Difficulty_Click;
            // 
            // button3
            // 
            button3.Location = new Point(404, 239);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 2;
            button3.Text = "Exit";
            button3.UseVisualStyleBackColor = true;
            // 
            // Board
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(Difficulty);
            Controls.Add(Start);
            Name = "Board";
            Text = "Board";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer Timer;
        private Button Start;
        private Button Difficulty;
        private Button button3;
    }
}
