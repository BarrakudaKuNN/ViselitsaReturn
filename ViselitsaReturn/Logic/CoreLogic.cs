﻿using System;
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
        LocalizationElements local = new LocalizationElements();
        Dictionary<int, string> inputed_Mathes = new Dictionary<int, string>();
        public List<string> list_Of_Word = new List<string>();

        string word_To_Guess="";
        string inputed_Key;
        
        int atemptCount=5;

        public string Word_To_Guess { get => word_To_Guess; set => word_To_Guess = value; }
        public string Inputed_Key { get => inputed_Key; set => inputed_Key = value; }
        public int AtemptCount { get => atemptCount; set => atemptCount = value; }

        public CoreLogic()
        {
            list_Of_Word.Add("дом");
            list_Of_Word.Add("мусор");
            list_Of_Word.Add("дурка");
            list_Of_Word.Add("машина");
            list_Of_Word.Add("беда");
        }

        public void Pic_Random_Word(Random rnd, List<string> list)
        {
            word_To_Guess = list[rnd.Next(0,list.Count)];
        }
        
        public void Translate_Input_Key(string input_S,TextBlock text)
        {
            //Это символ проверки на ошибку "-" метод  Input_Key_Chek_Error() 
            Inputed_Key = local.dictionary.ContainsKey(input_S) ? local.dictionary[input_S] : "-";
            text.Text = Inputed_Key;
            if (Inputed_Key.Equals("-"))
            {
                atemptCount++;
                MessageBox.Show("Нажимай на клавиши с буквами", "Ошибочка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            
        }

        /// <summary>
        /// Записываем кол-во совпавших букв і их положение в строке, Записываем в Dictionary
        /// где Ключ является положением в строке {i}
        /// </summary>
        public void Compare_Input_Key()
        {
            int i=0;
            inputed_Mathes.Clear();
            foreach (var item in word_To_Guess)
            {
                
                if (item.ToString() == inputed_Key)
                {
                    inputed_Mathes.Add(i, item.ToString());
                }
                i++;

            }
        }
        public void Show_Matches_Ltr(List<TextBlock> TextList,TextBlock atemtp,Player_UI UI)
        {
           if(inputed_Mathes.Count == 0)
           {
               atemtp.Text= (AtemptCount -= 1).ToString();

                /// тут код на случае неправільного ввода данных и минус попытка
           }
            else
            {
                foreach (var item in inputed_Mathes)
                {
                    TextList[item.Key].Text = item.Value;
                }
            }
        }
        public void Chek_If_You_Win(List<TextBlock> TextList,Player_UI UI)
        {
            int i = 0;
            for (int j = 0; j< word_To_Guess.Count(); j++, i++)
            {
                if (TextList[j].Text == "-")
                {
                    i = 0;
                    break;
                }
            }
            if (i == word_To_Guess.Count() )
            {
                atemptCount = 5;
                UI.Game_Lauch();
                /// ПОБЕДНЫЙ КОД

            }
        }
        public void Chek_Atempt(Player_UI ui,MediaElement media)
        {
            if(atemptCount == 0)
            {
                ui.Game_Lose();
                media.Source = new Uri(@"Videos\Laugh.mp4", UriKind.Relative);
                media.Play();
                atemptCount = 5;
            }
        }
    }
}
   