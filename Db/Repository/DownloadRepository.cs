using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Db.Repository;

namespace Db.Repository
{
    public class DownloadRepository
    {
        public void List()
        {
            using (var context = new Database())
            {
                // Create database
                //context.Database.EnsureCreated();

                // Init sample data
                //var download = new Download { Name = "Yuuko" };
                //context.Add(download);     
                //context.SaveChanges();

    

 

                // Output data
                var ret = context.Downloads.ToList();

                foreach (var x in ret)
                {
                    Console.WriteLine($"{ x.Name }");                    
                }
            }          
        }
    }

}
 