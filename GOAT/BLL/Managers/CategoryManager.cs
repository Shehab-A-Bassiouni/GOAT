
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

        private static CategoryRepo categoryRepo= new CategoryRepo();

        public static SaveState Add(Category category)
        {
            return categoryRepo.Add(category);
        }

        public static List<Category> GetAll()
        {
            return categoryRepo.GetAll();
        }

        public static Category GetByID(int id)
        {
            return categoryRepo.GetByID(id);
        }

        public static SaveState Edit(Category category)
        {
            CategoryRepo categoryRepoedit = new CategoryRepo();
            return categoryRepoedit.Update(category);
        }

        public static SaveState Delete(int id)
        {
            CategoryRepo categoryRepodelete = new CategoryRepo();
            return categoryRepodelete.DeleteByID(id);
        }
    }
}
