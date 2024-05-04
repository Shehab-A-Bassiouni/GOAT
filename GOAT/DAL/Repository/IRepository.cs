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
        public void DeleteByID(int id);
        public List<T> GetAll();
        public T GetByID(int id);
        
    }
}
