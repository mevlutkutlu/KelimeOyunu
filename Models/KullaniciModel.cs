﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KelimeOyunu.Models
{
    public class KullaniciModel
    {
        public int KullaniciID { get; set; }
        public string KullaniciAd { get; set; }
        public string KullaniciSoyad { get; set; }
        public string KullaniciMail { get; set; }
        public string KullaniciSifre { get; set; }
    }
}