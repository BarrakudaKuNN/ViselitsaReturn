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

namespace ViselitsaReturn
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        char s;
        public MainWindow()
        {
            InitializeComponent();
            s ='a';
        }

        private void Button_Game_Start_Click(object sender, RoutedEventArgs e)
        {
            TextBlock_Word_1.Text = s.ToString();


        }
        private void Keyboard_Click(object sender, KeyEventArgs e)
        {
            char d = (char)e.Key;
            TextBlock_Word_1.Text=d.ToString();
        }
        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            char d = (char)e.Key;
            if (e.Key == Key.A)
            {
                TextBlock_Word_1.Text = d.ToString();
            }
            else if (e.Key == Key.B)
            {
                TextBlock_Word_1.Text = d.ToString();
            }

            // Обработка других клавиш
        }

        private void TextBlock_Word_2_KeyDown(object sender, KeyEventArgs e)
        {
            char d = (char)e.Key;
            TextBlock_Word_1.Text = d.ToString();
        }
    }
}
