using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ViselitsaReturn.Logic
{
    internal class CoreLogic
    {
        public List<string> list_Of_Word = new List<string>();

        string word_To_Guess="Не то";

        int atemptCount=5;
        public CoreLogic()
        {
            list_Of_Word.Add("дом");
            list_Of_Word.Add("мусор");
            list_Of_Word.Add("дурка");
            list_Of_Word.Add("машина");
            list_Of_Word.Add("беда");
        }

        public string Word_To_Guess { get => word_To_Guess; set => word_To_Guess = value; }

        public void Pic_Random_Word(Random rnd, List<string> list)
        {
            word_To_Guess = list[rnd.Next(0,list.Count-1)];
        }
        
        public void Test(KeyEventArgs e)
        {
            
        }


    }
}
