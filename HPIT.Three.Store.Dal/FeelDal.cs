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
    public class FeelDal : IBaseDal<Feel>
    {
        public bool Del(Feel model)
        {
            SqlParameter[] par = new SqlParameter[]
            {
                new SqlParameter("@FeelID",model.FeelID)
            };
            return SQLHelper.NanQuery("", par);
        }

        public bool ins(Feel model)
        {
            SqlParameter[] par = new SqlParameter[]
            {
                new SqlParameter("@FeelAccount",model.FeelAccount),
                new SqlParameter("@FeelInfoID",model.FeelInfoID),
                new SqlParameter("@FeelPassWord",model.FeelPassWord),
            };
            return SQLHelper.NanQuery("", par);
        }

        public List<Feel> Sel(string name = "", string pwd = "", int par1 = 0, int par2 = 0)
        {
            SqlParameter[] par = new SqlParameter[] 
            {
                new SqlParameter("@FeelAccount",name),
                new SqlParameter("@FeelPassWord",pwd),
            };
            DataTable table = SQLHelper.Sel("",par);
            List<Feel> list = new List<Feel>();
            foreach (DataRow row in table.Rows)
            {
                Feel model = new Feel() 
                {
                    
                };
                list.Add(model);
            }
            return list;
        }

        public bool Upd(Feel model)
        {
            SqlParameter[] par = new SqlParameter[]
            {
                new SqlParameter("@FeelAccount",model.FeelAccount),
                new SqlParameter("@FeelInfoID",model.FeelInfoID),
                new SqlParameter("@FeelPassWord",model.FeelPassWord),
            };
            return SQLHelper.NanQuery("", par);
        }
    }
}
