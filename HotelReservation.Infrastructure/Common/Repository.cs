using Microsoft.EntityFrameworkCore;


namespace HotelReservation.Infrastructure.Data.Common
{
    public class Repository:IRepository
    {
        private readonly DbContext dbContext;

        public Repository(HotelReservationDbContext context)
        {
            dbContext = context;
        }

        public void Add<T>(T entity) where T : class
        {
            DbSet<T>().Add(entity);
        }

        public IQueryable<T> All<T>() where T : class
        {
            return DbSet<T>().AsQueryable();
        }

        public int SaveChanges()
        {
            return dbContext.SaveChanges();
        }

        private DbSet<T> DbSet<T>() where T: class
        {
            return dbContext.Set<T>();
        }
        public void Remove<T>(T entity) where T : class
        {
            DbSet<T>().Remove(entity);
        }

    }
}
