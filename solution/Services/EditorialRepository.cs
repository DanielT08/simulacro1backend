using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using solution.Data;

namespace solution.Services
{
    public class EditorialRepository : IEditorialRepository
    {
       private readonly BaseContext _context;
        public EditorialRepository(BaseContext context)
        {
            _context = context;
        }
    }
}