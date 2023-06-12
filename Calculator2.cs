using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloCSharpWin
{
    public partial class Calculator2 : Form
    {
        public Calculator2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
                /*HelloLabel.Text = "Hello C#";

                int number1 = 10;
                string operator1 = "+";
                bool isCorrect = true;

                // + , - , * , /
                int sum = 1 + 2; 
                int
                */

                int number1 = 1;
                int number2 = 2;

                int sum = number1 + number2;
                label1.Text = sum.ToString(); //sum 값은 정수이고 text는 문자열이므로 sum값을 문자열로 바꾸어줘야한다

          
        }

        private void SumNumbers_Click(object sender, EventArgs e)
        {
            int number1 = Convert.ToInt32(Sum1.Text);
            int number2 = Convert.ToInt32(Sum2.Text);

            int sum = Add(number1,number2);
            SumResult.Text = sum.ToString();
        }
      
        //덧셈 함수 선언
        public int Add(int number1, int number2)
        {
            int sum = number1 + number2;
            return sum;
        }
        public float Add2(float number1, float number2)
        {
            float sum = number1 + number2;
            return sum;
        }
    
        public int Sub (int number1, int number2)
        {
            int sub = number1 -  number2;
            return sub;
        }
    }
}
