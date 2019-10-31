using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HPIT.Three.BookStore.Model;
using HPIT.Three.Store.Dal;

namespace HPIT.Three.BookStore.Bll
{
    public class FeelBll : IBaseDal<Feel>
    {
        private FeelDal dal = new FeelDal();
        public bool Del(Feel model)
        {
            return dal.Del(model);
        }

        public bool ins(Feel model)
        {
            return dal.ins(model);
        }

        public List<Feel> Sel(string name = "", string pwd = "", int par1 = 0, int par2 = 0)
        {
            throw new NotImplementedException();
        }

        public bool Upd(Feel model)
        {
            return dal.Upd(model);
        }
    }
}
