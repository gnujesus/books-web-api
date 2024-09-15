using BooksWebApi.Core.Application.DTOs.BookDTOs;
using BooksWebApi.Core.Application.DTOs.PageDTOs;
using BooksWebApi.Core.Application.Interfaces.Service;
using BooksWebApi.Core.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Net.Security;

namespace BooksWebApi.Controllers
{
    [Route("api/books")]
    [ApiController]
    public class BookController : Controller
    {
    
        private readonly IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet]
        public IActionResult GetAllBooks()
        {
            return Ok(_bookService.GetAllBooks());
        }

        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute] int id){
            BookDto res = _bookService.GetBookById(id);

            if (res == null)
            {
                return NotFound();
            }

            return Ok(res);
        }

        [HttpGet("{id}/{name}/{author}/{description}")]
        public IActionResult GetBy([FromRoute] int id = 0, string name = "", string author = "", string description = ""){

            Dictionary<string, object> query = new()
            {
                {"id", id },
                {"name", name},
                {"author",  author},
                {"description", description}
            };

            BookDto res = _bookService.GetBookById(id);

            if (res == null)
            {
                return NotFound();
            }

            return Ok(res);
        }

        [HttpGet("page/{bookId}/{pageNumber}")]
        public IActionResult GetByPageNumber([FromRoute] int bookId, [FromRoute] int pageNumber)
        {
            PageDto res = _bookService.GetBookByPageNumber(bookId, pageNumber);

            if (res == null)
            {
                return NotFound();
            }

            return Ok(res);
        }

        [HttpPost]
        public IActionResult AddBook([FromBody] SaveBookDto dto)
        {
            _bookService.AddBook(dto);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBook([FromRoute] int id)
        {
            _bookService.DeleteBook(id);
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateBook([FromRoute] int id, [FromBody] SaveBookDto dto)
        {
            _bookService.UpdateBook(id, dto);
            return Ok();
        }

    }
}
