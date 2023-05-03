using ETrade.UOW;
using Microsoft.AspNetCore.Mvc;

namespace ETrade.UI.Controllers
{
    public class PropertiesController : BaseController
    {
        public PropertiesController(IUow uow) : base(uow)
        {

        }
        public IActionResult List()
        {
            return View(uow.propertyRepository.GetProperties());
        }
    }
}
