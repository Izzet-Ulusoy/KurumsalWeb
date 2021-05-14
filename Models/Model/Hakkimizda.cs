using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace KurumsalWeb.Models.Model
{
    [Table("Hakkımızda")]
    public class Hakkimizda
    {
        [Key]
        public int HakkimizdaId { get; set; }
        [Required]
        [DisplayName("Açıklama")]
        public string Aciklama { get; set; }
        public bool AktifMi { get; set; }
    }
}