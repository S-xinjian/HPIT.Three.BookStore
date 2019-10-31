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
    public class FeelInfoDal : IBaseDal<FeelInfo>
    {
        public bool Del(FeelInfo model)
        {
            SqlParameter[] par = new SqlParameter[]
            {
                new SqlParameter("@FeelInfoID",model.FeelInfoID),
            };
            return SQLHelper.NanQuery("", par);
        }

        public bool ins(FeelInfo model)
        {
            SqlParameter[] par = new SqlParameter[]
            {
                new SqlParameter("@",model.FeelName),
                new SqlParameter("@",model.FeelPhone),
            };
            return SQLHelper.NanQuery("", par);
        }

        public List<FeelInfo> Sel(string name = "", string pwd = "", int par1 = 0, int par2 = 0)
        {
            SqlParameter[] par = new SqlParameter[]
            {
                new SqlParameter("@",name)
            };
            DataTable table = SQLHelper.Sel("", par);
            List<FeelInfo> list = new List<FeelInfo>();
            foreach (DataRow row in table.Rows)
            {
                FeelInfo model = new FeelInfo() 
                {
                    
                };
                list.Add(model);
            }
            return list;
        }

        public bool Upd(FeelInfo model)
        {
            SqlParameter[] par = new SqlParameter[]
            {
                new SqlParameter("@FeelInfoID",model.FeelInfoID),
                new SqlParameter("@",model.FeelName),
                new SqlParameter("@",model.FeelPhone),
            };
            return SQLHelper.NanQuery("", par);
        }
    }
}
