using BookTracer.Domain.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookTracer.Domain.Repositories
{
    public interface IAuthorRepository
    {
        Author Create();
        Author? Retrieve(string firstName, string lastName);
        List<Author> RetrieveAll();
        void Save(Author author);
    }
}
