using ETrade.Core;
using ETrade.DTO;
using ETrade.Ent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.Rep.Abstract
{
    public interface IProductRepos : IBaseRepository<Products>
    {
        decimal PriceVAT(Guid Id);
        decimal PriceDiscount(Guid Id);
        List<ProductsDTO> GetProducts();
    }
}
