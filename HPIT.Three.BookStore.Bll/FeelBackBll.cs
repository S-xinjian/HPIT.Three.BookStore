using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HPIT.Three.BookStore.Model;
using HPIT.Three.Store.Dal;

namespace HPIT.Three.BookStore.Bll
{
    public class FeelBackBll : IBaseDal<FeelBack>
    {
        private FeelBackDal dal = new FeelBackDal();
        public bool Del(FeelBack model)
        {
            return dal.Del(model);
        }

        public bool ins(FeelBack model)
        {
            return dal.ins(model);
        }

        public List<FeelBack> Sel(string name = "", string pwd = "", int par1 = 0, int par2 = 0)
        {
            throw new NotImplementedException();
        }

        public bool Upd(FeelBack model)
        {
            return dal.Upd(model);
        }
    }
}
