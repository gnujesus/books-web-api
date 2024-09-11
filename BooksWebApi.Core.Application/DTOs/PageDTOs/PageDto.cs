using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksWebApi.Core.Application.DTOs.PageDTOs
{

    public class PageDto
    {
        public int Id { get; set; }
        public int PageNumber { get; set; }
        public string Content { get; set; }
        public int BookId { get; set; }

    }
}
