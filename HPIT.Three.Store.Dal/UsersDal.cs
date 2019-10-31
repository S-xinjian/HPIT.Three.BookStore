using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using HPIT.Three.BookStore.Model;

namespace HPIT.Three.Store.Dal
{
    public class UsersDal : IBaseDal<Users>
    {
        public bool Del(Users model)
        {
            throw new NotImplementedException();
        }

        public bool ins(Users model)
        {
            throw new NotImplementedException();
        }

        public List<Users> Sel(string name = "", string pwd = "", int par1 = 0, int par2 = 0)
        {
            throw new NotImplementedException();
        }

        public bool Upd(Users model)
        {
            throw new NotImplementedException();
        }
    }
}
