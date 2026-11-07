using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace Cv_MVC.Models.Entity
{
    public partial class CvDbEntities : DbContext
    {
        public CvDbEntities()
            : base("name=CvDbEntities")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }

        public virtual DbSet<Table_Admin> Table_Admin { get; set; }
        public virtual DbSet<Table_Deneyimlerim> Table_Deneyimlerim { get; set; }
        public virtual DbSet<Table_Egitimlerim> Table_Egitimlerim { get; set; }
        public virtual DbSet<Table_Hakkimda> Table_Hakkimda { get; set; }
        public virtual DbSet<Table_Hobilerim> Table_Hobilerim { get; set; }
        public virtual DbSet<Table_Iletisim> Table_Iletisim { get; set; }
        public virtual DbSet<Table_Sertifikalarim> Table_Sertifikalarim { get; set; }
        public virtual DbSet<Table_SosyalMedya> Table_SosyalMedya { get; set; }
        public virtual DbSet<Table_Yeteneklerim> Table_Yeteneklerim { get; set; }
    }
}