using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrate
{
   public class Barkod
    {
        public int Id { get; set; }
        public int UretimYili { get; set; }
        public int UretimAyi { get; set; }
        public int MakaraTipi { get; set; }
        public string Malzemesi { get; set; }
        public string Uretici { get; set; }
    }
}
