using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace onequestionquiz
{
    public partial class frmOneQuestionQuiz : Form
    {
        public frmOneQuestionQuiz()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            lblResult.Text= "incorrect";
            

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            lblResult.Text = "incorrect";

        }

        private void rdoDemi_CheckedChanged(object sender, EventArgs e)
        {
            lblResult.Text = "correct";

        }
    }
}
