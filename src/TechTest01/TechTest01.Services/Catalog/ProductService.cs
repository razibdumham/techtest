using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTest01.Domain.Catalog;
using TechTest01.Repository;

namespace TechTest01.Services.Catalog
{
    public class ProductService : IProductService
    {
        private UnityOfWork unityOfWork = new UnityOfWork();

        public Product GetById(int id)
        {
            return unityOfWork.ProductRepository.GetByID(id);
        }

        public Product GetByUrl(string slug)
        {
            return unityOfWork.ProductRepository.Get(filter:p => p.Slug == slug).FirstOrDefault();
        }

        public ICollection<Product> GetProducts()
        {
            return
                unityOfWork.ProductRepository.Get().ToList();
        }
    }
}
