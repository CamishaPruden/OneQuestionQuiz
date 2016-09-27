using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OneQuestionQuiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            lblResult.Text = "that is correct good guess";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rdoCountry_CheckedChanged(object sender, EventArgs e)
        {
            lblResult.Text = "that is incorrect please try again";
        }

        private void rdoRock_CheckedChanged(object sender, EventArgs e)
        {
            lblResult.Text = "that is incorrec please try againt";
        }

        private void rdoHipHop_CheckedChanged(object sender, EventArgs e)
        {
            lblResult.Text = "that is incorrect please try again";
        }

        private void rdoClassical_CheckedChanged(object sender, EventArgs e)
        {
            lblResult.Text = "that is incorrect please try again";
        }

        private void rdoJazz_CheckedChanged(object sender, EventArgs e)
        {
            lblResult.Text = "that is incorrect please try again";
        }
    }
}
