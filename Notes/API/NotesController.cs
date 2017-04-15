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

        // GET api/note?query=
        public IEnumerable<Note> Get([FromUri]string query)
        {
            return dataContext.Notes.Where(p => p.body.Contains(query));
        }

        // POST api/note
        public void Post(Note value)
        {
            dataContext.Notes.Add(value);
            dataContext.SaveChanges();
        }
    }
}
