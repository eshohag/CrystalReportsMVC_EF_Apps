using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace CrystalReportsMVC_EF.Models
{
    public partial class Employee
    {
        public int Id { get; set; }

        [StringLength(250)]
        public string FirstName { get; set; }

        [StringLength(250)]
        public string LastName { get; set; }

        [Column(TypeName = "date")]
        public DateTime HairDate { get; set; }

        public decimal Salary { get; set; }

        [StringLength(50)]
        public string MobileNo { get; set; }

        [Column(TypeName = "date")]
        public DateTime DateOfBirth { get; set; }

        [StringLength(2050)]
        public string Notes { get; set; }
    }
}
