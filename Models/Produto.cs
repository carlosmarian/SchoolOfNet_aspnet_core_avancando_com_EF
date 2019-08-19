using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCurso.Models
{
    public class Produto
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public Categoria Categoria { get; set; }
    }
}
