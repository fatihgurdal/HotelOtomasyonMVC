using ProjectTemplate.Core.Abstractions.Service;
using ProjectTemplate.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using WebApplication1.Convert;//burada zaten ekli  o yüzden her stringde o metotu görebileceğiz.

namespace WebApplication1.Controllers
{

    public class EmployeeController : BaseController
    {
        readonly IServiceEmployees _serviceEmployees;
        readonly IServiceGroupsOfEmployee _servicegroupsOfEmployee;
        readonly IServicePermits _servicePermits;
        readonly IServicePermitTypes _servicePermitTypes;
        readonly IServiceEmployeeShifts _serviceEmployeeShifts;
        readonly IServiceShifts _serviceShifts;

        public EmployeeController(IServiceEmployees serviceEmployees, IServiceGroupsOfEmployee servicegroupsOfEmployee, IServiceShifts serviceShifts, IServicePermitTypes servicePermitTypes, IServicePermits servicePermits, IServiceEmployeeShifts serviceEmployeeShifts)
        {
            _serviceEmployees = serviceEmployees;
            _servicegroupsOfEmployee = servicegroupsOfEmployee;
            _servicePermits = servicePermits;
            _servicePermitTypes = servicePermitTypes;
            _serviceEmployeeShifts = serviceEmployeeShifts;
            _serviceShifts = serviceShifts;
        }
        // GET: Employee
        public ActionResult Index()
        {
            return RedirectToAction("EmployeeList");
        }

        #region Çalışan
        [HttpGet]
        public ActionResult EmployeeInsert()
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
                BloodGroup.Select(x => new SelectListItem { Text = x, Value = x }).ToList();
            ViewBag.BloodGroup = BloodGroups;

            IEnumerable<SelectListItem> groupsofemployeelist = _servicegroupsOfEmployee.GetAll().Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.Name }).ToList();

            ViewBag.GroupsOfEmployeeId = groupsofemployeelist;
            return View();
        }

        [HttpPost]
        public ActionResult EmployeeInsert(EmployeesModel employeeModel)
        {
            Employees emp = employeeModel.ModelToEntity(); 
            emp.IsActive = true;
            _serviceEmployees.Insert(emp);
        
            return RedirectToAction("EmployeeList");
        }

        public ActionResult EmployeeDetails(int id)
        {
            EmployeesModel emp = _serviceEmployees.GetById(id).EntityToModel();
            return View(emp);
        }
        [HttpGet]
        public ActionResult EmployeeEdit(int id)
        {
            Employees employee = _serviceEmployees.GetById(id);
            if (_serviceEmployees.GetById(id) != null)
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
                    BloodGroup.Select(x => new SelectListItem { Text = x, Value = x, Selected = (employee.BloodGroup == x) }).ToList();
                ViewBag.BloodGroup = BloodGroups;
                IEnumerable<SelectListItem> groupsofemployeelist = _servicegroupsOfEmployee.GetAll().Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.Name, Selected = (employee.GroupsOfEmployeeId == x.Id) }).ToList().Distinct();
                ViewBag.GroupsOfEmployeeId = groupsofemployeelist;

                return View(employee.EntityToModel(true));
            }
            else
                return RedirectToAction("EmployeeList");

        }

        [HttpPost]
        public ActionResult EmployeeEdit(EmployeesModel employeeModel)
        {
            Employees employee = employeeModel.ModelToEntity();
            employee.IsActive = true;
            _serviceEmployees.Update(employee);
            return RedirectToAction("EmployeeList");
        }

        public ActionResult EmployeeDelete(int id)
        {
            Employees employeeDelete = _serviceEmployees.GetById(id);
            employeeDelete.IsActive = false;
            _serviceEmployees.Update(employeeDelete);
            return RedirectToAction("EmployeeList");
        }

        public ActionResult EmployeeList()
        {
            return View(_serviceEmployees.GetAll().EntityToModelList().Where(x => x.IsActive));
        }

        #endregion

        #region İzin

        public ActionResult PermitList()
        {
            return View(_servicePermits.GetAll().Where(x => x.IsActive).EntityToModelList(true));
        }

        [HttpGet]
        public ActionResult PermitInsert()
        {
            IEnumerable<SelectListItem> permitTypesList = _servicePermitTypes.GetAll().Select(x => new SelectListItem { Text = x.Name, Value = x.Id.ToString() }).ToList();
            ViewBag.PermitTypeId = permitTypesList;
            IEnumerable<SelectListItem> employeIdList = _serviceEmployees.GetAll().Select(x => new SelectListItem { Text = x.Name, Value = x.Id.ToString() }).ToList();
            ViewBag.EmployeeId = employeIdList;
            return View();
        }

        [HttpPost]
        public ActionResult PermitInsert(PermitsModel permitsModel)
        {
            Permits permit = permitsModel.ModelToEnity();
            permit.IsActive = true;
            _servicePermits.Insert(permit);
            return RedirectToAction("PermitList");
        }

        [HttpGet]
        public ActionResult PermitEdit(int id)
        {
            IEnumerable<SelectListItem> permitlist = _servicePermits.GetAll().Select(x => new SelectListItem { Text = x.PermitType.Name, Value = x.PermitType.Id.ToString(), Selected = (x.Id == id) }).ToList();
            ViewBag.PermitTypeId = permitlist;

            IEnumerable<SelectListItem> employeelist = _servicePermits.GetAll().Select(x => new SelectListItem { Text = x.Employee.Name, Value = x.EmployeeId.ToString(), Selected = (x.Id == id) }).Distinct().ToList();
            ViewBag.EmployeeId = employeelist;

            return View(_servicePermits.GetById(id).EntityToModel(true));
        }

        [HttpPost]
        public ActionResult PermitEdit(PermitsModel permits)
        {
            Permits permit = permits.ModelToEnity(true);
            permit.IsActive = true;
            _servicePermits.Update(permit);
            return RedirectToAction("PermitList");
        }

        [HttpPost]
        public ActionResult PermitDelete(int id)
        {
            Permits permit = _servicePermits.GetById(id);
            permit.IsActive = false;
            _servicePermits.Update(permit);
            return RedirectToAction("PermitList");
        }

        public ActionResult PermitDetails(int id)
        {
            return View(_servicePermits.GetById(id).EntityToModel(true));
        }

        #endregion
        
        #region PersonelVardiya

        public ActionResult EmployeeShiftList()
        {
            return View(_serviceEmployeeShifts.GetAll().Where(x=> x.IsActive == true).EntityToModelList(true));
        }
        [HttpGet]
        public ActionResult EmployeeShiftInsert()
        {
            IEnumerable<SelectListItem> empList = _serviceEmployees.GetAll().Select(x => new SelectListItem { Text = x.Name + " " + x.Surname, Value = x.Id.ToString() });
            ViewBag.EmployeeId = empList;
            return View();
        }
        [HttpPost]
        public ActionResult EmployeeShiftInsert(EmployeeShiftsModel empShiftModel)
        {
            EmployeeShifts emps = empShiftModel.ModelToEnity();
            emps.IsActive = true;
            _serviceEmployeeShifts.Insert(emps);
            return RedirectToAction("EmployeeShiftList");
        }

        public ActionResult EmployeeShiftDelete(int id)
        {
          EmployeeShifts empShift=  _serviceEmployeeShifts.GetById(id);
          empShift.IsActive = false;
          _serviceEmployeeShifts.Update(empShift);
            return RedirectToAction("EmployeeShiftList");
        }
        #endregion

        #region İzin Tipi

        public ActionResult PermitTypeList()
        {
            return View(_servicePermitTypes.GetAll().Where(x=>x.IsActive==true).EntityToModelList());
        }
        [HttpGet]
        public ActionResult PermitTypeInsert()
        {
            return View();
        }
        [HttpPost]
        public ActionResult PermitTypeInsert(PermitTypesModel permitTypes)
        {
            PermitTypes permitType = permitTypes.ModelToEnity();
            permitType.IsActive = true;
            _servicePermitTypes.Insert(permitType);
            return RedirectToAction("PermitTypeList");
        }

        public ActionResult PermitTypeDelete(int id)
        {
            _servicePermitTypes.GetById(id).IsActive = false;
            _servicePermitTypes.Update(_servicePermitTypes.GetById(id));
            return RedirectToAction("PermitTypeList");
        }

        #endregion

    }
}