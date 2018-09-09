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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LearnLikeAUnicorn
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void GoToMathGame(object sender, RoutedEventArgs e)
        {
            try
            {
                MathGame mg = new MathGame();
                mg.Show();
                this.Close();
            }
            catch
            {
                MessageBox.Show("Unable to go to Math Game");
            }
        }

        private void GoToLetterGame(object sender, RoutedEventArgs e)
        {
            DinoLetters dL = new DinoLetters();
            dL.Show();
            this.Close();
        }
    }
}
