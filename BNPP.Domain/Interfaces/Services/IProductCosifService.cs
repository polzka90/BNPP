﻿using BNPP.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BNPP.Domain.Interfaces.Services
{
    public interface IProductCosifService
    {
        List<ProductCosif> GetAllCosifByProduct(string Cod_Product);
    }
}