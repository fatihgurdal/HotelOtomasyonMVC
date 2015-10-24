using ProjectTemplate.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Convert
{
    public static class StatusesConvert
    {
        public static Statuses ModelToEnity(this StatusesModel model, bool virtualActive = false)
        {
            Statuses entity = new Statuses()
            {
                 Name=model.Name,
                Id = model.Id,
                IsActive = model.IsActive
            };
            if (virtualActive)
            {
                entity.RoomStatuses = model.RoomStatuses;

            }
            return entity;
        }

        public static StatusesModel EntityToModel(this Statuses entity, bool virtualActive = false)
        {
            try
            {
                StatusesModel model = new StatusesModel()
                {
                     Name=entity.Name,
                    IsActive = entity.IsActive,
                    Id = entity.Id
                };
                if (virtualActive)
                {
                    model.RoomStatuses = entity.RoomStatuses;

                }
                return model;
            }
            catch (Exception)
            {

                return new StatusesModel();
            }


        }

        public static List<Statuses> ModelToEntityList(this IEnumerable<StatusesModel> modelList, bool virtualActive = false)
        {
            return modelList.Select(itemStatusesModel => itemStatusesModel.ModelToEnity(virtualActive)).ToList();
        }

        public static List<StatusesModel> EntityToModelList(this IEnumerable<Statuses> modelList, bool virtualActive = false)
        {
            return modelList.Select(itemStatusesModel => itemStatusesModel.EntityToModel(virtualActive)).ToList();
        }
    }
}