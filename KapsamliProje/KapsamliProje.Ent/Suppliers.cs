﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KapsamliProje.Ent
{
    public class Suppliers : Enterprize
    {
        public Suppliers()
        {
            
        }
        public ICollection<Products> Products { get; set; }
    }
}