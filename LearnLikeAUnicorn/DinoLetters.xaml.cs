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
    /// Interaction logic for DinoLetters.xaml
    /// </summary>
    public partial class DinoLetters : Window
    {
        char ans;
        int points;
        char[] letters = new char[26] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
        Random ran = new Random();

        public DinoLetters()
        {
            InitializeComponent();
            points = 0;
            NewProb();
            
        }

        private void NewProb()
        {
            ans = letters[ran.Next(25)];
            letter.Content = ans;
            answer.Text = "";
            answer.Focus();
        }

        private void GetAnswer(object sender, KeyEventArgs e)
        {
            //answer.Text = Convert.ToString(e.Key);

            if (Convert.ToString(e.Key) == letter.Content.ToString())
            {
                MessageBox.Show("Correct!");
            }
            else
            {
                MessageBox.Show("Incorrect!");
            }

            NewProb();
        }
    }
}
