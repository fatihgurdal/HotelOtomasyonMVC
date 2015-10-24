using System.Data.Entity;
using ProjectTemplate.Core.Entities;
using ProjectTemplate.Core.FluentMappings;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Core.Objects;
using System.Data.SqlClient;
using System.Linq;

namespace ProjectTemplate.Core.EF
{
    public class ProjectTemplateContext : DbContext
    {
        public ProjectTemplateContext()
            : base("ProjectTemplateContext")
        {
            //Database.SetInitializer(new DbInitializer());
            Database.SetInitializer<ProjectTemplateContext>(new DbInitializer());
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<ProjectTemplateContext, ProjectTemplateConfiguration>());
        }

       
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<Departments> Departments { get; set; }
        public virtual DbSet<Discounts> Discounts { get; set; }
        public virtual DbSet<HotelFeatures> HotelFeatures { get; set; }
        public virtual DbSet<Nationalities> Nationalities { get; set; }
        public virtual DbSet<Packets> Packets { get; set; }
        public virtual DbSet<PacketsExtraProductCategories> PacketsExtraProductCategories { get; set; }
        public virtual DbSet<RoomFeatures> RoomFeatures { get; set; }
        public virtual DbSet<RoomFeaturesRoomTypes> RoomFeaturesRoomTypes { get; set; }
        public virtual DbSet<Rooms> Rooms { get; set; }
        public virtual DbSet<StayingInRoom> StayingInRoom { get; set; }
        public virtual DbSet<Sales> Sales { get; set; }
        public virtual DbSet<RoomSales> RoomSales { get; set; }
        public virtual DbSet<PaymentMethods> PaymentMethods { get; set; }
        public virtual DbSet<SaleExtras> SaleExtras { get; set; }
        public virtual DbSet<ExtraProducts> ExtraProducts { get; set; }
        public virtual DbSet<RoomTypes> RoomTypes { get; set; }
        public virtual DbSet<Shifts> Shifts { get; set; }
        public virtual DbSet<RoomStatuses> RoomStatuses { get; set; }
        public virtual DbSet<BlockFloors> BlockFloors { get; set; }
        public virtual DbSet<Statuses> Statuses { get; set; }
        public virtual DbSet<Blocks> Blocks { get; set; }
        public virtual DbSet<Employees> Employees { get; set; }
        public virtual DbSet<EmployeeShifts> EmployeeShifts { get; set; }
        public virtual DbSet<ExtraProductCategories> ExtraProductCategories { get; set; }
        public virtual DbSet<Floors> Floors { get; set; }
        public virtual DbSet<GroupsOfEmployee> GroupsOfEmployee { get; set; }
        public virtual DbSet<Permits> Permits { get; set; }
        public virtual DbSet<PermitTypes> PermitTypes { get; set; }
        public virtual DbSet<ReserveCancelLog> ReserveCancelLog { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<UserAuthorities> UserAuthoritys { get; set; }
        public virtual DbSet<Authorities> Authoritys { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //gerekli ise
           

            modelBuilder.Configurations.Add(new CustomersMap());
            modelBuilder.Configurations.Add(new StayingInRoomMap());
            modelBuilder.Configurations.Add(new DepartmentsMap());

            modelBuilder.Configurations.Add(new DiscountsMap());

            modelBuilder.Configurations.Add(new HotelFeaturesMap());
            modelBuilder.Configurations.Add(new NationalitiesMap());
            modelBuilder.Configurations.Add(new PacketsMap());

            modelBuilder.Configurations.Add(new PacketsExtraProductCategoriesMap());
            modelBuilder.Configurations.Add(new RoomFeaturesMap());
            modelBuilder.Configurations.Add(new RoomFeaturesRoomTypesMap());
            modelBuilder.Configurations.Add(new RoomsMap());

            modelBuilder.Configurations.Add(new SalesMap());
            modelBuilder.Configurations.Add(new RoomSalesMap());
            modelBuilder.Configurations.Add(new PaymentMethodsMap());
            modelBuilder.Configurations.Add(new SaleExtrasMap());


            modelBuilder.Configurations.Add(new ExtraProductsMap());
            modelBuilder.Configurations.Add(new RoomTypesMap());
            modelBuilder.Configurations.Add(new ShiftsMap());
            modelBuilder.Configurations.Add(new RoomStatusesMap());


            modelBuilder.Configurations.Add(new BlockFloorsMap());
            modelBuilder.Configurations.Add(new StatusesMap());
            modelBuilder.Configurations.Add(new BlocksMap());

            modelBuilder.Configurations.Add(new EmployeesMap());
            modelBuilder.Configurations.Add(new EmployeeShiftsMap());
            modelBuilder.Configurations.Add(new ExtraProductCategoriesMap());
            modelBuilder.Configurations.Add(new FloorsMap());
            modelBuilder.Configurations.Add(new GroupsOfEmployeeMap());

            modelBuilder.Configurations.Add(new PermitsMap());
            modelBuilder.Configurations.Add(new PermitTypesMap());
            modelBuilder.Configurations.Add(new ReserveCancelLogMap());
            modelBuilder.Configurations.Add(new UsersMap());
            modelBuilder.Configurations.Add(new UserAuthoritiesMap());
            modelBuilder.Configurations.Add(new AuthoritiesMap());

           
            
        }

        //[DbFunction("ProjectTemplateContext", "GetExtraProductSalesTotal")]
        public virtual IQueryable<decimal> GetExtraProductSalesTotal(int RoomId)
        {
            var CodeParameter = RoomId != 0 ?
                new ObjectParameter("RoomId", RoomId) :
                new ObjectParameter("RoomId", typeof(int));

            return ((IObjectContextAdapter)this).ObjectContext
                .CreateQuery<decimal>(
                    string.Format("SELECT [{0}].{1}", "dbo",
                        "[F_ExtraProductSalesTotal](@RoomId)"), CodeParameter);
        }


        public virtual IQueryable<ExtraProducts> GetExtraProducts(int PacketId)
        {
            var CodeParameter = PacketId != 0 ?
                new ObjectParameter("PacketId", PacketId) :
                new ObjectParameter("PacketId", typeof(int));

            return ((IObjectContextAdapter)this).ObjectContext
                .CreateQuery<ExtraProducts>(
                    string.Format("{0} {1}", "EXEC",
                        "[SP_ExtraProducts] @SatisOdaId "), CodeParameter);
        }
    }
}
