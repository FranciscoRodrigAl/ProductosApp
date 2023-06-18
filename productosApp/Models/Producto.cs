using System.ComponentModel.DataAnnotations;
namespace productosApp.Models
{
    public class Producto
    {
        public int Id { get; set; }
        [MaxLength(100,ErrorMessage ="Ingresar 100 o menos carácteres")]
        [MinLength(2, ErrorMessage="Ingresar por lo menos 2 carácteres")]
        public string Nombre { get; set; }
        [Range(1, double.MaxValue, ErrorMessage = "Favor agregar un precio mayor a {1}")]
        public decimal Precio { get; set; }
        public int CategoriaId { get; set; }
        public Categoria? Categoria { get; set; }
    }
}
