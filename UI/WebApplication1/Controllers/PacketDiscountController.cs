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
    public class PacketDiscountController : BaseController
    {
        private readonly IServicePackets _servicePackets;
        private readonly IServiceExtraProductCategories _serviceExtraProductCategories;
        private readonly IServicePacketsExtraProductCategories _servicePacketsExtraProductCategories;
        private readonly IServiceDiscounts _serviceDiscounts;
        public PacketDiscountController(IServicePackets servicePackets, IServiceExtraProductCategories serviceExtraProductCategories, IServicePacketsExtraProductCategories servicePacketsExtraProductCategories, IServiceDiscounts serviceDiscounts)
        {
            _servicePackets = servicePackets;
            _serviceExtraProductCategories = serviceExtraProductCategories;
            _servicePacketsExtraProductCategories = servicePacketsExtraProductCategories;
            _serviceDiscounts = serviceDiscounts;
        }
        // GET: Discount
        public ActionResult Index()
        {
            return RedirectToAction("PacketList");
        }

        public ActionResult PacketInsert()
        {

            return View();
        }

        [HttpPost]
        public ActionResult PacketInsert(PacketsModel model)
        {
            if (ModelState.IsValid)
            {
                _servicePackets.Insert(model.ModelToEnity());
            }

            return RedirectToAction("PacketList");
        }

        public ActionResult PacketEdit(int id)
        {
            if (_servicePackets.GetById(id) != null)
            {
                PacketsModel model = _servicePackets.GetById(id).EntityToModel();
                return View(model);
            }
            else
            {
                return RedirectToAction("PacketList");
            }
        }
        [HttpPost]
        public ActionResult PacketEdit(PacketsModel model)
        {
            if (ModelState.IsValid)
            {
                _servicePackets.Update(model.ModelToEnity());
            }

            return RedirectToAction("PacketList");
        }

        public ActionResult PacketDetails(int id)
        {
            if (_servicePackets.GetById(id).EntityToModel() != null)
            {
                return View(_servicePackets.GetById(id).EntityToModel(true));
            }
            else
            {
                return RedirectToAction("PacketList");
            }
        }

        [HttpPost]
        public JsonResult PacketDelete(int id)
        {

            if (_servicePackets.GetById(id) != null)
            {
                Packets p = _servicePackets.GetById(id);
                p.IsActive = false;
                _servicePackets.Update(p);
                return Json(true, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }


        }
        public ActionResult PacketList()
        {
            return View(_servicePackets.GetAll().Where(x => x.IsActive == true).EntityToModelList());
        }
        public ActionResult PacketCategoryInsert()
        {
            ViewBag.Kategoriler = _serviceExtraProductCategories.GetAll().Where(x => x.IsActive == true).Select(x => new SelectListItem { Text = x.Name, Value = x.Id.ToString() }).ToList();

            ViewBag.Paketler = _servicePackets.GetAll().Where(x => x.IsActive == true).Select(x => new SelectListItem { Text = x.Name, Value = x.Id.ToString() }).ToList();

            return View();
        }

        public ActionResult PacketCategoryEdit(int id)
        {
            if (_servicePacketsExtraProductCategories.GetById(id).EntityToModel() != null)
            {
                ViewBag.Kategoriler = _serviceExtraProductCategories.GetAll().Where(x => x.IsActive == true).Select(x => new SelectListItem { Text = x.Name, Value = x.Id.ToString() }).ToList();

                ViewBag.Paketler = _servicePackets.GetAll().Where(x => x.IsActive == true).Select(x => new SelectListItem { Text = x.Name, Value = x.Id.ToString() }).ToList();


                return View(_servicePacketsExtraProductCategories.GetById(id).EntityToModel());
            }
            else
            {
                return RedirectToAction("PacketCategoryList");
            }
        }

        [HttpPost]
        public ActionResult PacketCategoryEdit(PacketsExtraProductCategoriesModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Kategoriler = _serviceExtraProductCategories.GetAll().Where(x => x.IsActive == true).Select(x => new SelectListItem { Text = x.Name, Value = x.Id.ToString() }).ToList();

                ViewBag.Paketler = _servicePackets.GetAll().Where(x => x.IsActive == true).Select(x => new SelectListItem { Text = x.Name, Value = x.Id.ToString() }).ToList();

                _servicePacketsExtraProductCategories.Update(model.ModelToEnity());
            }


            return RedirectToAction("PacketCategoryList");
        }

        [HttpPost]
        public ActionResult PacketCategoryInsert(PacketsExtraProductCategoriesModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Kategoriler = _serviceExtraProductCategories.GetAll().Where(x => x.IsActive == true).Select(x => new SelectListItem { Text = x.Name, Value = x.Id.ToString() }).ToList();

                ViewBag.Paketler = _servicePackets.GetAll().Where(x => x.IsActive == true).Select(x => new SelectListItem { Text = x.Name, Value = x.Id.ToString() }).ToList();


                _servicePacketsExtraProductCategories.Insert(model.ModelToEnity());
            }


            return RedirectToAction("PacketCategoryList");
        }

        public ActionResult PacketCategoryDetails(int id)
        {
            if (_servicePacketsExtraProductCategories.GetById(id).EntityToModel() != null)
            {
                return View(_servicePacketsExtraProductCategories.GetById(id).EntityToModel(true));
            }
            else
            {
                return RedirectToAction("PacketCategoryList");
            }
        }
        public ActionResult PacketCategoryList()
        {
            return View(_servicePacketsExtraProductCategories.GetAll().Where(x => x.IsActive == true).EntityToModelList(true));
        }

        [HttpPost]
        public JsonResult PacketCategoryDelete(int id)
        {

            if (_servicePacketsExtraProductCategories.GetById(id) != null)
            {
                PacketsExtraProductCategories p = _servicePacketsExtraProductCategories.GetById(id);
                p.IsActive = false;
                _servicePacketsExtraProductCategories.Update(p);
                return Json(true, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }


        }

        public ActionResult DiscountInsert()
        {

            return View();
        }

        [HttpPost]
        public ActionResult DiscountInsert(DiscountsModel model)
        {
            if (ModelState.IsValid)
            {
                _serviceDiscounts.Insert(model.ModelToEnity());
            }

            return RedirectToAction("DiscountList");
        }

        public ActionResult DiscountList()
        {
            return View(_serviceDiscounts.GetAll().Where(x => x.IsActive == true).EntityToModelList(true));
        }

        public ActionResult DiscountEdit(int id)
        {
            if (_serviceDiscounts.GetById(id).EntityToModel() != null)
            {
                DiscountsModel model = _serviceDiscounts.GetById(id).EntityToModel();
                return View(model);
            }
            else
            {
                return RedirectToAction("DiscountList");
            }
        }
        [HttpPost]
        public ActionResult DiscountEdit(DiscountsModel model)
        {
            if (ModelState.IsValid)
            {
                _serviceDiscounts.Update(model.ModelToEnity(true));
            }
            
            return RedirectToAction("DiscountList");
        }

        public ActionResult DiscountDetails(int id)
        {
            if (_serviceDiscounts.GetById(id).EntityToModel()!=null)
            {
                 return View(_serviceDiscounts.GetById(id).EntityToModel(true));
            }
            else
            {
                return RedirectToAction("DiscountList");
            }
        }

        [HttpPost]
        public JsonResult DiscountDelete(int id)
        {

            if (_serviceDiscounts.GetById(id) != null)
            {
                Discounts p = _serviceDiscounts.GetById(id);
                p.IsActive = false;
                _serviceDiscounts.Update(p);
                return Json(true, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }


        }
    }
}