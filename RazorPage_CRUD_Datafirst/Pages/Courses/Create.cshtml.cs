using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPage_CRUD_Datafirst.Data;

namespace RazorPage_CRUD_Datafirst.Pages.Courses
{
    public class CreateModel : PageModel
    {
        private readonly RazorPage_CRUD_Datafirst.Data.RazorPage_CRUD_DatafirstContext _context;

        public CreateModel(RazorPage_CRUD_Datafirst.Data.RazorPage_CRUD_DatafirstContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Course Course { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Course.Add(Course);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
