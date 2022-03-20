using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SystemProgramming_homework2
{
    public partial class Ex4Form : Form
    {
        public Ex4Form()
        {
            InitializeComponent();
        }

        private string _path = String.Empty;
        private string _word = String.Empty;

        private void button1_Click(object sender, EventArgs e)
        {
            if (filePathTxtBox.Text != String.Empty && wordToFindTxtBox.Text != String.Empty)
            {
                _path = filePathTxtBox.Text;
                _word = wordToFindTxtBox.Text;
                ThreadPool.QueueUserWorkItem(CountOccurences, true);
            }
        }

        private void CountOccurences(object sender)
        {
            if (_path != String.Empty && _word != String.Empty)
            {
                string content = File.ReadAllText(_path);
                var arr = content.Split(new char[] { ' ', '.' });
                var count = Array.FindAll(arr, s => s.Equals(_word.Trim())).Length;
                nbOfOccurTxtBox.Text = count.ToString();
            }
        }

    }
}
