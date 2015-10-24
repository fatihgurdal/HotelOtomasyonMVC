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
    public class DepartmanShiftController : BaseController
    {
        private readonly IServiceDepartments _serviceDepartments;
        private readonly IServiceGroupsOfEmployee _serviceGroupsOfEmployee;
        private readonly IServiceShifts _serviceShifts;
        public DepartmanShiftController(IServiceDepartments serviceDepartments, IServiceGroupsOfEmployee serviceGroupsOfEmployee, IServiceShifts serviceShifts)
        {
            _serviceDepartments = serviceDepartments;
            _serviceGroupsOfEmployee = serviceGroupsOfEmployee;
            _serviceShifts = serviceShifts;
        }
        // GET: DepartmanShift
        public ActionResult Index()
        {
            return RedirectToAction("DepartmentList");
        }

        public ActionResult DepartmentInsert()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DepartmentInsert(DepartmentsModel model)
        {
            if (ModelState.IsValid)
            {
                _serviceDepartments.Insert(model.ModelToEnity(true));
            }

            return RedirectToAction("DepartmentList");
        }

        public ActionResult DepartmentList()
        {

            return View(_serviceDepartments.GetAll().Where(x => x.IsActive == true).EntityToModelList());
        }

        [HttpPost]
        public JsonResult DepartmentDelete(int id)
        {

            if (_serviceDepartments.GetById(id) != null)
            {
                Departments p = _serviceDepartments.GetById(id);
                p.IsActive = false;
                _serviceDepartments.Update(p);
                return Json(true, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }


        }

        public ActionResult DepartmentEdit(int id)
        {
            if (_serviceDepartments.GetById(id).EntityToModel() != null)
            {
                return View(_serviceDepartments.GetById(id).EntityToModel());
            }
            else
            {
                return RedirectToAction("DepartmentList");
            }
        }

        [HttpPost]
        public ActionResult DepartmentEdit(DepartmentsModel model)
        {
            if (ModelState.IsValid)
            {
                _serviceDepartments.Update(model.ModelToEnity(true));
            }

            return RedirectToAction("DepartmentList");
        }

        public ActionResult DepartmentDetails(int id)
        {
            if (_serviceDepartments.GetById(id).EntityToModel() != null)
            {
                return View(_serviceDepartments.GetById(id).EntityToModel());
            }
            else
            {
                return RedirectToAction("DepartmentList");
            }
        }


        public ActionResult GroupInsert()
        {
            ViewBag.Departmanlar = _serviceDepartments.GetAll().Select(x => new SelectListItem { Text = x.Name, Value = x.Id.ToString() }).ToList();
            return View();
        }

        [HttpPost]
        public ActionResult GroupInsert(GroupsOfEmployeeModel model)
        {
            ViewBag.Departmanlar = _serviceDepartments.GetAll().Select(x => new SelectListItem { Text = x.Name, Value = x.Id.ToString() }).ToList();
            if (ModelState.IsValid)
            {
                _serviceGroupsOfEmployee.Insert(model.ModelToEnity(true));
            }

            return RedirectToAction("GroupList");
        }

        public ActionResult GroupList()
        {

            return View(_serviceGroupsOfEmployee.GetAll().Where(x => x.IsActive == true).EntityToModelList(true));
        }

        [HttpPost]
        public JsonResult GroupDelete(int id)
        {

            if (_serviceGroupsOfEmployee.GetById(id) != null)
            {
                GroupsOfEmployee p = _serviceGroupsOfEmployee.GetById(id);
                p.IsActive = false;
                _serviceGroupsOfEmployee.Update(p);
                return Json(true, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }


        }

        public ActionResult GroupEdit(int id)
        {
            if (_serviceGroupsOfEmployee.GetById(id).EntityToModel()!= null)
            {
                ViewBag.Departmanlar = _serviceDepartments.GetAll().Select(x => new SelectListItem { Text = x.Name, Value = x.Id.ToString() }).ToList();
                return View(_serviceGroupsOfEmployee.GetById(id).EntityToModel());
            }
            else
            {
                return RedirectToAction("GroupList");
            }

        }

        [HttpPost]
        public ActionResult GroupEdit(GroupsOfEmployeeModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Departmanlar = _serviceDepartments.GetAll().Select(x => new SelectListItem { Text = x.Name, Value = x.Id.ToString() }).ToList();
                _serviceGroupsOfEmployee.Update(model.ModelToEnity(true));
            }

            return RedirectToAction("GroupList");
        }

        public ActionResult GroupDetails(int id)
        {
            if (_serviceGroupsOfEmployee.GetById(id).EntityToModel()!=null)
            {
                return View(_serviceGroupsOfEmployee.GetById(id).EntityToModel(true));
            }
            else
            {
                return RedirectToAction("GroupList");
            }
        }

        public ActionResult ShiftInsert()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ShiftInsert(ShiftsModel model)
        {
            if (ModelState.IsValid)
            {
                _serviceShifts.Insert(model.ModelToEnity(true));
            }
            
            return RedirectToAction("ShiftList");
        }

        public ActionResult ShiftList()
        {

            return View(_serviceShifts.GetAll().Where(x => x.IsActive == true).EntityToModelList());
        }

        [HttpPost]
        public JsonResult ShiftDelete(int id)
        {

            if (_serviceShifts.GetById(id) != null)
            {
                Shifts p = _serviceShifts.GetById(id);
                p.IsActive = false;
                _serviceShifts.Update(p);
                return Json(true, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }


        }

        public ActionResult ShiftEdit(int id)
        {
            if (_serviceShifts.GetById(id).EntityToModel()!=null)
            {
                return View(_serviceShifts.GetById(id).EntityToModel());
            }
            else
            {
                return RedirectToAction("ShiftList");
            }
        }

        [HttpPost]
        public ActionResult ShiftEdit(ShiftsModel model)
        {
            if (ModelState.IsValid)
            {
                _serviceShifts.Update(model.ModelToEnity(true));
            }
            
            return RedirectToAction("ShiftList");
        }

        public ActionResult ShiftDetails(int id)
        {
            if (_serviceShifts.GetById(id).EntityToModel()!=null)
            {
                 return View(_serviceShifts.GetById(id).EntityToModel());
            }
            else
            {
                return RedirectToAction("ShiftList");
            }
        }
    }
}