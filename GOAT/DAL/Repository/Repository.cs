using DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly GoatContext goatContext = new();
        public void Add(T entity)
        {
            goatContext.Add(entity);
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();

        }

        public BaseEntity Get(T entity)
        {
            throw new NotImplementedException();

        }

        public List<BaseEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }

        public void Save() {
            goatContext.SaveChanges();
        }
    }
}
