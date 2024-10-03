using BookTracer.Domain.Domains;
using BookTracer.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookTracer.Infrastracture.Repositories
{
    public class BookRepository : IBookRepository
    {
        public Book Retrieve(Guid authorId)
        {
            throw new NotImplementedException();
        }
        public Book Retrieve(string bookName)
        {
            throw new NotImplementedException();
        }
        public Book Create()
            => new Book();

        public List<Book> RetrieveAll()
        {
            throw new NotImplementedException();
        }

        public void Save(Book book)
        {
            throw new NotImplementedException();
        }
    }
}
