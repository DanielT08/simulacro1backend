using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using solution.Data;

namespace solution.Services
{
    public class BookRepository: IBookRepository
    {
        private readonly BaseContext _context;
        public BookRepository(BaseContext context){
            _context = context;
        }
    }
}