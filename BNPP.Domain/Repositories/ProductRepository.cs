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
    internal class ProductRepository : BaseRepository, IProductRepository
    {
        public List<Product> GetAllProducts()
        {
            using (var cnn = new SqlConnection(GetConnectionString()))
            {
                cnn.Open();
                List<Product> result = cnn.Query<Product>("SELECT * FROM PRODUTO WHERE [STA_STATUS] = 'A'").ToList();

                return result;
            }
        }
    }
}
