using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;


namespace CIDM3312_lAB11.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ProfessorDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<ProfessorDbContext>>()))
            {
                // Look for any movies.
                if (context.Professor.Any())
                {
                    return;   // DB has been seeded
                }
                context.Professor.AddRange(
                    new Professor
                    {
                        FirstName =  "Kareem",
                        LastName = "Dana" , 
                         Courses = new List<Course> {
                            new Course {Description="CIDM 3312"},
                            new Course {Description="CIDM 2315"}
                        }
                          

                                  
                      
                    },               

                    new Professor
                    {
                       FirstName =  "Jeff",
                        LastName = "Babb" , 
                         Courses = new List<Course> {
                            new Course {Description="CIDM 4385"},
                            new Course {Description="CIDM 4390"}
                        }
                           
                                             
                    },

                    new Professor
                    {
                       FirstName =  "Katherine",
                        LastName = "Carl" , 
                        Courses = new List<Course> {
                            new Course {Description="CIDM 4350"},
                            new Course {Description="CIDM 4382"}
                        }
                           

                         
                    },

                    new Professor
                    {
                       FirstName =  "Harry",
                        LastName = "Sally"
                        
                    }
                );
                context.SaveChanges();
            }
        }
    }
}