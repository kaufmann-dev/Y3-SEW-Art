using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SEW_Test_240321.model
{
    [Table("SCULPTURE")]
    public class Sculpture : WorkOfArt
    {
        [Column("WEIGHT", TypeName = "INT")]
        [Required]
        public int Weight { get; set; }
    }
}