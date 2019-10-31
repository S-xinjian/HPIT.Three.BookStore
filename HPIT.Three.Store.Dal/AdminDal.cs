using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HPIT.Three.BookStore.Model;
using System.Data;
using System.Data.SqlClient;

namespace HPIT.Three.Store.Dal
{
    public class AdminDal : IBaseDal<Admin>
    {
        public bool Del(Admin model)
        {
            SqlParameter[] par = new SqlParameter[]
            {
                new SqlParameter("@AdminID",model.AdminID)
            };
            return SQLHelper.NanQuery("", par);
        }

        public bool ins(Admin model)
        {
            SqlParameter[] par = new SqlParameter[]
            {
                new SqlParameter("@AdminAccount",model.AdminAccount),
                new SqlParameter("@AdminPassword",model.AdminPassword)
            };
            return SQLHelper.NanQuery("", par);
        }

        public List<Admin> Sel(string name = "", string pwd = "", int par1 = 0, int par2 = 0)
        {
            SqlParameter[] par = new SqlParameter[]
            {
                new SqlParameter("@AdminAccount",name),
                new SqlParameter("@AdminPassword",pwd)
            };
            DataTable table = SQLHelper.Sel("", par);
            List<Admin> listt = new List<Admin>();
            foreach (DataRow row in table.Rows)
            {
                Admin model = new Admin()
                {
                    AdminID = Convert.ToInt32(row["AdminID"]),
                    AdminPassword = Convert.ToString(row["AdminPassword"]),
                    AdminAccount = Convert.ToString(row["AdminAccount"]),
                };
                listt.Add(model);
            }
            return listt;

        }

        public bool Upd(Admin model)
        {
            SqlParameter[] par = new SqlParameter[]
            {
                new SqlParameter("@AdminAccount",model.AdminAccount),
                new SqlParameter("@AdminPassword",model.AdminPassword),
            };
            return SQLHelper.NanQuery("", par);
        }
    }
}
