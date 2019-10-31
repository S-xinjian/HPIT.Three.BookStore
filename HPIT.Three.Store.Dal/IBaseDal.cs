using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace HPIT.Three.Store.Dal
{
    public interface IBaseDal<T> where T : class, new()
    {
        List<T> Sel(string name = "",string pwd = "",int par1=0,int par2 = 0);

        bool ins( T model);

        bool Del( T model);

        bool Upd( T model);

    }
}

