﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCurso.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public override string ToString()
        {
            return "Categoria: " + this.Id.ToString() + " Nome:" + this.Nome;
        }
    }
}
