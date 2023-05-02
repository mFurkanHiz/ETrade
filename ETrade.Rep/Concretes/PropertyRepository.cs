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
    public class PropertyRepository : BaseRepository<Properties>, IPropertyRepository
    {
        public PropertyRepository(Context context) : base(context)
        {
        }
        public List<Properties> GetProperties()
        {
            return Set().Select(x => new Properties
            {
                // sol taraf ProductDTO sağ taraf Products
                Id = x.Id,
                PropertyName = x.PropertyName,
                Price = x.Price,
                LastUpdated = x.LastUpdated,
                CreatedDate = x.CreatedDate,

        //          public string PropertyName { get; set; }
        //          public decimal Price { get; set; }
        //          public ICollection<Foods> Foods { get; set; }


    }).ToList();
        }
    }
}