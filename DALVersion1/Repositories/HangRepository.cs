using DAL.DALVersion1.Context;
using DAL.DALVersion1.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DALVersion1.Repositories
{
    //Khi xây dựng theo dạng các tầng các lớp
    //=> đặc biệt để ý access modifier của class
    //(public, private, internal, protected,...)
    //public: có thể được truy cập từ mọi class, project khác
    //internal: chỉ có thể truy cập từ mọi class trong cùng 1 project
    //private: ko thể truy cập từ bất kì đâu, chỉ mình class đó sử dụng
    public class HangRepository //sửa thành public để cho tầng khác truy cập
    {
        DBContext dbContext;
        public HangRepository()
        {
            dbContext = new DBContext();
        }

        //get ALL
        public List<Hang> GetHangs() { 
            return dbContext.Hangs.ToList();
        }
    }
}
