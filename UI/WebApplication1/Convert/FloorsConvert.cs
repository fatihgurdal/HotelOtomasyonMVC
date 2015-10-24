using ProjectTemplate.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Convert
{
    public static class FloorsConvert
    {
        public static Floors ModelToEnity(this FloorsModel model, bool virtualActive = false)
        {
            Floors entity = new Floors()
            {
                 Name= model.Name,
                Id = model.Id,
                IsActive = model.IsActive
            };
            if (virtualActive)
            {
                entity.BlockFloors = model.BlockFloors;
           
            }
            return entity;
        }

        public static FloorsModel EntityToModel(this Floors entity, bool virtualActive = false)
        {
            try
            {
                FloorsModel model = new FloorsModel()
                {
                    Name = entity.Name,
                    IsActive = entity.IsActive,
                    Id = entity.Id
                };
                if (virtualActive)
                {
                    model.BlockFloors = entity.BlockFloors;

                }
                return model;
            }
            catch (Exception)
            {

                return new FloorsModel();
            }


        }

        public static List<Floors> ModelToEntityList(this IEnumerable<FloorsModel> modelList, bool virtualActive = false)
        {
            return modelList.Select(itemFloorsModel => itemFloorsModel.ModelToEnity(virtualActive)).ToList();
        }

        public static List<FloorsModel> EntityToModelList(this IEnumerable<Floors> modelList, bool virtualActive = false)
        {
            return modelList.Select(itemFloorsModel => itemFloorsModel.EntityToModel(virtualActive)).ToList();
        }
    }
}