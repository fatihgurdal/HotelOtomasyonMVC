using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;
using ProjectTemplate.Core.Abstractions.Service;
using ProjectTemplate.Core.Entities;
using WebApplication1.Convert;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class CustomerController : BaseController
    {
        private readonly IServiceCustomers _serviceCustomers;
        private readonly IServiceNationalities _serviceNationalities;
        private readonly IServiceStayingInRoom _serviceStayingInRoom;
        public CustomerController(IServiceCustomers serviceCustomers,IServiceNationalities serviceNationalities,IServiceStayingInRoom serviceStayingInRoom)
        {
            _serviceCustomers = serviceCustomers;
            _serviceNationalities = serviceNationalities;
            _serviceStayingInRoom = serviceStayingInRoom;
        }
        public ActionResult Index()
        {
            return RedirectToAction("CustomerList");
        }
        [HttpGet]
        public ActionResult CustomerInsert()
        {
            List<string> BloodGroup = new List<string>()
            {
                "0 RH-",
                "0 RH+",
                "A RH+",
                "B RH+",
                "A RH-",
                "B RH-",
                "AB RH+",
                "AB RH-"
            };
            IEnumerable<SelectListItem> BloodGroups =
                BloodGroup.Select(x => new SelectListItem {Text = x, Value = x}).ToList();
            ViewBag.BloodGroup = BloodGroups;
            IEnumerable<SelectListItem> Nationalitys =
                _serviceNationalities.GetAll().Select(x => new SelectListItem {Text = x.CountryName, Value = x.Id.ToString()}).ToList();
                ViewBag.Nationalitys = Nationalitys;
            return View();
        }
        [HttpPost]
        public ActionResult CustomerInsert(CustomersModel customersModel)
        {
            if (ModelState.IsValid)
            {
                _serviceCustomers.Insert(customersModel.ModelToEnity());
            }
            return RedirectToAction("CustomerList");
        }

        public ActionResult CustomerDetail(int id)
        {
            if (_serviceCustomers.GetById(id)!=null)
            {
                CustomersModel customersModel = _serviceCustomers.GetById(id).EntityToModel(true);
                
                return View(customersModel);
            }
            else
            {
                return RedirectToAction("CustomerList");
            }
            
            
        }
        [HttpGet]
        public ActionResult CustomerEdit(int id=1)
        {
            if (_serviceCustomers.GetById(id)!=null)
            {
                IEnumerable<SelectListItem> Nationalitys =
                   _serviceNationalities.GetAll().Select(x => new SelectListItem { Text = x.CountryName, Value = x.Id.ToString() }).ToList();
                ViewBag.Nationalitys = Nationalitys;
                return View(_serviceCustomers.GetById(id).EntityToModel(true));
            }
            else
            {
                return RedirectToAction("CustomerList");
            }
        }
        [HttpPost]
        public ActionResult CustomerEdit(CustomersModel customersModel)
        {

            Customers customers = customersModel.ModelToEnity();
            _serviceCustomers.Update(customers);
            return RedirectToAction("CustomerEdit");
        }

        [HttpPost]
        public JsonResult CustomerDelete(int id)
        {
            
            if (_serviceCustomers.GetById(id)!=null)
            {
                Customers c = _serviceCustomers.GetById(id);
                c.IsActive = false;
                _serviceCustomers.Update(c);
                return Json(true, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            
           
        }
        public ActionResult CustomerList()
        {
            List<CustomersModel> CustomersModelList = new List<CustomersModel>();
            foreach (var item in _serviceCustomers.GetAll())
            {
                CustomersModelList.Add(new CustomersModel()
                {
                    Description = item.Description,
                    Name = item.Name,
                    BloodGroup = item.BloodGroup,
                    DateOfBirth = item.DateOfBirth,
                    EmailAddress = item.EmailAddress,
                    IdentificationNumber = item.IdentificationNumber,
                    Address = item.Address,
                    IsMale = item.IsMale,
                    IsMarried = item.IsMale,
                    NationalityId = item.NationalityId,
                    PhoneNumber = item.PhoneNumber,
                    Surname = item.Surname,
                    Nationality = item.Nationality,
                    Sales = item.Sales,
                    StayingInRoom = item.StayingInRoom,
                    Id = item.Id
                });
            }
            return View(CustomersModelList);
        }
        public ActionResult CustomersStayingInTheHotelTodayList()
        {
            List<StayingInRoomModel> stayingInRoomModels;
            if (_serviceStayingInRoom.GetAll().Any())
            {
                stayingInRoomModels = _serviceStayingInRoom.GetAll().Select(item => new StayingInRoomModel()
                {
                    Customer = item.Customer,
                    Id = item.Id,
                    RoomSale = item.RoomSale
                }).ToList();
            }
            else
            {
                    stayingInRoomModels=new List<StayingInRoomModel>();
            }
            
            return View(stayingInRoomModels);
        }

        public ActionResult CustomersArrivingTodayList()
        {
            return View();
        }
        public ActionResult CustomersWillLeaveTodayList()
        {
            return View();
        }

        public ActionResult NationalityInsert()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NationalityInsert(NationalitiesModel nationalitiesModel)
        {
            _serviceNationalities.Insert(nationalitiesModel.ModelToEnity());
            return RedirectToAction("NationalityList");
        }
        public ActionResult NationalityEdit(int id)
        {
            return View(_serviceNationalities.GetById(id).EntityToModel());
        }
        [HttpPost]
        public ActionResult NationalityEdit(NationalitiesModel nationalitiesModel)
        {
            _serviceNationalities.Update(nationalitiesModel.ModelToEnity());
            return RedirectToAction("NationalityEdit");
        }
        public ActionResult NationalityList()
        {
            return View(_serviceNationalities.GetAll().EntityToModelList());
        }
        [HttpPost]
        public JsonResult NationalityDelete(int id)
        {
            if (_serviceNationalities.GetById(id) != null)
            {
                return !_serviceNationalities.GetById(id).Customers.Any() ? Json(_serviceNationalities.Delete(_serviceNationalities.GetById(id))>0, JsonRequestBehavior.AllowGet) : Json(false, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
    }
}