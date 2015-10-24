using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjectTemplate.Core.Entities;
using WebApplication1.Models;

namespace WebApplication1.Convert
{
    public static class NationalitiesConvert
    {
        public static Nationalities ModelToEnity(this NationalitiesModel model, bool virtualActive = false)
        {
            Nationalities entity = new Nationalities()
            {
               CountryName = model.CountryName,
               Name = model.Name,
               Id = model.Id
            };
            if (virtualActive)
            {
                entity.Customers = model.Customers;
            }
            return entity;
        }

        public static NationalitiesModel EntityToModel(this Nationalities entity, bool virtualActive = false)
        {
            NationalitiesModel model = new NationalitiesModel()
            {
                CountryName = entity.CountryName,
                Name        = entity.Name,
                Id          = entity.Id
            };
            if (virtualActive)
            {
                model.Customers = entity.Customers;
            }

            return model;
        }

        public static List<Nationalities> ModelToEntityList(this IEnumerable<NationalitiesModel> modelList, bool virtualActive = false)
        {
            return modelList.Select(itemNationalitiesModel => itemNationalitiesModel.ModelToEnity(virtualActive)).ToList();
        }

        public static List<NationalitiesModel> EntityToModelList(this IEnumerable<Nationalities> modelList, bool virtualActive = false)
        {
            return modelList.Select(itemNationalitiesModel => itemNationalitiesModel.EntityToModel(virtualActive)).ToList();
        }
    }
}