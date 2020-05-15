namespace Pahamdiri
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DiagnosaEntity : DbContext
    {
        public DiagnosaEntity()
            : base("name=DiagnosaEntity1")
        {
        }

        public virtual DbSet<DiagnosaDB> DiagnosaDBs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
