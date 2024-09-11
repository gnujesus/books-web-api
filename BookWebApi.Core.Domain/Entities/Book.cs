using BooksWebApi.Core.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksWebApi.Core.Domain.Entities
{
    public class Book : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string Author { get; set; } 
        public string Description { get; set; } 
        public Dictionary<int, Page> Pages { get; set; }
    }
}
