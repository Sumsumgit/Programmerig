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

namespace WPF_Frågesport
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Quiz myQuiz = new Quiz();
        private MainCard currentCard;
        private int antalRätt;
        public MainWindow()
        {
            InitializeComponent();
            currentCard = myQuiz.Nextcard();
            fråga.Text = currentCard.Question;
            
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                if (currentCard.IsCorrect(svar.Text))
                {
                    antalRätt = antalRätt + 1;
                    currentCard = myQuiz.Nextcard();
                    
                    if (currentCard is MultiCard)
                    {
                        alternativ.Visibility = Visibility.Visible;
                        alternativ.Text = ((MultiCard)currentCard).HämtaSvar();
                    }
                    else
                    {
                        alternativ.Visibility = Visibility.Collapsed;

                    }

                    if (currentCard is FinalCard)
                    {
                        alternativ.Visibility = Visibility.Visible;
                        alternativ.Text = ((FinalCard)currentCard).HämtaSvar();
                        svar.Visibility = Visibility.Collapsed;
                    }
                    fråga.Text = currentCard.Question;
                    svar.Clear();
                }
                else
                {
                    svar.Clear();
                }

            }
        }

        
    }

    
}
