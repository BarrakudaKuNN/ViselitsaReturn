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
using ViselitsaReturn.Logic;

namespace ViselitsaReturn
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random random;
        CoreLogic Core;
        List<TextBlock> TextList;
        public MainWindow()
        {
            InitializeComponent();
            random= new Random();
            Core = new CoreLogic();
            TextList = new List<TextBlock>
            {
                TextBlock_Word_1,
                TextBlock_Word_3,
                TextBlock_Word_4,
                TextBlock_Word_5,
                TextBlock_Word_6,
                TextBlock_Word_7,
                TextBlock_Word_8
            };
        }

        private void Button_Game_Start_Click(object sender, RoutedEventArgs e)
        {
            //Запускаем случайное слово
            Core.Pic_Random_Word(random, Core.list_Of_Word);
            var d = TextList.Skip(Core.Word_To_Guess.Length).Select(x => x);
            foreach (var item in d)
            {
                item.Text = "Hidden";
            }
            TextBlock_Test.Text = Core.Word_To_Guess;
        }
        private void Keyboard_Click(object sender, KeyEventArgs e)
        {
            
        }
        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void Window_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            Core.Translate_Input_Key(e.Key.ToString().ToLower());
            TextBlock_Word_1.Text = Core.Inputed_Key;
            Core.Input_Key_Chek();


        }
    }
}
