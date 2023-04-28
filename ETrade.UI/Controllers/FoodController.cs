using ETrade.UI.Models.ViewModel;
using ETrade.UOW;
using Microsoft.AspNetCore.Mvc;

namespace ETrade.UI.Controllers
{
    public class FoodController : BaseController
    {
   
        public FoodController(IUow uow) : base(uow)
        {

        }

        public IActionResult List()
        {
            return View(uow.foodRepository.GetFoods());
        }
    }
}
