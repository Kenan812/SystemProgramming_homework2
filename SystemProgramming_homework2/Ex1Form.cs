using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemProgramming_homework2
{
    public partial class Ex1Form : Form
    {
        public Ex1Form()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (nTxtBox.Text != String.Empty)
                {
                    int n = Int32.Parse(nTxtBox.Text);

                    if (n < 1 || n >= 8)
                    {
                        MessageBox.Show("Too few or many bars");
                        return;
                    }


                    for (int i = 0; i < n; i++)
                    {
                        Random rnd = new Random();

                        ProgressBar progressBar = new ProgressBar();
                        progressBar.Step = rnd.Next(1, 5);
                        progressBar.Width = 700;
                        progressBar.Minimum = 0;
                        progressBar.Maximum = 700;
                        progressBar.Left = 20;
                        progressBar.Top = 45 + 20*(i+1) + 15*i;

                        progressBar.Value = 0;
                        progressBar.ForeColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                        progressBar.Enabled = true;
                        progressBar.Visible = true;

                        pBarGroupBox.Controls.Add(progressBar);
                        progressBar.Show();

                        ThreadPool.QueueUserWorkItem(StartDancing, progressBar);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Message: {ex.Message}\n\nStack Trace: {ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void StartDancing(object obj)
        {
            try
            {
                ProgressBar progressBar = obj as ProgressBar;

                Random rnd = new Random();

                while (progressBar.Value != progressBar.Maximum)
                {
                    progressBar.PerformStep();
                    Thread.Sleep(rnd.Next(50, 200));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Message: {ex.Message}\n\nStack Trace: {ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
