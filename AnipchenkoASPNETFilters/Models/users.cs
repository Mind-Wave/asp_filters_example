namespace AnipchenkoASPNETFilters.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class users
    {
        public int id { get; set; }

        [StringLength(50)]
        public string login { get; set; }

        [StringLength(50)]
        public string pass { get; set; }
    }
}
