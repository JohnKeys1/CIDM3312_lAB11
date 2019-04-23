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
    public class IndexModel : PageModel
    {
        private readonly CIDM3312_lAB11.Models.ProfessorDbContext _context;

        public IndexModel(CIDM3312_lAB11.Models.ProfessorDbContext context)
        {
            _context = context;
        }

        public IList<Professor> Professor { get;set; }

        public async Task OnGetAsync()
        {
            Professor = await _context.Professor.ToListAsync();
        }
    }
}
