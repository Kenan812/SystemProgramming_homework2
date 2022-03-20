using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace SystemProgramming_homework2
{
    public partial class Ex5Form : Form
    {
        public Ex5Form()
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
                ThreadPool.QueueUserWorkItem(FillResultTextBox, true);
            }
        }
        private void FillResultTextBox(object sender)
        {
            if (_path != String.Empty && _word != String.Empty)
            {
                CountResult(_path);
            }
        }

        private void CountResult(string dirPath)
        {
            string[] namesOfFiles = Directory.GetFiles(dirPath);

            // Counting word in files
            foreach (string fName in namesOfFiles)
            {
                try
                {
                    string content = File.ReadAllText(fName);
                    var arr = content.Split(new char[] { ' ', '.' });
                    var count = Array.FindAll(arr, s => s.Equals(_word.Trim())).Length;
                    resultTextBox.Text += "-|-|-|- " + fName + " --- " + count.ToString()+ " ---|||  ";
                }
                catch (Exception)
                { }
            }

            var directories = Directory.GetDirectories(dirPath);
            foreach (string dName in directories)
            {
                CountResult(dName);
            }

        }


    }
}
