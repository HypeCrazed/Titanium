using System;
using System.Diagnostics;
using System.Linq.Expressions;

namespace Titanium
{
    public partial class titanium_app : Form
    {
        public titanium_app()
        {
            
            InitializeComponent();
            formatBox.SelectedItem = File.ReadAllText("format.txt");
            frameBox.SelectedItem = File.ReadAllText("framerate.txt");
            qualityBox.SelectedItem = File.ReadAllText("quality.txt");

            string outputPath = File.ReadAllText("output_path.txt").Trim();

            currentPathLabel.Text = $"Current output path: {outputPath}";

        }


        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string outputPathCheck = File.ReadAllText("output_path.txt").Trim();

            if (!string.IsNullOrEmpty(outputPathCheck))
            {
                openFileDialog1 = new OpenFileDialog();

                openFileDialog1.Title = "Titanium | Select the video you want to downscale.";
                openFileDialog1.InitialDirectory = @"C:\\";
                openFileDialog1.Filter = "Video Files|*.avi;*.mp4;*.mov;*.wmv;*.flv;*.mkv|All Files|*.*";
                openFileDialog1.ShowDialog();


                string videoPath = openFileDialog1.FileName;

                string outputPath = File.ReadAllText("output_path.txt").Trim();
                string formatTXT = File.ReadAllText("format.txt").Trim();
                string framerateTXT = File.ReadAllText("framerate.txt").Trim();
                string qualityTXT = File.ReadAllText("quality.txt").Trim();

                string convert = $"/c ffmpeg -i \"{videoPath}\" -vf scale={qualityTXT} -r {framerateTXT} -c:v libx264 -crf 18 \"{outputPath}\\titanium_output.{formatTXT}\"";

                Process.Start("cmd.exe", convert);
            }
            else
            {
                MessageBox.Show("It seems you haven't selected an output path, you will now be prompted to select one.", "Output Path Error");
                button4_Click(sender, e);
            }



                                   
        }

        private void convertTab_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1 = new FolderBrowserDialog();

            openFileDialog1.Title = "Titanium | Select the folder you want your videos to be saved to.";
            openFileDialog1.InitialDirectory = @"C:\\";
            folderBrowserDialog1.ShowDialog();

            string outputPath = folderBrowserDialog1.SelectedPath;

            File.WriteAllText("output_path.txt", outputPath);

            MessageBox.Show($"Your videos will now save to {outputPath}", "Output path saved!");

            currentPathLabel.Text = $"Current output path: {outputPath}";
        }

        private void button3_Click(object sender, EventArgs e)
        {


            string formatSave = formatBox.Text;
            string frameSave = frameBox.Text;
            string qualitySave = qualityBox.Text;

            File.WriteAllText("format.txt", formatBox.Text);
            File.WriteAllText("framerate.txt", frameBox.Text);
            File.WriteAllText("quality.txt", qualityBox.Text);

            MessageBox.Show("Your settings have been saved.", "Settings saved!");

        }

        private void formatBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void settingsTab_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click_1(object sender, EventArgs e)
        {

        }

        private void creditsPage_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            string githubUrl = "https://github.com/hypecrazed/titanium";

            Process.Start(new ProcessStartInfo(githubUrl) { UseShellExecute = true });
        }

        private void label11_Click(object sender, EventArgs e)
        {
            
        }
    }
}
