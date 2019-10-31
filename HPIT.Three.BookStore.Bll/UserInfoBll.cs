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
        private UserInfoDal dal = new UserInfoDal();
        public bool Del(UserInfo model)
        {
            return dal.Del(model);
        }

        public bool ins(UserInfo model)
        {
            return dal.ins(model);
        }

        public List<UserInfo> Sel(string name = "", string pwd = "", int par1 = 0, int par2 = 0)
        {
            throw new NotImplementedException();
        }

        public bool Upd(UserInfo model)
        {
            return dal.Upd(model);
        }
    }
}
