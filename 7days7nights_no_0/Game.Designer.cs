namespace _7days7nights_no_0
{
    partial class Game
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
            GameTImer = new System.Windows.Forms.Timer(components);
            txtammo = new Label();
            txtscore = new Label();
            txthealth = new Label();
            healthBar = new ProgressBar();
            SuspendLayout();
            // 
            // GameTImer
            // 
            GameTImer.Enabled = true;
            GameTImer.Interval = 20;
            GameTImer.Tick += MainTimerEvent;
            // 
            // txtammo
            // 
            txtammo.AutoSize = true;
            txtammo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            txtammo.ForeColor = Color.White;
            txtammo.Location = new Point(13, 15);
            txtammo.Margin = new Padding(4, 0, 4, 0);
            txtammo.Name = "txtammo";
            txtammo.Size = new Size(142, 40);
            txtammo.TabIndex = 0;
            txtammo.Text = "Ammo: 0";
            // 
            // txtscore
            // 
            txtscore.AutoSize = true;
            txtscore.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            txtscore.ForeColor = Color.White;
            txtscore.Location = new Point(576, 13);
            txtscore.Margin = new Padding(4, 0, 4, 0);
            txtscore.Name = "txtscore";
            txtscore.Size = new Size(106, 40);
            txtscore.TabIndex = 1;
            txtscore.Text = "Kills: 0";
            // 
            // txthealth
            // 
            txthealth.AutoSize = true;
            txthealth.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            txthealth.ForeColor = Color.White;
            txthealth.Location = new Point(949, 15);
            txthealth.Margin = new Padding(4, 0, 4, 0);
            txthealth.Name = "txthealth";
            txthealth.Size = new Size(107, 40);
            txthealth.TabIndex = 2;
            txthealth.Text = "Health";
            // 
            // healthBar
            // 
            healthBar.Location = new Point(1061, 23);
            healthBar.Margin = new Padding(4, 5, 4, 5);
            healthBar.Name = "healthBar";
            healthBar.Size = new Size(241, 38);
            healthBar.TabIndex = 3;
            healthBar.Value = 100;
            // 
            // Game
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(2720, 1268);
            Controls.Add(healthBar);
            Controls.Add(txthealth);
            Controls.Add(txtscore);
            Controls.Add(txtammo);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Game";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Game_Load;
            Paint += CharacterPaintEvent;
            KeyDown += KeyIsDown;
            KeyUp += KeyIsUp;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer GameTImer;
        private Label txtammo;
        private Label txtscore;
        private Label txthealth;
        private ProgressBar healthBar;
    }
}