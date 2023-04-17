using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace MVC__CRUD_Islemleri.Models
{
    public partial class UrunLerDbConTexT : DbContext
    {
        public UrunLerDbConTexT()
            : base("name=UrunLerDbConTexT")
        {

        }

        public virtual DbSet<Urunler> Urunler { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
