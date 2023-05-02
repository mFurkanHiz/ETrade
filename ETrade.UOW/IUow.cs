using ETrade.Rep.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.UOW
{
    public interface IUow
    {
        // değişkenler

        ICategoryRepository categoryRepository { get; }
        IFoodRepository foodRepository { get; }
        IOrderDetailRepository orderDetailRepository { get; }
        IOrderRepository orderRepository { get; }
        IPropertyRepository propertyRepository { get; }
        IUserRepository userRepository { get; }

        void Commit();
    }
}
