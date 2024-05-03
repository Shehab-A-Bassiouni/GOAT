using DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public interface IRepository<T> where T: BaseEntity
    {
        public void Add(T entity);
        public void Update(T entity);
        public void Delete(T entity);
        public BaseEntity Get(T entity);
        public List<BaseEntity> GetAll();
    }
}
