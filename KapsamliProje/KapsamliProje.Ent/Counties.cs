using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KapsamliProje.Ent
{
    public class Counties:Base
    {
        public string  ?CountyName { get; set; }
        public int CityId  { get; set; }
        [ForeignKey("CityId")]
        public  Cities Cities { get; set; }
    }
}
