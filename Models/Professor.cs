using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CIDM3312_lAB11.Models

{
   
    public class Professor
    {
       
        public int ID { get; set; }
        public String FirstName{ get; set; }
        public String LastName{ get; set; }
       //  public int MovieID { get; set; }//foreign key
        
      //   public Movie movie  { get; set; }//nav prop


         
        
    }
}