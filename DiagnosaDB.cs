namespace Pahamdiri
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DiagnosaDB")]
    public partial class DiagnosaDB
    {
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string Tanggal { get; set; }

        [Required]
        [StringLength(20)]
        public string Diagnosa { get; set; }

        [Required]
        [StringLength(500)]
        public string Keluhan { get; set; }

        [Required]
        [StringLength(300)]
        public string Saran { get; set; }
    }
}
