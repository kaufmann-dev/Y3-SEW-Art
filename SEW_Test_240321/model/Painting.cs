using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SEW_Test_240321.model
{
    [Table("PAINTING")]
    public class Painting : WorkOfArt
    {
        [Column("WIDTH", TypeName = "INT")]
        [Required]
        public int Width { get; set; }
        
        [Column("HEIGHT", TypeName = "INT")]
        [Required]
        public int Height { get; set; }
    }
}