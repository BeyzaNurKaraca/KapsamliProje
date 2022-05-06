using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KapsamliProje.Ent
{
    public class Cities:Base
    {
        public Cities()
        {
            Counties = new  HashSet<Counties>();
        }
        public string  ?CityName  { get; set; }
        public ICollection<Counties> Counties { get; set; }
    }
}
