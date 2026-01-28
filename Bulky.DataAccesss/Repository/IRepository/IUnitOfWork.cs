using System;
using System.Collections.Generic;
using System.Text;

namespace BulkyBook.DataAccesss.Repository.IRepository
{
    public interface IUnitOfWork
    {
        public CategoryRepository CategoryRepository { get; }
        void Commit();
    }
}
