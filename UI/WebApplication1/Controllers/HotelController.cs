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
    public class HotelController : BaseController
    {
        // GET: Hotel
        private readonly IServiceHotelFeatures _serviceHotelFeatures;
        private readonly IServicePaymentMethods _servicePaymentMethods;
        public HotelController(IServiceHotelFeatures serviceHotelFeatures, IServicePaymentMethods servicePaymentMethods)
        {
            _serviceHotelFeatures = serviceHotelFeatures;
            _servicePaymentMethods = servicePaymentMethods;
        }
        public ActionResult Index()
        {
            return RedirectToAction("HotelFeatureList");
        }

        public ActionResult HotelFeatureInsert()
        {
            return View();
        }
        [HttpPost]
        public ActionResult HotelFeatureInsert(HotelFeaturesModel model)
        {
            if (ModelState.IsValid)
            {
                _serviceHotelFeatures.Insert(model.ModelToEnity());
            }
            
            return RedirectToAction("HotelFeatureList");
        }

        public ActionResult HotelFeatureList()
        {
            return View(_serviceHotelFeatures.GetAll().Where(x => x.IsActive == true).EntityToModelList());
        }

        public ActionResult HotelFeatureEdit(int id)
        {
            if (_serviceHotelFeatures.GetById(id)!=null)
            {
                return View(_serviceHotelFeatures.GetById(id).EntityToModel());
            }
            else
            {
                return RedirectToAction("HotelFeatureList");
            }
        }

        [HttpPost]
        public ActionResult HotelFeatureEdit(HotelFeaturesModel model)
        {
            if (ModelState.IsValid)
            {
                 _serviceHotelFeatures.Update(model.ModelToEnity(true));
            }
           
            return RedirectToAction("HotelFeatureList");
        }

        public ActionResult HotelFeatureDetails(int id)
        {
            if (_serviceHotelFeatures.GetById(id)!=null)
            {
                return View(_serviceHotelFeatures.GetById(id).EntityToModel());
            }
            else
            {
                return RedirectToAction("HotelFeatureList");
            }
        }

        [HttpPost]
        public JsonResult HotelFeatureDelete(int id)
        {

            if (_serviceHotelFeatures.GetById(id) != null)
            {
                HotelFeatures p = _serviceHotelFeatures.GetById(id);
                p.IsActive = false;
                _serviceHotelFeatures.Update(p);
                return Json(true, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }


        }


        public ActionResult PaymentMethodInsert()
        {
            return View();
        }
        [HttpPost]
        public ActionResult PaymentMethodInsert(PaymentMethodsModel model)
        {
            if (ModelState.IsValid)
            {
                _servicePaymentMethods.Insert(model.ModelToEnity());
            }
            
            return RedirectToAction("PaymentMethodList");
        }

        public ActionResult PaymentMethodList()
        {
            return View(_servicePaymentMethods.GetAll().Where(x => x.IsActive == true).EntityToModelList());
        }

        public ActionResult PaymentMethodEdit(int id)
        {
            return View(_servicePaymentMethods.GetById(id).EntityToModel());
        }

        [HttpPost]
        public ActionResult PaymentMethodEdit(PaymentMethodsModel model)
        {
            if (ModelState.IsValid)
            {
                _servicePaymentMethods.Update(model.ModelToEnity(true));
            }
            
            return RedirectToAction("PaymentMethodList");
        }

        public ActionResult PaymentMethodDetails(int id)
        {
            if (_servicePaymentMethods.GetById(id)!=null)
            {
                return View(_servicePaymentMethods.GetById(id).EntityToModel());
            }
            else
            {
                return RedirectToAction("PaymentMethodList");
            }
        }

        [HttpPost]
        public JsonResult PaymentMethodDelete(int id)
        {

            if (_servicePaymentMethods.GetById(id) != null)
            {
                PaymentMethods p = _servicePaymentMethods.GetById(id);
                p.IsActive = false;
                _servicePaymentMethods.Update(p);
                return Json(true, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }


        }

    }
}