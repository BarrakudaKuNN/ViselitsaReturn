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
        Grid win;

        public Player_UI(Grid menu, Grid game, Grid lose, Grid win)
        {
            this.menu = menu;
            this.game = game;
            this.lose = lose;
            this.win = win;
        }
        //Перебіраем все техтбоксы и прячем их
        //Оставшиеся заполняем нейтральным словом "-"
        public void Hide_Unused(List<TextBlock> TextList, CoreLogic Core)
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
            menu.Visibility = System.Windows.Visibility.Visible;
            game.Visibility = System.Windows.Visibility.Hidden;
            lose.Visibility = System.Windows.Visibility.Hidden;
        }
        public void Game_Start(MediaElement media)
        {
            media.Source = new Uri(@"Music\Chill.mp3", UriKind.Relative);
            media.Play();
            menu.Visibility = System.Windows.Visibility.Hidden;
            game.Visibility = System.Windows.Visibility.Visible;
        }

        public void Game_Lose(MediaElement media,MediaElement mediaOff)
        {

            game.Visibility = System.Windows.Visibility.Hidden;
            lose.Visibility = System.Windows.Visibility.Visible;
            media.Source = new Uri(@"Videos\Laugh.mp4", UriKind.Relative);
            mediaOff.Stop();
            media.Play();
            
        }
        public void Game_Win(MediaElement media,TextBlock text, MediaElement off)
        {

            game.Visibility = System.Windows.Visibility.Hidden;
            win.Visibility = System.Windows.Visibility.Visible;
            text.Text = "Ты выиграл, Чемпион.    Теперь отдохни с нами и расслабься.  Голые девки подождут";
            off.Stop();
            media.Source = new Uri(@"Videos\Pat.mp4", UriKind.Relative);
            media.Play();
            
        }
    }
}
