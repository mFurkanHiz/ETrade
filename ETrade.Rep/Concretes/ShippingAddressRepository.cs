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
    public class ShippingAddressRepository : BaseRepository<ShippingAddresses>, IShippingAddressRepository
    {
        public ShippingAddressRepository(Context context) : base(context)
        {
        }
    }
}
