using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HPIT.Three.BookStore.Model;
using HPIT.Three.Store.Dal;

namespace HPIT.Three.BookStore.Bll
{
    public class UserOrderBll : IBaseDal<UserOrder>
    {
        private UserOrder dal = new UserOrder();
        public bool Del(UserOrder model)
        {
            throw new NotImplementedException();
        }

        public bool ins(UserOrder model)
        {
            throw new NotImplementedException();
        }

        public List<UserOrder> Sel(string name = "", string pwd = "", int par1 = 0, int par2 = 0)
        {
            throw new NotImplementedException();
        }

        public bool Upd(UserOrder model)
        {
            throw new NotImplementedException();
        }
    }
}
