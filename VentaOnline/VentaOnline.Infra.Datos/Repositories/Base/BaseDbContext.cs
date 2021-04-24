using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentaOnline.Domain.Models;

namespace VentaOnline.Infra.Datos.Repositories.Base
{
    public abstract class BaseDbContext: DbContext
    {
        

        public BaseDbContext(string conntectionStringName)
            : base(conntectionStringName) { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
        public virtual DbSet<Categoria> Categoria { get; set; }
    }
}
