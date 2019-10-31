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
    public class BookDal : IBaseDal<Book>
    {
        public bool Del(Book model)
        {
            SqlParameter[] par = new SqlParameter[]
            {
                new SqlParameter("@BookID",model.BookID),
            };
            return SQLHelper.NanQuery("", par);
        }

        public bool ins(Book model)
        {
            SqlParameter[] par = new SqlParameter[]
          {
                new SqlParameter("@BookDetailsImg",model.BookDetailsImg),
                new SqlParameter("@BookIndexImg",model.BookIndexImg),
                new SqlParameter("@BookName",model.BookName),
                new SqlParameter("@BookPrice",model.BookPrice),
                new SqlParameter("@BookRoost",model.BookRoost),
                new SqlParameter("@BookStock",model.BookStock),
                new SqlParameter("@BookTypeID",model.BookTypeID),
                new SqlParameter("@ShopInfoID",model.ShopInfoID),
          };
            return SQLHelper.NanQuery("", par);
        }

        public List<Book> Sel(string name = "", string pwd = "", int par1 = 0, int par2 = 0)
        {

            SqlParameter[] par = new SqlParameter[]
            {
                new SqlParameter("",name),
            };
            DataTable table = SQLHelper.Sel("", par);
            List<Book> list = new List<Book>();
            foreach (DataRow row in table.Rows)
            {
                Book model = new Book() 
                {
                    
                };
                list.Add(model);
            }
            return list;
        }

        public bool Upd(Book model)
        {
            SqlParameter[] par = new SqlParameter[]
          {
                new SqlParameter("@BookID",model.BookID),
                new SqlParameter("@BookIndexImg",model.BookIndexImg),
                new SqlParameter("@BookName",model.BookName),
                new SqlParameter("@BookPrice",model.BookPrice),
                new SqlParameter("@BookRoost",model.BookRoost),
                new SqlParameter("@BookStock",model.BookStock),
                new SqlParameter("@BookTypeID",model.BookTypeID),
                new SqlParameter("@ShopInfoID",model.ShopInfoID),
                new SqlParameter("@BookDetailsImg",model.BookDetailsImg),
          };
            return SQLHelper.NanQuery("", par);
        }
    }
}
