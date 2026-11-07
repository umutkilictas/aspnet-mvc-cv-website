using System;

namespace Cv_MVC.Models.Entity
{
    public partial class Table_Yeteneklerim
    {
        public int ID { get; set; }
        public string Yetenek { get; set; }
        public Nullable<byte> Oran { get; set; }
    }
}