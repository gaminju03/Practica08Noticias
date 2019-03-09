using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Practica08Noticias.Models
{
    public class Categoria
    {
        public int CategoriaID { get; set; }
        [Required]
        [StringLength(30)]
        public string Nombre { get; set; }

        public virtual ICollection <Noticia> Noticias { get; set; } //es una coleccion por ser un conhjunto de Noticias 
    }
}
