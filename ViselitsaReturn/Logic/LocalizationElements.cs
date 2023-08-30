using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViselitsaReturn.Logic
{
    internal class LocalizationElements
    {
        public Dictionary<string, string> dictionary;

        public LocalizationElements()
        {
            CreateDictionary();
        }
        void CreateDictionary()
        {
            dictionary = new Dictionary<string, string>();
            dictionary.Add("q", "й");
            dictionary.Add("w", "ц");
            dictionary.Add("e", "у");
            dictionary.Add("r", "к");
            dictionary.Add("t", "е");
            dictionary.Add("y", "н");
            dictionary.Add("u", "г");
            dictionary.Add("i", "ш");
            dictionary.Add("o", "щ");
            dictionary.Add("p", "з");
            dictionary.Add("oemopenbrackets", "х");
            dictionary.Add("oem6", "ъ");
            dictionary.Add("a", "ф");
            dictionary.Add("s", "ы");
            dictionary.Add("d", "в"); 
            dictionary.Add("f", "а");
            dictionary.Add("g", "п");
            dictionary.Add("h", "р");
            dictionary.Add("j", "о");
            dictionary.Add("k", "л");
            dictionary.Add("l", "д");
            dictionary.Add("oem1", "ж");
            dictionary.Add("oemquotes", "э");
            dictionary.Add("z", "я");
            dictionary.Add("x", "ч");
            dictionary.Add("c", "с");
            dictionary.Add("v", "м");
            dictionary.Add("b", "и");
            dictionary.Add("n", "т");
            dictionary.Add("m", "ь");
            dictionary.Add("oemcomma", "б");
            dictionary.Add("oemperiod", "ю");
            dictionary.Add("oem3", "ё");
        }
    }
}
