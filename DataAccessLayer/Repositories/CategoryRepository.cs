using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class CategoryRepository : ICategoryDal
    {
        Context c = new Context();
        void ICategoryDal.AddCategory(Category category)
        {
            c.Add(category);
            c.SaveChanges();
        }

        void ICategoryDal.DeleteCategory(Category category)
        {
            c.Remove(category);
            c.SaveChanges();
        }

        Category ICategoryDal.GetById(int id)
        {
            return c.Categories.Find(id);
        }

        List<Category> ICategoryDal.ListAllCategory()
        {
            return c.Categories.ToList();
        }

        void ICategoryDal.UpdateCategory(Category category)
        {
            c.Update(category);
            c.SaveChanges();
        }
    }
}
