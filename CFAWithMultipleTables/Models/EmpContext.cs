using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using CFAWithMultipleTables.Models;
namespace CFAWithMultipleTables.Models
{
    public class EmpContext:DbContext
    {
        public EmpContext() : base("con")
        {

        }
        public DbSet<Dept> Depts { get; set; }
        public DbSet<Employee> Emps { get; set; }
    }
}