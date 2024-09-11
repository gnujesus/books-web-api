using BooksWebApi.Core.Application.DTOs.BookDTOs;
using BooksWebApi.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksWebApi.Core.Application.Interfaces.Repository
{
    public interface IBookRepository : IGenericRepository<Book>
    {
        Page GetByPageNumber(int bookId, int pageNumber);
    }
}
