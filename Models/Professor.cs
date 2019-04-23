using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CIDM3312_lAB11.Models;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace CIDM3312_lAB11.Models

{
   
    public class Professor
    {
       [BindProperty]
        public int ID { get; set; }

        [Display(Name = "First Name")]
        [BindProperty]
        public String FirstName{ get; set; }

        [Display(Name = "Last Name")]
        [BindProperty]
        public String LastName{ get; set; }
        
        public List<Course> Courses {get; set;}//nav prop
      

         
        
    }
}