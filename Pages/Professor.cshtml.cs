
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CIDM3312_lAB11.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace CIDM3312_lAB11.Pages
{
    public class ProfessorModel : PageModel
    {
        private readonly ProfessorDbContext _context;
        private readonly ILogger _log;

        public List<Professor> Professors {get; set;}

        public SelectList ProfessorsDropDown {get; set;}  

        [BindProperty]
        public int professorId {get; set;}
        
        [Display(Name = "First Name")]
        [BindProperty]
        public String FirstName{ get; set; }

        [Display(Name = "Last Name")]
        [BindProperty]
        public String LastName{ get; set; }

        [BindProperty]
        public string message {get; set;}

        [BindProperty]
        public string Description {get; set;}

        [BindProperty]
        public string message2 {get; set;}

   

        public ProfessorModel(ProfessorDbContext context, ILogger<ProfessorModel> log)
        {
            _context = context;
            _log = log;
        }


        // public ProfessorModel(ProfessorDbContext context)
        // {
        //     _context = context;
        // }


        public void OnGet()
        {
          
           Professors = _context.Professor.Include(c => c.Courses).ToList();
        
           ProfessorsDropDown= new SelectList(Professors, "ID", "FirstName","LastName");
           
           
        }

        public void OnPost()
        {

            FirstName=_context.Professor.Where(p=>p.ID==professorId).FirstOrDefault().FirstName;
            LastName=_context.Professor.Where(p=>p.ID==professorId).FirstOrDefault().LastName;
            Description=_context.Course.Where(p=>p.ID==professorId).FirstOrDefault().Description;

            message="You selected " +FirstName + " "+LastName;
            message2= FirstName +"  "+LastName+" is teaching " + Description;

            //  _log.LogWarning($"OnPost() Called. FirstName = '{FirstName}' LastName = '{LastName}'");
            //  Professors = _context.Professor.ToList();

            //  var ProfName= from p in _context.Professor
            //                 where p.ID ==professorId
            //                 select p.FirstName;

                            
            //Console.WriteLine("professor ID:{0}",professorId);
            
           
            
            //var selectedProf=DropDownList.SelectedIndex;
           
        }
            
        }
    }
