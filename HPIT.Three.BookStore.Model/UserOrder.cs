using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HPIT.Three.BookStore.Model
{
    public class UserOrder
    {
        public int UserOrderID { get; set; }
        public string UserOrderName { get; set; }
        public string UserOrderTime { get; set; }
        public int UserInfoID { get; set; }
    }
}
