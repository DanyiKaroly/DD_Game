namespace Demo
{
    partial class Sound
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sound));
            volumeTrackBar = new TrackBar();
            folderBrowserDialog1 = new FolderBrowserDialog();
            panel1 = new Panel();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            volumeTrackBar2 = new TrackBar();
            button2 = new Button();
            button3 = new Button();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)volumeTrackBar).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)volumeTrackBar2).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // volumeTrackBar
            // 
            volumeTrackBar.BackColor = SystemColors.ControlDarkDark;
            volumeTrackBar.Location = new Point(14, 85);
            volumeTrackBar.Margin = new Padding(4, 5, 4, 5);
            volumeTrackBar.Maximum = 100;
            volumeTrackBar.Name = "volumeTrackBar";
            volumeTrackBar.Size = new Size(263, 69);
            volumeTrackBar.TabIndex = 0;
            volumeTrackBar.TickFrequency = 10;
            volumeTrackBar.Value = 50;
            volumeTrackBar.Scroll += volumeTrackBar_Scroll;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 2);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(301, 1705);
            panel1.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            button1.Location = new Point(34, 1555);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(223, 113);
            button1.TabIndex = 1;
            button1.Text = "Exit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Mongolian Baiti", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(34, 40);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(184, 50);
            label1.TabIndex = 0;
            label1.Text = "Settings";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Mongolian Baiti", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(14, 42);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(202, 34);
            label2.TabIndex = 2;
            label2.Text = "Music sounds";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Mongolian Baiti", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(14, 238);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(222, 34);
            label3.TabIndex = 4;
            label3.Text = "Effects Sounds";
            // 
            // volumeTrackBar2
            // 
            volumeTrackBar2.BackColor = SystemColors.ControlDarkDark;
            volumeTrackBar2.Location = new Point(14, 282);
            volumeTrackBar2.Margin = new Padding(4, 5, 4, 5);
            volumeTrackBar2.Maximum = 100;
            volumeTrackBar2.Name = "volumeTrackBar2";
            volumeTrackBar2.Size = new Size(263, 69);
            volumeTrackBar2.TabIndex = 3;
            volumeTrackBar2.TickFrequency = 10;
            volumeTrackBar2.Value = 50;
            volumeTrackBar2.Scroll += volumeTrackBar2_Scroll;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            button2.Location = new Point(286, 85);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(177, 75);
            button2.TabIndex = 2;
            button2.Text = "TestMusic";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaption;
            button3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            button3.Location = new Point(286, 282);
            button3.Margin = new Padding(4, 3, 4, 3);
            button3.Name = "button3";
            button3.Size = new Size(177, 75);
            button3.TabIndex = 5;
            button3.Text = "TestSFX";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Silver;
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(volumeTrackBar2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(volumeTrackBar);
            panel2.Location = new Point(313, 42);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(566, 428);
            panel2.TabIndex = 6;
            panel2.Paint += panel2_Paint;
            // 
            // Sound
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1463, 1649);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            MaximumSize = new Size(1463, 1707);
            MinimumSize = new Size(1463, 1006);
            Name = "Sound";
            ShowIcon = false;
            ShowInTaskbar = false;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)volumeTrackBar).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)volumeTrackBar2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private FolderBrowserDialog folderBrowserDialog1;
        private Panel panel1;
        private Label label1;
        private Label label2;
        public TrackBar volumeTrackBar;
        private Label label3;
        public TrackBar volumeTrackBar2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Panel panel2;
    }
}