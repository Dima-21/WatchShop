namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Watch")]
    public partial class Watch
    {
        public int id { get; set; }

        [Required]
        [StringLength(255)]
        public string model { get; set; }

        public int? price { get; set; }

        [Required]
        [StringLength(255)]
        public string descript_path { get; set; }

        [StringLength(255)]
        public string folder_img { get; set; }

        public int? weight { get; set; }

        public int manuf_id { get; set; }

        public int? wtype_id { get; set; }

        public int? style_id { get; set; }

        public int? glass_id { get; set; }

        public int? material_id { get; set; }

        public int country_id { get; set; }

        public virtual Country Country { get; set; }

        public virtual Glass Glass { get; set; }

        public virtual Manufacturer Manufacturer { get; set; }

        public virtual Material Material { get; set; }

        public virtual Style Style { get; set; }

        public virtual Wtype Wtype { get; set; }
    }
}
