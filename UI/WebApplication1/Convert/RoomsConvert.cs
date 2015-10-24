using ProjectTemplate.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Convert
{
    public static class RoomsConvert
    {
        public static Rooms ModelToEnity(this RoomsModel model, bool virtualActive = false)
        {
            Rooms entity = new Rooms()
            {
                BlockFloorId = model.BlockFloorId,
                Number = model.Number,
                RoomTypeId = model.RoomTypeId,
                Id = model.Id,
                IsActive = model.IsActive
            };
            if (virtualActive)
            {
                entity.RoomSales = model.RoomSales;
                entity.RoomStatuses = model.RoomStatuses;
                entity.RoomType = model.RoomType;
                entity.BlockFloor = model.BlockFloor;


            }
            return entity;
        }

        public static RoomsModel EntityToModel(this Rooms entity, bool virtualActive = false)
        {
            try
            {
                RoomsModel model = new RoomsModel()
                {
                    BlockFloorId = entity.BlockFloorId,
                    Number = entity.Number,
                    RoomTypeId = entity.RoomTypeId,
                    IsActive = entity.IsActive,
                    Id = entity.Id
                };
                if (virtualActive)
                {
                    model.RoomSales = entity.RoomSales;
                    model.BlockFloor = entity.BlockFloor;
                    model.RoomSales = entity.RoomSales;
                    model.RoomStatuses = entity.RoomStatuses;
                    model.RoomType = entity.RoomType;

                }
                return model;
            }
            catch (Exception)
            {

                return new RoomsModel();
            }


        }

        public static List<Rooms> ModelToEntityList(this IEnumerable<RoomsModel> modelList, bool virtualActive = false)
        {
            return modelList.Select(itemRoomsModel => itemRoomsModel.ModelToEnity(virtualActive)).ToList();
        }

        public static List<RoomsModel> EntityToModelList(this IEnumerable<Rooms> modelList, bool virtualActive = false)
        {
            return modelList.Select(itemRoomsModel => itemRoomsModel.EntityToModel(virtualActive)).ToList();
        }
    }
}