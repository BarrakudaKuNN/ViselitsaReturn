using System;
using System.Collections.Generic;
using System.IO;
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
        Player_UI UI;
        List<TextBlock> TextList;
        public MainWindow()
        {
            InitializeComponent();

            random= new Random();

            Core = new CoreLogic();

            UI = new Player_UI(Grid_Main_Menu, Grid_Game_Screen,Grid_Deafeat_Menu);
            UI.Game_Lauch();
            TextList = new List<TextBlock>
            {
                TextBlock_Word_3,
                TextBlock_Word_4,
                TextBlock_Word_5,
                TextBlock_Word_6,
                TextBlock_Word_7,
                TextBlock_Word_8
            };
        }
        private MediaPlayer _player;

        string d = "Videos/Laugh.mp4";
        
        private void Button_Game_Start_Click(object sender, RoutedEventArgs e)
        {
            
            //Запускаем случайное слово
            Core.Pic_Random_Word(random, Core.list_Of_Word);
            UI.Game_Start();
            UI.Hide_Unused(TextList, Core);
            TextBlock_Try_Count.Text = Core.AtemptCount.ToString();
        }
        
        private void Window_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            
            Core.Translate_Input_Key(e.Key.ToString().ToLower(), TextBlock_Word_1);
            Core.Compare_Input_Key();
            Core.Show_Matches_Ltr(TextList,TextBlock_Try_Count,UI);
            Core.Chek_Atempt(UI,MediaEl_Defeat);
            Core.Chek_If_You_Win(TextList,UI);
        }

        private void Button_Restart_Click(object sender, RoutedEventArgs e)
        {
            UI.Game_Lauch(); 
        }
    }
}
