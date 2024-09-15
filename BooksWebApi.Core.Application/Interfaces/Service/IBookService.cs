using BooksWebApi.Core.Application.DTOs.BookDTOs;
using BooksWebApi.Core.Application.DTOs.PageDTOs;
using BooksWebApi.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksWebApi.Core.Application.Interfaces.Service
{
    public interface IBookService
    {
        IEnumerable<BookDto> GetAllBooks();
        BookDto GetBookById(int id);
        PageDto GetBookByPageNumber(int bookId, int pageNumber);
        BookDto GetBookByQuery(Dictionary<string, object> query);
        void AddBook(SaveBookDto book);
        void DeleteBook(int id);
        void UpdateBook(int id, SaveBookDto dto);
    }
}
