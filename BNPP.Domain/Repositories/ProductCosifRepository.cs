using BNPP.Domain.Interfaces.Repositories;
using BNPP.Domain.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BNPP.Domain.Repositories
{
    internal class ProductCosifRepository : BaseRepository, IProductCosifRepository
    {
        public List<ProductCosif> GetAllProductCosif(string Cod_Product)
        {

            using (var cnn = new SqlConnection(GetConnectionString()))
            {
                cnn.Open();
                List<ProductCosif> result = cnn.Query<ProductCosif>("SELECT * FROM PRODUTO_COSIF WHERE [STA_STATUS] = 'A' AND COD_PRODUTO = @COD_PRODUTO", new { COD_PRODUTO = Cod_Product }).ToList();

                return result;
            }
        }
    }
}
