using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anupom_Roy_Lab06_Ex01
{
    public partial class UserInputForm : Form
    {
        //For Task C  -Check for odd and even
        public delegate bool NumberPredicate(int number);

        public UserInputForm()
        {
            InitializeComponent();
        }

        private void btnEvenOdd_Click(object sender, EventArgs e)
        {
            //Exception Handelling for Number input
            string txtBoxValue = txtInputNum.Text;
            int inputNum = Convert.ToInt32(txtBoxValue);
            try
            {
                InputValidation(txtBoxValue);
            }
            catch (InputException ie)
            {
                MessageBox.Show(ie.Message, "Input Alert");
            }

            //Functionality

            NumberPredicate evenPredicate = IsEven;
            lblEvenOddResult.Text = "The Number is a : ";
            lblEvenOddResult.Text += evenPredicate(inputNum) ? "Even" : "odd"; 
        }
        //validating user input
        public void InputValidation(string input)
        {
            string inputNum = input;
            if (inputNum == "")
            {
                throw new InputException("Give an appropriate input");
            }
        }
        //Task c start -Check for odd and even
        #region Task C -check odd/Even Num
        private bool IsEven(int num) => num % 2 == 0;
        
        #endregion
        //Task c End -Check for odd and even
    }
}
