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
    public class BookTypeDal : IBaseDal<BookType>
    {
        public bool Del(BookType model)
        {
            SqlParameter[] par = new SqlParameter[] 
            {
                new SqlParameter("@",model)
            };
            return SQLHelper.NanQuery("",par);
        }

        public bool ins(BookType model)
        {
            SqlParameter[] par = new SqlParameter[]
            {
                new SqlParameter("@",model)
            };
            return SQLHelper.NanQuery("", par);
        }

        public List<BookType> Sel(string name = "", string pwd = "", int par1 = 0, int par2 = 0)
        {
            SqlParameter[] par = new SqlParameter[]
            {
                new SqlParameter("@",name)
            };
            List<BookType> list = new List<BookType>();
            DataTable table = SQLHelper.Sel("", par);
            foreach (DataRow row in table.Rows)
            {
                BookType model = new BookType() 
                {
                    
                };
                list.Add(model);
            }
            return list;
        }

        public bool Upd(BookType model)
        {
            SqlParameter[] par = new SqlParameter[]
            {
                new SqlParameter("@",model)
            };
            return SQLHelper.NanQuery("", par);
        }
    }
}
