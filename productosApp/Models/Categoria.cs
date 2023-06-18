using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace productosApp.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        [MaxLength(50,ErrorMessage = "El nombre no debe tener más de 50 carácteres")]
        [MinLength(2, ErrorMessage = "El nombre debe tener por lo menos 2 carácteres")]
        [Required]
        public string Nombre { get; set; }
        public ICollection<Producto> Productos { get; set; }
    }
}
