using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace OnTap_24_12.Models
{
    public partial class THDB : DbContext
    {
        public THDB()
            : base("name=THDB")
        {
        }

        public virtual DbSet<lophoc> lophocs { get; set; }
        public virtual DbSet<sinhvien> sinhviens { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
