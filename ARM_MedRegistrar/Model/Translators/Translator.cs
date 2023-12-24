using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARM_MedRegistrar.Model.Translators
{
    public class Translator : ITranslator
    {
        private readonly IDictionary<string, string> _dict = new Dictionary<string, string>();
        public Translator() 
        {
            string[] dictionary = File.ReadAllLines("Dictionary.txt");
            foreach (string line in dictionary)
            {
                string[] words = line.Split(' ');
                _dict.Add(words[0], words[1]);
                
            }
        }
        public string Translate(string word) 
        {
            if (_dict.ContainsKey(word))
                return _dict[word];
            else
                 return  "<???> "; //если нет в словаре
            
        }
    }
}

