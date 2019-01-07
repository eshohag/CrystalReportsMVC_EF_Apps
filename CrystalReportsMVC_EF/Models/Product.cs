namespace CrystalReportsMVC_EF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Product
    {
        public int Id { get; set; }

        [StringLength(250)]
        public string Name { get; set; }

        public int CategoryId { get; set; }

        public int Quentity { get; set; }

        public decimal Price { get; set; }

        public virtual Category Category { get; set; }
    }
}
