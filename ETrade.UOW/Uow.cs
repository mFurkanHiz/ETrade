using ETrade.Dal;
using ETrade.Rep.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.UOW
{
    public class Uow : IUow
    {
        // özellik olduğu için arrow kullanıldı metot değil property
        public ICatRepos catRepos { get; }

        public IProductRepos productRepos { get; }

        private readonly Context context;

        public Uow(Context context, ICatRepos catRepos, IProductRepos productRepos)
        {
            // ctorda çağırmak yerine newleyebiliriz ama tavsiye edilmez
            this.context = context;
            this.catRepos = catRepos;
            this.productRepos = productRepos;
        }

        public void Commit()
        {
            context.SaveChanges();
        }
    }
}
