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
            if (DateTime.Parse(textBox_dateDeNaissance.Text) <= DateTime.Today.AddYears(-18))
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
