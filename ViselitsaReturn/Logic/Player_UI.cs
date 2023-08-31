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
        Grid lose;

        public Grid Menu { get => menu; set => menu = value; }
        public Grid Game { get => game; set => game = value; }
        public Grid Lose { get => lose; set => lose = value; }

        public Player_UI(Grid menu,Grid game,Grid lose) 
        {
            this.menu = menu;
            this.game = game;
            this.Lose = lose;
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
            Lose.Visibility=System.Windows.Visibility.Hidden;
        }
        public void Game_Start()
        {
            Menu.Visibility = System.Windows.Visibility.Hidden;
            Game.Visibility = System.Windows.Visibility.Visible;
        }

        public void Game_Lose()
        {
            Lose.Visibility = System.Windows.Visibility.Visible;

            game.Visibility = System.Windows.Visibility.Hidden;
        }
    }
}
