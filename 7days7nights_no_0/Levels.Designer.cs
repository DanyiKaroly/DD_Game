namespace _7days7nights_no_0
{
    partial class Levels
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Levels));
            Level1 = new Button();
            Level2 = new Button();
            BackButton = new Button();
            Level3 = new Button();
            Level6 = new Button();
            Level5 = new Button();
            Level4 = new Button();
            SuspendLayout();
            // 
            // Level1
            // 
            Level1.BackColor = Color.FromArgb(100, 240, 240, 240);
            Level1.FlatAppearance.MouseOverBackColor = Color.FromArgb(150, 220, 220, 220);
            Level1.FlatStyle = FlatStyle.Flat;
            Level1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Level1.Location = new Point(40, 12);
            Level1.Name = "Level1";
            Level1.Size = new Size(142, 71);
            Level1.TabIndex = 0;
            Level1.Text = "Level1";
            Level1.UseVisualStyleBackColor = true;
            Level1.Click += Level1_Click;
            // 
            // Level2
            // 
            Level2.BackColor = Color.FromArgb(100, 240, 240, 240);
            Level2.FlatAppearance.MouseOverBackColor = Color.FromArgb(150, 220, 220, 220);
            Level2.FlatStyle = FlatStyle.Flat;
            Level2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Level2.Location = new Point(203, 12);
            Level2.Name = "Level2";
            Level2.Size = new Size(142, 71);
            Level2.TabIndex = 1;
            Level2.Text = "Level2";
            Level2.UseVisualStyleBackColor = true;
            // 
            // BackButton
            // 
            BackButton.BackColor = Color.FromArgb(100, 240, 240, 240);
            BackButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(150, 220, 220, 220);
            BackButton.FlatStyle = FlatStyle.Flat;
            BackButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            BackButton.Location = new Point(214, 192);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(118, 60);
            BackButton.TabIndex = 2;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // Level3
            // 
            Level3.BackColor = Color.FromArgb(100, 240, 240, 240);
            Level3.FlatAppearance.MouseOverBackColor = Color.FromArgb(150, 220, 220, 220);
            Level3.FlatStyle = FlatStyle.Flat;
            Level3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Level3.Location = new Point(371, 12);
            Level3.Name = "Level3";
            Level3.Size = new Size(142, 71);
            Level3.TabIndex = 3;
            Level3.Text = "Level3";
            Level3.UseVisualStyleBackColor = true;
            // 
            // Level6
            // 
            Level6.BackColor = Color.FromArgb(100, 240, 240, 240);
            Level6.FlatAppearance.MouseOverBackColor = Color.FromArgb(150, 220, 220, 220);
            Level6.FlatStyle = FlatStyle.Flat;
            Level6.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Level6.Location = new Point(371, 97);
            Level6.Name = "Level6";
            Level6.Size = new Size(142, 71);
            Level6.TabIndex = 6;
            Level6.Text = "Level6";
            Level6.UseVisualStyleBackColor = true;
            // 
            // Level5
            // 
            Level5.BackColor = Color.FromArgb(100, 240, 240, 240);
            Level5.FlatAppearance.MouseOverBackColor = Color.FromArgb(150, 220, 220, 220);
            Level5.FlatStyle = FlatStyle.Flat;
            Level5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Level5.Location = new Point(203, 97);
            Level5.Name = "Level5";
            Level5.Size = new Size(142, 71);
            Level5.TabIndex = 5;
            Level5.Text = "Level5";
            Level5.UseVisualStyleBackColor = true;
            // 
            // Level4
            // 
            Level4.BackColor = Color.FromArgb(100, 240, 240, 240);
            Level4.FlatAppearance.MouseOverBackColor = Color.FromArgb(150, 220, 220, 220);
            Level4.FlatStyle = FlatStyle.Flat;
            Level4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Level4.Location = new Point(40, 97);
            Level4.Name = "Level4";
            Level4.Size = new Size(142, 71);
            Level4.TabIndex = 4;
            Level4.Text = "Level4";
            Level4.UseVisualStyleBackColor = true;
            // 
            // Levels
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(543, 264);
            Controls.Add(Level6);
            Controls.Add(Level5);
            Controls.Add(Level4);
            Controls.Add(Level3);
            Controls.Add(BackButton);
            Controls.Add(Level2);
            Controls.Add(Level1);
            Cursor = Cursors.Cross;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Levels";
            ShowIcon = false;
            ShowInTaskbar = false;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Levels";
            Load += Levels_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button Level1;
        private Button Level2;
        private Button BackButton;
        private Button Level3;
        private Button Level6;
        private Button Level5;
        private Button Level4;
    }
}