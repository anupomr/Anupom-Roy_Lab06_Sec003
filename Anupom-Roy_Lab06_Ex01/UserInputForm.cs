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

            NumberPredicate evenPredicate = IsEven;
            lblEvenOddResult.Text = "The Number is a : ";
            lblEvenOddResult.Text += evenPredicate(inputNum) ? "Even" : "odd"; 
        }      
 
        private bool IsEven(int num) => num % 2 == 0;              

        private void txtInputNum_KeyPress(object sender, KeyPressEventArgs e)
        {
           //Checking Key press
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8) e.Handled = true;
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
              

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int searchResult=-1;

            if (rbInteger.Checked) searchResult = Search(intArray, Convert.ToInt32( txtSearch.Text));
            if (rbDoubles.Checked) searchResult = Search(doubleArray, Convert.ToDouble(txtSearch.Text));
            if (rbChar.Checked) searchResult = Search(charArray, Convert.ToChar(txtSearch.Text));
            if (searchResult < 0) MessageBox.Show("Item not found!!","Search Result");
            else MessageBox.Show("Item found!!", "Search Result");
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {

        }

        /*public int Search<T>(List<T> list, T lowIndex, T heighIndex) where T : IComparable<T>
        {
            retrun -1;
        }*/
        public int Search<T>(T[] list, T searchItem) where T : IComparable<T>
        {
            for (int i = 0; i < list.Length; i++)
            {
                if (searchItem.CompareTo(list[i]) == 0)
                { return i; }
            }
            return -1;
        }
        #endregion
        //validating user input
        public void InputValidation(string input)
        {
            string inputNum = input;
            if (inputNum == "") throw new InputException("Give an appropriate input");

        }
    }
}
