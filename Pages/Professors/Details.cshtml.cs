using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CIDM3312_lAB11.Models;

namespace CIDM3312_lAB11.Pages.Professors
{
    public class DetailsModel : PageModel
    {
        private readonly CIDM3312_lAB11.Models.ProfessorDbContext _context;

        public DetailsModel(CIDM3312_lAB11.Models.ProfessorDbContext context)
        {
            _context = context;
        }

        public Professor Professor { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Professor = await _context.Professor.FirstOrDefaultAsync(m => m.ID == id);

            if (Professor == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
