using DAL_DiyetProgrami.Context;
using DAL_DiyetProgrami.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_DiyetProgrami.Repositories.Concrete
{
    public class YemekKategorisiRepository 
    {
        public YemekKategorisiRepository(DiyetProgramiDbContext dbContext) : base(dbContext)
        {
            
        }
    }
}
