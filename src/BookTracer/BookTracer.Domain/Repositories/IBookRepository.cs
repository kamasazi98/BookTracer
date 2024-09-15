using BookTracer.Domain.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookTracer.Domain.Repositories
{
    public interface IBookRepository
    {
        List<Book> RetrieveAll();
        Book Retrieve(Guid authorId);
        void Save(Book book);
    }
}
