using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace LearnLikeAUnicorn
{
    /// <summary>
    /// Interaction logic for MathGame.xaml
    /// </summary>
    public partial class MathGame : Window
    {
        int num1;
        int num2;
        int opInt;
        int solution;
        int points;
        Random ran = new Random();

        public MathGame()
        {
            InitializeComponent();
            points = 0;
            NewProb();
            answer.Focus();
        }

        private void NewProb()
        {
            ptDisp.Content = points + " points";
            answer.Text = "";
            //Determine the two numbers and the operation
            num1 = ran.Next(12);
            num2 = ran.Next(12);
            opInt = ran.Next(1, 2);

            number1.Content = num1;
            number2.Content = num2;

            switch (opInt)
            {
                case 1:
                    opDisp.Content = "+";
                    solution = num1 + num2;
                    break;
                case 2:
                    opDisp.Content = "-";
                    num2 = ran.Next(num1);
                    solution = num1 - num2;
                    break;
            }
        }

        private void GetAnswer(object sender, KeyEventArgs e)
        {
            //bool correct;
            int ans;
            //Checks if Enter was pressed. Evaluates answer.text against actual answer to determine result, enacts response based on result
            if (e.Key == Key.Enter)
            {
                try
                {
                    ans = Convert.ToInt32(answer.Text);
                }
                catch
                {
                    ans = 999;
                }

                if (ans == solution)
                {
                    //Reaction to correct answer: "Ding!", add a point, Visual response
                    MessageBox.Show("Correct!");
                    points++;
                    NewProb();
                }
                else
                {
                    //Reaction to incorrect answer: "Buzz!", Lose a chance, visual response; end game if 0 chances remaining
                    MessageBox.Show("Incorrect!");
                    NewProb();
                }
            }
        }
    }
}
