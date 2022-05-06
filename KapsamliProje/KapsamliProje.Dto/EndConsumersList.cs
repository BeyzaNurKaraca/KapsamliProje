using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KapsamliProje.Dto
{
    public class EndConsumersList
    {
        public int Id { get; set; }
        public string ?Name { get; set; }
        public string ?Surname { get; set; }
        public int CountyId { get; set; }
    }
}
