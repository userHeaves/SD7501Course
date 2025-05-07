using SD7501Bulky.DataAccess.Repository.IRepository;
using SD7501Lab1.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD7501Bulky.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private BulkyDbContext _db;
        public ICategoryRepository Category { get; private set; }
        public IProductRepository Product { get; private set; }

        public UnitOfWork(BulkyDbContext db)
        {
            _db = db;
            Category = new CategoryRepository(_db);
            Product = new ProductRepository(_db);
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
