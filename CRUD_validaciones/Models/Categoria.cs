using System.ComponentModel.DataAnnotations;
namespace CRUD_validaciones.Models
{
    public class Categoria
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="El Nombre de categoria es obligatorio")]
        public string NombreCategoria { get; set; }
        [Required(ErrorMessage = "El Orden es obligatorio")]
        [Range(1, int.MaxValue,ErrorMessage ="El Orden debe ser mayor a cero")]
        public int Orden { get; set;}
        [Required(ErrorMessage = "El descripcion es obligatoria")]
        public string Descripcion { get; set;}
    }
}
