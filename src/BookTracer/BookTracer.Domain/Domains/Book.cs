using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookTracer.Domain.Domains
{
    public class Book : IBook
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public Guid AuthorId { get; private set; }
        public int Rate { get; private set; }
        public Author Author { get; private set; }
        public Book New(string name, Guid authorId, int rate)
        {
            Id = Guid.NewGuid();
            Name = name;
            AuthorId = authorId;
            Rate = rate;
            return this;
        }
        public Book Load(string id, string name, string authorId, int rate)
        {
            Id = Guid.Parse(id);
            Name = name;
            AuthorId = Guid.Parse(authorId); ;
            Rate = rate;
            return this;
        }

    }

    public interface IBook
    {
        Guid Id { get; }
        string Name { get; }
        Guid AuthorId { get; }
        Author Author { get; }

        Book New(string name, Guid authorId, int rate);
    }
}
