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
    public class DetailsModel : PageModel
    {
        private readonly RazorPage_CRUD_Datafirst.Data.RazorPage_CRUD_DatafirstContext _context;

        public DetailsModel(RazorPage_CRUD_Datafirst.Data.RazorPage_CRUD_DatafirstContext context)
        {
            _context = context;
        }

        public Course Course { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var course = await _context.Course.FirstOrDefaultAsync(m => m.CourseID == id);
            if (course == null)
            {
                return NotFound();
            }
            else
            {
                Course = course;
            }
            return Page();
        }
    }
}
