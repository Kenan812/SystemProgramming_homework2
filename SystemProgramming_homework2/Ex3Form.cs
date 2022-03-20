using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SystemProgramming_homework2
{
    public partial class Ex3Form : Form
    {
        public Ex3Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (upperBoundTextBox.Text != String.Empty)
            {
                ThreadPool.QueueUserWorkItem(WriteNumbers, upperBoundTextBox.Text);
            }
        }

        private void WriteNumbers(object sender)
        {
            long upperBound = 0;
            try
            {
                upperBound = long.Parse( sender.ToString());
            }
            catch (Exception) { }

            long first = 0;
            long second = 1;
            numbersTextBox.Text += "0 ";
            Thread.Sleep(500);

            while (second <= upperBound)
            {
                numbersTextBox.Text += second.ToString() + " ";
                long nxt = GetNextFibonacci(first, second);
                first = second;
                second = nxt;
                Thread.Sleep(500);
            }
        }

        private long GetNextFibonacci(long prev, long curr)
        {
            return prev + curr;
        }
    }
}
