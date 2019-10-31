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
            SqlParameter[] par = new SqlParameter[]
            {
                new SqlParameter("@UsersId",model.UsersId)
            };
            return SQLHelper.NanQuery("", par);
        }

        public bool ins(Users model)
        {
            SqlParameter[] par = new SqlParameter[]
            {
                new SqlParameter("@UserInfoID",model.UserInfoID),
                new SqlParameter("@UsersAccount",model.UsersAccount),
                new SqlParameter("@UsersPassword",model.UsersPassword),
            };
            return SQLHelper.NanQuery("", par);
        }

        public List<Users> Sel(string name = "", string pwd = "", int par1 = 0, int par2 = 0)
        {
            SqlParameter[] par = new SqlParameter[]
            {
                new SqlParameter("@UsersAccount",name),
                new SqlParameter("@UsersPassword",pwd),
            };
            List<Users> list = new List<Users>();
            DataTable table = SQLHelper.Sel("",par);
            foreach (DataRow row in table.Rows)
            {
                Users model = new Users() 
                {
                    
                };
                list.Add(model);
            }
            return list;
        }

        public bool Upd(Users model)
        {
            SqlParameter[] par = new SqlParameter[]
            {
                new SqlParameter("@UsersId",model.UsersId),
                new SqlParameter("@UserInfoID",model.UserInfoID),
                new SqlParameter("@UsersAccount",model.UsersAccount),
                new SqlParameter("@UsersPassword",model.UsersPassword),
            };
            return SQLHelper.NanQuery("", par);
        }
    }
}
