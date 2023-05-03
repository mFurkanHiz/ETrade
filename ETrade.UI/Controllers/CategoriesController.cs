using ETrade.UI.Models.ViewModel;
using ETrade.UOW;
using Microsoft.AspNetCore.Mvc;

namespace ETrade.UI.Controllers
{
    public class CategoriesController : BaseController
    {
        private readonly CategoriesModel model;

        public CategoriesController(IUow uow, CategoriesModel model) : base(uow)
        {
            this.model = model;
        }

        public IActionResult List()
        {
            return View(uow.categoryRepository.GetCategories());
        }

        public IActionResult Create()
        {
            model.Text = "Kaydet";
            model.Head = "Yeni Giriş";
            model.Class = "btn btn-primary";
            return View("Crud", model);        
        }

        [HttpPost]
        public IActionResult Create(CategoriesModel m)
        {
            uow.categoryRepository.Add(m.Categories);
            uow.Commit();
            return RedirectToAction("List");
        }

        public IActionResult Update(Guid Id)
        {
            model.Head = "Güncelleme";
            model.Text = "Güncelle";
            model.Class = "btn btn-success";
            model.Categories = uow.categoryRepository.Find(Id);
            return View("Crud", model);
        }
        [HttpPost]
        public IActionResult Update(CategoriesModel m)
        {
            //uow.categoryRepository.Update(uow.categoryRepository.Find(m.Categories.Id));
            uow.categoryRepository.Update(m.Categories);
            uow.Commit();
            return RedirectToAction("List");
        }

        public IActionResult Delete(Guid Id)
        {
            //uow.categoryRepository.Delete(m.Categories);
            uow.categoryRepository.Delete(uow.categoryRepository.Find(Id));
            uow.Commit();
            return RedirectToAction("List");
        }
    }
}
