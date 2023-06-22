using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meshur_Sehirler_CF.Data
{
    // [Table("Cities")] // tablo adı degistirme
    public class Sehir
    {
        [Key] // Plaka primary key  // virgulle bırlestırılebılır
        [DatabaseGenerated(DatabaseGeneratedOption.None)] // identity degil kendim giricem
        // [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Plaka { get; set; }

        [MaxLength(50)] // nvarchar(50) demek
        // [Column("CityName")] // kolon adı degistirme
        public string Ad { get; set; } = null!;  // string? olursa null olabilir demek

        // Navigation Property yon bulma Sehirden Ozelliklere gecme
        public List<Ozellik> Ozellikler { get; set; } = new();
    }
}
