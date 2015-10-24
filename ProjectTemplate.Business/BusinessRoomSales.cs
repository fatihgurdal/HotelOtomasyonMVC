using System;
using System.Collections.Generic;
using ProjectTemplate.Core.Abstractions.Business;
using ProjectTemplate.Core.Abstractions.Repository;
using ProjectTemplate.Core.Entities;
using ProjectTemplate.Core.Repository;

namespace ProjectTemplate.Business
{
    public class BusinessRoomSales : BusinessBase<RoomSales>,IBusinessRoomSales
    {
        private readonly IRepositoryRoomSales _repositoryRoomSales;
        public BusinessRoomSales(IRepositoryBase<RoomSales> repository,IRepositoryRoomSales repositoryRoomSales, IUnitOfWork uow) : base(repository, uow)
        {
            _repositoryRoomSales = repositoryRoomSales;
        }

        public IEnumerable<RoomSales> GetReserveRooms(DateTime? nowDate = null)
        {
            return !nowDate.HasValue ? _repositoryRoomSales.GetReserveRooms(DateTime.Now.Date) : _repositoryRoomSales.GetReserveRooms((DateTime)nowDate);
        }

        public IEnumerable<RoomSales> GetSaleRooms(int id)
        {
            return _repositoryRoomSales.GetSaleRooms(id);
        }
    }
}
