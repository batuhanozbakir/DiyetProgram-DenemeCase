using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_DiyetProgrami.Entities.Abstract
{
    public abstract class BaseEntity : IEntity
    {
        public int Id { get; set; }
        public string Adi { get; set; }

        public DateTime OlusturmaTarihi { get; set; } // yönetici olma tarihi işe giriş

        public DateTime? GuncellenmeTarihi { get; set; } // Gidecek CRUD
        public DateTime? SilinmeTarihi { get; set; } // Gidecek CRUD
        public bool AktifMi { get; set; }
    }
}
