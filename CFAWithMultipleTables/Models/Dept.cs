using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CFAWithMultipleTables.Models
{
    [Table("Dept")]
    public class Dept
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Key]
        public int Dno { get; set; }
        public string Dname { get; set; }
        public List<Employee> Emp { get; set; }
   }
}