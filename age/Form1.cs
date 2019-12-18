using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace age
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Maximum = 10;
            progressBar1.Minimum = 0;
            progressBar1.Step = 1;

            while (this.label_result.Text == "result")
            {
                progressBar1.PerformStep();
            }


            if (DateTime.Parse(textBox_dateDeNaissance.Text) <= DateTime.Today.AddYears(-18) & DateTime.Parse(textBox_dateDeNaissance.Text) >= DateTime.Today.AddYears(-25))
            {
                label_result.Text = "19-25";
            }
            else if (DateTime.Parse(textBox_dateDeNaissance.Text) < DateTime.Today.AddYears(-18))
            {
                label_result.Text = "Majeur";
            }
            else
            {
                label_result.Text = "Mineur";
            }
        }
    }
}
