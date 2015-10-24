using ProjectTemplate.Core.Abstractions.Service;
using ProjectTemplate.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class ReserveCancelLogController : BaseController
    {
        private readonly IServiceReserveCancelLog _serviceReserveCancelLog;
        public ReserveCancelLogController(IServiceReserveCancelLog serviceReserveCancelLog)
        {
            _serviceReserveCancelLog = serviceReserveCancelLog;
        }
        // GET: ReserveCancelLog
        public ActionResult Insert()
        {
            ReserveCancelLog x = new ReserveCancelLog() { CustomerId = 1, Id = 1, ReserveCancelDate = DateTime.Now, ReserveDate = DateTime.Now, SaleId = 1, Description = "yeni kayıt" };
            _serviceReserveCancelLog.Insert(x);
            return View();
        }
    }
}