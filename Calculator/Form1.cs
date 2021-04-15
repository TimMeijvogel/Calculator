using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double firstNumberDouble;
        double secondNumberDouble;
        decimal firstNumberDecimal;
        decimal secondNumberDecimal;
        double resultDouble;
        decimal resultDecimal;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PlusButton_Click(object sender, EventArgs e)
        {
            ReadNumbers();
            resultDouble = firstNumberDouble + secondNumberDouble;
            resultDecimal = firstNumberDecimal + secondNumberDecimal;
            DisplayResult();
            
        }

        private void MinButton_Click(object sender, EventArgs e)
        {
            ReadNumbers();
            resultDouble = firstNumberDouble - secondNumberDouble;
            resultDecimal = firstNumberDecimal - secondNumberDecimal;
            DisplayResult();
        }

        private void KeerButton_Click(object sender, EventArgs e)
        {
            ReadNumbers();
            resultDouble = firstNumberDouble * secondNumberDouble;
            resultDecimal = firstNumberDecimal * secondNumberDecimal;
            DisplayResult();
        }

        private void DeelButton_Click(object sender, EventArgs e)
        {
            ReadNumbers();
            resultDouble = firstNumberDouble / secondNumberDouble;
            CatchDevisionErrors();
            resultDecimal = firstNumberDecimal / secondNumberDecimal;
            CatchDevisionErrorsDecimal();
            DisplayResult();
        }

        private void RootButton_Click(object sender, EventArgs e)
        {
            firstNumberDouble = Convert.ToDouble(FirstNumberTextBox.Text);
            firstNumberDecimal = Convert.ToDecimal(FirstNumberTextBox.Text);
            DisplayRootResult();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            FirstNumberTextBox.Clear();
            SecondNumberTextBox.Clear();
            DoubleTextBox.Clear();
            DecimalTextBox.Clear();
        }

        void ReadNumbers() 
        {
            firstNumberDouble = Convert.ToDouble(FirstNumberTextBox.Text);
            secondNumberDouble = Convert.ToDouble(SecondNumberTextBox.Text);
            firstNumberDecimal = Convert.ToDecimal(FirstNumberTextBox.Text);
            secondNumberDecimal = Convert.ToDecimal(SecondNumberTextBox.Text);
        }

        void DisplayResult()
        {
            DoubleTextBox.Text = resultDouble.ToString();
            DecimalTextBox.Text = resultDecimal.ToString();
        }

        void DisplayRootResult()
        {
            DoubleTextBox.Text = CalculateRootDouble(2);
            DecimalTextBox.Text = CalculateRootDecimal(2);
        }

        void CatchDevisionErrors()
        {
            if (firstNumberDouble == 0)
            {
                DoubleTextBox.Text = "YOU SHALL NOT DEVIDE BY 0!";
            }
            else if (secondNumberDouble == 0)
            {
                DoubleTextBox.Text = "YOU SHALL NOT DEVIDE BY 0!";
            }
        }

        void CatchDevisionErrorsDecimal() 
        { 
            if (firstNumberDecimal == 0)
            {
                DecimalTextBox.Text = "YOU SHALL NOT DEVIDE BY 0!";
            }
            else if (secondNumberDecimal == 0)
            {
                DecimalTextBox.Text = "YOU SHALL NOT DEVIDE BY 0!";
            }
        }

        string CalculateRootDouble(int rootNumber)
        {
            double rootDouble = 1;
            int loopNumber = 1;

            while (firstNumberDouble + 1 != loopNumber)
            {
                loopNumber = loopNumber + 1;
                rootDouble = (firstNumberDouble / rootDouble + rootDouble) / rootNumber;
            }
            return rootDouble.ToString();
        }

        string CalculateRootDecimal(int rootNumber)
        {
            decimal rootDecimal = 1;
            int loopNumber = 1;

            while (firstNumberDouble + 1 != loopNumber)
            {
                loopNumber = loopNumber + 1;
                rootDecimal = (firstNumberDecimal / rootDecimal + rootDecimal) / rootNumber;
            }
            return rootDecimal.ToString();
        }
    }
}
