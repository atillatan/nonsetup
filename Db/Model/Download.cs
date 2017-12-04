using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Db.Model
{
    public class Download
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

}