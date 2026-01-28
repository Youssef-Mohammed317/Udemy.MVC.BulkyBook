using BulkyBook.DataAccesss.Data;
using BulkyBook.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace BulkyBook.DataAccesss.DbInitializer
{
    public class DbInitializer : IDbInitializer
    {
        private readonly ApplicationDbContext _context;

        public DbInitializer(ApplicationDbContext context)
        {
            this._context = context;
        }
        public void Initialize()
        {
            _context.Database.EnsureCreated();

            if (_context.Database.GetPendingMigrations().Any())
            {
                _context.Database.Migrate();
            }

            if (!_context.Categories.Any())
            {

                _context.Categories.AddRange(new Category { Id = 1, Name = "Action", DisplayOrder = 1 },
                                    new Category { Id = 2, Name = "SciFi", DisplayOrder = 2 },
                                    new Category { Id = 3, Name = "History", DisplayOrder = 3 }
                                    );
            }
        }
    }
}
