﻿using ITTWEB_ASPNetCore.Core;
using ITTWEB_ASPNetCore.Core.Domain;
using ITTWEB_ASPNetCore.Core.Repositories;
using ITTWEB_ASPNetCore.Persistence.Repositories;

namespace ITTWEB_ASPNetCore.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly EmbeddedStockContext _context;

        public UnitOfWork(EmbeddedStockContext context)
        {
            _context = context;
            Categories = new CategoryRepository(_context);
            ComponentTypes = new ComponentTypeRepository(_context);
            Components = new ComponentRepository(_context);
            CategoryComponentTypes = new CategoryComponentTypeRepository(_context);
        }


        public ICategoryRepository Categories { get; set; }
        public IComponentTypeRepository ComponentTypes { get; set; }
        public IComponentRepository Components { get; set; }
        public ICategoryComponentTypeRepository CategoryComponentTypes { get; set; }

        public void Dispose()
        {
            _context.Dispose();
        }

        public int Complete()
        {
            return _context.SaveChanges();
        }
    }
}