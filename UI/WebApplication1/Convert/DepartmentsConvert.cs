using ProjectTemplate.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Convert
{
    public static class DepartmentsConvert
    {
        public static Departments ModelToEnity(this DepartmentsModel model, bool virtualActive = false)
        {
            Departments entity = new Departments()
            {
                Name = model.Name,
                Id = model.Id,
                IsActive = model.IsActive
            };
            if (virtualActive)
            {
                entity.GroupsOfEmployee = model.GroupsOfEmployee;
            }
            return entity;
        }

        public static DepartmentsModel EntityToModel(this Departments entity, bool virtualActive = false)
        {
            try
            {
                DepartmentsModel model = new DepartmentsModel()
                {
                    
                    Name = entity.Name,
                    IsActive= entity.IsActive,
                    Id = entity.Id
                };
                if (virtualActive)
                {
                    model.GroupsOfEmployee = entity.GroupsOfEmployee;
                }
                return model;
            }
            catch (Exception)
            {

                return new DepartmentsModel();
            }


        }

        public static List<Departments> ModelToEntityList(this IEnumerable<DepartmentsModel> modelList, bool virtualActive = false)
        {
            return modelList.Select(itemDepartmentsModel => itemDepartmentsModel.ModelToEnity(virtualActive)).ToList();
        }

        public static List<DepartmentsModel> EntityToModelList(this IEnumerable<Departments> modelList, bool virtualActive = false)
        {
            return modelList.Select(itemDepartmentsModel => itemDepartmentsModel.EntityToModel(virtualActive)).ToList();
        } 
    }
}