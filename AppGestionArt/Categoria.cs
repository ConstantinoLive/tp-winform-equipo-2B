﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionArt
{
    internal class Categoria
    {
        public int Id { get; set; }
        public string categoria { get; set; }

        public override string ToString()
        {
            return categoria;
        }
    }
}
