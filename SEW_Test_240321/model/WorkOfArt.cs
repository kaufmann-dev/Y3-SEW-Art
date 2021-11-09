using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SEW_Test_240321.model
{
    [Table("WORK_OF_ART_BT")]
    public class WorkOfArt
    {
        [Column("ARTWORK_ID")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        [Column("TITLE", TypeName = "VARCHAR(255)")]
        [Required]
        public string Title { get; set; }
        
        [Column("AESTIMATED_VALUE", TypeName = "INT")]
        [Required]
        public int AestimatedValue { get; set; }
        
        [ForeignKey("ARTIST")]
        public Artist Artist { get; set; }
    }
}