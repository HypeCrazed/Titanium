namespace Titanium
{
    partial class titanium_app
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(titanium_app));
            tabControl1 = new TabControl();
            convertTab = new TabPage();
            button3 = new Button();
            label9 = new Label();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            settingsTab = new TabPage();
            currentPathLabel = new Label();
            browsePathButton = new Button();
            label8 = new Label();
            label4 = new Label();
            qualityBox = new ComboBox();
            label3 = new Label();
            frameBox = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            formatBox = new ComboBox();
            saveButton = new Button();
            creditsPage = new TabPage();
            panel1 = new Panel();
            label10 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            openFileDialog1 = new OpenFileDialog();
            folderBrowserDialog1 = new FolderBrowserDialog();
            tabControl1.SuspendLayout();
            convertTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            settingsTab.SuspendLayout();
            creditsPage.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(convertTab);
            tabControl1.Controls.Add(settingsTab);
            tabControl1.Controls.Add(creditsPage);
            tabControl1.ItemSize = new Size(61, 25);
            tabControl1.Location = new Point(-5, -2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(509, 329);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            tabControl1.TabIndex = 0;
            // 
            // convertTab
            // 
            convertTab.BackColor = Color.FromArgb(55, 55, 55);
            convertTab.Controls.Add(button3);
            convertTab.Controls.Add(label9);
            convertTab.Controls.Add(button1);
            convertTab.Controls.Add(pictureBox1);
            convertTab.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            convertTab.Location = new Point(4, 29);
            convertTab.Name = "convertTab";
            convertTab.Padding = new Padding(3);
            convertTab.RightToLeft = RightToLeft.No;
            convertTab.Size = new Size(501, 296);
            convertTab.TabIndex = 0;
            convertTab.Text = "Convert";
            convertTab.Click += convertTab_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.BackgroundImage = Properties.Resources.OIP;
            button3.BackgroundImageLayout = ImageLayout.Zoom;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button3.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(13, 239);
            button3.Name = "button3";
            button3.Size = new Size(31, 29);
            button3.TabIndex = 5;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(107, 132);
            label9.Name = "label9";
            label9.Size = new Size(278, 25);
            label9.TabIndex = 4;
            label9.Text = "Open Source Video Downscaler";
            label9.Click += label9_Click_1;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(30, 30, 30);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(109, 176);
            button1.Name = "button1";
            button1.Size = new Size(276, 42);
            button1.TabIndex = 0;
            button1.Text = "Choose a video to downscale";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-35, -121);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(571, 421);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // settingsTab
            // 
            settingsTab.BackColor = Color.FromArgb(55, 55, 55);
            settingsTab.Controls.Add(currentPathLabel);
            settingsTab.Controls.Add(browsePathButton);
            settingsTab.Controls.Add(label8);
            settingsTab.Controls.Add(label4);
            settingsTab.Controls.Add(qualityBox);
            settingsTab.Controls.Add(label3);
            settingsTab.Controls.Add(frameBox);
            settingsTab.Controls.Add(label2);
            settingsTab.Controls.Add(label1);
            settingsTab.Controls.Add(formatBox);
            settingsTab.Controls.Add(saveButton);
            settingsTab.Location = new Point(4, 29);
            settingsTab.Name = "settingsTab";
            settingsTab.Padding = new Padding(3);
            settingsTab.Size = new Size(501, 296);
            settingsTab.TabIndex = 1;
            settingsTab.Text = "Settings";
            settingsTab.Click += settingsTab_Click;
            // 
            // currentPathLabel
            // 
            currentPathLabel.AutoSize = true;
            currentPathLabel.ForeColor = Color.White;
            currentPathLabel.Location = new Point(13, 214);
            currentPathLabel.Name = "currentPathLabel";
            currentPathLabel.Size = new Size(116, 15);
            currentPathLabel.TabIndex = 11;
            currentPathLabel.Text = "Current output path:";
            currentPathLabel.Click += label11_Click;
            // 
            // browsePathButton
            // 
            browsePathButton.BackColor = Color.FromArgb(30, 30, 30);
            browsePathButton.FlatAppearance.BorderSize = 0;
            browsePathButton.FlatStyle = FlatStyle.Flat;
            browsePathButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            browsePathButton.ForeColor = Color.White;
            browsePathButton.Location = new Point(94, 172);
            browsePathButton.Name = "browsePathButton";
            browsePathButton.Size = new Size(76, 27);
            browsePathButton.TabIndex = 10;
            browsePathButton.Text = "Browse";
            browsePathButton.UseVisualStyleBackColor = false;
            browsePathButton.Click += button4_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.White;
            label8.Location = new Point(13, 179);
            label8.Name = "label8";
            label8.Size = new Size(75, 15);
            label8.TabIndex = 9;
            label8.Text = "Output Path:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(13, 141);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 8;
            label4.Text = "Quality:";
            // 
            // qualityBox
            // 
            qualityBox.FormattingEnabled = true;
            qualityBox.Items.AddRange(new object[] { "1920x1080", "1280x720", "800x800", "720×480", "480x360" });
            qualityBox.Location = new Point(67, 138);
            qualityBox.Name = "qualityBox";
            qualityBox.Size = new Size(80, 23);
            qualityBox.TabIndex = 7;
            qualityBox.Text = "1280x720";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(13, 108);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 6;
            label3.Text = "Frame Rate:";
            // 
            // frameBox
            // 
            frameBox.FormattingEnabled = true;
            frameBox.Items.AddRange(new object[] { "60", "50", "45", "30", "24", "20", "10" });
            frameBox.Location = new Point(88, 105);
            frameBox.Name = "frameBox";
            frameBox.Size = new Size(59, 23);
            frameBox.TabIndex = 5;
            frameBox.Text = "30";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(13, 73);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 4;
            label2.Text = "Format:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(13, 21);
            label1.Name = "label1";
            label1.Size = new Size(197, 25);
            label1.TabIndex = 3;
            label1.Text = "Video Output Settings";
            // 
            // formatBox
            // 
            formatBox.FormattingEnabled = true;
            formatBox.Items.AddRange(new object[] { "mp4", "mkv", "mov", "avi", "wmv" });
            formatBox.Location = new Point(67, 70);
            formatBox.Name = "formatBox";
            formatBox.Size = new Size(59, 23);
            formatBox.TabIndex = 2;
            formatBox.Text = "mp4";
            formatBox.SelectedIndexChanged += formatBox_SelectedIndexChanged;
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.FromArgb(30, 30, 30);
            saveButton.FlatAppearance.BorderSize = 0;
            saveButton.FlatStyle = FlatStyle.Flat;
            saveButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            saveButton.ForeColor = Color.White;
            saveButton.Location = new Point(13, 240);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(197, 28);
            saveButton.TabIndex = 1;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += button3_Click;
            // 
            // creditsPage
            // 
            creditsPage.BackColor = Color.FromArgb(55, 55, 55);
            creditsPage.Controls.Add(panel1);
            creditsPage.Controls.Add(label10);
            creditsPage.Controls.Add(label7);
            creditsPage.Controls.Add(label6);
            creditsPage.Controls.Add(label5);
            creditsPage.Location = new Point(4, 29);
            creditsPage.Name = "creditsPage";
            creditsPage.Size = new Size(501, 296);
            creditsPage.TabIndex = 2;
            creditsPage.Text = "Credits";
            creditsPage.Click += creditsPage_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Location = new Point(13, 126);
            panel1.Name = "panel1";
            panel1.Size = new Size(471, 3);
            panel1.TabIndex = 8;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(60, 146);
            label10.Name = "label10";
            label10.Size = new Size(371, 45);
            label10.TabIndex = 7;
            label10.Text = "Titanium is free and always will be, if you want to support this project\r\nby making pull requests, you could have your name on this cool little\r\ncredits page :D";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.White;
            label7.Location = new Point(13, 89);
            label7.Name = "label7";
            label7.Size = new Size(120, 15);
            label7.TabIndex = 6;
            label7.Text = "FFmpeg: FFmpeg.org";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(13, 64);
            label6.Name = "label6";
            label6.Size = new Size(124, 15);
            label6.TabIndex = 5;
            label6.Text = "Titanium: HypeCrazed";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(13, 21);
            label5.Name = "label5";
            label5.Size = new Size(71, 25);
            label5.TabIndex = 4;
            label5.Text = "Credits";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // titanium_app
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(55, 55, 55);
            ClientSize = new Size(495, 307);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "titanium_app";
            Text = "Titanium v1.1";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            convertTab.ResumeLayout(false);
            convertTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            settingsTab.ResumeLayout(false);
            settingsTab.PerformLayout();
            creditsPage.ResumeLayout(false);
            creditsPage.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage convertTab;
        private TabPage settingsTab;
        private Button button1;
        private PictureBox pictureBox1;
        private ComboBox formatBox;
        private Button saveButton;
        private Label label2;
        private Label label1;
        private ComboBox frameBox;
        private Label label3;
        private Label label4;
        private ComboBox qualityBox;
        private TabPage creditsPage;
        private Label label5;
        private Label label7;
        private Label label6;
        private OpenFileDialog openFileDialog1;
        private FolderBrowserDialog folderBrowserDialog1;
        private Button browsePathButton;
        private Label label8;
        private Label label9;
        private Panel panel1;
        private Label label10;
        private Button button3;
        private Label currentPathLabel;
    }
}
