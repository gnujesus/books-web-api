using BooksWebApi.Core.Domain.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BooksWebApi.Core.Application.DTOs.BookDTOs;
using BooksWebApi.Core.Application.Interfaces.Repository;
using BooksWebApi.Core.Application.Interfaces.Service;
using BooksWebApi.Core.Application.DTOs.PageDTOs;

namespace BooksWebApi.Core.Application.Services
{
    public class BookService:IBookService
    {
        private readonly IBookRepository _bookRepository;
        private readonly IMapper _mapper;

        public BookService(IBookRepository bookRepository, IMapper mapper)
        {
            _bookRepository= bookRepository;
            _mapper = mapper;
        }
        public IEnumerable<BookDto> GetAllBooks()
        {
            return _mapper.Map<List<BookDto>>(_bookRepository.GetAll());
        }

        public BookDto GetBookById(int id)
        {
            return _mapper.Map<BookDto>(_bookRepository.GetById(id));
        }

        public PageDto GetBookByPageNumber(int bookId, int pageNumber)
        {
            return _mapper.Map<PageDto>(_bookRepository.GetByPageNumber(bookId, pageNumber));
        }

        public BookDto GetBookByQuery(Dictionary<string, object> query)
        {
            List<BookDto> books = _mapper.Map<List<BookDto>>(GetAllBooks());
            BookDto? result;

            foreach(var value in query.Values)
            {
                // convert to string since a string that says "Jon" can't be converted to int
                bool valid = value.ToString() != "0" && value.ToString() != "" && value != null;

                if (valid)
                {
                    result = books.Where(b => b.Id.ToString() == value?.ToString() ||
                    b.Name == value?.ToString() ||
                    b.Author == value?.ToString() ||
                    b.Description.Contains(value?.ToString()!)).FirstOrDefault();

                    return result;
                }  
                else
                {
                    result = null;
                }
            }

            // just to push without errors
            return null;

        }

        public void AddBook(SaveBookDto dto)
        {
            Book book = _mapper.Map<Book>(dto);
            _bookRepository.Add(book);
        }

        public void DeleteBook(int id) 
        {
            _bookRepository.Delete(id);
        }

        public void UpdateBook(int oldBookId, SaveBookDto dto)
        {
            Book newBook = _mapper.Map<Book>(dto);
            newBook.Id = oldBookId;
            _bookRepository.Update(oldBookId, newBook);
        }

    }
}
