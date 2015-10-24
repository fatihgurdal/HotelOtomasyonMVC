using ProjectTemplate.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Convert
{
    public static class RoomFeaturesRoomTypesConvert
    {
        public static RoomFeaturesRoomTypes ModelToEnity(this RoomFeaturesRoomTypesModel model, bool virtualActive = false)
        {
            RoomFeaturesRoomTypes entity = new RoomFeaturesRoomTypes()
            {
                RoomFeatureId = model.RoomFeatureId,
                RoomFeatureQuantity = model.RoomFeatureQuantity,
                RoomTypeId = model.RoomTypeId,
                Id = model.Id,
                IsActive = model.IsActive
            };
            if (virtualActive)
            {
                entity.RoomType = model.RoomType;
                entity.RoomFeature = model.RoomFeature;

            }
            return entity;
        }

        public static RoomFeaturesRoomTypesModel EntityToModel(this RoomFeaturesRoomTypes entity, bool virtualActive = false)
        {
            try
            {
                RoomFeaturesRoomTypesModel model = new RoomFeaturesRoomTypesModel()
                {
                    RoomFeatureId = entity.RoomFeatureId,
                    RoomFeatureQuantity = entity.RoomFeatureQuantity,
                    RoomTypeId = entity.RoomTypeId,
                    IsActive = entity.IsActive,
                    Id = entity.Id
                };
                if (virtualActive)
                {
                    model.RoomType = entity.RoomType;
                    model.RoomFeature = entity.RoomFeature;

                }
                return model;
            }
            catch (Exception)
            {

                return new RoomFeaturesRoomTypesModel();
            }


        }

        public static List<RoomFeaturesRoomTypes> ModelToEntityList(this IEnumerable<RoomFeaturesRoomTypesModel> modelList, bool virtualActive = false)
        {
            return modelList.Select(itemRoomFeaturesRoomTypesModel => itemRoomFeaturesRoomTypesModel.ModelToEnity(virtualActive)).ToList();
        }

        public static List<RoomFeaturesRoomTypesModel> EntityToModelList(this IEnumerable<RoomFeaturesRoomTypes> modelList, bool virtualActive = false)
        {
            return modelList.Select(itemRoomFeaturesRoomTypesModel => itemRoomFeaturesRoomTypesModel.EntityToModel(virtualActive)).ToList();
        }
    }
}