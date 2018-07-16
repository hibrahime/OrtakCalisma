using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calisma.Model
{
    [Table("Ogretmenler")]
    public class Ogretmen : Insan
    {
        public string Brans { get; set; }
    }
}
