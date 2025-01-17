﻿using learnmvc.DataAccess.Repository.IRepository;
using learnmvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learnmvc.DataAccess.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly AppDbContext _db;
        public CategoryRepository(AppDbContext db):base(db)
        {
            _db = db;
        }
        public void Update(Category obj)
        {
            _db.categories.Update(obj);
        }
    }
}
