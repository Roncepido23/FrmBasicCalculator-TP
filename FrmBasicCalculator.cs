using CalculatorPrivateAssembly;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicCalculator
{
    public partial class FrmBasicCalculator : Form
    {
        public FrmBasicCalculator()
        {
            InitializeComponent();
        }

        private void FrmBasicCalculator_Load(object sender, EventArgs e)
        {
            var operations = new List<string> { "+", "-", "*", "/" };

            foreach (var operation in operations) cbOperation.Items.Add(operation);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int num1 = Convert.ToInt32(tbInput1.Text);
                int num2 = Convert.ToInt32(tbInput2.Text);
                string operation = cbOperation.SelectedItem.ToString();
                string result = "None";

                Console.WriteLine($"Current operation: {operation}");

                switch (operation)
                {
                    case "+":
                        result = BasicComputation.Addition(num1, num2).ToString();
                        break;

                    case "-":
                        result = BasicComputation.Subtraction(num1, num2).ToString();
                        break;

                    case"/":
                        result = BasicComputation.Division(num1, num2).ToString();
                        break;

                    case "*":
                        result = BasicComputation.Multiplication(num1, num2).ToString();
                        break;

                    default:
                        result = "Invalid operation selected.";
                        break;
                }
 
                MessageBox.Show("Result: " + result);
                rtbTotal.Text = $"Total:\n{result}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred: " + ex.Message);
            }

        }
    }
}
