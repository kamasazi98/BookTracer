using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookTracer.Domain.Domains
{
    public class Author : IAuthor
    {
        public Guid Id { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public IEnumerable<Book> Books { get; private set; }
        public Author Initialize(string firstName, string lastName)
        {
            Id = Guid.NewGuid();
            FirstName = firstName;
            LastName = lastName;
            Books = new List<Book>();
            return this;
        }
        public Author Load(string id, string firstName, string lastName, IEnumerable<Book> books)
        {
            Id = Guid.Parse(id);
            FirstName = firstName;
            LastName = lastName;
            Books = books;
            return this;
        }
    }

    public interface IAuthor
    {
        Guid Id { get; }
        string FirstName { get; }
        string LastName { get; }
        IEnumerable<Book> Books { get; }

        Author Initialize(string firstName, string lastName);
    }
}
