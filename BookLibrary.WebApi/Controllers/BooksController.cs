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
    }
}