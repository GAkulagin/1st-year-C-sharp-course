namespace Laba13
{
    class Journal
    {
        JournalEntry[] journal = null;


        public Journal()
        {
            journal = null;
        }

        // Обработчики событий
        public void CollectionCountChanged(object sourse, CollectionHandlerEventArgs args)
        {
            JournalEntry je = new JournalEntry(args.Name, args.TypeOfChange, args.Reference.ToString());
            Add(je);

        }
        public void CollectionReferenceChanged(object sourse, CollectionHandlerEventArgs args)
        {
            JournalEntry je = new JournalEntry(args.Name, args.TypeOfChange, args.Reference.ToString());
            Add(je);
        }


        private void Add(JournalEntry je)
        {
            if(journal == null)
            {
                journal = new JournalEntry[1];
                journal[0] = je;
                return;
            }

            JournalEntry[] temp = new JournalEntry[journal.Length + 1];
            journal.CopyTo(temp, 0);
            temp[journal.Length] = je;
            journal = temp;
        }

        public override string ToString()
        {
            if (journal == null) return "Журнал не заполнен";

            string output = "";

            foreach (JournalEntry je in journal)
                output += je.ToString() + "\n";

            return output;
        }
    }
}
