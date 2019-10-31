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
        private Book dal = new Book();
        public bool Del(Book model)
        {
            throw new NotImplementedException();
        }

        public bool ins(Book model)
        {
            throw new NotImplementedException();
        }

        public List<Book> Sel(string name = "", string pwd = "", int par1 = 0, int par2 = 0)
        {
            throw new NotImplementedException();
        }

        public bool Upd(Book model)
        {
            throw new NotImplementedException();
        }
    }
}
