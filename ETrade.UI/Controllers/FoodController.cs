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

        public IActionResult Update(Guid Id)
        {
            model.Head = "Güncelleme";
            model.Text = "Güncelle";
            model.Class = "btn btn-success";
            model.SelectedFood = uow.foodRepository.Find(Id);
            return View("Crud", model);
        }
        [HttpPost]
        public IActionResult Update(FoodsModel model)
        {
            uow.foodRepository.Update(model.SelectedFood);
            uow.Commit();
            return RedirectToAction("List");
        }

        public IActionResult Delete(Guid id)
        {
            //var cat = Uow.catRepos.Find(id);
            //return View(cat);

            uow.foodRepository.Delete(uow.foodRepository.Find(id));
            uow.Commit();
            return RedirectToAction("List");
        }

        public IActionResult Add()
        {
            //Categories cat = new Categories();
            //return View(cat);

            model.Head = "Yeni Giriş";
            model.Text = "Kaydet";
            model.Class = "btn btn-primary";
            return View("Crud", model);
        }
        [HttpPost]
        public IActionResult Add(FoodsModel model)
        {
            uow.foodRepository.Add(model.SelectedFood);
            uow.Commit();
            return RedirectToAction("List");
        }
    }
}
