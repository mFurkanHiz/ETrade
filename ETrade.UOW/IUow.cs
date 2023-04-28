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
        ICatRepos catRepos { get; }
        IProductRepos productRepos { get; }
        ICategoryRepository categoryRepository { get; }
        IFoodRepository foodRepository { get; }
        IOrderDetailRepository orderDetailRepository { get; }
        IOrderRepository orderRepository { get; }
        IPropertyRepository propertyRepository { get; }
        IShippingAddressRepository shippingAddressRepository { get; }
        IUserRepository userRepository { get; }

        void Commit();
    }
}
