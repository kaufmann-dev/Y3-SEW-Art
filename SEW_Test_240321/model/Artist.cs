using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SEW_Test_240321.model
{
    [Table("ARTISTS")]
    public class Artist
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ARTIST_ID")]
        public int Id { get; set; }
        
        [Column("FIRST_NAME", TypeName = "VARCHAR(20)")]
        [Required]
        public string FirstName { get; set; }
        
        [Column("LAST_NAME", TypeName = "VARCHAR(20)")]
        [Required]
        public string LastName { get; set; }
        
        [Column("EPOCHE", TypeName = "VARCHAR(30)")]
        [Required]
        public EEpoche Epoche { get; set; }
    }
}