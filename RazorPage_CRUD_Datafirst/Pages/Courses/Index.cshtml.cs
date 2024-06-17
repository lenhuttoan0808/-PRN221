using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPage_CRUD_Datafirst.Data;

namespace RazorPage_CRUD_Datafirst.Pages.Courses
{
    public class IndexModel : PageModel
    {
        private readonly RazorPage_CRUD_Datafirst.Data.RazorPage_CRUD_DatafirstContext _context;

        public IndexModel(RazorPage_CRUD_Datafirst.Data.RazorPage_CRUD_DatafirstContext context)
        {
            _context = context;
        }

        public IList<Course> Course { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Course = await _context.Course.ToListAsync();
        }
    }
}
