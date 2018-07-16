using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calisma.Model
{
    [Table("Ogrenciler")]
    public class Ogrenci : Insan
    {
        public int OgrenciNo { get; set; }
    }
}
