
using BLL.Utilities;
using DAL.CustomRepositories;
using DTOs.Objects;
using DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Managers
{
    public class CategoryManager
    {

        public static SaveState Add(Category category)
        {
            CategoryRepo categoryRepo = new CategoryRepo();
            return categoryRepo.Add(category);
        }

        public static List<Category> GetAll()
        {
            CategoryRepo categoryRepo = new CategoryRepo();
            return categoryRepo.GetAll();
        }

        public static Category GetByID(int id)
        {
            CategoryRepo categoryRepo = new CategoryRepo();
            return categoryRepo.GetByID(id);
        }

        public static SaveState Edit(Category category)
        {
            CategoryRepo categoryRepo = new CategoryRepo();
            return categoryRepo.Update(category);
        }

        public static SaveState Delete(int id)
        {
            CategoryRepo categoryRepo = new CategoryRepo();
            return categoryRepo.DeleteByID(id);
        }
    }
}
