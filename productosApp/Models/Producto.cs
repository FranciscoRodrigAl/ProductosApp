using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace productosApp.Models
{
    public class Producto
    {
        public int Id { get; set; }
        [MaxLength(100,ErrorMessage ="Ingresar 100 o menos carácteres")]
        [MinLength(2, ErrorMessage="Ingresar por lo menos 2 carácteres")]
        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Nombre { get; set; }
        [Range(1, double.MaxValue, ErrorMessage = "Favor agregar un precio mayor a 0")]
        [RegularExpression(@"^-?\d+(?:[\.,]\d+)?$", ErrorMessage = "El valor ingresado debe ser númerico")]
        [Required(ErrorMessage = "El Precio es obligatorio")]
        [DataType(DataType.Currency,ErrorMessage ="El valor ingresado debe ser un precio")]
        public decimal Precio { get; set; }
        [Display(Name = "Categoría Asociada")]
        [Required(ErrorMessage = "La Categoria es obligatoria")]
        public int CategoriaId { get; set; }
        public Categoria? Categoria { get; set; }
    }
}
