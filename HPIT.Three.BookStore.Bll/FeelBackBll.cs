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
        private FeelBack dal = new FeelBack();
        public bool Del(FeelBack model)
        {
            throw new NotImplementedException();
        }

        public bool ins(FeelBack model)
        {
            throw new NotImplementedException();
        }

        public List<FeelBack> Sel(string name = "", string pwd = "", int par1 = 0, int par2 = 0)
        {
            throw new NotImplementedException();
        }

        public bool Upd(FeelBack model)
        {
            throw new NotImplementedException();
        }
    }
}
