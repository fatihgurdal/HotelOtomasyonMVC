using ProjectTemplate.Core.Abstractions.Service;
using ProjectTemplate.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using WebApplication1.Convert;

namespace WebApplication1.Controllers
{
    public class RoomsController : Controller
    {
        readonly IServiceRooms _serviceRooms;
        readonly IServiceBlockFloors _serviceBlockFloors;
        readonly IServiceRoomTypes _serviceRoomTypes;
        readonly IServiceFloors _servisceFloors;
        readonly IServiceRoomFeatures _serviceRoomFeatures;
        readonly IServiceBlocks _serviceBlocks;
        readonly IServiceStatuses _serviceStatuses;
        readonly IServiceRoomStatuses _serviceRoomStatuses;
        readonly IServiceRoomFeaturesRoomTypes _serviceRoomFeaturesRoomTypes;
        readonly IServiceStatuses _serviceStatus;

        public RoomsController(IServiceRooms serviceRooms, IServiceBlockFloors serviceBlockFloors, IServiceRoomTypes serviceRoomTypes, IServiceFloors servisceFloors, IServiceBlocks serviceBlocks, IServiceRoomFeatures serviceRoomFeatures, IServiceStatuses serviceStatuses, IServiceRoomStatuses serviceRoomStatuses, IServiceRoomFeaturesRoomTypes serviceRoomFeaturesRoomTypes, IServiceStatuses serviceStatus)
        {
            _serviceRooms = serviceRooms;
            _serviceBlockFloors = serviceBlockFloors;
            _serviceRoomTypes = serviceRoomTypes;
            _servisceFloors = servisceFloors;
            _serviceBlocks = serviceBlocks;
            _serviceRoomFeatures = serviceRoomFeatures;
            _serviceStatuses = serviceStatuses;
            _serviceRoomStatuses = serviceRoomStatuses;
            _serviceRoomFeaturesRoomTypes = serviceRoomFeaturesRoomTypes;
            _serviceStatus = serviceStatus;
        }

        #region Odalar
        public ActionResult RoomList()
        {
            IEnumerable<Statuses> statusList = _serviceStatus.GetAll();
            ViewBag.StatusList = statusList;
            return View(_serviceRooms.GetAll().EntityToModelList(true).Where(x => x.IsActive));
        }
        // GET: Room
        public ActionResult Index()
        {
            return RedirectToAction("RoomList");
        }

        public ActionResult RoomInsert()
        {
            //ısactıve !!!!!!!!!
            IEnumerable<Statuses> listStatus = _serviceStatuses.GetAll().Distinct().Where(x => x.IsActive);
            List<SelectListItem> blockFloorIdList = new List<SelectListItem>();
            List<SelectListItem> roomTypeIdList = new List<SelectListItem>();
            foreach (var item in _serviceBlockFloors.GetAll().OrderBy(s => s.Floor.Name).OrderBy(s => s.Block.BlockName))
            {
                SelectListItem sli = new SelectListItem();
                sli.Text = item.Block.BlockName + " - " + item.Floor.Name;
                sli.Value = item.Id.ToString();
                blockFloorIdList.Add(sli);
            }
            foreach (var item in _serviceRoomTypes.GetAll().Where(s => s.IsActive))
            {
                SelectListItem sli = new SelectListItem();
                sli.Value = item.Id.ToString();
                sli.Text = item.Name.ToString();
                roomTypeIdList.Add(sli);
            }

            ViewBag.StatusList = listStatus;
            ViewBag.BlockFloorId = blockFloorIdList;
            ViewBag.RoomTypeId = roomTypeIdList;

            return View();
        }

        [HttpPost]
        public ActionResult RoomInsert(RoomsModel roomModel, int[] StatusList)
        {
            Rooms room = roomModel.ModelToEnity();
            room.IsActive = true;
            _serviceRooms.Insert(room);
            RoomStatuses roomstatus = new RoomStatuses();
            foreach (var item in StatusList)
            {
                roomstatus.RoomId = room.Id;
                roomstatus.IsActive = true;
                roomstatus.StatusId = item;
                _serviceRoomStatuses.Insert(roomstatus);

            }
            return RedirectToAction("RoomList");
        }

        public ActionResult RoomEdit(int id)
        {

            Rooms editRoom = _serviceRooms.GetById(id);
            var floors = _serviceBlockFloors.GetAll().OrderBy(x => x.Block.BlockName).Select(x => new SelectListItem { Text = x.Block.BlockName + " - " + x.Floor.Name, Value = x.Id.ToString(), Selected = editRoom.BlockFloor.Id == x.Id }).ToList();
            var rooms = _serviceRoomTypes.GetAll().Select(x => new SelectListItem { Text = x.Name, Value = x.Id.ToString(), Selected = editRoom.RoomType.Id == x.Id }).ToList();
            IEnumerable<Statuses> statuslist = _serviceStatuses.GetAll().Where(x => x.IsActive);
            List<CheckedModel> chckRoomStatusList = new List<CheckedModel>();
            foreach (var item in statuslist)
            {
                CheckedModel chckModel = new CheckedModel();
                chckModel.Id = item.Id;
                chckModel.Name = item.Name;
                chckModel.IsChecked = _serviceRooms.GetById(id).RoomStatuses.Where(x => x.StatusId == item.Id).Count() > 0;
                chckRoomStatusList.Add(chckModel);

            }
            ViewBag.StatusList = chckRoomStatusList;
            ViewBag.BlockFloorId = floors;
            ViewBag.RoomTypeId = rooms;

            return View(editRoom.EntityToModel());
        }

        [HttpPost]
        public ActionResult RoomEdit(RoomsModel room, int[] StatusList)
        {
            Rooms rooms = room.ModelToEnity();
            rooms.IsActive = true;
            _serviceRooms.Update(rooms);
            foreach (var item in StatusList)
            {
                RoomStatuses rs = new RoomStatuses();
                rs.RoomId = rooms.Id;
                rs.StatusId = item;
                _serviceRoomStatuses.Insert(rs);
            }

            return RedirectToAction("RoomList");
        }

        public ActionResult RoomDelete(int id)
        {
            Rooms silinecekOda = _serviceRooms.GetById(id);
            silinecekOda.IsActive = false;
            _serviceRooms.Update(silinecekOda);
            return RedirectToAction("RoomList");
        }


        #endregion

        #region OdaOzellikleri
        public ActionResult RoomFeaturesList()
        {
            return View(_serviceRoomFeatures.GetAll().EntityToModelList(true).Where(x => x.IsActive));

        }

        [HttpGet]
        public ActionResult RoomFeatureInsert()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RoomFeatureInsert(RoomFeaturesModel roomModel)
        {

            RoomFeatures room = roomModel.ModelToEnity();
            room.IsActive = true;
            _serviceRoomFeatures.Insert(room);
            return RedirectToAction("RoomFeaturesList");
        }

        [HttpGet]
        public ActionResult RoomFeaturesEdit(int id)
        {
            return View(_serviceRoomFeatures.GetById(id).EntityToModel());
        }

        [HttpPost]
        public ActionResult RoomFeaturesEdit(RoomFeaturesModel roomFeatures)
        {
            RoomFeatures roomfeatures = roomFeatures.ModelToEnity();
            roomfeatures.IsActive = true;
            _serviceRoomFeatures.Update(roomfeatures);
            return RedirectToAction("RoomFeaturesList");
        }

        public ActionResult RoomFeaturesDelete(int id)
        {
            RoomFeatures room = _serviceRoomFeatures.GetById(id);
            room.IsActive = false;
            _serviceRoomFeatures.Update(room);
            return RedirectToAction("RoomFeaturesList");
        }
        #endregion

        #region OdaTipleri
        public ActionResult RoomTypeList()
        {
            return View(_serviceRoomTypes.GetAll().EntityToModelList(true).Where(x => x.IsActive));

        }

        [HttpGet]
        public ActionResult RoomTypeInsert()
        {
            ViewBag.RoomFeature = _serviceRoomFeatures.GetAll().Where(s => s.IsActive);
            return View();
        }

        [HttpPost]
        public ActionResult RoomTypeInsert(RoomTypesModel roomType, int[] RoomFeatureList)
        {
            RoomTypes room = roomType.ModelToEnity();
            room.IsActive = true;
            _serviceRoomTypes.Insert(room);
            return RedirectToAction("RoomTypeList");
        }

        [HttpGet]
        public ActionResult RoomTypeEdit(int id)
        {
            return View(_serviceRoomTypes.GetById(id).EntityToModel());
        }

        [HttpPost]
        public ActionResult RoomTypeEdit(RoomTypesModel roomtypes)
        {
            RoomTypes roomtype = roomtypes.ModelToEnity();
            roomtype.IsActive = true;
            _serviceRoomTypes.Update(roomtype);
            return RedirectToAction("RoomTypeList");
        }

        public ActionResult RoomTypeDelete(int id)
        {
            RoomTypes room = _serviceRoomTypes.GetById(id);
            room.IsActive = false;
            _serviceRoomTypes.Update(room);
            return RedirectToAction("RoomTypeList");
        }

        public ActionResult RoomTypeDetails(int id)
        {
            List<CheckedModel> chckList = new List<CheckedModel>();
            IEnumerable<RoomFeatures> featurelist = _serviceRoomFeatures.GetAll().Where(x => x.IsActive);
            RoomTypes rt = _serviceRooms.GetById(id).RoomType;
            IEnumerable<RoomFeaturesRoomTypes> rfrtList = _serviceRoomFeaturesRoomTypes.GetAll().Where(s => s.RoomTypeId == rt.Id);


            foreach (var item in featurelist)
            {
                CheckedModel chck = new CheckedModel()
             {
                 Id = item.Id,
                 Name = item.Name,
                 IsChecked = rfrtList.Where(s => s.RoomFeatureId == item.Id).Count() > 0
             };
                chckList.Add(chck);
            }
            ViewBag.FeatureList = chckList;
            return View();
        }
        #endregion

        #region Floors
        public ActionResult FloorList()
        {
            return View(_servisceFloors.GetAll().EntityToModelList().Where(x => x.IsActive));
        }
        [HttpGet]
        public ActionResult FloorInsert()
        {
            return View();
        }
        [HttpPost]
        public ActionResult FloorInsert(FloorsModel floormodel)
        {
            Floors floors = floormodel.ModelToEnity();
            floors.IsActive = true;
            _servisceFloors.Insert(floors);
            return RedirectToAction("FloorList");
        }
        //[HttpGet]
        //public ActionResult FloorEdit(int id)
        //{
        //    return View(_servisceFloors.GetById(id).EntityToModel());
        //}

        //[HttpPost]
        //public ActionResult FloorEdit(FloorsModel floorModel)
        //{
        //    _servisceFloors.Update(floorModel.ModelToEnity());
        //    return RedirectToAction("FloorList");
        //}

        public ActionResult FloorDelete(int id)
        {
            Floors floor = _servisceFloors.GetById(id);
            floor.IsActive = false;
            _servisceFloors.Update(floor);
            return RedirectToAction("FloorList");
        }
        #endregion

        #region Blocks

        public ActionResult BlockList()
        {
            return View(_serviceBlocks.GetAll().Where(x => x.IsActive).EntityToModelList());
        }

        [HttpGet]
        public ActionResult BlockInsert()
        {
            ViewBag.FloorList = _servisceFloors.GetAll();
            return View();
        }

        [HttpPost]
        public ActionResult BlockInsert(BlocksModel blocksModel, int[] floorsList)
        {
            Blocks block = blocksModel.ModelToEnity(true);
            block.IsActive = true;
            _serviceBlocks.Insert(block);
            for (int i = 0; i < floorsList.Length; i++)
            {
                BlockFloors blockFloors = new BlockFloors();
                blockFloors.BlockId = block.Id;
                blockFloors.FloorId = floorsList[i];
                _serviceBlockFloors.Insert(blockFloors);
            }
            return RedirectToAction("BlockList");
        }

        [HttpGet]
        public ActionResult BlockEdit(int id)
        {
            Blocks block = _serviceBlocks.GetById(id);
            List<CheckedModel> chckBlockFloorList = new List<CheckedModel>();
            IEnumerable<Floors> floorList = _servisceFloors.GetAll().Where(s => s.IsActive);
            foreach (var item in floorList)
            {
                CheckedModel befm = new CheckedModel();
                befm.Name = item.Name;
                befm.Id = item.Id;
                befm.IsChecked = block.BlockFloors.Where(x => x.FloorId == item.Id).Count() > 0;
                chckBlockFloorList.Add(befm);
            }

            ViewBag.FloorList = chckBlockFloorList;

            return View(block.EntityToModel(true));
        }

        [HttpPost]
        public ActionResult BlockEdit(int id, int[] floorsList)
        {
            Blocks block = _serviceBlocks.GetById(id);
            var allFloors = _servisceFloors.GetAll().Where(s => s.IsActive);
            foreach (var item in allFloors)
            {
                BlockFloors bf = _serviceBlockFloors.GetAll().Where(s => s.BlockId == block.Id && s.FloorId == item.Id).FirstOrDefault();
                if (bf != null)
                {
                    _serviceBlockFloors.Delete(bf);
                }
            }

            for (int i = 0; i < floorsList.Length; i++)
            {
                BlockFloors blockFloors = new BlockFloors();
                blockFloors.BlockId = block.Id;
                blockFloors.FloorId = floorsList[i];
                _serviceBlockFloors.Insert(blockFloors);
            }
            return RedirectToAction("BlockList");
        }

        public ActionResult BlockDelete(int id)
        {
            Blocks block = _serviceBlocks.GetById(id);
            block.IsActive = false;
            _serviceBlocks.Update(block);
            return RedirectToAction("BlockList");
        }

        //public ActionResult BlockDetail(int id, int[] floorsList)
        //{

        //}
        #endregion

        #region OdaDurumlar

        public ActionResult RoomStatusList()
        {
            return View(_serviceStatuses.GetAll().Where(x => x.IsActive).EntityToModelList());
        }

        [HttpGet]
        public ActionResult RoomStatusInsert()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RoomStatusInsert(StatusesModel status)
        {
            Statuses st = status.ModelToEnity();
            st.IsActive = true;
            _serviceStatuses.Insert(st);
            return RedirectToAction("RoomStatusList");
        }

        public ActionResult RoomStatusDelete(int id)
        {
            Statuses status = _serviceStatuses.GetById(id);
            status.IsActive = false;
            _serviceStatuses.Update(status);
            return RedirectToAction("RoomStatusList");
        }

        #endregion

        [HttpPost]
        public ActionResult RoomStatusList(int[] StatusList)
        {
            List<RoomsModel> roomList = _serviceRooms.GetAll().ToList().EntityToModelList(true);
            List<RoomsModel> sonucRoomList = new List<RoomsModel>();
            if (StatusList!=null)
            {
                foreach (RoomsModel room in roomList)
                {
                    for (int i = 0; i < StatusList.Length; i++)
                    {
                        if (room.RoomStatuses.Where(x => StatusList[i] == x.Status.Id).Count() > 0)
                        {
                            sonucRoomList.Add(room);
                            break;
                        }
                    }
                }
            }
            else
            {
                sonucRoomList = roomList;
            }
            
            IEnumerable<Statuses> statusList = _serviceStatus.GetAll();
            ViewBag.StatusList = statusList;
            return View("RoomList", sonucRoomList);
        }
    }
}