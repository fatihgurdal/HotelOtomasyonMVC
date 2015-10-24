using ProjectTemplate.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Convert
{
    public static class RoomStatusesConvert
    {
        public static RoomStatuses ModelToEnity(this RoomStatusesModel model, bool virtualActive = false)
        {
            RoomStatuses entity = new RoomStatuses()
            {
                 RoomId=model.RoomId,
                  StatusId=model.StatusId,
                Id = model.Id,
                IsActive = model.IsActive
            };
            if (virtualActive)
            {
                entity.Room = model.Room;
                entity.Status = model.Status;

            }
            return entity;
        }

        public static RoomStatusesModel EntityToModel(this RoomStatuses entity, bool virtualActive = false)
        {
            try
            {
                RoomStatusesModel model = new RoomStatusesModel()
                {
                    RoomId=entity.RoomId,
                    StatusId=entity.StatusId,
                    IsActive = entity.IsActive,
                    Id = entity.Id
                };
                if (virtualActive)
                {
                    model.Status = entity.Status;
                    model.Room = entity.Room;

                }
                return model;
            }
            catch (Exception)
            {

                return new RoomStatusesModel();
            }


        }

        public static List<RoomStatuses> ModelToEntityList(this IEnumerable<RoomStatusesModel> modelList, bool virtualActive = false)
        {
            return modelList.Select(itemRoomStatusesModel => itemRoomStatusesModel.ModelToEnity(virtualActive)).ToList();
        }

        public static List<RoomStatusesModel> EntityToModelList(this IEnumerable<RoomStatuses> modelList, bool virtualActive = false)
        {
            return modelList.Select(itemRoomStatusesModel => itemRoomStatusesModel.EntityToModel(virtualActive)).ToList();
        }
    }
}