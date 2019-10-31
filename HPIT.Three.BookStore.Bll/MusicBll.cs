using HPIT.Three.BookStore.Model;
using HPIT.Three.Store.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HPIT.Three.BookStore.Bll
{
    public class MusicBll : IBaseDal<Music>
    {
        private MusicDal dal = new MusicDal();

        public bool Del(Music model)
        {
            return dal.Del(model);
        }

        public bool ins(Music model)
        {
            return dal.ins(model);
        }

        public List<Music> Sel(string name = "", string pwd = "", int par1 = 0, int par2 = 0)
        {
            return dal.Sel( name,  pwd,  par1,  par2);
        }

        public bool Upd(Music model)
        {
            return dal.Upd(model);
        }
    }
}
