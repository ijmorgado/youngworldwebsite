using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MundoJoven.Models
{
    public class Note
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Contents { get; set; }
        public DateTime date_creation { get; set; }
        public DateTime date_publish { get; set; }
        public int active { get; set; }

    }
    public class NoteDBContext : DbContext
    {
        public DbSet<Note> Notes { get; set; }
    }
}