using BNPP.Domain.Interfaces.Repositories;
using BNPP.Domain.Interfaces.Services;
using BNPP.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BNPP.Domain.Services
{
    public class ProductCosifService : IProductCosifService
    {
        private readonly IProductCosifRepository _productCosifRepository;
        public ProductCosifService(IProductCosifRepository productCosifRepository)
        {
            _productCosifRepository = productCosifRepository;
        }

        public List<ProductCosif> GetAllCosifByProduct(string Cod_Product)
        {
            return _productCosifRepository.GetAllProductCosif(Cod_Product);
        }
    }
}
