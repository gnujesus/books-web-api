using BooksWebApi.Core.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksWebApi.Core.Domain.Entities
{
    public class Page: BaseEntity
    {
        public int PageNumber { get; set; }
        public string Content { get; set; }

    }
}
