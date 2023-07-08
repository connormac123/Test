using System;
using System.Collections.Generic;
using System.Linq;

namespace ScriptureMemory
{
    public class Scripture
    {
        public Reference Reference { get; }
        public List<Word> Words { get; } //Recieves the words in the scriptures 
        public bool AllWordsHidden => Words.All(w => w.IsHidden); // 

        public Scripture(Reference reference, string text)
        {
            Reference = reference;
            Words = text.Split(' ').Select(w => new Word(w)).ToList();
        }

        public void HideRandomWord()
        {
            Random random = new Random();
            List<Word> visibleWords = Words.Where(w => !w.IsHidden).ToList(); //Hides the words

            if (visibleWords.Count > 0)
            {
                visibleWords[random.Next(visibleWords.Count)].IsHidden = true;
            }
        }

        public override string ToString() 
        {
            return $"{Reference}\n{string.Join(' ', Words)}";
        }
    }
}
