namespace _7days7nights_no_0
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            exitButton = new Button();
            settingsButton = new Button();
            inventoryButton = new Button();
            startButton = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.FromArgb(100, 240, 240, 240);
            exitButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(150, 220, 220, 220);
            exitButton.FlatStyle = FlatStyle.Flat;
            exitButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            exitButton.Location = new Point(384, 790);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(242, 75);
            exitButton.TabIndex = 0;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += button1_Click;
            // 
            // settingsButton
            // 
            settingsButton.BackColor = Color.FromArgb(100, 240, 240, 240);
            settingsButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(150, 220, 220, 220);
            settingsButton.FlatStyle = FlatStyle.Flat;
            settingsButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            settingsButton.Location = new Point(384, 597);
            settingsButton.Name = "settingsButton";
            settingsButton.Size = new Size(242, 75);
            settingsButton.TabIndex = 1;
            settingsButton.Text = "Settings";
            settingsButton.UseVisualStyleBackColor = true;
            settingsButton.Click += button2_Click;
            // 
            // inventoryButton
            // 
            inventoryButton.BackColor = Color.FromArgb(100, 240, 240, 240);
            inventoryButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(150, 220, 220, 220);
            inventoryButton.FlatStyle = FlatStyle.Flat;
            inventoryButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            inventoryButton.Location = new Point(384, 467);
            inventoryButton.Name = "inventoryButton";
            inventoryButton.Size = new Size(242, 75);
            inventoryButton.TabIndex = 2;
            inventoryButton.Text = "Inventory";
            inventoryButton.UseVisualStyleBackColor = true;
            inventoryButton.Click += inventoryButton_Click;
            // 
            // startButton
            // 
            startButton.BackColor = Color.FromArgb(100, 240, 240, 240);
            startButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(150, 220, 220, 220);
            startButton.FlatStyle = FlatStyle.Flat;
            startButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            startButton.Location = new Point(384, 342);
            startButton.Name = "startButton";
            startButton.Size = new Size(242, 75);
            startButton.TabIndex = 3;
            startButton.Text = "Start";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Yu Gothic", 39.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.ForeColor = Color.FromArgb(192, 0, 0);
            label1.Location = new Point(337, 113);
            label1.Name = "label1";
            label1.Size = new Size(384, 68);
            label1.TabIndex = 4;
            label1.Text = "7days 7nights";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1024, 1024);
            ControlBox = false;
            Controls.Add(label1);
            Controls.Add(startButton);
            Controls.Add(inventoryButton);
            Controls.Add(settingsButton);
            Controls.Add(exitButton);
            Cursor = Cursors.Cross;
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(1024, 1024);
            MinimumSize = new Size(1024, 1024);
            Name = "MenuForm";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button exitButton;
        private Button settingsButton;
        private Button inventoryButton;
        private Button startButton;
        private Label label1;
    }
}
