namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Clockface")]
    public partial class Clockface
    {
        public int id { get; set; }

        [Required]
        [StringLength(100)]
        public string name { get; set; }
    }
}
