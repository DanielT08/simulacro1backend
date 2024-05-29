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
    public class EditorialCreateController: ControllerBase
    {
        private readonly IEditorialRepository _editorialRepository;
        public EditorialCreateController(IEditorialRepository editorialRepository){
            _editorialRepository = editorialRepository;
        }
        
    }
}