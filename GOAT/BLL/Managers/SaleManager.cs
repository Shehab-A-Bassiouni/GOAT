using DAL.Repository;
using DTOs.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Managers
{
    public static class SaleManager
    {
        public static void Add(Sale sale) { 
            IRepository<Sale> repository = new Repository<Sale>();
            repository.Add(sale);
        }
    }
}
