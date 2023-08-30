using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace ViselitsaReturn.Logic
{
    internal class CoreLogic
    {
        public List<string> list_Of_Word = new List<string>();

        string word_To_Guess="Не то";

        string inputed_Key;

        int atemptCount=5;
        public CoreLogic()
        {
            list_Of_Word.Add("дом");
            list_Of_Word.Add("мусор");
            list_Of_Word.Add("дурка");
            list_Of_Word.Add("машина");
            list_Of_Word.Add("беда");
        }

        LocalizationElements local = new LocalizationElements();

        public string Word_To_Guess { get => word_To_Guess; set => word_To_Guess = value; }
        public string Inputed_Key { get => inputed_Key; set => inputed_Key = value; }

        public void Pic_Random_Word(Random rnd, List<string> list)
        {
            word_To_Guess = list[rnd.Next(0,list.Count-1)];
        }
        
        public void Test(KeyEventArgs e)
        {
            
        }

        public void Translate_Input_Key(string input_S)
        {
            foreach (var item in local.dictionary.Keys)
            {
                if (item == input_S)
                {
                    Inputed_Key = local.dictionary[item];
                    break;
                }
                else
                {
                    Inputed_Key = "-";
                }
            }
            //Пробни сделать это через LINQ
        }

        public bool Input_Key_Chek()
        {
            if (Inputed_Key == "-")
            {
                MessageBox.Show("Нажимай на клавиши с буквами", "Ошибочка",   MessageBoxButton.OK,MessageBoxImage.Error);
                return false;
            }
            return true;
        }

    }
}
   