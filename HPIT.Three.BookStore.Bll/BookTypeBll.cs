using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HPIT.Three.BookStore.Model;
using HPIT.Three.Store.Dal;

namespace HPIT.Three.BookStore.Bll
{
    public class BookTypeBll : IBaseDal<BookType>
    {
        private BookTypeDal dal = new BookTypeDal();
        public bool Del(BookType model)
        {
            return dal.Del(model);
        }

        public bool ins(BookType model)
        {
            return dal.ins(model);
        }

        public List<BookType> Sel(string name = "", string pwd = "", int par1 = 0, int par2 = 0)
        {
            throw new NotImplementedException();
        }

        public bool Upd(BookType model)
        {
            return dal.Upd(model);
        }
    }
}
