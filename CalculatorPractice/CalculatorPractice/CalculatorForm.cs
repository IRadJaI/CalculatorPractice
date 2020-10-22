using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CalculatorPractice
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            labelResult.Text = $"{Calculator.Plus(textBoxFirst.Text, textBoxSecond.Text)}";
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            labelResult.Text = $"{Calculator.Minus(textBoxFirst.Text, textBoxSecond.Text)}";
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            labelResult.Text = $"{Calculator.Multiply(textBoxFirst.Text, textBoxSecond.Text)}";
        }

        private void buttonDevide_Click(object sender, EventArgs e)
        {
            labelResult.Text = $"{Calculator.Devide(textBoxFirst.Text, textBoxSecond.Text)}";
        }
    }
}
