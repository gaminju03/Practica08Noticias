using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Practica08Noticias.Models
{
    public class Noticia
    {
        [key]
        public int NoticiaID { get; set; }
        [Required]
        public string Titulo { get; set; }
        [DataType(DataType.MultilineText)]//el multiline tex genera en HTMl un TX area
        public string Contenido { get; set; }

        public DateTime FechaPublicacion { get; set; }
        
        public int CategoriaID { get; set; }
        public virtual Categoria Categoria { get; set; }//indca la relacion de llave foranea a la tabla cateoria Virtual categoria y su ID 
    }
}
