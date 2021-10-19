using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace pc3b.Models
{
    
    public class Producto
    { 
    
        public int Id { get; set;}

        [Required]
        
        public string NameP { get; set; }

        [Required]
        
        public string Image{ get; set; }

        [Required]
        
        public string Descripcion { get; set; }

        [Required]
        
        public Decimal Price { get; set; }

        [Required]
       
        public int cell { get; set; }
        
        [Required]
       
        public string Place { get; set; }

        [Required]
        
        public string NameC { get; set; }

        [Required]
        
        public string Categoria { get; set; }

        public DateTime Fecha { get; set; }
    
        public Producto()//constructor = instancia
        {
            Fecha = DateTime.Now;//fecha actual
        }
    }
}