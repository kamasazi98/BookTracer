using BookTracer.Domain.Domains;
using BookTracer.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookTracer.Infrastracture.Repositories
{
    public class AuthorRepository : IAuthorRepository
    {
        public List<Author> RetrieveAll()
        {
            throw new NotImplementedException();
        }

        public void Save(Author author)
        {
            throw new NotImplementedException();
        }
    }
}
