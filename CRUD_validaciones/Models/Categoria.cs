using System.ComponentModel.DataAnnotations;
namespace CRUD_validaciones.Models
{
    public class Categoria
    {
        [Key]
        public int Id { get; set; }
        public string NombreCategoria { get; set; }
        public int Orden { get; set;}
        public string Descripcion { get; set;}
    }
}
