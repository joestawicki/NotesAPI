using System.Data.Entity;

namespace Notes.Model
{
    public class NoteContext : DbContext
    {
        public DbSet<Note> Notes { get; set; }

        public NoteContext() : base("name=NoteContext")
        {
        }
    }
}
