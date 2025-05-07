using SD7501Bulky.DataAccess.Repository.IRepository;
using SD7501Lab1.Data;
using SD7501Lab1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD7501Bulky.DataAccess.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private BulkyDbContext _db;

        public CategoryRepository(BulkyDbContext db) : base(db)
        {
            _db = db;
        }
        public void Save()
        {
            _db.SaveChanges();
        }

        public void Update(Category obj)
        {
            _db.Update(obj);
        }
    }
}
