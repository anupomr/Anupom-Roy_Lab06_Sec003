using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Numerics;
/*
 * Student Name: Anupom Roy
 * Student id  : 300853516
 * Assinment   : # 6 Using Asynchronous Programming and Lambdas
 * 
 */
namespace Anupom_Roy_Lab06_Ex01
{
    public partial class UserInputForm : Form
    {
        //For Task C  -Check for odd and even
        public delegate bool NumberPredicate(int number);
        public int[] intArray = new int[10];
        double[] doubleArray = new double[10];
        char[] charArray = new char[10];

        public UserInputForm()
        {
            InitializeComponent();
        }
        //Task C start -Check for odd and even
        #region Task C -check odd/Even Num
        private void btnEvenOdd_Click(object sender, EventArgs e)
        {            
            //Exception Handelling for Number input
            try
            {
                InputValidation(txtInputNum.Text);
                string txtBoxValue = txtInputNum.Text;
                int inputNum = Convert.ToInt32(txtBoxValue);
                NumberPredicate evenPredicate = IsEven;
                lblEvenOddResult.Text = "The Number is a : ";
                lblEvenOddResult.Text += evenPredicate(inputNum) ? "Even" : "Odd";
            }
            catch (InputException ie)
            {
                MessageBox.Show(ie.Message, "Input Alert");
            }
           
        } 
        //Finding Even Number 
        private bool IsEven(int num) => num % 2 == 0;
        //Checking Key press && restrict invalid key
        private void txtInputNum_KeyPress(object sender, KeyPressEventArgs e)
        {            
            if (txtSearch.Focused)
            {
                if (rbDoubles.Checked)
                { if (char.IsLetter(e.KeyChar) && e.KeyChar != 110) e.Handled = true; }
                if(rbInteger.Checked)
                { if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8) e.Handled = true; }
                if(rbChar.Checked)
                { if (char.IsDigit(e.KeyChar) && e.KeyChar != 8) e.Handled = true; }
            }
            if (txtFactorial.Focused)
            { if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8) e.Handled = true; }

            if (txtInputNum.Focused||txtLowIndex.Focused||txtHeighIndex.Focused)
            { if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8) e.Handled = true; }

            if (txtLowIndex.Focused)
            { if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8) e.Handled = true; }

            if (txtHeighIndex.Focused)
            { if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8) e.Handled = true; }

        }
        #endregion
        //Task C End -Check for odd and even
        #region Task D

        private void btnGenerateValues_Click(object sender, EventArgs e)
        {            
            Random ranNum = new Random();
            if (rbInteger.Checked)
            {
                listBoxDisplay.Items.Clear();
                for (int i = 0; i <intArray.Length; i++)
                {
                    intArray[i] = ranNum.Next(10, 99);                    
                    listBoxDisplay.Items.Add(intArray[i].ToString());
                }                               
            }
            if (rbDoubles.Checked)
            {
                listBoxDisplay.Items.Clear();
                for (int i = 0; i < doubleArray.Length; i++)
                {
                    doubleArray[i] = Math.Round(ranNum.NextDouble(),2);
                    listBoxDisplay.Items.Add(doubleArray[i].ToString());
                }
            }
            if (rbChar.Checked)
            {
                listBoxDisplay.Items.Clear();
                for (int i = 0; i < charArray.Length; i++)
                {                   
                    charArray[i] = (char)(ranNum.Next(0, 26) + 65);                    
                    listBoxDisplay.Items.Add(charArray[i]);
                }
            }
        }    
        //Searching number from selected array
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                int searchResult = -1;
                InputValidation(txtSearch.Text);
                if (rbInteger.Checked) searchResult = Search(intArray, Convert.ToInt32(txtSearch.Text));
                if (rbDoubles.Checked) searchResult = Search(doubleArray, Convert.ToDouble(txtSearch.Text));
                if (rbChar.Checked) searchResult = Search(charArray, Convert.ToChar(txtSearch.Text));
                if (searchResult < 0) MessageBox.Show("Item not found!!", "Search Result");
                else MessageBox.Show("Item found!!", "Search Result");
            }
            catch (InputException ie)
            {
                MessageBox.Show(ie.Message, "Error ");
            }
        }
        public void btnDisplay_Click(object sender, EventArgs e)
        {
            try
            {
                InputValidation(txtLowIndex.Text);
                InputValidation(txtHeighIndex.Text);
                int lowIndex = Convert.ToInt32(txtLowIndex.Text);
                int highIndex = Convert.ToInt32(txtHeighIndex.Text);
                if (rbInteger.Checked)
                {
                    DisplayArray(intArray,lowIndex,highIndex);
                }
                if (rbDoubles.Checked)
                {
                    DisplayArray(doubleArray, lowIndex, highIndex);                   
                }
                if (rbChar.Checked)
                {
                    DisplayArray(charArray, lowIndex, highIndex);                    
                }
            }
            catch(InputException ie)
            {
                MessageBox.Show(ie.Message,"Error !!!! ");
            }            
        }
        private  void DisplayArray<T>(T[] inputArray, int lowIndex, int highIndex)
        {
            if (lowIndex < 0 || highIndex < 0)
            {
                throw new InputException("Low Index shouldnot Empty ");
            }
            if (lowIndex > highIndex)
            {
                throw new InputException("First Argument suppose to lower then Second argument");
            }
            if (highIndex > inputArray.Length)
            {
                throw new InputException("Second argument is heigher then array size");
            }
            T[] newArray = new T[highIndex];
            listBoxLowToHeighValue.Items.Clear();
            while (lowIndex <= highIndex)
            {
                int i = 0;
                newArray[i]= inputArray[lowIndex];
                listBoxLowToHeighValue.Items.Add(newArray[i]).ToString();
                i++;
                lowIndex++;
            }          

        }
        public int Search<T>(T[] list, T searchItem) where T : IComparable<T>
        {
            for (int i = 0; i < list.Length; i++)
            {
                if (searchItem.CompareTo(list[i]) == 0)
                { return i; }
            }return -1;            
        }
        #endregion
       
        //validating user input
        public void InputValidation(string input)
        {
            string inputNum = input;
            if (inputNum == "") throw new InputException("Give an appropriate input");
            if (inputNum == "" && rbInteger.Checked) throw new InputException("Give an appropriate Number");
            if (inputNum == "" && rbDoubles.Checked) throw new InputException("Give an appropriate Decemal number");
            if (inputNum == "" && rbChar.Checked) throw new InputException("Give an appropriate Letter");            
        }

        private void txtSearch_TextChanged(object sender, EventArgs e) {  //By Mistake
        }
        private async void btnCalculate_Click(object sender, EventArgs e)
        {            
            long num=0;
            try {
                InputValidation(txtFactorial.Text);
                num = Convert.ToInt64(txtFactorial.Text);
                
            } catch (InputException ie)
            {
                MessageBox.Show(ie.Message, "Error in Factorial");
                return;
            }
            lblFactorialResult.Text = "Please wait ....";
            Task<long> factorialTask = Task.Run(()=>factorialResult(num));           
            await factorialTask;
           
            lblFactorialResult.Text = BigInteger.Parse(factorialTask.Result.ToString()).ToString();
        }
        //Find Factorial Number 
        //public  long factorialResult(long num)=> (num <= 1)?1: num * factorialResult(num - 1);
        public long factorialResult(long num)
        {
            Thread.Sleep(5000);
            if (num <= 1) return 1;
            else return num * factorialResult(num - 1);
        }

    }
}
