using System.ComponentModel.DataAnnotations;

namespace API.Entity;

public class Product{


// [Key] Identity özelliği ekliyor.
    [Key]
    public int Id { get; set; }

// name altı çizik olarak gözüküyor
// bunun sebebi (API.csproj) içinde <Nullable>enable</Nullable> olması
// string yanına ? koymak null geçilebilir olması anlamına gelir.
// [Required] ile boş geçilemez olması
    [Required]
    public string? Name { get; set; }

    public string? Description { get; set; }
    public decimal Price { get; set; }
    public bool IsActive  { get; set; }
    public string? ImageUrl { get; set; }
    public int Stock { get; set; }
}