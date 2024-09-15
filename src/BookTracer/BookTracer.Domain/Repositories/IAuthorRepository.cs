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
        List<Author> RetrieveAll();
        void Save(Author author);
    }
}
