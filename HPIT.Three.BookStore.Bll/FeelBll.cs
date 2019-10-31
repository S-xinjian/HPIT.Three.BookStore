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
        private Feel dal = new Feel();
        public bool Del(Feel model)
        {
            throw new NotImplementedException();
        }

        public bool ins(Feel model)
        {
            throw new NotImplementedException();
        }

        public List<Feel> Sel(string name = "", string pwd = "", int par1 = 0, int par2 = 0)
        {
            throw new NotImplementedException();
        }

        public bool Upd(Feel model)
        {
            throw new NotImplementedException();
        }
    }
}
