using Microsoft.EntityFrameworkCore;
using MVCUdemy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCUdemy.Services
{
    public class DepartmentService
    {
        private readonly MVCUdemyContext _context;

        public DepartmentService(MVCUdemyContext context)
        {
            _context = context;
        }
        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
