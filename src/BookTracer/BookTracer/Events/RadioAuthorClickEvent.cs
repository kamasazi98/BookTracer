using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookTracer.Events
{
    public class RadioAuthorClickEvent
    {
        public AuthorExistence AuthorExistence { get; set; }

        public RadioAuthorClickEvent(AuthorExistence authorExistence)
        {
            AuthorExistence = authorExistence;
        }
    }
    public enum AuthorExistence
    {
        Exists = 1,
        New = 2
    }
}
