namespace Pahamdiri
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DataPasien")]
    public partial class DataPasien
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Nama { get; set; }

        [Required]
        [StringLength(50)]
        public string Pekerjaan { get; set; }

        [Required]
        [StringLength(50)]
        public string No_Hp { get; set; }
    }
}
