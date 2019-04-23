using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CIDM3312_lAB11.Models

{
   
    public class Course
    {
       
        public int CourseId { get; set; }
        public String Description{ get; set; }
        public int ID{ get; set; }//Foreign Key
        public Professor Professor{ get; set; }//nav prop

      
/* 



 */
         
        
    }
}