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
    public class AuthorDeleteController: ControllerBase
    {
        private readonly IAuthorRepository _authorRepository;
        public AuthorDeleteController(IAuthorRepository authorRepository){
            _authorRepository = authorRepository;
        }
    }
}