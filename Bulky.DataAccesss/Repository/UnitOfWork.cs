using BulkyBook.DataAccesss.Data;
using BulkyBook.DataAccesss.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace BulkyBook.DataAccesss.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private readonly CategoryRepository _categoryRepository;

        public UnitOfWork(ApplicationDbContext context)
        {
            this._context = context;
        }
        public CategoryRepository CategoryRepository => _categoryRepository ?? new CategoryRepository(_context);



        public void Commit()
        {
            _context.SaveChanges();
        }
    }
}
