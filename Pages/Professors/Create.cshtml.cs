using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CIDM3312_lAB11.Models;

namespace CIDM3312_lAB11.Pages.Professors
{
    public class CreateModel : PageModel
    {
        private readonly CIDM3312_lAB11.Models.ProfessorDbContext _context;

        public CreateModel(CIDM3312_lAB11.Models.ProfessorDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Professor Professor { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Professor.Add(Professor);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}