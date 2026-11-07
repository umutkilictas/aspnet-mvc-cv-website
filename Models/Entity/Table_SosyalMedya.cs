using System;

namespace Cv_MVC.Models.Entity
{
    public partial class Table_SosyalMedya
    {
        public int ID { get; set; }
        public string Ad { get; set; }
        public string Link { get; set; }
        public string Ikon { get; set; }
        public Nullable<bool> Durum { get; set; }
    }
}