using BNPP.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BNPP.Domain.Interfaces.Repositories
{
    public interface IProductCosifRepository
    {
        List<ProductCosif> GetAllProductCosif(string Cod_Product);
    }
}
