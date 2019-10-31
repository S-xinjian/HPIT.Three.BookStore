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
    public class UserOrderDal : IBaseDal<UserOrder>
    {
        public bool Del(UserOrder model)
        {
            SqlParameter[] par = new SqlParameter[]
            {
                new SqlParameter("@UserOrderID",model.UserOrderID)
            };
            return SQLHelper.NanQuery("", par);
        }

        public bool ins(UserOrder model)
        {
            SqlParameter[] par = new SqlParameter[]
            {
                new SqlParameter("@UserInfoID",model.UserInfoID),
                new SqlParameter("@UserOrderName",model.UserOrderName),
                new SqlParameter("@UserOrderTime",model.UserOrderTime),
            };
            return SQLHelper.NanQuery("", par);
        }

        public List<UserOrder> Sel(string name = "", string pwd = "", int par1 = 0, int par2 = 0)
        {
            SqlParameter[] par = new SqlParameter[] 
            {
                
            };
            DataTable table = SQLHelper.Sel("", par);
            List<UserOrder> list = new List<UserOrder>();
            foreach (DataRow row in table.Rows)
            {
                UserOrder model = new UserOrder() 
                { 
                    
                };
                list.Add(model);
            }
            return list;
        }

        public bool Upd(UserOrder model)
        {
            SqlParameter[] par = new SqlParameter[]
            {
                new SqlParameter("@UserOrderID",model.UserOrderID),
                new SqlParameter("@UserInfoID",model.UserInfoID),
                new SqlParameter("@UserOrderName",model.UserOrderName),
                new SqlParameter("@UserOrderTime",model.UserOrderTime),
            };
            return SQLHelper.NanQuery("", par);
        }
    }
}
