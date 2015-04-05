using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class CalculatorUI : Form
    {
        private double firstNo = 0;
        private double secondNo = 0;
        private double result = 0;
        public CalculatorUI()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            firstNo = Convert.ToDouble(firstNumberTextBox.Text);
            secondNo = Convert.ToDouble(secondNumberTextBox.Text);
            result = firstNo + secondNo;
            resultTextBox.Text = result.ToString();
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            firstNo = Convert.ToDouble(firstNumberTextBox.Text);
            secondNo = Convert.ToDouble(secondNumberTextBox.Text);
            result = firstNo - secondNo;
            resultTextBox.Text = result.ToString();
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            firstNo = Convert.ToDouble(firstNumberTextBox.Text);
            secondNo = Convert.ToDouble(secondNumberTextBox.Text);
            result = firstNo * secondNo;
            resultTextBox.Text = result.ToString();
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            firstNo = Convert.ToDouble(firstNumberTextBox.Text);
            secondNo = Convert.ToDouble(secondNumberTextBox.Text);
            result = firstNo / secondNo;
            resultTextBox.Text = result.ToString();
        }

        private void CalculatorUI_Load(object sender, EventArgs e)
        {

        }
    }
}
