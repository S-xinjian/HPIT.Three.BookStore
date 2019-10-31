using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HPIT.Three.BookStore.Model;
using HPIT.Three.Store.Dal;

namespace HPIT.Three.BookStore.Bll
{
    public class UsersBll : IBaseDal<Users>
    {
        private UsersDal dal = new UsersDal();
        public bool Del(Users model)
        {
            return dal.Del(model);
        }

        public bool ins(Users model)
        {
            return dal.ins(model);
        }

        public List<Users> Sel(string name = "", string pwd = "", int par1 = 0, int par2 = 0)
        {
            throw new NotImplementedException();
        }

        public bool Upd(Users model)
        {
            return dal.Upd(model);
        }
    }
}
