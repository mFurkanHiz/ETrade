using ETrade.Core;
using ETrade.Dal;
using ETrade.Ent;
using ETrade.Rep.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.Rep.Concretes
{
    public class CategoryRepository : BaseRepository<Categories>, ICategoryRepository
    {
        public CategoryRepository(Context context) : base(context)
        {

        }
        public List<Categories> GetCategories()
        {
            return Set().Select(x => new Categories
            {
                // sol taraf ProductDTO sağ taraf Products
                Id = x.Id,
                CategoryName = x.CategoryName,
                LastUpdated = x.LastUpdated,
                CreatedDate = x.CreatedDate,

        //                public string CategoryName { get; set; }
        //public ICollection<Foods> Foods { get; set; }


    }).ToList();
        }
    }
}