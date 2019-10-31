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
    public class ShopInfoDal : IBaseDal<ShopInfo>
    {
        public bool Del(ShopInfo model)
        {
            SqlParameter[] par = new SqlParameter[]
           {
                new SqlParameter("@ShopInfoID",model.ShopInfoID),
           };
            return SQLHelper.NanQuery("", par);
        }

        public bool ins(ShopInfo model)
        {
            SqlParameter[] par = new SqlParameter[]
           {
                new SqlParameter("@ShopInfoName",model.ShopInfoName),
                new SqlParameter("@ShopInfoPhone",model.ShopInfoPhone),
                new SqlParameter("@ShopInfoStoreName",model.ShopInfoStoreName),
           };
            return SQLHelper.NanQuery("", par);
        }

        public List<ShopInfo> Sel(string name = "", string pwd = "", int par1 = 0, int par2 = 0)
        {
            SqlParameter[] par = new SqlParameter[]
            {
                new SqlParameter("",name)
            };
            DataTable table = SQLHelper.Sel("", par);
            List<ShopInfo> list = new List<ShopInfo>();
            foreach (DataRow row in table.Rows)
            {
                ShopInfo model = new ShopInfo()
                {

                };
                list.Add(model);
            }
            return list;
        }

        public bool Upd(ShopInfo model)
        {
            SqlParameter[] par = new SqlParameter[]
            {
                new SqlParameter("@ShopInfoID",model.ShopInfoID),
                new SqlParameter("@ShopInfoName",model.ShopInfoName),
                new SqlParameter("@ShopInfoPhone",model.ShopInfoPhone),
                new SqlParameter("@ShopInfoStoreName",model.ShopInfoStoreName),
            };
            return SQLHelper.NanQuery("", par);
        }
    }
}
