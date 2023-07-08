namespace ScriptureMemory
{
    public class Reference
    {
        public string Book { get; } //This chunck properly recieves each part of the scripture
        public int Chapter { get; }
        public int StartVerse { get; }
        public int? EndVerse { get; }

        public Reference(string book, int chapter, int startVerse)
        {
            Book = book;
            Chapter = chapter;
            StartVerse = startVerse;
        }

        public Reference(string book, int chapter, int startVerse, int endVerse) : this(book, chapter, startVerse)
        {
            EndVerse = endVerse;
        }

        public override string ToString()
        {
            return EndVerse.HasValue ? $"{Book} {Chapter}:{StartVerse}-{EndVerse}" : $"{Book} {Chapter}:{StartVerse}";
        }
    }
}
