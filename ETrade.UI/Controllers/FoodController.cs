using ETrade.UI.Models.ViewModel;
using ETrade.UOW;
using Microsoft.AspNetCore.Mvc;

namespace ETrade.UI.Controllers
{
    public class FoodController : BaseController
    {
        private readonly FoodsModel model;

        public FoodController(IUow uow, FoodsModel model) : base(uow)
        {
            this.model = model;
        }

        public IActionResult List()
        {
            return View(uow.foodRepository.GetFoods());
        }
        public IActionResult Create()
        {
            model.Text = "Kaydet";
            model.Head = "Yeni Giriş";
            model.Class = "btn btn-primary";
            return View("Crud", model);
        }

        [HttpPost]
        public IActionResult Create(FoodsModel m)
        {
            uow.foodRepository.Add(m.SelectedFood);
            uow.Commit();
            return RedirectToAction("List");
        }

        public IActionResult Update(Guid Id)
        {
            model.Head = "Güncelleme";
            model.Text = "Güncelle";
            model.Class = "btn btn-success";
            model.SelectedFood = uow.foodRepository.Find(Id);
            return View("Crud", model);
        }
        [HttpPost]
        public IActionResult Update(FoodsModel m)
        {
            //uow.foodRepository.Update(uow.foodRepository.Find(m.Properties.Id));
            uow.foodRepository.Update(m.SelectedFood);
            uow.Commit();
            return RedirectToAction("List");
        }

        public IActionResult Delete(Guid Id)
        {
            //uow.foodRepository.Delete(m.Properties);
            uow.foodRepository.Delete(uow.foodRepository.Find(Id));
            uow.Commit();
            return RedirectToAction("List");
        }
    }
}
