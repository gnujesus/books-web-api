using BooksWebApi.Core.Domain.Entities;
using BooksWebApi.Core.Application.Interfaces.Repository;
using BooksWebApi.Core.Application.DTOs.BookDTOs;

namespace BooksWebApi.Infrastructure.Persistence.Repositories
{
    public class BookRepository : IBookRepository
    {

        // This has test data just to see if the HttpGet is working correctly
        private List<Book> books = [];

        public void Add(Book book)
        {

            // Just some id assignment logic
            if (books.Count > 0)
            {
                var lastBook = books[books.Count - 1];
                book.Id = lastBook.Id + 1;
            } else
            {
                book.Id = 1;
            }


            books.Add(book);
        }

        public Book GetById(int id)
        {
            return books.FirstOrDefault(b => b.Id == id);
        }
        public Page GetByPageNumber(int bookId, int pageNumber)
        {
            return books[bookId - 1].Pages[pageNumber];
        }



        public IEnumerable<Book> GetAll()
        {
            return books.ToList();
        }

        public void Delete(int id)
        {
            Book book = GetById(id);
            books.Remove(book);
        }

        public void Update(int oldBookId, Book newBook)
        {
            Book oldBook = GetById(oldBookId);
            books[oldBook.Id - 1] = newBook;
        }
    }
}
