using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CIDM3312_lAB11.Models;

namespace CIDM3312_lAB11.Pages.Professors
{
    public class EditModel : PageModel
    {
        private readonly CIDM3312_lAB11.Models.ProfessorDbContext _context;

        public EditModel(CIDM3312_lAB11.Models.ProfessorDbContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Professor).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProfessorExists(Professor.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ProfessorExists(int id)
        {
            return _context.Professor.Any(e => e.ID == id);
        }
    }
}
