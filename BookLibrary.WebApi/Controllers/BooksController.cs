using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookLibrary.Core;
using Microsoft.AspNetCore.Mvc;

namespace BookLibrary.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BooksController : ControllerBase
    {
        private readonly IBookService _bookservice;
        public BooksController(IBookService bookService)
        {
            _bookservice = bookService;
        }

        [HttpGet]
        public IActionResult GetBooks()
        {
            return Ok(_bookservice.GetBooks());
        }

        [HttpGet("{id}" , Name ="GetBook")]
        public ActionResult GetBook(string id)
        {
            return Ok(_bookservice.GetBook(id));
        }

        [HttpPost]
        public IActionResult AddBook(Book book)
        {
            _bookservice.AddBook(book);
            return CreatedAtRoute("GetBook", new { id = book.Id } , book);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBook(string id)
        {
            _bookservice.DeleteBook(id);
            return NoContent();
        }

        [HttpPut]
        public IActionResult UpdateBook(Book book)
        {
            return Ok(_bookservice.UpdateBook(book));
        }
    }
}