using Microsoft.EntityFrameworkCore;
using PermissionsApplication.DataAccess.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PermissionsApplication.DataAccess.Repositories.Base
{
    public abstract class BaseRepository<T> : IBaseRepository<T> where T : class, new()
    {
        protected PermissionsApplicationContext RepositoryContext { get; set; }
        protected readonly DbSet<T> entities;
        public BaseRepository(PermissionsApplicationContext repositoryContext)
        {
            this.RepositoryContext = repositoryContext;
            entities = RepositoryContext.Set<T>();
        }

        public virtual IQueryable<T> FindAll()
        {
            var result = this.entities.AsNoTracking();
            return result;
        }

        public virtual IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return this.RepositoryContext.Set<T>().Where(expression).AsNoTracking();
        }

        public virtual T FirstOrDefault(Expression<Func<T, bool>> expression)
        {
            return this.RepositoryContext.Set<T>().FirstOrDefault(expression);
        }

        public virtual T GetOne(int Id)
        {
            return this.RepositoryContext.Set<T>().Find(Id);
        }

        public bool Exist(Expression<Func<T, bool>> expression) => (this.RepositoryContext.Set<T>().Any(expression));

        public virtual int Create(T entity)
        {
            var result = entities.Add(entity);
            this.RepositoryContext.SaveChanges();
            return Convert.ToInt32(result.Property("ID").CurrentValue.ToString());
        }

        public virtual void CreateRange(List<T> entitys)
        {
            entities.AddRange(entitys);
            this.RepositoryContext.SaveChanges();
        }

        public virtual T Update(T entity)
        {
            this.RepositoryContext.Set<T>().Update(entity);
            this.RepositoryContext.SaveChanges();
            return entity;
        }

        public virtual void UpdateRange(List<T> entitys)
        {
            entities.UpdateRange(entitys);
            this.RepositoryContext.SaveChanges();
        }

        public virtual void Delete(T entity)
        {
            this.RepositoryContext.Entry(entity).State = EntityState.Deleted;
            this.RepositoryContext.SaveChanges();
        }
    }
}
