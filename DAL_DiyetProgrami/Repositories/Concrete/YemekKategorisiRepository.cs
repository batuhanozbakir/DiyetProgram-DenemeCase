using DAL_DiyetProgrami.Context;
using DAL_DiyetProgrami.Entities.Concrete;
using DAL_DiyetProgrami.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_DiyetProgrami.Repositories.Concrete
{
    public class YemekKategorisiRepository : Repository<YemekKategorisi>,IYemekKaragorisi
    {
        public DiyetProgramiDbContext DiyetProgramiDbContext
        {
            get { return _dbContext as DiyetProgramiDbContext; }
        }


        public YemekKategorisiRepository(DiyetProgramiDbContext dbContext) : base(dbContext)
        {
            
        }

        public override void Add(YemekKategorisi entity)
        {
            base.Add(entity);
        }
    }
}
