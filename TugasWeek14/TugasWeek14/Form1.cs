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
            textBoxInput.CharacterCasing = CharacterCasing.Upper;

            char[] input = textBoxInput.Text.ToCharArray();
            string output = " ";

            char[] huruf1 = textBoxhuruf1.Text.ToCharArray();
            char no1 = Convert.ToChar(textBoxhuruf1.Text); 

            char[] huruf2 = textBoxhuruf2.Text.ToCharArray();
            char no2 = huruf2[0];

            string huruf = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            char[] hurufurut = huruf.ToCharArray();

            int selisih = no2 - no1;
            if (selisih < 0)
            {
                selisih += 26;
            }

            for (int i = 0; i < textBoxInput.Text.Length; i++)
            {
                for (int j = 0; j < 26; j++)
                {
                    if (hurufurut[j] == input[i])
                    {
                        int reset = j + selisih;
                        if (reset >= 26)
                        {
                            reset -= 26;
                        }
                        input[i] = hurufurut[reset];

                        output += input[i];

                        
                        input[i] = 'a';


                    }
                    if (input[i] == ' ')
                    {
                        output += " ";
                        input[i] = 'a';
                    }
                }
            }

            labelOutput.Text = output;
            
        }

        private void buttonKeluh_Click(object sender, EventArgs e)
        {
            MessageBox.Show("MERRY CHRISTMAS AND HAPPY NEW YEAR :) " +
                "LAIN KALI KALO LIBURAN JANGAN SUSAH SUSAH TUGASNYAAA");
        }
    }
}
