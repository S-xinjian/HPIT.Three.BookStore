using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HPIT.Three.BookStore.Model;
using HPIT.Three.Store.Dal;

namespace HPIT.Three.BookStore.Bll
{
    public class ShopBll : IBaseDal<Shop>
    {
        private ShopDal dal = new ShopDal();
        public bool Del(Shop model)
        {
            return dal.Del(model);
        }

        public bool ins(Shop model)
        {
            return dal.ins(model);
        }

        public List<Shop> Sel(string name = "", string pwd = "", int par1 = 0, int par2 = 0)
        {
            throw new NotImplementedException();
        }

        public bool Upd(Shop model)
        {
            return dal.Upd(model);
        }
    }
}
