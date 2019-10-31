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
    public class UserInfoDal : IBaseDal<UserInfo>
    {
        public bool Del(UserInfo model)
        {
            SqlParameter[] par = new SqlParameter[]
            {
                new SqlParameter("@UserInfoID",model.UserInfoID)
            };
            return SQLHelper.NanQuery("", par);
        }

        public bool ins(UserInfo model)
        {
            SqlParameter[] par = new SqlParameter[]
            {
                new SqlParameter("@UserInfoAddress",model.UserInfoAddress),
                new SqlParameter("@UserInfoName",model.UserInfoName),
                new SqlParameter("@UserInfoPhone",model.UserInfoPhone),
                new SqlParameter("@UserInfoSex",model.UserInfoSex),
            };
            return SQLHelper.NanQuery("", par);
        }

        public List<UserInfo> Sel(string name = "", string pwd = "", int par1 = 0, int par2 = 0)
        {
            SqlParameter[] par = new SqlParameter[]
            {
                new SqlParameter("@UserInfoName",name)
            };
            DataTable table = SQLHelper.Sel("", par);
            List<UserInfo> list = new List<UserInfo>();
            foreach (DataRow row in table.Rows)
            {
                UserInfo model = new UserInfo() 
                {
                    
                };
                list.Add(model);
            }
            return list;
        }

        public bool Upd(UserInfo model)
        {
            SqlParameter[] par = new SqlParameter[]
            {
                new SqlParameter("@UserInfoID",model.UserInfoID),
                new SqlParameter("@UserInfoAddress",model.UserInfoAddress),
                new SqlParameter("@UserInfoName",model.UserInfoName),
                new SqlParameter("@UserInfoPhone",model.UserInfoPhone),
                new SqlParameter("@UserInfoSex",model.UserInfoSex),
            };
            return SQLHelper.NanQuery("", par);
        }
    }
}
