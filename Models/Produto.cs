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
        public virtual Categoria Categoria { get; set; }

        public override string ToString()
        {
            return "Produto: " + this.ID.ToString() + " Nome:" + this.Nome + " Categoria: [" + this.Categoria.ToString() +"]";
        }
    }
}
