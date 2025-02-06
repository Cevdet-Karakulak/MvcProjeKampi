using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class CategoryManager
    {
        GenericRepository <Category> repo=new GenericRepository<Category>();

        public List<Category> GetAll()
        {
            return repo.List();
        }
        public void CategoryAddBl(Category p)
        {
            if (p.CategoryName == null || p.CategoryName.Length<=3 || p.CategoryDescription=="" || p.CategoryName.Length>=51)
            {

            }
            else
            {
                repo.Insert(p);
            }
        }
    }
}
