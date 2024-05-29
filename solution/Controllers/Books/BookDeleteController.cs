using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using solution.Models;
using solution.Services;

namespace solution.Controllers.Books
{
    public class BookDeleteController: ControllerBase
    {
        private readonly IBookRepository _bookRepository;
        public BookDeleteController(IBookRepository bookRepository){
            _bookRepository = bookRepository;
        }
    }
}