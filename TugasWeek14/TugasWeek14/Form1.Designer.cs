
namespace TugasWeek14
{
    partial class FormQuiz
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelkalimat = new System.Windows.Forms.Label();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.labelhuruf1 = new System.Windows.Forms.Label();
            this.textBoxhuruf1 = new System.Windows.Forms.TextBox();
            this.labelhuruf2 = new System.Windows.Forms.Label();
            this.textBoxhuruf2 = new System.Windows.Forms.TextBox();
            this.buttonconvert = new System.Windows.Forms.Button();
            this.labelHasil = new System.Windows.Forms.Label();
            this.labelOutput = new System.Windows.Forms.Label();
            this.buttonKeluh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelkalimat
            // 
            this.labelkalimat.AutoSize = true;
            this.labelkalimat.Location = new System.Drawing.Point(25, 41);
            this.labelkalimat.Name = "labelkalimat";
            this.labelkalimat.Size = new System.Drawing.Size(94, 13);
            this.labelkalimat.TabIndex = 0;
            this.labelkalimat.Text = "Masukkan Kalimat";
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(125, 38);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(194, 20);
            this.textBoxInput.TabIndex = 1;
            // 
            // labelhuruf1
            // 
            this.labelhuruf1.AutoSize = true;
            this.labelhuruf1.Location = new System.Drawing.Point(28, 88);
            this.labelhuruf1.Name = "labelhuruf1";
            this.labelhuruf1.Size = new System.Drawing.Size(84, 13);
            this.labelhuruf1.TabIndex = 2;
            this.labelhuruf1.Text = "Masukkan huruf";
            // 
            // textBoxhuruf1
            // 
            this.textBoxhuruf1.Location = new System.Drawing.Point(125, 85);
            this.textBoxhuruf1.Name = "textBoxhuruf1";
            this.textBoxhuruf1.Size = new System.Drawing.Size(69, 20);
            this.textBoxhuruf1.TabIndex = 3;
            // 
            // labelhuruf2
            // 
            this.labelhuruf2.AutoSize = true;
            this.labelhuruf2.Location = new System.Drawing.Point(200, 88);
            this.labelhuruf2.Name = "labelhuruf2";
            this.labelhuruf2.Size = new System.Drawing.Size(44, 13);
            this.labelhuruf2.TabIndex = 4;
            this.labelhuruf2.Text = "Menjadi";
            // 
            // textBoxhuruf2
            // 
            this.textBoxhuruf2.Location = new System.Drawing.Point(250, 85);
            this.textBoxhuruf2.Name = "textBoxhuruf2";
            this.textBoxhuruf2.Size = new System.Drawing.Size(69, 20);
            this.textBoxhuruf2.TabIndex = 5;
            // 
            // buttonconvert
            // 
            this.buttonconvert.Location = new System.Drawing.Point(125, 136);
            this.buttonconvert.Name = "buttonconvert";
            this.buttonconvert.Size = new System.Drawing.Size(194, 23);
            this.buttonconvert.TabIndex = 6;
            this.buttonconvert.Text = "Konversikan!!";
            this.buttonconvert.UseVisualStyleBackColor = true;
            this.buttonconvert.Click += new System.EventHandler(this.buttonconvert_Click);
            // 
            // labelHasil
            // 
            this.labelHasil.AutoSize = true;
            this.labelHasil.Location = new System.Drawing.Point(28, 180);
            this.labelHasil.Name = "labelHasil";
            this.labelHasil.Size = new System.Drawing.Size(36, 13);
            this.labelHasil.TabIndex = 7;
            this.labelHasil.Text = "Hasil: ";
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Location = new System.Drawing.Point(84, 195);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(0, 13);
            this.labelOutput.TabIndex = 8;
            // 
            // buttonKeluh
            // 
            this.buttonKeluh.Location = new System.Drawing.Point(678, 415);
            this.buttonKeluh.Name = "buttonKeluh";
            this.buttonKeluh.Size = new System.Drawing.Size(110, 23);
            this.buttonKeluh.TabIndex = 9;
            this.buttonKeluh.Text = "KELUH KESAH";
            this.buttonKeluh.UseVisualStyleBackColor = true;
            this.buttonKeluh.Click += new System.EventHandler(this.buttonKeluh_Click);
            // 
            // FormQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonKeluh);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.labelHasil);
            this.Controls.Add(this.buttonconvert);
            this.Controls.Add(this.textBoxhuruf2);
            this.Controls.Add(this.labelhuruf2);
            this.Controls.Add(this.textBoxhuruf1);
            this.Controls.Add(this.labelhuruf1);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.labelkalimat);
            this.Name = "FormQuiz";
            this.Text = "Quiz Panda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelkalimat;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Label labelhuruf1;
        private System.Windows.Forms.TextBox textBoxhuruf1;
        private System.Windows.Forms.Label labelhuruf2;
        private System.Windows.Forms.TextBox textBoxhuruf2;
        private System.Windows.Forms.Button buttonconvert;
        private System.Windows.Forms.Label labelHasil;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.Button buttonKeluh;
    }
}

