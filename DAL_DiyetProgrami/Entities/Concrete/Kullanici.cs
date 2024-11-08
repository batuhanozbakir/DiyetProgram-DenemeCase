﻿using DAL_DiyetProgrami.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_DiyetProgrami.Entities.Concrete
{
    public class Kullanici : BaseEntity
    { 
        public string Soyadi { get; set; }
        public string KullaniciSifre { get; set; } // ?  Hash code yapılacak
        public int Yas { get; set; }
        public double Kilo { get; set; }
        public double Boy { get; set; }
        public string Email { get; set; }
        public  string Cinsiyet { get; set; }
        public List<Yemek> Yemekler { get; set; } = new List<Yemek>();
        public List<Ogun> Ogunler { get; set; } = new List<Ogun>();

    }
}
