using DAL_DiyetProgrami.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_DiyetProgrami.Entities.Concrete
{
    public class YemekKategorisi : BaseEntity
    {
        public string YemekTuru { get; set; }

        public string YemekAciklamasi { get; set; }

    }
}
