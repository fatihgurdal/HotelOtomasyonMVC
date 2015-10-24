using ProjectTemplate.Core.Abstractions.Service;
using ProjectTemplate.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Convert;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ProductController : BaseController
    {
        private readonly IServiceExtraProducts _serviceExtraProducts;
        private readonly IServiceExtraProductCategories _serviceExtraProductCategories;
        public ProductController(IServiceExtraProducts serviceExtraProducts, IServiceExtraProductCategories serviceExtraProductCategories)
        {
            _serviceExtraProducts = serviceExtraProducts;
            _serviceExtraProductCategories = serviceExtraProductCategories;
        }
        // GET: Product
        public ActionResult Index()
        {
            return RedirectToAction("ProductList");
        }


        public ActionResult ProductInsert()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ProductInsert(ExtraProductsModel model)
        {
            if (ModelState.IsValid)
            {
                _serviceExtraProducts.Insert(model.ModelToEnity());
            }

            return RedirectToAction("ProductList");
        }

        public ActionResult ProductList()
        {
            return View(_serviceExtraProducts.GetAll().Where(x => x.IsActive == true).EntityToModelList());
        }

        public ActionResult ProductEdit(int id)
        {
            if (_serviceExtraProducts.GetById(id).EntityToModel() != null)
            {
                return View(_serviceExtraProducts.GetById(id).EntityToModel());
            }
            else
            {
                return RedirectToAction("ProductList");
            }
        }

        [HttpPost]
        public ActionResult ProductEdit(ExtraProductsModel model)
        {
            if (ModelState.IsValid)
            {
                _serviceExtraProducts.Update(model.ModelToEnity(true));
            }

            return RedirectToAction("ProductList");
        }

        public ActionResult ProductDetails(int id)
        {
            if (_serviceExtraProducts.GetById(id).EntityToModel() != null)
            {
                return View(_serviceExtraProducts.GetById(id).EntityToModel());
            }
            else
            {
                return RedirectToAction("ProductList");
            }
        }

        [HttpPost]
        public JsonResult ProductDelete(int id)
        {

            if (_serviceExtraProducts.GetById(id) != null)
            {
                ExtraProducts p = _serviceExtraProducts.GetById(id);
                p.IsActive = false;
                _serviceExtraProducts.Update(p);
                return Json(true, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }


        }



        public ActionResult CategoryInsert()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CategoryInsert(ExtraProductCategoriesModel model)
        {
            if (ModelState.IsValid)
            {
                _serviceExtraProductCategories.Insert(model.ModelToEnity());
            }

            return RedirectToAction("CategoryList");
        }

        public ActionResult CategoryList()
        {
            return View(_serviceExtraProductCategories.GetAll().Where(x => x.IsActive == true).EntityToModelList());
        }

        public ActionResult CategoryEdit(int id)
        {
            if (_serviceExtraProductCategories.GetById(id).EntityToModel() != null)
            {
                return View(_serviceExtraProductCategories.GetById(id).EntityToModel());
            }
            else
            {
                return RedirectToAction("CategoryList");
            }
        }

        [HttpPost]
        public ActionResult CategoryEdit(ExtraProductCategoriesModel model)
        {
            if (ModelState.IsValid)
            {
                _serviceExtraProductCategories.Update(model.ModelToEnity(true));
            }

            return RedirectToAction("CategoryList");
        }

        public ActionResult CategoryDetails(int id)
        {
            if (_serviceExtraProductCategories.GetById(id).EntityToModel() != null)
            {
                return View(_serviceExtraProductCategories.GetById(id).EntityToModel());
            }
            else
            {
                return RedirectToAction("CategoryList");
            }
        }

        [HttpPost]
        public JsonResult CategoryDelete(int id)
        {

            if (_serviceExtraProductCategories.GetById(id) != null)
            {
                ExtraProductCategories p = _serviceExtraProductCategories.GetById(id);
                p.IsActive = false;
                _serviceExtraProductCategories.Update(p);
                return Json(true, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }


        }
    }
}