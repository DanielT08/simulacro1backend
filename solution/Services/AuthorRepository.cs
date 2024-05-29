using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using solution.Data;

namespace solution.Services
{
    public class AuthorRepository: IAuthorRepository
    {
        private readonly BaseContext _context;
        public AuthorRepository(BaseContext context){
            _context = context;
        }
    }
}