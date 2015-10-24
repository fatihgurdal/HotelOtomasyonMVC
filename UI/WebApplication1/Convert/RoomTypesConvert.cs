using ProjectTemplate.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Convert
{
    public static class RoomTypesConvert
    {
        public static RoomTypes ModelToEnity(this RoomTypesModel model, bool virtualActive = false)
        {
            RoomTypes entity = new RoomTypes()
            {
                Amount=model.Amount,
                 Name=model.Name,
                  Quota=model.Quota,
               
                Id = model.Id,
                IsActive = model.IsActive
            };
            if (virtualActive)
            {
                entity.RoomFeaturesRoomTypes = model.RoomFeaturesRoomTypes;
                entity.Rooms = model.Rooms;

            }
            return entity;
        }

        public static RoomTypesModel EntityToModel(this RoomTypes entity, bool virtualActive = false)
        {
            try
            {
                RoomTypesModel model = new RoomTypesModel()
                {
                    Amount=entity.Amount,
                     Name=entity.Name,
                      Quota=entity.Quota,
                    IsActive = entity.IsActive,
                    Id = entity.Id
                };
                if (virtualActive)
                {
                    model.RoomFeaturesRoomTypes = entity.RoomFeaturesRoomTypes;
                    model.Rooms = entity.Rooms;

                }
                return model;
            }
            catch (Exception)
            {

                return new RoomTypesModel();
            }


        }

        public static List<RoomTypes> ModelToEntityList(this IEnumerable<RoomTypesModel> modelList, bool virtualActive = false)
        {
            return modelList.Select(itemRoomTypesModel => itemRoomTypesModel.ModelToEnity(virtualActive)).ToList();
        }

        public static List<RoomTypesModel> EntityToModelList(this IEnumerable<RoomTypes> modelList, bool virtualActive = false)
        {
            return modelList.Select(itemRoomTypesModel => itemRoomTypesModel.EntityToModel(virtualActive)).ToList();
        }
    }
}