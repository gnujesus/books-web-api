using BooksWebApi.Core.Application.DTOs.PageDTOs;
using BooksWebApi.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksWebApi.Core.Application.DTOs.BookDTOs
{
    public class SaveBookDto
    {
        public string Name { get; set; } = string.Empty;
        public string Author { get; set; }
        public string Description { get; set; }
        public Dictionary<int, PageDto>? Pages { get; set; } = new Dictionary<int, PageDto>();
    }
}
