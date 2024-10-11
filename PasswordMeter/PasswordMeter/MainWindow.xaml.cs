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

namespace PasswordMeter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Input velden: userNameTextBox en passwordTextBox
        /// Output veld: resultTextBlock
        /// </summary>

        string userName;
        string password;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void passwordMeterButton_Click(object sender, RoutedEventArgs e)
        {
            password = passwordTextBox.Text;
            password = password.Trim();

            userName = userNameTextBox.Text;
            userName = userName.Trim();

            bool isNumber = false;
            bool isUpperCase = false;
            bool isLowerCase = false;
            bool isDigit = false;
            
            bool containsUserName = password.Contains(userName);

            for (int i = 0; i < password.Length; i++)
            {
                char letter;
                string eerstVolgendeLetter = password.Substring(i, 1);

                letter = char.Parse(eerstVolgendeLetter);

                isDigit =char.IsDigit(letter);
                if (isDigit)
                {
                    break;
                }
            }

            bool contains10Characters = password.Length >= 10;

            if(containsUserName == false && contains10Characters && isDigit)
            {
                resultTextBlock.Foreground = Brushes.Green;
                resultTextBlock.Text = "Wachtwoord OK";
            }
            else if (!contains10Characters)
            {
                resultTextBlock.Foreground = Brushes.Orange;
                resultTextBlock.Text = "Wachtwoord Niet OK";
            }
            else if(!isDigit)
            {
                resultTextBlock.Foreground = Brushes.Orange;
                resultTextBlock.Text = "Wachtwoord Niet OK";
            }
            else
            {
                resultTextBlock.Foreground = Brushes.Red;
                resultTextBlock.Text = "Wachtwoord Niet OK";
            }
            
        }
    }
}
