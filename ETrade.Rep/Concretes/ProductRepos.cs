using ETrade.Core;
using ETrade.Dal;
using ETrade.DTO;
using ETrade.Ent;
using ETrade.Rep.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.Rep.Concretes
{
    public class ProductRepos : BaseRepository<Products>, IProductRepos
    {
        public ProductRepos(Context context) : base(context)
        {
        }

        public List<ProductsDTO> GetProducts()
        {
            // inner Join
            return Set().Select(x => new ProductsDTO
            {
                // sol taraf ProductDTO sağ taraf Products
                Id = x.Id,
                CategoryName = x.Categories.Name,
                ProductName = x.Name,
                UnitPrice = x.Price,

            }).ToList();
        }

        public decimal PriceDiscount(Guid Id)
        {
            //var p = Find(Id);
            //return p.PriceDiscount();

            //return PriceDiscount(Find(Id));

            //return PriceDiscount(Id);

            //return this.PriceDiscount(Id);

            return Find(Id).PriceDiscount();
        }

        public decimal PriceVAT(Guid Id)
        {
            return (Find(Id).PriceVAT());
        }
    }
}
