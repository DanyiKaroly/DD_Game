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
            InventoryButton.Location = new Point(91, 143);
            InventoryButton.Margin = new Padding(4, 5, 4, 5);
            InventoryButton.Name = "InventoryButton";
            InventoryButton.Size = new Size(203, 118);
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
            SkillsButton.Location = new Point(480, 143);
            SkillsButton.Margin = new Padding(4, 5, 4, 5);
            SkillsButton.Name = "SkillsButton";
            SkillsButton.Size = new Size(203, 118);
            SkillsButton.TabIndex = 1;
            SkillsButton.Text = "Skills";
            SkillsButton.UseVisualStyleBackColor = true;
            SkillsButton.Click += SkillsButton_Click;
            // 
            // BackButton
            // 
            BackButton.BackColor = Color.FromArgb(100, 240, 240, 240);
            BackButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(150, 220, 220, 220);
            BackButton.FlatStyle = FlatStyle.Flat;
            BackButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            BackButton.Location = new Point(303, 285);
            BackButton.Margin = new Padding(4, 5, 4, 5);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(169, 100);
            BackButton.TabIndex = 2;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // InventoryPerSkills
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(776, 440);
            Controls.Add(BackButton);
            Controls.Add(SkillsButton);
            Controls.Add(InventoryButton);
            Cursor = Cursors.Cross;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
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