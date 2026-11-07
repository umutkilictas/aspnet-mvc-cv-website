using System.ComponentModel.DataAnnotations;

namespace Cv_MVC.Models.Entity
{
    public partial class Table_Egitimlerim
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Bu alanı boş geçemezsiniz.")]
        public string Baslik { get; set; }

        public string AltBaslik1 { get; set; }
        public string AltBaslik2 { get; set; }

        [StringLength(10, ErrorMessage = "Lütfen en fazla 10 karakterlik veri girişi yapınız.")]
        public string GNO { get; set; }

        public string Tarih { get; set; }
    }
}