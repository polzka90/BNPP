using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace BNPP.Domain.Repositories
{
    internal class BaseRepository
    {
        protected string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["BNPP"].ConnectionString;
        }
    }
}
