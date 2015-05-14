using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Model;
using DataLayer;
using System.Data.Entity;

namespace DataLayer.EfEntityFramework
{
    public class EfEntityRepository<T>: IEntityRepository<T> where T : Entity
    {
        private readonly DbContext _context; 
        public EfEntityRepository() 
        { 
            _context = new TutoratDbContext(); 
        }

        public IQueryable<T> GetAll() 
        { 
            return _context.Set<T>().AsQueryable(); 
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
        }

        public void Update(T entity) //??????
        {
            //T objet = this.GetById(entity.Id); 
            //if (objet != null)
            //{
            //    object
            //}
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
            _context.SaveChanges();
        }

        public T SingleId(int id)
        {
            return _context.Set<T>().Find(id);
        }
    }
}
