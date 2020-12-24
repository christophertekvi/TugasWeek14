using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasWeek14
{
    public partial class FormQuiz : Form
    {
        public FormQuiz()
        {
            InitializeComponent();
        }

        private void buttonconvert_Click(object sender, EventArgs e)
        {
            string[] alphabet = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", 
                "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"};
            

            string[] input = new string[textBoxInput.Text.Length];

            for (int i = 0; i < textBoxInput.Text.Length; i++)
            {
                input[i] = textBoxInput.Text.Substring(i, 1);
            }


            char[] output = new char[textBoxInput.Text.Length];

            for (int i = 0; i < textBoxInput.Text.Length; i++)
            {
                output[i] = Convert.ToChar(input[i]);
            }

            string output2 = new string(output);

            labelOutput.Text = output2;

        }

        private void buttonKeluh_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tolong aku ga ngerti quiz pandaaa!!");
        }
    }
}
