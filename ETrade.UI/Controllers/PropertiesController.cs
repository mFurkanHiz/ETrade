using ETrade.UI.Models.ViewModel;
using ETrade.UOW;
using Microsoft.AspNetCore.Mvc;

namespace ETrade.UI.Controllers
{
    public class PropertiesController : BaseController
    {
        private readonly PropertiesModel model;

        public PropertiesController(IUow uow, PropertiesModel model) : base(uow)
        {
            this.model = model;
        }
        public IActionResult List()
        {
            return View(uow.propertyRepository.GetProperties());
        }

        public IActionResult Create()
        {
            model.Text = "Kaydet";
            model.Head = "Yeni Giriş";
            model.Class = "btn btn-primary";
            return View("Crud", model);
        }

        [HttpPost]
        public IActionResult Create(PropertiesModel m)
        {
            uow.propertyRepository.Add(m.Properties);
            uow.Commit();
            return RedirectToAction("List");
        }

        public IActionResult Update(Guid Id)
        {
            model.Head = "Güncelleme";
            model.Text = "Güncelle";
            model.Class = "btn btn-success";
            model.Properties = uow.propertyRepository.Find(Id);
            return View("Crud", model);
        }
        [HttpPost]
        public IActionResult Update(PropertiesModel m)
        {
            //uow.propertyRepository.Update(uow.propertyRepository.Find(m.Properties.Id));
            uow.propertyRepository.Update(m.Properties);
            uow.Commit();
            return RedirectToAction("List");
        }

        public IActionResult Delete(Guid Id)
        {
            //uow.propertyRepository.Delete(m.Properties);
            uow.propertyRepository.Delete(uow.propertyRepository.Find(Id));
            uow.Commit();
            return RedirectToAction("List");
        }
    }
}
