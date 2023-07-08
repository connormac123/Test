namespace ScriptureMemory
{
    public class Word
    {
        private readonly string _text; //Makes _text only accesable in the Word class. 

        public bool IsHidden { get; set; }

        public Word(string text)
        {
            _text = text;
        }

        public override string ToString()
        {
            return IsHidden ? new string('_', _text.Length) : _text; //Will dertermine if it will return underscores or not based on if the words are already hidden or not.
        }
    }
}
