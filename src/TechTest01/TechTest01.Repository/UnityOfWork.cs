using System;
using TechTest01.Domain;
using TechTest01.Domain.Catalog;
using TechTest01.Repository;

namespace TechTest01.Repository
{
    public class UnityOfWork : IDisposable
    {
        private TechTestDbContext context = new TechTestDbContext();
        private GenericRepository<Product> productRepository;
        

        public GenericRepository<Product> ProductRepository
        {
            get
            {

                if (this.productRepository == null)
                {
                    this.productRepository = new GenericRepository<Product>(context);
                }
                return productRepository;
            }
        }

       
        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}