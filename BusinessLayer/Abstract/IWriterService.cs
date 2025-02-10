using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IWriterService
    {
        List<Writer> GetList();
        void WrtiterAdd(Writer writer);
        void WrtiterDelete(Writer writer);
        void WrtiterUpdate(Writer writer);
        Writer GetById(int id);
    }
}
