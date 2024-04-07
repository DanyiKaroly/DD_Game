namespace _7days7nights_no_0
{
    partial class InventoryPerSkills
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryPerSkills));
            InventoryButton = new Button();
            SkillsButton = new Button();
            BackButton = new Button();
            SuspendLayout();
            // 
            // InventoryButton
            // 
            InventoryButton.BackColor = Color.FromArgb(100, 240, 240, 240);
            InventoryButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(150, 220, 220, 220);
            InventoryButton.FlatStyle = FlatStyle.Flat;
            InventoryButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            InventoryButton.Location = new Point(64, 86);
            InventoryButton.Name = "InventoryButton";
            InventoryButton.Size = new Size(142, 71);
            InventoryButton.TabIndex = 0;
            InventoryButton.Text = "Inventory";
            InventoryButton.UseVisualStyleBackColor = true;
            // 
            // SkillsButton
            // 
            SkillsButton.BackColor = Color.FromArgb(100, 240, 240, 240);
            SkillsButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(150, 220, 220, 220);
            SkillsButton.FlatStyle = FlatStyle.Flat;
            SkillsButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            SkillsButton.Location = new Point(336, 86);
            SkillsButton.Name = "SkillsButton";
            SkillsButton.Size = new Size(142, 71);
            SkillsButton.TabIndex = 1;
            SkillsButton.Text = "Skills";
            SkillsButton.UseVisualStyleBackColor = true;
            // 
            // BackButton
            // 
            BackButton.BackColor = Color.FromArgb(100, 240, 240, 240);
            BackButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(150, 220, 220, 220);
            BackButton.FlatStyle = FlatStyle.Flat;
            BackButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            BackButton.Location = new Point(212, 171);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(118, 60);
            BackButton.TabIndex = 2;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // InventoryPerSkills
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(543, 264);
            Controls.Add(BackButton);
            Controls.Add(SkillsButton);
            Controls.Add(InventoryButton);
            Cursor = Cursors.Cross;
            FormBorderStyle = FormBorderStyle.None;
            Name = "InventoryPerSkills";
            ShowIcon = false;
            ShowInTaskbar = false;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InventoryPerSkills";
            Load += InventoryPerSkills_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button InventoryButton;
        private Button SkillsButton;
        private Button BackButton;
    }
}