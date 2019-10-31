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
        private UserOrderDal dal = new UserOrderDal();
        public bool Del(UserOrder model)
        {
            return dal.Del(model);
        }

        public bool ins(UserOrder model)
        {
            return dal.ins(model);
        }

        public List<UserOrder> Sel(string name = "", string pwd = "", int par1 = 0, int par2 = 0)
        {
            throw new NotImplementedException();
        }

        public bool Upd(UserOrder model)
        {
            return dal.Upd(model);
        }
    }
}
