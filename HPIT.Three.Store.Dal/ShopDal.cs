using HPIT.Three.BookStore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace HPIT.Three.Store.Dal
{
    public class ShopDal : IBaseDal<Shop>
    {
        public bool Del(Shop model)
        {
            SqlParameter[] par = new SqlParameter[]
            {
                new SqlParameter("@ShopID",model.ShopID),
            };
            return SQLHelper.NanQuery("", par);
        }

        public bool ins(Shop model)
        {
            SqlParameter[] par = new SqlParameter[]
            {
                new SqlParameter("@ShopAccount",model.ShopAccount),
                new SqlParameter("@ShopInfoID",model.ShopInfoID),
                new SqlParameter("@ShopPassword",model.ShopPassword),
            };
            return SQLHelper.NanQuery("", par);
        }

        public List<Shop> Sel(string name = "", string pwd = "", int par1 = 0, int par2 = 0)
        {
            SqlParameter[] par = new SqlParameter[]
            {
                new SqlParameter("@",name)
            };
            DataTable table = SQLHelper.Sel("",par);
            List<Shop> list = new List<Shop>();
            foreach (DataRow row in table.Rows)
            {
                Shop model = new Shop() 
                {
                    
                };
                list.Add(model);
            }
            return list;
        }

        public bool Upd(Shop model)
        {
            SqlParameter[] par = new SqlParameter[]
            {
                new SqlParameter("@ShopID",model.ShopID),
            };
            return SQLHelper.NanQuery("", par);
        }
    }
}
