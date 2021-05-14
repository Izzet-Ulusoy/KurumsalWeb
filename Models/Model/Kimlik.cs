using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace KurumsalWeb.Models.Model
{
    [Table("Kimlik")]
    public class Kimlik
    {
        [Key]
        public int KimlikId { get; set; }
        [DisplayName("Site Başlık")]
        [Required,StringLength(100,ErrorMessage ="Max 100 Karakter Olmalı")]
        public string Title { get; set; }
        [DisplayName("Anahtar Kelimeler")]
        [Required, StringLength(200, ErrorMessage = "Max 200 Karakter Olmalı")]
        public string Keywords { get; set; }
        [DisplayName("Site Başlık")]
        public string Description { get; set; }
        [DisplayName("Site Logo")]
        public string LogoURL { get; set; }
        [DisplayName("Site Unvan")]
        public string Unvan { get; set; }
        public bool AktifMi { get; set; }
    }
}