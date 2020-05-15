namespace Pahamdiri
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class PasienModel : DbContext
    {
        public PasienModel()
            : base("name=PasienModel2")
        {
        }

        public virtual DbSet<DataPasien> DataPasiens { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
