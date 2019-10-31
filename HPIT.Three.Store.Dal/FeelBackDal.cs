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
    public class FeelBackDal : IBaseDal<FeelBack>
    {
        public bool Del(FeelBack model)
        {
            SqlParameter[] par = new SqlParameter[]
            {
                new SqlParameter("@FeelBackID",model.FeelBackID),
            };
            return SQLHelper.NanQuery("", par);
        }

        public bool ins(FeelBack model)
        {
            SqlParameter[] par = new SqlParameter[]
            {
                new SqlParameter("@FeelBackAdvance",model.FeelBackAdvance),
                new SqlParameter("@FeelBackTime",model.FeelBackTime),
                new SqlParameter("@FeelInfo",model.FeelInfo),
                new SqlParameter("@UserInfoID",model.UserInfoID),
                new SqlParameter("@FeelBackBack",model.FeelBackBack),
            };
            return SQLHelper.NanQuery("", par);
        }

        public List<FeelBack> Sel(string name = "", string pwd = "", int par1 = 0, int par2 = 0)
        {
            SqlParameter[] par = new SqlParameter[]
            {
                new SqlParameter("@",name)
            };
            List<FeelBack> list = new List<FeelBack>();
            DataTable table = SQLHelper.Sel("", par);
            foreach (DataRow row in table.Rows)
            {
                FeelBack model = new FeelBack() 
                {
                    
                };
                list.Add(model);
            }
            return list;
        }

        public bool Upd(FeelBack model)
        {
            SqlParameter[] par = new SqlParameter[]
            {
                new SqlParameter("@FeelBackID",model.FeelBackID),
                new SqlParameter("@FeelBackAdvance",model.FeelBackAdvance),
                new SqlParameter("@FeelBackTime",model.FeelBackTime),
                new SqlParameter("@FeelInfo",model.FeelInfo),
                new SqlParameter("@UserInfoID",model.UserInfoID),
                new SqlParameter("@FeelBackBack",model.FeelBackBack),
            };
            return SQLHelper.NanQuery("", par);
        }
    }
}
