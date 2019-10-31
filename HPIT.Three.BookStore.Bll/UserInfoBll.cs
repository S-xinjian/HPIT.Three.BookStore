using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HPIT.Three.BookStore.Model;
using HPIT.Three.Store.Dal;

namespace HPIT.Three.BookStore.Bll
{
    public class UserInfoBll : IBaseDal<UserInfo>
    {
        private UserInfo dasl = new UserInfo();
        public bool Del(UserInfo model)
        {
            throw new NotImplementedException();
        }

        public bool ins(UserInfo model)
        {
            throw new NotImplementedException();
        }

        public List<UserInfo> Sel(string name = "", string pwd = "", int par1 = 0, int par2 = 0)
        {
            throw new NotImplementedException();
        }

        public bool Upd(UserInfo model)
        {
            throw new NotImplementedException();
        }
    }
}
