using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionArt
{
    internal class Articulo
    {
        public int IdProductos { get; set; }
        public string CodArticulo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Marca Marca { get; set; }
        public Categoria Categoria { get; set; }    
        public double Precio { get; set; }
        public string UrlImagen { get; set; }

    }
}
