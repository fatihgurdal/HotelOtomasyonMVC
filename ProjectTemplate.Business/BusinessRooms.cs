using System;
using System.Collections.Generic;
using ProjectTemplate.Core.Abstractions.Business;
using ProjectTemplate.Core.Abstractions.Repository;
using ProjectTemplate.Core.Entities;
using ProjectTemplate.Core.Repository;

namespace ProjectTemplate.Business
{
    public class BusinessRooms : BusinessBase<Rooms>,IBusinessRooms
    {
        private readonly IRepositoryRooms _repositoryRooms;
        public BusinessRooms(IRepositoryBase<Rooms> repository, IUnitOfWork uow, IRepositoryRooms repositoryRooms)
            : base(repository, uow)
        {
            _repositoryRooms = repositoryRooms;
        }

        public IEnumerable<Rooms> GetDateRooms(DateTime startDateTime, DateTime endDateTime, int thisId)
        {
            return _repositoryRooms.GetDateRooms(startDateTime, endDateTime,thisId);
        }

        public IEnumerable<Rooms> GetTypeRooms(int typeId)
        {
            return _repositoryRooms.GetTypeRooms(typeId);
        }

        public IEnumerable<Rooms> GetTypeAndDateRooms(DateTime startDateTime, DateTime endDateTime, int typeId, int thisId)
        {
            return _repositoryRooms.GetTypeAndDateRooms(startDateTime, endDateTime, typeId,thisId);
        }
    }
}
