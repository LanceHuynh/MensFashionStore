using MensFashionStore.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MensFashionStore.Controllers
{
    public class ShirtController : Controller
    {
        private ClothingRepository _clothingRepository = new ClothingRepository();
        public ActionResult Index()
        {
            return View(_clothingRepository.GetClothing("Shirt"));
        }
        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            return View(_clothingRepository.GetClothing((int)id));
        }
    }
}