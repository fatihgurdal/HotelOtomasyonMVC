using System.Data.Entity;
using ProjectTemplate.Business;
using ProjectTemplate.Core.Abstractions.Business;
using ProjectTemplate.Core.Abstractions.Repository;
using ProjectTemplate.Core.Abstractions.Service;
using ProjectTemplate.Core.EF;
using ProjectTemplate.Core.Entities;
using ProjectTemplate.Core.IoC;
using ProjectTemplate.Core.Repository;
using ProjectTemplate.Repository;
using ProjectTemplate.Service;

namespace ProjectTemplate.Application.Bootstrappers
{
    /// <summary>
    /// Dependency bootstrapper
    /// </summary>
    public class DependencyBootstrapper : IBootstrapper
    {
        /// <summary>
        /// Bootstraps dependencies
        /// </summary>
        /// <param name="dependencyContainer"></param>
        public virtual void Bootstrap(IDependencyContainer dependencyContainer)
        {
           
        
            dependencyContainer.RegisterTransient<IUnitOfWork, EFUnitOfWork>();
            dependencyContainer.RegisterTransient<IRepository, EFRepository>();
            dependencyContainer.RegisterTransient<DbContext, ProjectTemplateContext>();



            


            dependencyContainer.RegisterTransient<IServiceBase<Customers>, ServiceBase<Customers>>();
            dependencyContainer.RegisterTransient<IRepositoryBase<Customers>, RepositoryBase<Customers>>();
            dependencyContainer.RegisterTransient<IBusinessBase<Customers>, BusinessBase<Customers>>();
            dependencyContainer.RegisterTransient<IServiceCustomers, ServiceCustomers>();
            dependencyContainer.RegisterTransient<IRepositoryCustomers, RepositoryCustomers>();
            dependencyContainer.RegisterTransient<IBusinessCustomers, BusinessCustomers>();



            dependencyContainer.RegisterTransient<IServiceBase<Departments>, ServiceBase<Departments>>();
            dependencyContainer.RegisterTransient<IRepositoryBase<Departments>, RepositoryBase<Departments>>();
            dependencyContainer.RegisterTransient<IBusinessBase<Departments>, BusinessBase<Departments>>();
            dependencyContainer.RegisterTransient<IServiceDepartments, ServiceDepartments>();
            dependencyContainer.RegisterTransient<IRepositoryDepartments, RepositoryDepartments>();
            dependencyContainer.RegisterTransient<IBusinessDepartments, BusinessDepartments>();


            dependencyContainer.RegisterTransient<IServiceBase<Discounts>, ServiceBase<Discounts>>();
            dependencyContainer.RegisterTransient<IRepositoryBase<Discounts>, RepositoryBase<Discounts>>();
            dependencyContainer.RegisterTransient<IBusinessBase<Discounts>, BusinessBase<Discounts>>();
            dependencyContainer.RegisterTransient<IServiceDiscounts, ServiceDiscounts>();
            dependencyContainer.RegisterTransient<IRepositoryDiscounts, RepositoryDiscounts>();
            dependencyContainer.RegisterTransient<IBusinessDiscounts, BusinessDiscounts>();


            dependencyContainer.RegisterTransient<IServiceBase<HotelFeatures>, ServiceBase<HotelFeatures>>();
            dependencyContainer.RegisterTransient<IRepositoryBase<HotelFeatures>, RepositoryBase<HotelFeatures>>();
            dependencyContainer.RegisterTransient<IBusinessBase<HotelFeatures>, BusinessBase<HotelFeatures>>();
            dependencyContainer.RegisterTransient<IServiceHotelFeatures, ServiceHotelFeatures>();
            dependencyContainer.RegisterTransient<IRepositoryHotelFeatures, RepositoryHotelFeatures>();
            dependencyContainer.RegisterTransient<IBusinessHotelFeatures, BusinessHotelFeatures>();

            dependencyContainer.RegisterTransient<IServiceBase<Nationalities>, ServiceBase<Nationalities>>();
            dependencyContainer.RegisterTransient<IRepositoryBase<Nationalities>, RepositoryBase<Nationalities>>();
            dependencyContainer.RegisterTransient<IBusinessBase<Nationalities>, BusinessBase<Nationalities>>();
            dependencyContainer.RegisterTransient<IServiceNationalities, ServiceNationalities>();
            dependencyContainer.RegisterTransient<IRepositoryNationalities, RepositoryNationalities>();
            dependencyContainer.RegisterTransient<IBusinessNationalities, BusinessNationalities>();


            dependencyContainer.RegisterTransient<IServiceBase<Packets>, ServiceBase<Packets>>();
            dependencyContainer.RegisterTransient<IRepositoryBase<Packets>, RepositoryBase<Packets>>();
            dependencyContainer.RegisterTransient<IBusinessBase<Packets>, BusinessBase<Packets>>();
            dependencyContainer.RegisterTransient<IServicePackets, ServicePackets>();
            dependencyContainer.RegisterTransient<IRepositoryPackets, RepositoryPackets>();
            dependencyContainer.RegisterTransient<IBusinessPackets, BusinessPackets>();

            dependencyContainer.RegisterTransient<IServiceBase<PacketsExtraProductCategories>, ServiceBase<PacketsExtraProductCategories>>();
            dependencyContainer.RegisterTransient<IRepositoryBase<PacketsExtraProductCategories>, RepositoryBase<PacketsExtraProductCategories>>();
            dependencyContainer.RegisterTransient<IBusinessBase<PacketsExtraProductCategories>, BusinessBase<PacketsExtraProductCategories>>();
            dependencyContainer.RegisterTransient<IServicePacketsExtraProductCategories, ServicePacketsExtraProductCategories>();
            dependencyContainer.RegisterTransient<IRepositoryPacketsExtraProductCategories, RepositoryPacketsExtraProductCategories>();
            dependencyContainer.RegisterTransient<IBusinessPacketsExtraProductCategories, BusinessPacketsExtraProductCategories>();



            dependencyContainer.RegisterTransient<IServiceBase<RoomFeatures>, ServiceBase<RoomFeatures>>();
            dependencyContainer.RegisterTransient<IRepositoryBase<RoomFeatures>, RepositoryBase<RoomFeatures>>();
            dependencyContainer.RegisterTransient<IBusinessBase<RoomFeatures>, BusinessBase<RoomFeatures>>();
            dependencyContainer.RegisterTransient<IServiceRoomFeatures, ServiceRoomFeatures>();
            dependencyContainer.RegisterTransient<IRepositoryRoomFeatures, RepositoryRoomFeatures>();
            dependencyContainer.RegisterTransient<IBusinessRoomFeatures, BusinessRoomFeatures>();


            dependencyContainer.RegisterTransient<IServiceBase<RoomFeaturesRoomTypes>, ServiceBase<RoomFeaturesRoomTypes>>();
            dependencyContainer.RegisterTransient<IRepositoryBase<RoomFeaturesRoomTypes>, RepositoryBase<RoomFeaturesRoomTypes>>();
            dependencyContainer.RegisterTransient<IBusinessBase<RoomFeaturesRoomTypes>, BusinessBase<RoomFeaturesRoomTypes>>();
            dependencyContainer.RegisterTransient<IServiceRoomFeaturesRoomTypes, ServiceRoomFeaturesRoomTypes>();
            dependencyContainer.RegisterTransient<IRepositoryRoomFeaturesRoomTypes, RepositoryRoomFeaturesRoomTypes>();
            dependencyContainer.RegisterTransient<IBusinessRoomFeaturesRoomTypes, BusinessRoomFeaturesRoomTypes>();



            dependencyContainer.RegisterTransient<IServiceBase<Rooms>, ServiceBase<Rooms>>();
            dependencyContainer.RegisterTransient<IRepositoryBase<Rooms>, RepositoryBase<Rooms>>();
            dependencyContainer.RegisterTransient<IBusinessBase<Rooms>, BusinessBase<Rooms>>();
            dependencyContainer.RegisterTransient<IServiceRooms, ServiceRooms>();
            dependencyContainer.RegisterTransient<IRepositoryRooms, RepositoryRooms>();
            dependencyContainer.RegisterTransient<IBusinessRooms, BusinessRooms>();



            dependencyContainer.RegisterTransient<IServiceBase<StayingInRoom>, ServiceBase<StayingInRoom>>();
            dependencyContainer.RegisterTransient<IRepositoryBase<StayingInRoom>, RepositoryBase<StayingInRoom>>();
            dependencyContainer.RegisterTransient<IBusinessBase<StayingInRoom>, BusinessBase<StayingInRoom>>();
            dependencyContainer.RegisterTransient<IServiceStayingInRoom, ServiceStayingInRoom>();
            dependencyContainer.RegisterTransient<IRepositoryStayingInRoom, RepositoryStayingInRoom>();
            dependencyContainer.RegisterTransient<IBusinessStayingInRoom, BusinessStayingInRoom>();


            dependencyContainer.RegisterTransient<IServiceBase<Sales>, ServiceBase<Sales>>();
            dependencyContainer.RegisterTransient<IRepositoryBase<Sales>, RepositoryBase<Sales>>();
            dependencyContainer.RegisterTransient<IBusinessBase<Sales>, BusinessBase<Sales>>();
            dependencyContainer.RegisterTransient<IServiceSales, ServiceSales>();
            dependencyContainer.RegisterTransient<IRepositorySales, RepositorySales>();
            dependencyContainer.RegisterTransient<IBusinessSales, BusinessSales>();


            dependencyContainer.RegisterTransient<IServiceBase<RoomSales>, ServiceBase<RoomSales>>();
            dependencyContainer.RegisterTransient<IRepositoryBase<RoomSales>, RepositoryBase<RoomSales>>();
            dependencyContainer.RegisterTransient<IBusinessBase<RoomSales>, BusinessBase<RoomSales>>();
            dependencyContainer.RegisterTransient<IServiceRoomSales, ServiceRoomSales>();
            dependencyContainer.RegisterTransient<IRepositoryRoomSales, RepositoryRoomSales>();
            dependencyContainer.RegisterTransient<IBusinessRoomSales, BusinessRoomSales>();

            dependencyContainer.RegisterTransient<IServiceBase<PaymentMethods>, ServiceBase<PaymentMethods>>();
            dependencyContainer.RegisterTransient<IRepositoryBase<PaymentMethods>, RepositoryBase<PaymentMethods>>();
            dependencyContainer.RegisterTransient<IBusinessBase<PaymentMethods>, BusinessBase<PaymentMethods>>();
            dependencyContainer.RegisterTransient<IServicePaymentMethods, ServicePaymentMethods>();
            dependencyContainer.RegisterTransient<IRepositoryPaymentMethods, RepositoryPaymentMethods>();
            dependencyContainer.RegisterTransient<IBusinessPaymentMethods, BusinessPaymentMethods>();

            dependencyContainer.RegisterTransient<IServiceBase<SaleExtras>, ServiceBase<SaleExtras>>();
            dependencyContainer.RegisterTransient<IRepositoryBase<SaleExtras>, RepositoryBase<SaleExtras>>();
            dependencyContainer.RegisterTransient<IBusinessBase<SaleExtras>, BusinessBase<SaleExtras>>();
            dependencyContainer.RegisterTransient<IServiceSaleExtras, ServiceSaleExtras>();
            dependencyContainer.RegisterTransient<IRepositorySaleExtras, RepositorySaleExtras>();
            dependencyContainer.RegisterTransient<IBusinessSaleExtras, BusinessSaleExtras>();


            dependencyContainer.RegisterTransient<IServiceBase<ExtraProducts>, ServiceBase<ExtraProducts>>();
            dependencyContainer.RegisterTransient<IRepositoryBase<ExtraProducts>, RepositoryBase<ExtraProducts>>();
            dependencyContainer.RegisterTransient<IBusinessBase<ExtraProducts>, BusinessBase<ExtraProducts>>();
            dependencyContainer.RegisterTransient<IServiceExtraProducts, ServiceExtraProducts>();
            dependencyContainer.RegisterTransient<IRepositoryExtraProducts, RepositoryExtraProducts>();
            dependencyContainer.RegisterTransient<IBusinessExtraProducts, BusinessExtraProducts>();

            dependencyContainer.RegisterTransient<IServiceBase<ExtraProductCategories>, ServiceBase<ExtraProductCategories>>();
            dependencyContainer.RegisterTransient<IRepositoryBase<ExtraProductCategories>, RepositoryBase<ExtraProductCategories>>();
            dependencyContainer.RegisterTransient<IBusinessBase<ExtraProductCategories>, BusinessBase<ExtraProductCategories>>();
            dependencyContainer.RegisterTransient<IServiceExtraProductCategories, ServiceExtraProductCategories>();
            dependencyContainer.RegisterTransient<IRepositoryExtraProductCategories, RepositoryExtraProductCategories>();
            dependencyContainer.RegisterTransient<IBusinessExtraProductCategories, BusinessExtraProductCategories>();

            dependencyContainer.RegisterTransient<IServiceBase<RoomTypes>, ServiceBase<RoomTypes>>();
            dependencyContainer.RegisterTransient<IRepositoryBase<RoomTypes>, RepositoryBase<RoomTypes>>();
            dependencyContainer.RegisterTransient<IBusinessBase<RoomTypes>, BusinessBase<RoomTypes>>();
            dependencyContainer.RegisterTransient<IServiceRoomTypes, ServiceRoomTypes>();
            dependencyContainer.RegisterTransient<IRepositoryRoomTypes, RepositoryRoomTypes>();
            dependencyContainer.RegisterTransient<IBusinessRoomTypes, BusinessRoomTypes>();

            dependencyContainer.RegisterTransient<IServiceBase<Shifts>, ServiceBase<Shifts>>();
            dependencyContainer.RegisterTransient<IRepositoryBase<Shifts>, RepositoryBase<Shifts>>();
            dependencyContainer.RegisterTransient<IBusinessBase<Shifts>, BusinessBase<Shifts>>();
            dependencyContainer.RegisterTransient<IServiceShifts, ServiceShifts>();
            dependencyContainer.RegisterTransient<IRepositoryShifts, RepositoryShifts>();
            dependencyContainer.RegisterTransient<IBusinessShifts, BusinessShifts>();

            dependencyContainer.RegisterTransient<IServiceBase<RoomStatuses>, ServiceBase<RoomStatuses>>();
            dependencyContainer.RegisterTransient<IRepositoryBase<RoomStatuses>, RepositoryBase<RoomStatuses>>();
            dependencyContainer.RegisterTransient<IBusinessBase<RoomStatuses>, BusinessBase<RoomStatuses>>();
            dependencyContainer.RegisterTransient<IServiceRoomStatuses, ServiceRoomStatuses>();
            dependencyContainer.RegisterTransient<IRepositoryRoomStatuses, RepositoryRoomStatuses>();
            dependencyContainer.RegisterTransient<IBusinessRoomStatuses, BusinessRoomStatuses>();

            dependencyContainer.RegisterTransient<IServiceBase<BlockFloors>, ServiceBase<BlockFloors>>();
            dependencyContainer.RegisterTransient<IRepositoryBase<BlockFloors>, RepositoryBase<BlockFloors>>();
            dependencyContainer.RegisterTransient<IBusinessBase<BlockFloors>, BusinessBase<BlockFloors>>();
            dependencyContainer.RegisterTransient<IServiceBlockFloors, ServiceBlockFloors>();
            dependencyContainer.RegisterTransient<IRepositoryBlockFloors, RepositoryBlockFloors>();
            dependencyContainer.RegisterTransient<IBusinessBlockFloors, BusinessBlockFloors>();

            dependencyContainer.RegisterTransient<IServiceBase<Statuses>, ServiceBase<Statuses>>();
            dependencyContainer.RegisterTransient<IRepositoryBase<Statuses>, RepositoryBase<Statuses>>();
            dependencyContainer.RegisterTransient<IBusinessBase<Statuses>, BusinessBase<Statuses>>();
            dependencyContainer.RegisterTransient<IServiceStatuses, ServiceStatuses>();
            dependencyContainer.RegisterTransient<IRepositoryStatuses, RepositoryStatuses>();
            dependencyContainer.RegisterTransient<IBusinessStatuses, BusinessStatuses>();


            dependencyContainer.RegisterTransient<IServiceBase<Blocks>, ServiceBase<Blocks>>();
            dependencyContainer.RegisterTransient<IRepositoryBase<Blocks>, RepositoryBase<Blocks>>();
            dependencyContainer.RegisterTransient<IBusinessBase<Blocks>, BusinessBase<Blocks>>();
            dependencyContainer.RegisterTransient<IServiceBlocks, ServiceBlocks>();
            dependencyContainer.RegisterTransient<IRepositoryBlocks, RepositoryBlocks>();
            dependencyContainer.RegisterTransient<IBusinessBlocks, BusinessBlocks>();


            dependencyContainer.RegisterTransient<IServiceBase<Employees>, ServiceBase<Employees>>();
            dependencyContainer.RegisterTransient<IRepositoryBase<Employees>, RepositoryBase<Employees>>();
            dependencyContainer.RegisterTransient<IBusinessBase<Employees>, BusinessBase<Employees>>();
            dependencyContainer.RegisterTransient<IServiceEmployees, ServiceEmployees>();
            dependencyContainer.RegisterTransient<IRepositoryEmployees, RepositoryEmployees>();
            dependencyContainer.RegisterTransient<IBusinessEmployees, BusinessEmployees>();


            dependencyContainer.RegisterTransient<IServiceBase<EmployeeShifts>, ServiceBase<EmployeeShifts>>();
            dependencyContainer.RegisterTransient<IRepositoryBase<EmployeeShifts>, RepositoryBase<EmployeeShifts>>();
            dependencyContainer.RegisterTransient<IBusinessBase<EmployeeShifts>, BusinessBase<EmployeeShifts>>();
            dependencyContainer.RegisterTransient<IServiceEmployeeShifts, ServiceEmployeeShifts>();
            dependencyContainer.RegisterTransient<IRepositoryEmployeeShifts, RepositoryEmployeeShifts>();
            dependencyContainer.RegisterTransient<IBusinessEmployeeShifts, BusinessEmployeeShifts>();



            dependencyContainer.RegisterTransient<IServiceBase<Floors>, ServiceBase<Floors>>();
            dependencyContainer.RegisterTransient<IRepositoryBase<Floors>, RepositoryBase<Floors>>();
            dependencyContainer.RegisterTransient<IBusinessBase<Floors>, BusinessBase<Floors>>();
            dependencyContainer.RegisterTransient<IServiceFloors, ServiceFloors>();
            dependencyContainer.RegisterTransient<IRepositoryFloors, RepositoryFloors>();
            dependencyContainer.RegisterTransient<IBusinessFloors, BusinessFloors>();



            dependencyContainer.RegisterTransient<IServiceBase<GroupsOfEmployee>, ServiceBase<GroupsOfEmployee>>();
            dependencyContainer.RegisterTransient<IRepositoryBase<GroupsOfEmployee>, RepositoryBase<GroupsOfEmployee>>();
            dependencyContainer.RegisterTransient<IBusinessBase<GroupsOfEmployee>, BusinessBase<GroupsOfEmployee>>();
            dependencyContainer.RegisterTransient<IServiceGroupsOfEmployee, ServiceGroupsOfEmployee>();
            dependencyContainer.RegisterTransient<IRepositoryGroupsOfEmployee, RepositoryGroupsOfEmployee>();
            dependencyContainer.RegisterTransient<IBusinessGroupsOfEmployee, BusinessGroupsOfEmployee>();


            dependencyContainer.RegisterTransient<IServiceBase<Permits>, ServiceBase<Permits>>();
            dependencyContainer.RegisterTransient<IRepositoryBase<Permits>, RepositoryBase<Permits>>();
            dependencyContainer.RegisterTransient<IBusinessBase<Permits>, BusinessBase<Permits>>();
            dependencyContainer.RegisterTransient<IServicePermits, ServicePermits>();
            dependencyContainer.RegisterTransient<IRepositoryPermits, RepositoryPermits>();
            dependencyContainer.RegisterTransient<IBusinessPermits, BusinessPermits>();


            dependencyContainer.RegisterTransient<IServiceBase<PermitTypes>, ServiceBase<PermitTypes>>();
            dependencyContainer.RegisterTransient<IRepositoryBase<PermitTypes>, RepositoryBase<PermitTypes>>();
            dependencyContainer.RegisterTransient<IBusinessBase<PermitTypes>, BusinessBase<PermitTypes>>();
            dependencyContainer.RegisterTransient<IServicePermitTypes, ServicePermitTypes>();
            dependencyContainer.RegisterTransient<IRepositoryPermitTypes, RepositoryPermitTypes>();
            dependencyContainer.RegisterTransient<IBusinessPermitTypes, BusinessPermitTypes>();



            dependencyContainer.RegisterTransient<IServiceBase<ReserveCancelLog>, ServiceBase<ReserveCancelLog>>();
            dependencyContainer.RegisterTransient<IRepositoryBase<ReserveCancelLog>, RepositoryBase<ReserveCancelLog>>();
            dependencyContainer.RegisterTransient<IBusinessBase<ReserveCancelLog>, BusinessBase<ReserveCancelLog>>();
            dependencyContainer.RegisterTransient<IServiceReserveCancelLog, ServiceReserveCancelLog>();
            dependencyContainer.RegisterTransient<IRepositoryReserveCancelLog, RepositoryReserveCancelLog>();
            dependencyContainer.RegisterTransient<IBusinessReserveCancelLog, BusinessReserveCancelLog>();



            dependencyContainer.RegisterTransient<IServiceBase<Users>, ServiceBase<Users>>();
            dependencyContainer.RegisterTransient<IRepositoryBase<Users>, RepositoryBase<Users>>();
            dependencyContainer.RegisterTransient<IBusinessBase<Users>, BusinessBase<Users>>();
            dependencyContainer.RegisterTransient<IServiceUsers, ServiceUsers>();
            dependencyContainer.RegisterTransient<IRepositoryUsers, RepositoryUsers>();
            dependencyContainer.RegisterTransient<IBusinessUsers, BusinessUsers>();

            dependencyContainer.RegisterTransient<IServiceBase<UserAuthorities>, ServiceBase<UserAuthorities>>();
            dependencyContainer.RegisterTransient<IRepositoryBase<UserAuthorities>, RepositoryBase<UserAuthorities>>();
            dependencyContainer.RegisterTransient<IBusinessBase<UserAuthorities>, BusinessBase<UserAuthorities>>();
            dependencyContainer.RegisterTransient<IServiceUserAuthoritys, ServiceUserAuthoritys>();
            dependencyContainer.RegisterTransient<IRepositoryUserAuthoritys, RepositoryUserAuthoritys>();
            dependencyContainer.RegisterTransient<IBusinessUserAuthoritys, BusinessUserAuthoritys>();

            dependencyContainer.RegisterTransient<IServiceBase<Authorities>, ServiceBase<Authorities>>();
            dependencyContainer.RegisterTransient<IRepositoryBase<Authorities>, RepositoryBase<Authorities>>();
            dependencyContainer.RegisterTransient<IBusinessBase<Authorities>, BusinessBase<Authorities>>();
            dependencyContainer.RegisterTransient<IServiceAuthoritys, ServiceAuthoritys>();
            dependencyContainer.RegisterTransient<IRepositoryAuthoritys, RepositoryAuthoritys>();
            dependencyContainer.RegisterTransient<IBusinessAuthoritys, BusinessAuthoritys>();

        }
    }
}
