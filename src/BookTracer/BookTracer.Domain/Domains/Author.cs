using BookTracer.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookTracer.Domain.Domains
{
    public class Author : IAuthor
    {
        private readonly IBookRepository bookRepository;

        public Author(IBookRepository bookRepository)
        {
            this.bookRepository = bookRepository;
        }
        private IEnumerable<Book> books;

        public Guid Id { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public IEnumerable<Book> Books
        {
            get => books == null ? books = bookRepository.Retrieve(Id) : books;
            private set => books = value;
        }
        public Author Initialize(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            return this;
        }
        public Author Load(string id, string firstName, string lastName)
        {
            Id = Guid.Parse(id);
            FirstName = firstName;
            LastName = lastName;
            return this;
        }
        public void SetId(Guid id)
        {
            Id = id;
        }
    }

    public interface IAuthor
    {
        Guid Id { get; }
        string FirstName { get; }
        string LastName { get; }
        IEnumerable<Book> Books { get; }

        Author Initialize(string firstName, string lastName);
        void SetId(Guid id);
    }
}
