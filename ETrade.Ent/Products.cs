using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.Ent
{
    public class Products : Base
    {
        public decimal Price { get; set; }

        public Guid CategoryId { get; set; }
        [ForeignKey(nameof(CategoryId))]

        public Categories Categories { get; set; }

        public decimal PriceDiscount()
        {
            return Price * .85m; // %85 indirim
        }
        public decimal PriceVAT()
        {
            return Price * 1.18m; // %118
        }

    }
}
