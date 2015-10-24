using ProjectTemplate.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Convert
{
    public static class HotelFeaturesConvert
    {
        public static HotelFeatures ModelToEnity(this HotelFeaturesModel model, bool virtualActive = false)
        {
            HotelFeatures entity = new HotelFeatures()
            {
                Name=model.Name,
                Id = model.Id,
                Content= model.Content,
                IsActive = model.IsActive
            };
            if (virtualActive)
            {
              
            }
            return entity;
        }

        public static HotelFeaturesModel EntityToModel(this HotelFeatures entity, bool virtualActive = false)
        {
            try
            {
                HotelFeaturesModel model = new HotelFeaturesModel()
                {
                    Name=entity.Name,
                    Content=entity.Content,
                    IsActive = entity.IsActive,
                    Id = entity.Id
                };
                if (virtualActive)
                {
                  

                }
                return model;
            }
            catch (Exception)
            {

                return new HotelFeaturesModel();
            }


        }

        public static List<HotelFeatures> ModelToEntityList(this IEnumerable<HotelFeaturesModel> modelList, bool virtualActive = false)
        {
            return modelList.Select(itemHotelFeaturesModel => itemHotelFeaturesModel.ModelToEnity(virtualActive)).ToList();
        }

        public static List<HotelFeaturesModel> EntityToModelList(this IEnumerable<HotelFeatures> modelList, bool virtualActive = false)
        {
            return modelList.Select(itemHotelFeaturesModel => itemHotelFeaturesModel.EntityToModel(virtualActive)).ToList();
        }
    }
}