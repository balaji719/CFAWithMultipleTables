using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CFAWithMultipleTables.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public int Eno { get; set; }
        public string Ename { get; set; }
        public decimal Salary { get; set; }
        public int Dno { get; set; }
        public Dept D { get; set; }
    }
}