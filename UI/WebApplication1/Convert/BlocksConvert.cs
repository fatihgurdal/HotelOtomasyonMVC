using ProjectTemplate.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Convert
{
    public static class BlocksConvert
    {
        public static Blocks ModelToEnity(this BlocksModel model, bool virtualActive = false)
        {
            Blocks entity = new Blocks()
            {
                BlockName=model.BlockName,
                Id = model.Id,
                IsActive = model.IsActive
            };
            if (virtualActive)
            {
                entity.BlockFloors = model.BlockFloors;

            }
            return entity;
        }

        public static BlocksModel EntityToModel(this Blocks entity, bool virtualActive = false)
        {
            try
            {
                BlocksModel model = new BlocksModel()
                {
                     BlockName=entity.BlockName,
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

                return new BlocksModel();
            }


        }

        public static List<Blocks> ModelToEntityList(this IEnumerable<BlocksModel> modelList, bool virtualActive = false)
        {
            return modelList.Select(itemBlocksModel => itemBlocksModel.ModelToEnity(virtualActive)).ToList();
        }

        public static List<BlocksModel> EntityToModelList(this IEnumerable<Blocks> modelList, bool virtualActive = false)
        {
            return modelList.Select(itemBlocksModel => itemBlocksModel.EntityToModel(virtualActive)).ToList();
        }
    }
}