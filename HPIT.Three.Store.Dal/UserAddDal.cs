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
    public class UserAddDal : IBaseDal<UserAdd>
    {
        public bool Del(UserAdd model)
        {
            SqlParameter[] par = new SqlParameter[]
            {
                new SqlParameter("@UserAddID",model.UserAddID),
            };
            return SQLHelper.NanQuery("", par);
        }

        public bool ins(UserAdd model)
        {
            SqlParameter[] par = new SqlParameter[]
            {
                new SqlParameter("@",model.UserAddBookID),
                new SqlParameter("@",model.UserAddBookNmae),
                new SqlParameter("@",model.UserAddName),
            };
            return SQLHelper.NanQuery("", par);
        }

        public List<UserAdd> Sel(string name = "", string pwd = "", int par1 = 0, int par2 = 0)
        {
            SqlParameter[] par = new SqlParameter[]
            {
                new SqlParameter("@UserAddBookNmae",name),
                new SqlParameter("@UserAddName",pwd),
            };
            DataTable table = SQLHelper.Sel("", par);
            List<UserAdd> list = new List<UserAdd>();
            foreach (DataRow row in table.Rows)
            {
                UserAdd model = new UserAdd() 
                {
                    
                };
                list.Add(model);
            }
            return list;
        }

        public bool Upd(UserAdd model)
        {
            SqlParameter[] par = new SqlParameter[]
            {
                new SqlParameter("@UserAddID",model.UserAddID),
                new SqlParameter("@UserAddBookID",model.UserAddBookID),
                new SqlParameter("@UserAddBookNmae",model.UserAddBookNmae),
                new SqlParameter("@UserAddName",model.UserAddName),
            };
            return SQLHelper.NanQuery("", par);
        }
    }
}
