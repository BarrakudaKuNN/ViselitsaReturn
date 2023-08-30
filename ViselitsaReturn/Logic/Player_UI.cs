using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;


namespace ViselitsaReturn.Logic
{
    internal class Player_UI
    {

        Grid menu;
        Grid game;

        public Grid Menu { get => menu; set => menu = value; }
        public Grid Game { get => game; set => game = value; }

        public Player_UI(Grid menu,Grid game) 
        {
            this.menu = menu;
            this.game = game;
        }
        //Перебіраем все техтбоксы и прячем их
        //Оставшиеся заполняем нейтральным словом "-"
        public void Hide_Unused(List<TextBlock> TextList,CoreLogic Core)
        {
            foreach (var item in TextList)
            {
                item.Visibility = System.Windows.Visibility.Hidden;
            }
            for (int i = 0; i < Core.Word_To_Guess.Length; i++)
            {
                TextList[i].Text = "-";
                TextList[i].Visibility = System.Windows.Visibility.Visible;
            }
        }
        public void Game_Lauch()
        {
            Menu.Visibility=System.Windows.Visibility.Visible;
            Game.Visibility=System.Windows.Visibility.Hidden;
        }
        public void Game_Start()
        {
            Menu.Visibility = System.Windows.Visibility.Hidden;
            Game.Visibility = System.Windows.Visibility.Visible;
        }
    }
}
