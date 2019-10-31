using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HPIT.Three.BookStore.Model;
using HPIT.Three.Store.Dal;

namespace HPIT.Three.BookStore.Bll
{
    public class UserAddBll : IBaseDal<UserAdd>
    {
        private UserAdd dal = new UserAdd();
        public bool Del(UserAdd model)
        {
            throw new NotImplementedException();
        }

        public bool ins(UserAdd model)
        {
            throw new NotImplementedException();
        }

        public List<UserAdd> Sel(string name = "", string pwd = "", int par1 = 0, int par2 = 0)
        {
            throw new NotImplementedException();
        }

        public bool Upd(UserAdd model)
        {
            throw new NotImplementedException();
        }
    }
}
