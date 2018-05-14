using PagingAndSorting.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace PagingAndSorting.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext()
            : base("DefaultConnection")
        {
        }
        public DbSet<EmployeeMaster> Employees { get; set; }
    }
}