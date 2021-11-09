using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SEW_Test_240321.model
{
    [Table("SETUP")]
    public class Setup : WorkOfArt
    {
        [Column("DESCRIPTION", TypeName = "VARCHAR(255)")]
        [Required]
        public string Description { get; set; }
    }
}