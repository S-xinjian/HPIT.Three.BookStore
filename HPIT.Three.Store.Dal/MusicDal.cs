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
    public class MusicDal : IBaseDal<Music>
    {
        public bool Del(Music model)
        {
            SqlParameter[] par = new SqlParameter[]
             {
                new SqlParameter("@Musician",model.Musician),
                new SqlParameter("@Musicname",model.Musicname),
                new SqlParameter("@MusicSrc",model.MusicSrc),
                new SqlParameter("@MusicID",model.MusicID)

             };
            return SQLHelper.NanQuery("", par);
        }

        public bool ins(Music model)
        {
            SqlParameter[] par = new SqlParameter[]
            {
                new SqlParameter("@Musician",model.Musician),
                new SqlParameter("@Musicname",model.Musicname),
                new SqlParameter("@MusicSrc",model.MusicSrc),
                new SqlParameter("@MusicID",model.MusicID)

            };
            return SQLHelper.NanQuery("", par);
        }

        public List<Music> Sel(string name = "", string pwd = "", int par1 = 0, int par2 = 0)
        {
            List<Music> list = new List<Music>();
            DataTable table = SQLHelper.Sel("");
            foreach (DataRow row in table.Rows)
            {
                Music model = new Music() 
                {
                    MusicID = Convert.ToInt32(row["MusicID"]),
                    Musician = Convert.ToString(row["Musician"]),
                    Musicname = Convert.ToString(row["Musicname"]),
                    MusicSrc = Convert.ToString(row["MusicSrc"]),
                };
                list.Add(model);
            }
            return list;
        }

        public bool Upd(Music model)
        {
            throw new NotImplementedException();
        }
    }
}
