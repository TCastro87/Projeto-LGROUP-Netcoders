using Business;
using Model;
using System.Web.Mvc;

namespace Web.Controllers
{
    public class ContatoController : Controller
    {
        private ContatoBusiness _business;

        public ContatoController()
        {
            _business = new ContatoBusiness();
        }


        private void CarregaSexos()
        {
            ViewBag.Sexos = new SelectList(new SexoBusiness().GetAll(), "Id", "Sexo");
        }

        public ActionResult Index()
        {
            return View(_business.GetAll());
        }

        public ActionResult Create()
        {
            CarregaSexos();

            return View();
        }


        [HttpPost]
        public ActionResult Create(ContatoModel model)
        {
            ModelState.Remove("Id");

            if (!ModelState.IsValid)
            {
                //adicionando erros manualmente
                //if (validagmail(model.Email))
                //    ModelState.AddModelError("Email", "Email precisa ser gmail");

                CarregaSexos();

                return View(model);
            }

            _business.Save(model);

            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            CarregaSexos();

            var contato =  _business.GetById(id);

            return View(contato);
        }

        [HttpPost]
        public ActionResult Edit(ContatoModel contato)
        {
            _business.Save(contato);

            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            _business.Delete(id);

            return RedirectToAction("Index");
        }
    }
}