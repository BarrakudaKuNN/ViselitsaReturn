using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViselitsaReturn.Logic
{
    internal class CoreLogic
    {
        List<string> list_Of_Word = new List<string>();

        string word_To_Guess="";

        CoreLogic()
        {
            list_Of_Word.Add("шляпа");
            list_Of_Word.Add("мусор");
            list_Of_Word.Add("дурка");
            list_Of_Word.Add("машина");
            list_Of_Word.Add("квартира");
        }

        void Pic_Random_Word(Random rnd, List<string> list)
        {
            string word_To_Guess = list[rnd.Next(0,list.Count-1)];
        }



    }
}
