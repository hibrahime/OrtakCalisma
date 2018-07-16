using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calisma.Model
{
    public class CalismaContext : DbContext
    {
        public CalismaContext() : base("DefaultConnection")
        {
        }

        public virtual DbSet<Ogretmen> Ogretmen { get; set; }
        public virtual DbSet<Ogrenci> Ogrenci { get; set; }
    }
}
