using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HPIT.Three.BookStore.Model;
using HPIT.Three.Store.Dal;

namespace HPIT.Three.BookStore.Bll
{
    public class FeelInfoBll : IBaseDal<FeelInfo>
    {
        private FeelInfoDal dal = new FeelInfoDal();
        public bool Del(FeelInfo model)
        {
            return dal.Del(model);
        }

        public bool ins(FeelInfo model)
        {
            return dal.ins(model);
        }

        public List<FeelInfo> Sel(string name = "", string pwd = "", int par1 = 0, int par2 = 0)
        {
            throw new NotImplementedException();
        }

        public bool Upd(FeelInfo model)
        {
            return dal.Upd(model);
        }
    }
}
