using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meshur_Sehirler_CF.Data
{
    public class Ozellik
    {
        public int Id { get; set; }

        [MaxLength(100)]
        public string Ad { get; set; } = null!; // null girilemez -- string? nullable oluyor

        //[ForeignKey("Sehir")]  -- foreign key
        public int SehirId { get; set; }   // otomatik bunla FK oldugunu algılıyor sınıfAdıId ismiyle

        public Sehir Sehir { get; set; } = null!; // affet null ı
    } 
}
