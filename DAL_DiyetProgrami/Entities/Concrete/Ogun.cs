using DAL_DiyetProgrami.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_DiyetProgrami.Entities.Concrete
{
    public class Ogun : BaseEntity
    {
        public DateTime OgunZamani { get; set; } // ?
        public  List<Yemek> Yemekler { get; set; } = new List<Yemek>();
    }
}
