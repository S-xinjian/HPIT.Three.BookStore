﻿using HPIT.Three.BookStore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace HPIT.Three.Store.Dal
{
    public class ShopInfoDal : IBaseDal<ShopInfo>
    {
        public bool Del(ShopInfo model)
        {
            throw new NotImplementedException();
        }

        public bool ins(ShopInfo model)
        {
            throw new NotImplementedException();
        }

        public List<ShopInfo> Sel(string name = "", string pwd = "", int par1 = 0, int par2 = 0)
        {
            throw new NotImplementedException();
        }

        public bool Upd(ShopInfo model)
        {
            throw new NotImplementedException();
        }
    }
}
