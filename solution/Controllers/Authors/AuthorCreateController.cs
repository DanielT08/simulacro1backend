using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using solution.Models;
using solution.Services;


namespace solution.Controllers.Authors
{
    public class AuthorCreateController: ControllerBase
    {
        private readonly IAuthorRepository _authorRepository;
        public AuthorCreateController(IAuthorRepository authorRepository){
            _authorRepository = authorRepository;
        }
    }
}