using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HPIT.Three.BookStore.Model;
using System.Data;
using System.Data.SqlClient;

namespace HPIT.Three.Store.Dal
{
    public class AdminDal : IBaseDal<Admin>
    {
        public bool Del(Admin model)
        {
            throw new NotImplementedException();
        }

        public bool ins(Admin model)
        {
            throw new NotImplementedException();
        }

        public List<Admin> Sel(string name = "", string pwd = "", int par1 = 0, int par2 = 0)
        {
            throw new NotImplementedException();
        }

        public bool Upd(Admin model)
        {
            throw new NotImplementedException();
        }
    }
}
