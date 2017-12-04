using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Db.Repository;
using Db.Model;

namespace Db.Repository
{
    public class DownloadRepository
    {
        public List<Download> List()
        {
            using (var context = new Database())
            {
     
                // Init sample data
                //var download = new Download { Name = "Yuuko" };
                //context.Add(download);     
                //context.SaveChanges();

                // Output data
                return context.Download.ToList();

           
            }          
        }
    }

}
 