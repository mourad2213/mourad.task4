using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookShop.Models;

public class Category
{
    //[Key]
    public int Id { get; set; }

    // [Required]

    // [MaxLength(50)]
    public string catName { get; set; }

    // [Required]
    public int catOrder { get; set; }

    // [NotMapped]
    public DateTime crearedDate { get; set; }

    // [Display(Name="Isdeleted")]
    public bool markedAsDeleted { get; set; }

}
