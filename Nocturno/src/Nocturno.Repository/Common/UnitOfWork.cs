using Nocturno.Repository.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nocturno.Repository.Common
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly NocturnoContext _context;

        public UnitOfWork(NocturnoContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}