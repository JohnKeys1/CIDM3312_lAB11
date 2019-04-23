using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CIDM3312_lAB11.Models;


namespace CIDM3312_lAB11.Pages
{
    public class IndexModel : PageModel
        {   private readonly ProfessorDbContext _context;
            public List<CIDM3312_lAB11.Models.Professor> Professors {get; set;}

        public IndexModel(ProfessorDbContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
                   Professors= _context.Professor.ToList();
        }
    }
}
