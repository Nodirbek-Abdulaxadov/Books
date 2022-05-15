using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Books.API.Models;

public class Category
{
    [Key, Required]
    [Column("CategoryId")]
    public int Id { get; set; }
    [Required]
    [StringLength(100)]
    public string Name { get; set; } = string.Empty;
    public List<Book>? CategoryBooks { get; set; }
}
