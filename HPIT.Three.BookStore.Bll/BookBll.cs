using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HPIT.Three.BookStore.Model;
using HPIT.Three.Store.Dal;

namespace HPIT.Three.BookStore.Bll
{
    public class BookBll : IBaseDal<Book>
    {
        private BookDal dal = new BookDal();
        public bool Del(Book model)
        {
            return dal.Del(model);
        }

        public bool ins(Book model)
        {
            return dal.ins(model);
        }

        public List<Book> Sel(string name = "", string pwd = "", int par1 = 0, int par2 = 0)
        {
            throw new NotImplementedException();
        }

        public bool Upd(Book model)
        {
            return dal.Upd(model);
        }
    }
}
