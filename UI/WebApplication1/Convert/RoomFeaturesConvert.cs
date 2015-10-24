using ProjectTemplate.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Convert
{
    public static class RoomFeaturesConvert
    {
        public static RoomFeatures ModelToEnity(this RoomFeaturesModel model, bool virtualActive = false)
        {
            RoomFeatures entity = new RoomFeatures()
            {
                 Name=model.Name,
                Id = model.Id,
                IsActive = model.IsActive
            };
            if (virtualActive)
            {
                entity.RoomFeaturesRoomTypes = model.RoomFeaturesRoomTypes;

            }
            return entity;
        }

        public static RoomFeaturesModel EntityToModel(this RoomFeatures entity, bool virtualActive = false)
        {
            try
            {
                RoomFeaturesModel model = new RoomFeaturesModel()
                {
                    Name=entity.Name,
                    IsActive = entity.IsActive,
                    Id = entity.Id
                };
                if (virtualActive)
                {
                    model.RoomFeaturesRoomTypes = entity.RoomFeaturesRoomTypes;

                }
                return model;
            }
            catch (Exception)
            {

                return new RoomFeaturesModel();
            }


        }

        public static List<RoomFeatures> ModelToEntityList(this IEnumerable<RoomFeaturesModel> modelList, bool virtualActive = false)
        {
            return modelList.Select(itemRoomFeaturesModel => itemRoomFeaturesModel.ModelToEnity(virtualActive)).ToList();
        }

        public static List<RoomFeaturesModel> EntityToModelList(this IEnumerable<RoomFeatures> modelList, bool virtualActive = false)
        {
            return modelList.Select(itemRoomFeaturesModel => itemRoomFeaturesModel.EntityToModel(virtualActive)).ToList();
        }
    }
}