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
            labelOutput.Text = textBoxInput.Text;

            string[] array = new string[10];
        }

        private void buttonKeluh_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tolong aku ga ngerti quiz pandaaa!!");
        }
    }
}
