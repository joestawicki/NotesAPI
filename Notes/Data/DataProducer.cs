using Notes.Model;

namespace Notes.Data
{
    class DataProducer
    {
        private static NoteContext context = new NoteContext();
        public static void TryFill()
        {
            context.Database.CreateIfNotExists();
        }
    }
}
