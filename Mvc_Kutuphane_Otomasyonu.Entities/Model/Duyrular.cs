﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mvc_Kutuphane_Otomasyonu.Entities.Model
{
    public class Duyrular
    {
        public int Id { get; set; } 
        public string Baslik { get; set; } 
        public string Duyuru { get; set; } 
        public string Acıklama { get; set; } 
        public DateTime Tarih { get; set; } 
    }
}
