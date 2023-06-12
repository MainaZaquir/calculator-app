using System;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void EvaluateExpression()
        {
            try
            {
                double result = Eval(entryTextBox.Text);
                resultLabel.Text = "Result: " + result;
            }
            catch
            {
                resultLabel.Text = "Invalid expression";
            }
        }

        private double Eval(string expression)
        {
            return Convert.ToDouble(new System.Data.DataTable().Compute(expression, ""));
        }

        private void evaluateButton_Click(object sender, EventArgs e)
        {
            EvaluateExpression();
        }
    }
}
