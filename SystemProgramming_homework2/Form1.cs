using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemProgramming_homework2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ex1Button_Click(object sender, EventArgs e)
        {
            Ex1Form ex1Form = new Ex1Form();
            ex1Form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ex2Form ex2Form = new Ex2Form();
            ex2Form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ex3Form ex3Form = new Ex3Form();
            ex3Form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ex4Form ex4Form = new Ex4Form();
            ex4Form.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Ex5Form ex5Form = new Ex5Form();
            ex5Form.ShowDialog();
        }
    }
}
