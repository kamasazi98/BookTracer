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
        public Author Author { get; private set; }
        public Book Initialize(string name, Guid authorId)
        {
            Id = Guid.NewGuid();
            Name = name;
            AuthorId = authorId;
            return this;
        }

    }

    public interface IBook
    {
        Guid Id { get; }
        string Name { get; }
        Guid AuthorId { get; }
        Author Author { get; }

        Book Initialize(string name, Guid authorId);
    }
}
