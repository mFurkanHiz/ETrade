using ETrade.UI.Models.ViewModel;
using ETrade.UOW;
using Microsoft.AspNetCore.Mvc;

namespace ETrade.UI.Controllers
{
    public class FoodController : BaseController
    {
        private readonly ProductsModel model;
        public FoodController(IUow uow, ProductsModel model) : base(uow)
        {
            this.model = model;
        }

        public IActionResult List()
        {


            return View(uow.foodRepository.GetFoods());
        }
    }
}
