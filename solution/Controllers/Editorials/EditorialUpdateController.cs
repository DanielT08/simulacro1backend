using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using solution.Models;
using solution.Services;

namespace solution.Controllers.Editorials
{
    public class EditorialUpdateController : ControllerBase
    {
        private readonly IEditorialRepository _editorialRepository;
        public EditorialUpdateController(IEditorialRepository editorialRepository){
            _editorialRepository = editorialRepository;
        }
    }
}