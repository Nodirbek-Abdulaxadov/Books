using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Books.Data.Models;

public class Book
{
    [Key, Required]
    [Column("BookId")]
    public int Id { get; set; }
    [Required]
    public string Name { get; set; } = string.Empty;
    [Required]
    public double Price { get; set; }
    [Required]
    public string UrlToBook { get; set; }
    [Required]
    public string Author { get; set; } = string.Empty;
    [Required]
    public int CategoryId { get; set; }
}
