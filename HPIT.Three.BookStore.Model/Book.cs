using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HPIT.Three.BookStore.Model
{
    public class Book
    {
        public int BookID { get; set; }
        public string BookIndexImg { get; set; }
        public string BookName { get; set; }
        public string BookDetailsImg { get; set; }
        public double BookPrice { get; set; }
        public int BookRoost { get; set; }
        public int BookStock { get; set; }
        public int ShopInfoID { get; set; }
        public int BookTypeID { get; set; }
    }
}
