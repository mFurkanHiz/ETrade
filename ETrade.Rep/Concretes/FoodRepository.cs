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
    public class FoodRepository : BaseRepository<Foods>, IFoodRepository
    {
        public FoodRepository(Context context) : base(context)
        {
        }
    }
}
