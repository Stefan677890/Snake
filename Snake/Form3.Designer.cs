namespace Snake
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            Normal = new Button();
            Hard = new Button();
            Extreme = new Button();
            Secret = new Button();
            SuspendLayout();
            // 
            // Normal
            // 
            Normal.BackColor = Color.Transparent;
            Normal.Cursor = Cursors.Hand;
            Normal.FlatAppearance.BorderSize = 0;
            Normal.FlatAppearance.MouseDownBackColor = Color.Transparent;
            Normal.FlatAppearance.MouseOverBackColor = Color.Transparent;
            Normal.FlatStyle = FlatStyle.Flat;
            Normal.ForeColor = Color.Transparent;
            Normal.Location = new Point(205, 183);
            Normal.Name = "Normal";
            Normal.Size = new Size(371, 73);
            Normal.TabIndex = 1;
            Normal.UseVisualStyleBackColor = false;
            Normal.Click += Normal_Click;
            // 
            // Hard
            // 
            Hard.BackColor = Color.Transparent;
            Hard.Cursor = Cursors.Hand;
            Hard.FlatAppearance.BorderSize = 0;
            Hard.FlatAppearance.MouseDownBackColor = Color.Transparent;
            Hard.FlatAppearance.MouseOverBackColor = Color.Transparent;
            Hard.FlatStyle = FlatStyle.Flat;
            Hard.ForeColor = Color.Transparent;
            Hard.Location = new Point(205, 274);
            Hard.Name = "Hard";
            Hard.Size = new Size(371, 80);
            Hard.TabIndex = 2;
            Hard.UseVisualStyleBackColor = false;
            Hard.Click += Hard_Click;
            // 
            // Extreme
            // 
            Extreme.BackColor = Color.Transparent;
            Extreme.Cursor = Cursors.Hand;
            Extreme.FlatAppearance.BorderSize = 0;
            Extreme.FlatAppearance.MouseDownBackColor = Color.Transparent;
            Extreme.FlatAppearance.MouseOverBackColor = Color.Transparent;
            Extreme.FlatStyle = FlatStyle.Flat;
            Extreme.ForeColor = Color.Transparent;
            Extreme.Location = new Point(205, 360);
            Extreme.Name = "Extreme";
            Extreme.Size = new Size(371, 80);
            Extreme.TabIndex = 3;
            Extreme.UseVisualStyleBackColor = false;
            Extreme.Click += Extreme_Click;
            // 
            // Secret
            // 
            Secret.BackColor = Color.Transparent;
            Secret.Cursor = Cursors.Hand;
            Secret.FlatAppearance.BorderSize = 0;
            Secret.FlatAppearance.MouseDownBackColor = Color.Transparent;
            Secret.FlatAppearance.MouseOverBackColor = Color.Transparent;
            Secret.FlatStyle = FlatStyle.Flat;
            Secret.ForeColor = Color.Transparent;
            Secret.Location = new Point(623, 213);
            Secret.Name = "Secret";
            Secret.Size = new Size(92, 89);
            Secret.TabIndex = 4;
            Secret.UseVisualStyleBackColor = false;
            Secret.Click += Secret_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(784, 561);
            Controls.Add(Secret);
            Controls.Add(Extreme);
            Controls.Add(Hard);
            Controls.Add(Normal);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(800, 600);
            MinimumSize = new Size(800, 600);
            Name = "Form3";
            Text = "Difficulty";
            ResumeLayout(false);
        }

        #endregion

        private Button Normal;
        private Button Hard;
        private Button Extreme;
        private Button Secret;
    }
}