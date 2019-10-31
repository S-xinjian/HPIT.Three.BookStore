using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HPIT.Three.BookStore.Model;
using HPIT.Three.Store.Dal;

namespace HPIT.Three.BookStore.Bll
{
    public class ShopInfoBll : IBaseDal<ShopInfo>
    {
        private ShopInfoDal dal = new ShopInfoDal();
        public bool Del(ShopInfo model)
        {
            return dal.Del(model);
        }

        public bool ins(ShopInfo model)
        {
            return dal.ins(model);
        }

        public List<ShopInfo> Sel(string name = "", string pwd = "", int par1 = 0, int par2 = 0)
        {
            throw new NotImplementedException();
        }

        public bool Upd(ShopInfo model)
        {
            return dal.Upd(model);
        }
    }
}
