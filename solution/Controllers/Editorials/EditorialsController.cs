using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using solution.Models;
using solution.Services;

namespace solution.Controllers.Controllers
{
    public class EditorialController: ControllerBase
    {
        private readonly IEditorialRepository _editorialRepository;
        public EditorialController(IEditorialRepository editorialRepository){
            _editorialRepository = editorialRepository;
        }
        
    }
}