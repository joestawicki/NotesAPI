using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Notes.Model;

namespace Notes.API
{
    public class NotesController : ApiController
    {
        private readonly NoteContext dataContext = new NoteContext();

        // GET api/notes    
        public IEnumerable<Note> Get()
        {
            return dataContext.Notes;
        }

        // GET api/note/5 
        public Note Get(int id)
        {
            return dataContext.Notes.SingleOrDefault(d => d.id == id);
        }

        // POST api/note
        public void Post(Note value)
        {
            dataContext.Notes.Add(value);
            dataContext.SaveChanges();
        }
    }
}
