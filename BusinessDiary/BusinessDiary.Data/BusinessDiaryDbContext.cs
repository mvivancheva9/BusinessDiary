using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessDiary.Data
{
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;
    using System.Data.Entity;

    public class BusinessDiaryDbContext : IdentityDbContext<User>, IBusinessDiaryDbContext
    {
        public BusinessDiaryDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        IDbSet<Company> Companies { get; set; }

        IDbSet<Import> Imports { get; set; }

        IDbSet<Product> Products { get; set; }

        IDbSet<Center> Centers { get; set; }

        IDbSet<ProductsCenters> ProductsCenters { get; set; }

        IDbSet<SalesPerDay> SalesPerDay { get; set; }

        IDbSet<SalesPerProduct> SalesPerProduct { get; set; }

        IDbSet<RevenuesPerDay> RevenuesPerDay { get; set; }

        IDbSet<RevenuesPerProduct> RevenuesPerProduct { get; set; }
             
        public static BusinessDiaryDbContext Create()
        {
            return new BusinessDiaryDbContext();
        }

        DbSet<TEntity> IBusinessDiaryDbContext.Set<TEntity>()
        {
            return base.Set<TEntity>();
        }

        public override int SaveChanges()
        {
            return base.SaveChanges();
        }
    }
}
