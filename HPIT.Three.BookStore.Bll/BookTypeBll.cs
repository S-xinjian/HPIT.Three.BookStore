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
        private BookType dal = new BookType();
        public bool Del(BookType model)
        {
            throw new NotImplementedException();
        }

        public bool ins(BookType model)
        {
            throw new NotImplementedException();
        }

        public List<BookType> Sel(string name = "", string pwd = "", int par1 = 0, int par2 = 0)
        {
            throw new NotImplementedException();
        }

        public bool Upd(BookType model)
        {
            throw new NotImplementedException();
        }
    }
}
