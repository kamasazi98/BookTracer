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
        IAuthor? Retrieve(string firstName, string lastName);
        IAuthor Retrieve(Guid id);
        List<IAuthor> RetrieveAll();
        void Save(IAuthor author);
    }
}
