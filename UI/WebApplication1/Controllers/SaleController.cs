using ProjectTemplate.Core.Abstractions.Service;
using ProjectTemplate.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Razor.Text;
using System.Web.Routing;
using Microsoft.Ajax.Utilities;
using WebApplication1.Convert;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class SaleController : BaseController
    {
        #region Servisler
        private readonly IServiceSales _serviceSales;
        private readonly IServiceCustomers _serviceCustomers;
        private readonly IServiceEmployees _serviceEmployees;
        private readonly IServicePaymentMethods _servicePaymentMethods;
        private readonly IServiceDiscounts _serviceDiscounts;
        private readonly IServicePackets _servicePackets;
        private readonly IServiceRooms _serviceRooms;
        private readonly IServiceRoomSales _serviceRoomSales;
        private readonly IServiceStatuses _serviceStatuses;
        private readonly IServiceRoomStatuses _serviceRoomStatuses;
        private readonly IServiceExtraProducts _serviceExtraProducts;
        private readonly IServiceSaleExtras _serviceSaleExtras;
        private readonly IServiceStayingInRoom _serviceStayingInRoom;
        private readonly IServiceRoomTypes _serviceRoomTypes;
        #endregion

        public SaleController(IServiceSales serviceSales, IServiceCustomers serviceCustomers, IServiceEmployees serviceEmployees, IServicePaymentMethods servicePaymentMethods, IServiceDiscounts serviceDiscounts, IServicePackets servicePackets, IServiceRooms serviceRooms, IServiceRoomSales serviceRoomSales, IServiceStatuses serviceStatuses, IServiceRoomStatuses serviceRoomStatuses, IServiceExtraProducts serviceExtraProducts, IServiceSaleExtras serviceSaleExtras, IServiceStayingInRoom serviceStayingInRoom,IServiceRoomTypes serviceRoomTypes)
        {
            _serviceSales = serviceSales;
            _serviceCustomers = serviceCustomers;
            _serviceEmployees = serviceEmployees;
            _servicePaymentMethods = servicePaymentMethods;
            _serviceDiscounts = serviceDiscounts;
            _servicePackets = servicePackets;
            _serviceRooms = serviceRooms;
            _serviceRoomSales = serviceRoomSales;
            _serviceStatuses = serviceStatuses;
            _serviceRoomStatuses = serviceRoomStatuses;
            _serviceExtraProducts = serviceExtraProducts;
            _serviceSaleExtras = serviceSaleExtras;
            _serviceStayingInRoom = serviceStayingInRoom;
            _serviceRoomTypes = serviceRoomTypes;

        }
        // GET: Sale
        public ActionResult Index()
        {
            return RedirectToAction("OpenSale","Sale");
        }


        //Satış açmak için kullanılacak
        public ActionResult OpenSale()
        {

            var Musteriler = _serviceCustomers.GetAll().Select(x => new SelectListItem { Text= x.Name+" "+ x.Surname, Value=x.Id.ToString() }).ToList();
            var Personeller = _serviceEmployees.GetAll().Select(x => new SelectListItem { Text = x.Name + " " + x.Surname, Value = x.Id.ToString() }).ToList();
            ViewBag.Musteriler = Musteriler;
            ViewBag.Personeller = Personeller;

            return View();
        }
        [HttpPost]
        public ActionResult OpenSale(SalesModel model)
        {
            var Musteriler = _serviceCustomers.GetAll().Select(x => new SelectListItem { Text = x.Name + " " + x.Surname, Value = x.Id.ToString() }).ToList();
            var Personeller = _serviceEmployees.GetAll().Select(x => new SelectListItem { Text = x.Name + " " + x.Surname, Value = x.Id.ToString() }).ToList();
           
            ViewBag.Musteriler = Musteriler;
            ViewBag.Personeller = Personeller;
            model.IsActive = true;
            model.IsCollect = false;
            model.IsSale = false;
            model.ReserveDate = DateTime.Now.Date;
            Sales sale = model.ModelToEnity();
            _serviceSales.Insert(sale);
          var satis= _serviceSales.GetById(sale.Id);

            return RedirectToAction("RoomSalesInsert", new { id=satis.Id  });
        }

        //Rezervasyon işlemleri için
        public ActionResult RoomSalesInsert(int id)
        {
            if (_serviceRoomSales.GetById(id).EntityToModel()==null)
            {
                return RedirectToAction("RoomSalesList");
            }
            var Indirimler = _serviceDiscounts.GetAll().OrderBy(x=>x.Rate).Select(x => new SelectListItem { Text = x.Name, Value = x.Id.ToString() }).ToList();
            var Satis = _serviceSales.GetById(id).Customer.Name + " " + _serviceSales.GetById(id).Customer.Surname + " - " + _serviceSales.GetById(id).ReserveDate;
            var Paketler = _servicePackets.GetAll().Select(x => new SelectListItem { Text = x.Name, Value = x.Id.ToString() }).ToList();
            var rooms = new List<Rooms>().Select(x => new SelectListItem { Text = x.Number, Value = x.Id.ToString() }).ToList();

            ViewBag.Indirimler = Indirimler;
            ViewBag.Satislar = Satis;
            ViewBag.Paketler = Paketler;
            ViewBag.SaleId = id;

            return View();
        }

        [HttpPost]
        public ActionResult RoomSalesInsert(RoomSalesModel model)
        {
            if (_serviceRoomSales.Insert(model.ModelToEnity())>0)
            {
                return RedirectToAction("RoomSalesCustomerInsert", "Sale", new {id = model.Id});
            }
            else
            {
                return RedirectToAction("RoomSalesInsert", "Sale",new { id=model.Id });
            }


        }

        public ActionResult RoomSalesEdit(int id=0)
        {
            if (_serviceRoomSales.GetById(id)==null)
            {
                return RedirectToAction("RoomSalesList","Sale");
            }
            var Indirimler = _serviceDiscounts.GetAll().Select(x => new SelectListItem { Text = x.Name, Value = x.Id.ToString() }).ToList();


            var Satis = _serviceSales.GetById(id).Customer.Name + " " + _serviceSales.GetById(id).Customer.Surname + " - " + _serviceSales.GetById(id).ReserveDate;
            var Paketler = _servicePackets.GetAll().Select(x => new SelectListItem { Text = x.Name, Value = x.Id.ToString() }).ToList();
            RoomSalesModel roomSalesModel = _serviceRoomSales.GetById(id).EntityToModel(true);
            ViewBag.Indirimler = Indirimler;
            ViewBag.Satislar = Satis;
            ViewBag.Paketler = Paketler;

            IEnumerable<Rooms> rooms = _serviceRooms.GetDateRooms(roomSalesModel.LoginDate, roomSalesModel.LogoutDate,roomSalesModel.RoomId).ToList();
            IEnumerable<RoomTypes> roomTypesModels = rooms.DistinctBy(x => x.RoomTypeId).Select(y => y.RoomType).ToList();
            
            ViewBag.RoomTypes = roomTypesModels.Select(x=> new SelectListItem{Text = x.Name,Value = x.Id.ToString()});

            ViewBag.Rooms = _serviceRooms.GetTypeAndDateRooms(roomSalesModel.LoginDate, roomSalesModel.LogoutDate, roomSalesModel.Room.RoomTypeId, roomSalesModel.RoomId).Select(x => new SelectListItem { Text = x.Number, Value = x.Id.ToString() });
            return View(roomSalesModel);
        }

        [HttpPost]
        public ActionResult RoomSalesEdit(RoomSalesModel model)
        {
            int sayi= _serviceRoomSales.Update(model.ModelToEnity()); 
           return RedirectToAction("RoomSalesEdit","Sale",new {id=model.Id});
        }

        public ActionResult RoomSalesDetails(int id)
        {
           var rezervasyon= _serviceRoomSales.GetById(id);
           RoomSalesModel model = new RoomSalesModel
           {
               Amount = rezervasyon.Amount,
               Discount = rezervasyon.Discount,
               DiscountsId = rezervasyon.DiscountsId,
               Id = rezervasyon.Id,
               LoginDate = rezervasyon.LoginDate,
               LogoutDate = rezervasyon.LogoutDate,
               Packet = rezervasyon.Packet,
               PacketId = rezervasyon.PacketId,
               Room = rezervasyon.Room,
               RoomId = rezervasyon.RoomId,
               Sale = rezervasyon.Sale,
               SalesId = rezervasyon.SalesId
           };
            return View(model);
        }

        public ActionResult RoomSalesDelete(int id)
        {
           var satis= _serviceRoomSales.GetById(id);
           satis.IsActive = false;
           _serviceRoomSales.Update(satis);
           var room=_serviceRooms.GetById(satis.RoomId);
           var rezerve= _serviceStatuses.GetAll().Where(x=>x.Name=="Rezerve").FirstOrDefault();
             var bos= _serviceStatuses.GetAll().Where(x=>x.Name=="Boş").FirstOrDefault();
             var roomSatatus =_serviceRoomStatuses.GetAll().Where(x => x.RoomId == satis.RoomId && x.StatusId == rezerve.Id).FirstOrDefault();
          roomSatatus.StatusId = bos.Id;
          _serviceRoomStatuses.Update(roomSatatus);

          return RedirectToAction("RoomSalesList");
        }

        public ActionResult RoomSalesList(int id=0)
        {
            IEnumerable<RoomSales> model;
            if (id==0)
            {
                model = _serviceRoomSales.GetReserveRooms().ToList();
            }
            else
            {
                model = _serviceRoomSales.GetSaleRooms(id).ToList();
                ViewBag.SaleId = id;
            }
            if (!model.Any())
            {
                model =new List<RoomSales>();
            }
            return View(model.EntityToModelList(true));
        }

        //Ekstra harcamalar için
        public ActionResult SaleExtrasInsert(int id)
        {
            var rezervasyon = _serviceRoomSales.GetById(id).Room.Number + " : " + _serviceRoomSales.GetById(id).LoginDate + "-" + _serviceRoomSales.GetById(id).LogoutDate;
        
           var Urunler = _serviceExtraProducts.GetExtraProducts(_serviceRoomSales.GetById(id).PacketId).Select(x => new SelectListItem { Text = x.Name, Value = x.Id.ToString() }).ToList();
            ViewBag.Rezervasyon = rezervasyon;
            ViewBag.Urunler = Urunler;
            return View();
        }

        [HttpPost]
        public ActionResult SaleExtrasInsert(SaleExtrasModel model,int id)
        {
            var rezervasyon = _serviceRoomSales.GetById(id).Room.Number + " : " + _serviceRoomSales.GetById(id).LoginDate + "-" + _serviceRoomSales.GetById(id).LogoutDate;
         
            var Urunler = _serviceExtraProducts.GetExtraProducts(_serviceRoomSales.GetById(id).PacketId).Select(x => new SelectListItem { Text = x.Name, Value = x.Id.ToString() }).ToList();
            ViewBag.Rezervasyon = rezervasyon;
            ViewBag.Urunler = Urunler;

            SaleExtras yeni = new SaleExtras
            {
                ExtraProductId = model.ExtraProductId,
                ProductAmount = model.ProductAmount,
                ProductUnit = model.ProductUnit,
                RoomSaleId = model.RoomSaleId
            };

            _serviceSaleExtras.Insert(yeni);

            return RedirectToAction("SaleExtrasList");
        }
        public ActionResult SaleExtrasEdit()
        {
           

            return View();
        }

        public ActionResult SaleExtrasDelete()
        {
            return View();
        }

        public ActionResult SaleExtrasList()
        {
            List<SaleExtrasModel> model = new List<SaleExtrasModel>();
            var saleExtras = _serviceSaleExtras.GetAll();
            foreach (var item in saleExtras)
            {
                model.Add(
                new SaleExtrasModel
                {
                   Id= item.Id,
                    ExtraProductId=item.ExtraProductId,
                     ProductAmount=item.ProductAmount,
                      RoomSaleId=item.RoomSaleId,
                       ProductUnit=item.ProductUnit
                });

            }
            return View(model);
        }

       
        //Şatış tamamlamak için kullanılacak
        public ActionResult SalesInsert()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SalesEdit(SalesModel model)
        {
            Sales sales = _serviceSales.GetById(model.Id);
            sales.CustomerId = model.CustomerId;
            sales.EmployeeId = model.EmployeeId;
            sales.PaymentMethodId = model.PaymentMethodId;
            _serviceSales.Update(sales);

            var Musteriler = _serviceCustomers.GetAll().Select(x => new SelectListItem { Text = x.Name + " " + x.Surname, Value = x.Id.ToString() }).ToList();
            var Personeller = _serviceEmployees.GetAll().Select(x => new SelectListItem { Text = x.Name + " " + x.Surname, Value = x.Id.ToString() }).ToList();
            var OdemeYontemi = _servicePaymentMethods.GetAll().Select(x => new SelectListItem { Text = x.Name, Value = x.Id.ToString() }).ToList();
            ViewBag.Musteriler = Musteriler;
            ViewBag.Personeller = Personeller;
            ViewBag.PaymentMethod = OdemeYontemi;
            return View(sales.EntityToModel());
        }

        public ActionResult SalesEdit(int id)
        {
            var Musteriler = _serviceCustomers.GetAll().Select(x => new SelectListItem { Text = x.Name + " " + x.Surname, Value = x.Id.ToString() }).ToList();
            var Personeller = _serviceEmployees.GetAll().Select(x => new SelectListItem { Text = x.Name + " " + x.Surname, Value = x.Id.ToString() }).ToList();
            var OdemeYontemi= _servicePaymentMethods.GetAll().Select(x=> new SelectListItem{ Text=x.Name, Value=x.Id.ToString()}).ToList();
            ViewBag.Musteriler = Musteriler;
            ViewBag.Personeller = Personeller;
            ViewBag.PaymentMethod = OdemeYontemi;
            return View(_serviceSales.GetById(id).EntityToModel());
        }
        [HttpPost]
        public JsonResult SalesDelete(int id)
        {
            Sales s = _serviceSales.GetById(id);
            s.IsActive = false;
            return Json(_serviceSales.Update(s)>0);
        }

        public ActionResult SalesDetails(int id=0)
        {
            if (id==0)
            {
                return RedirectToAction("SalesList");
            }
            return View(_serviceSales.GetById(id).EntityToModel(true));
        }
        [HttpGet]
        public ActionResult SalesList(string status = "")
        {
            if (status=="Collect")
            {
                ViewBag.CollectNote = "Sadece Satışı Gerçekleştirilmemişleri Getir";
                ViewBag.CollectClass = "btn btn-success";
                ViewBag.Collect = false;
                return View(_serviceSales.GetAll().Where(x => (x.IsActive) && (x.IsCollect)).EntityToModelList(true));
            }
            else
            {
                ViewBag.CollectNote = "Sadece Satışı Gerçekleştirilenler Getir";
                ViewBag.CollectClass = "btn btn-warning";
                ViewBag.Collect = true;
                return View(_serviceSales.GetAll().Where(x=>(x.IsActive) && (x.IsCollect==false)).EntityToModelList(true));
            }
        }

        [HttpPost]
        public JsonResult DateToRoomType(DateTime startDateTime, DateTime endDateTime,int thisId=0)
        {

            IEnumerable<Rooms> rooms = _serviceRooms.GetDateRooms(startDateTime, endDateTime, thisId).ToList();
                IEnumerable<RoomTypes> SingleRoomTypes = rooms.DistinctBy(x => x.RoomTypeId).Select(y => y.RoomType).ToList();
                return Json(SingleRoomTypes.EntityToModelList());

        }
        [HttpPost]
        public JsonResult RoomTypeToRooms(int id, DateTime startDateTime, DateTime endDateTime,int thisId=0)
        {
            return Json(_serviceRooms.GetTypeAndDateRooms(startDateTime, endDateTime, id, thisId).EntityToModelList());
        }

        [HttpPost]
        public JsonResult GetRoomSalesAmount(DateTime sDate, DateTime eDate, int roomTypeId, int diccountsId, int packetId)
        {
            int dayCount = (eDate - sDate).Days;

            decimal roomPrice = _serviceRoomTypes.GetById(roomTypeId).Amount;
            int toteldiscount = _servicePackets.GetById(packetId).PricePercentage - _serviceDiscounts.GetById(diccountsId).Rate;
            decimal a = (decimal)toteldiscount/ 100;
            decimal countMoney = (dayCount*roomPrice)*(decimal)(a+1);

            return Json(countMoney);
        }
    }
}