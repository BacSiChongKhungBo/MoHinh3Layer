using DAL.DALVersion1.Context;
using DAL.DALVersion1.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DALVersion1.Repositories
{
    public class NuocNgotRepository
    {
        DBContext dbContext;
        public NuocNgotRepository()
        {
            dbContext = new DBContext();
        }

        public List<Nuocngot> GetNuocngots() 
        { 
            return dbContext.Nuocngots.ToList();
        }

    }
}
