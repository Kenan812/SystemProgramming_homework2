using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace SystemProgramming_homework2
{
    public partial class Ex2Form : Form
    {
        private List<int> winners = new List<int>();

        public Ex2Form()
        {
            InitializeComponent();

            horse1.Maximum = 1000;
            horse2.Maximum = 1000;
            horse3.Maximum = 1000;
            horse4.Maximum = 1000;
            horse5.Maximum = 1000;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            ThreadPool.QueueUserWorkItem(StartRunning, horse1);
            ThreadPool.QueueUserWorkItem(StartRunning, horse2);
            ThreadPool.QueueUserWorkItem(StartRunning, horse3);
            ThreadPool.QueueUserWorkItem(StartRunning, horse4);
            ThreadPool.QueueUserWorkItem(StartRunning, horse5);
        }

        private void StartRunning(object obj)
        {
            try
            {
                ProgressBar pb = obj as ProgressBar;

                Random rnd = new Random();

                while (pb.Value != pb.Maximum)
                {
                    pb.Step = rnd.Next(1, 50);
                    pb.PerformStep();
                    Thread.Sleep(rnd.Next(50, 200));
                }

                if (firstPlaceLabel.Text == String.Empty)
                {
                    if (pb.Name == "horse1") firstPlaceLabel.Text = "Horse 1";
                    if (pb.Name == "horse2") firstPlaceLabel.Text = "Horse 2";
                    if (pb.Name == "horse3") firstPlaceLabel.Text = "Horse 3";
                    if (pb.Name == "horse4") firstPlaceLabel.Text = "Horse 4";
                    if (pb.Name == "horse5") firstPlaceLabel.Text = "Horse 5";
                }

                else if (secondPlaceLabel.Text == String.Empty)
                {
                    if (pb.Name == "horse1") secondPlaceLabel.Text = "Horse 1";
                    if (pb.Name == "horse2") secondPlaceLabel.Text = "Horse 2";
                    if (pb.Name == "horse3") secondPlaceLabel.Text = "Horse 3";
                    if (pb.Name == "horse4") secondPlaceLabel.Text = "Horse 4";
                    if (pb.Name == "horse5") secondPlaceLabel.Text = "Horse 5";
                }

                else if (thirdPlaceLabel.Text == String.Empty)
                {
                    if (pb.Name == "horse1") thirdPlaceLabel.Text = "Horse 1";
                    if (pb.Name == "horse2") thirdPlaceLabel.Text = "Horse 2";
                    if (pb.Name == "horse3") thirdPlaceLabel.Text = "Horse 3";
                    if (pb.Name == "horse4") thirdPlaceLabel.Text = "Horse 4";
                    if (pb.Name == "horse5") thirdPlaceLabel.Text = "Horse 5";
                }                                                       
                                                                        
                else if (forthPlaceLabel.Text == String.Empty)          
                {                                                       
                    if (pb.Name == "horse1") forthPlaceLabel.Text = "Horse 1";
                    if (pb.Name == "horse2") forthPlaceLabel.Text = "Horse 2";
                    if (pb.Name == "horse3") forthPlaceLabel.Text = "Horse 3";
                    if (pb.Name == "horse4") forthPlaceLabel.Text = "Horse 4";
                    if (pb.Name == "horse5") forthPlaceLabel.Text = "Horse 5";
                }                                                         
                                                                          
                else if (fifthPlaceLabel.Text == String.Empty)            
                {                                                         
                    if (pb.Name == "horse1") fifthPlaceLabel.Text = "Horse 1";
                    if (pb.Name == "horse2") fifthPlaceLabel.Text = "Horse 2";
                    if (pb.Name == "horse3") fifthPlaceLabel.Text = "Horse 3";
                    if (pb.Name == "horse4") fifthPlaceLabel.Text = "Horse 4";
                    if (pb.Name == "horse5") fifthPlaceLabel.Text = "Horse 5";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Message: {ex.Message}\n\nStack Trace: {ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
